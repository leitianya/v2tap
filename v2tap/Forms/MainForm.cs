using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2tap.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 是否启动
        /// </summary>
        public static bool isStarted = false;

        /// <summary>
        /// 当前状态
        /// </summary>
        public string Status = "等待指令中";

        /// <summary>
        /// 总流量
        /// </summary>
        public long UsedBandwidth = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Utils.Util.InitAdapter();
            InitProxies();

            v2rayModeComboBox.SelectedIndex = 1;

            // 更新时间和状态
            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            Text = "v2tap - " + DateTime.Now.ToString();
                        });

                        StatusLabel.Invoke((MethodInvoker)delegate
                        {
                            StatusLabel.Text = "当前状态：" + Status;
                        });

                        Thread.Sleep(100);
                    }
                    catch (Exception)
                    {

                    }
                }
            });

            // 更新流量信息
            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        if (isStarted)
                        {
                            var channel = new Grpc.Core.Channel("localhost:1020", Grpc.Core.ChannelCredentials.Insecure);
                            var client = new v2ray.Core.App.Stats.Command.StatsService.StatsServiceClient(channel);
                            var uplink = client.GetStats(new v2ray.Core.App.Stats.Command.GetStatsRequest { Name = "inbound>>>defaultInbound>>>traffic>>>uplink", Reset = true });
                            var downlink = client.GetStats(new v2ray.Core.App.Stats.Command.GetStatsRequest { Name = "inbound>>>defaultInbound>>>traffic>>>downlink", Reset = true });

                            UsedBandwidth += uplink.Stat.Value;
                            UsedBandwidth += downlink.Stat.Value;
                            StatusStrip.Invoke((MethodInvoker)delegate
                            {
                                BandwidthLabel.Text = "总流量：" + Utils.Util.ProcessBandwidth(UsedBandwidth);
                                UplinkLabel.Text = "↑：" + Utils.Util.ProcessStatusBandwidth(uplink.Stat.Value);
                                DownlinkLabel.Text = "↓：" + Utils.Util.ProcessStatusBandwidth(downlink.Stat.Value);
                            });
                        }

                        Thread.Sleep(1000);
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isStarted)
            {
                MessageBox.Show("请先点击关闭按钮", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                Utils.Util.SaveConfigsToFile();
                Utils.Util.SaveServersToFile();
            }
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var cbx = sender as ComboBox;
            if (cbx != null)
            {
                e.DrawBackground();

                if (e.Index >= 0)
                {
                    var sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;

                    var brush = new SolidBrush(cbx.ForeColor);

                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    {
                        brush = SystemBrushes.HighlightText as SolidBrush;
                    }

                    e.Graphics.DrawString(cbx.Items[e.Index].ToString(), cbx.Font, brush, e.Bounds, sf);
                }
            }
        }

        private void v2rayAddButton_Click(object sender, EventArgs e)
        {
            Global.Form.EditForm = new EditForm()
            {
                Mode = "Add"
            };
            Global.Form.EditForm.Show();
            Hide();
        }

        private void v2rayDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Global.Proxies.RemoveAt(Utils.Util.GetServerIndexByRemark(v2rayProxyComboBox.Text));
            }
            catch (Exception)
            {
                return;
            }

            InitProxies();
            Utils.Util.SaveServersToFile();
        }

        private void v2rayEditButton_Click(object sender, EventArgs e)
        {
            Global.Form.EditForm = new EditForm()
            {
                Mode = "Edit"
            };
            Global.Form.EditForm.Show();
            Hide();
        }

        private void v2rayImportButton_Click(object sender, EventArgs e)
        {
            Global.Form.ImportForm = new ImportForm();
            Global.Form.ImportForm.Show();
            Hide();
        }

        private void AdvancedButton_Click(object sender, EventArgs e)
        {
            Global.Form.AdvancedForm = new AdvancedForm();
            Global.Form.AdvancedForm.Show();
            Hide();
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            Status = "正在处理中";
            if (!isStarted)
            {
                ControlButton.Enabled = false;
                ControlButton.Text = "处理中";

                Task.Run(() =>
                {
                    var index = Utils.Util.GetServerIndexByRemark(v2rayProxyComboBox.Text);
                    var address = Global.Configs.AdapterAddress[Global.Configs.AdapterAddressIndex];
                    var gateway = Global.Configs.AdapterGateway[Global.Configs.AdapterGatewayIndex];

                    Thread.Sleep(2000);
                    Status = "正在生成 v2ray 配置文件中";
                    var v2rayConfig = Encoding.UTF8.GetString(Properties.Resources.v2ray);
                    v2rayConfig = v2rayConfig
                        .Replace("v2rayLoggingLevel", Global.Configs.v2rayLoggingLevel.ToLower())
                        .Replace("AdapterAddress", address)
                        .Replace("v2rayServerAddress", Global.Proxies[index].Address)
                        .Replace("v2rayServerPort", Global.Proxies[index].Port.ToString())
                        .Replace("v2rayUserID", Global.Proxies[index].UserID)
                        .Replace("v2rayAlterID", Global.Proxies[index].AlterID.ToString())
                        .Replace("v2rayTLSSecure", Global.Proxies[index].TLSSecure ? "tls" : "none")
                        .Replace("v2rayPath", Global.Proxies[index].Path);
                    switch (Global.Proxies[index].TransferMethod)
                    {
                        case "TCP":
                            v2rayConfig = v2rayConfig.Replace("v2rayTransferMethod", "tcp");
                            break;
                        case "mKCP":
                            v2rayConfig = v2rayConfig.Replace("v2rayTransferMethod", "kcp");
                            break;
                        case "WebSockets":
                            v2rayConfig = v2rayConfig.Replace("v2rayTransferMethod", "ws");
                            break;
                        case "HTTP/2":
                            v2rayConfig = v2rayConfig.Replace("v2rayTransferMethod", "http");
                            break;
                        case "QUIC":
                            v2rayConfig = v2rayConfig.Replace("v2rayTransferMethod", "quic");
                            break;
                        default:
                            v2rayConfig = v2rayConfig.Replace("v2rayTransferMethod", "tcp");
                            break;
                    }
                    File.WriteAllText("config.json", v2rayConfig);

                    Thread.Sleep(2000);
                    Status = "正在启动 v2ray 服务中";
                    Utils.Util.ExecuteCommand("wv2ray.exe -config config.json");

                    Thread.Sleep(2000);
                    Status = "正在启动 tun2socks 服务中";
                    Task.Run(() =>
                    {
                        Utils.Util.ExecuteCommand(String.Format("tun2socks.exe -tun-address {0} -tun-gw {1} -tun-dns {2} -local-socks-addr 127.0.0.1:1099 -enable-dns-cache -public-only > logging\\tun2socks.txt 2>&1", Global.Configs.TUNTAPAddress, Global.Configs.TUNTAPGateway, Global.Configs.TUNTAPDNS));
                    });
                    
                    Thread.Sleep(2000);
                    Status = "正在配置 路由表 中";
                    Utils.Util.ExecuteCommand(String.Format("ROUTE CHANGE 0.0.0.0 MASK 0.0.0.0 {0} METRIC 1000", gateway));
                    Utils.Util.ExecuteCommand(String.Format("ROUTE ADD 0.0.0.0 MASK 0.0.0.0 {0} METRIC {1}", Global.Configs.TUNTAPGateway, Global.Configs.TUNTAPMetric));
                    Utils.Util.ExecuteCommand(String.Format("ROUTE ADD 114.114.114.114 MASK 255.255.255.255 {0} METRIC 10", gateway));
                    Utils.Util.ExecuteCommand(String.Format("ROUTE ADD 8.8.8.8 MASK 255.255.255.255 {0} METRIC 10", gateway));
                    if (Global.Configs.TUNTAPDNS.Contains(","))
                    {
                        foreach (var ip in Global.Configs.TUNTAPDNS.Split(','))
                        {
                            Utils.Util.ExecuteCommand(String.Format("ROUTE ADD {0} MASK 255.255.255.255 {1} METRIC 10", ip, gateway));
                        }
                    }
                    else
                    {
                        Utils.Util.ExecuteCommand(String.Format("ROUTE ADD {0} MASK 255.255.255.255 {1} METRIC 10", Global.Configs.TUNTAPDNS, gateway));
                    }

                    Thread.Sleep(2000);
                    isStarted = true;
                    Status = "启动完毕，请自行检查网络";
                    ControlButton.Invoke((MethodInvoker)delegate
                    {
                        ControlButton.Enabled = true;
                        ControlButton.Text = "停止";
                    });

                    try
                    {
                        File.Delete("config.json");
                    }
                    catch (Exception)
                    {

                    }
                });
            }
            else
            {
                ControlButton.Enabled = false;
                ControlButton.Text = "处理中";

                Task.Run(() =>
                {
                    isStarted = false;
                    Thread.Sleep(2000);
                    Status = "正在关闭 tun2socks 服务中";
                    Utils.Util.ExecuteCommand("TASKKILL /F /T /IM tun2socks.exe");

                    Thread.Sleep(2000);
                    Status = "正在关闭 v2ray 服务中";
                    Utils.Util.ExecuteCommand("TASKKILL /F /T /IM wv2ray.exe");

                    Thread.Sleep(2000);
                    Status = "正在重置 路由表 中";
                    Utils.Util.ExecuteCommand("TASKKILL /F /T /IM tun2socks.exe");
                    Utils.Util.ExecuteCommand("ROUTE DELETE 114.114.114.114");
                    Utils.Util.ExecuteCommand("ROUTE DELETE 8.8.8.8");
                    if (Global.Configs.TUNTAPDNS.Contains(","))
                    {
                        foreach (var ip in Global.Configs.TUNTAPDNS.Split(','))
                        {
                            Utils.Util.ExecuteCommand(String.Format("ROUTE DELETE {0}", ip));
                        }
                    }
                    else
                    {
                        Utils.Util.ExecuteCommand(String.Format("ROUTE DELETE {0}", Global.Configs.TUNTAPDNS));
                    }

                    Thread.Sleep(2000);
                    Status = "停止完毕";
                    ControlButton.Invoke((MethodInvoker)delegate
                    {
                        ControlButton.Enabled = true;
                        ControlButton.Text = "启动";
                    });
                });
            }
        }

        public void InitProxies()
        {
            v2rayProxyComboBox.Items.Clear();
            foreach (var proxy in Global.Proxies)
            {
                v2rayProxyComboBox.Items.Add(proxy.Remark);
            }

            if (v2rayProxyComboBox.Items.Count > 0)
            {
                v2rayProxyComboBox.SelectedIndex = 0;
            }
        }
    }
}
