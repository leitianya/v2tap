using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace v2tap
{
    public partial class MainForm : Form
    {
        public static string status = "初始化完毕，等待命令下发中";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("eula.txt"))
            {
                string eula = "" +
                "1. 软件由 Holli_Freed 制作并开源与 GitHub 上\n" +
                "\n" +
                "GitHub：https://github.com/hacking001/v2tap\n" +
                "\n" +
                "最终解释权归 Holli_Freed 所有！" +
                "";
                MessageBox.Show(eula, "免责声明", MessageBoxButtons.OK, MessageBoxIcon.Information);

                File.WriteAllText("eula.txt", "");
            }

            if (File.Exists("defaultConfig.ini"))
            {
                FileIniDataParser parser = new FileIniDataParser();
                IniData data = parser.ReadFile("defaultConfig.ini");
                v2rayServerAddressTextBox.Text = data["v2ray"]["ServerAddress"];
                v2rayServerPortTextBox.Text = data["v2ray"]["ServerPort"];
                v2rayUserIDTextBox.Text = data["v2ray"]["UserID"];
                v2rayAlterIDTextBox.Text = data["v2ray"]["AlterID"];
                v2rayTransferMethodComboBox.Text = data["v2ray"]["TransferMethod"];
                v2rayPathTextBox.Text = data["v2ray"]["Path"];
                v2rayDefaultDNSTextBox.Text = data["v2ray"]["DefaultDNS"];
                v2rayChinaDNSTextBox.Text = data["v2ray"]["ChinaDNS"];
                v2rayTLSSecureCheckBox.Checked = Boolean.Parse(data["v2ray"]["TLSSecure"]);
            }
            else
            {
                v2rayUserIDTextBox.Text = Guid.NewGuid().ToString();
                v2rayTransferMethodComboBox.SelectedIndex = 2;
            }

            using (UdpClient client = new UdpClient("114.114.114.114", 53))
            {
                IPAddress address = ((IPEndPoint)client.Client.LocalEndPoint).Address;

                int addressCount = 0;
                int gatewayCount = 0;
                bool addressGeted = false;

                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in adapters)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();

                    foreach (UnicastIPAddressInformation information in properties.UnicastAddresses)
                    {
                        if (information.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            string IP = information.Address.ToString();

                            if (IP.StartsWith("10.") || IP.StartsWith("172.") || IP.StartsWith("192."))
                            {
                                if (Equals(information.Address, address))
                                {
                                    addressGeted = true;
                                }
                                else
                                {
                                    if (!addressGeted)
                                    {
                                        addressCount++;
                                    }
                                }

                                AdapterAddressComboBox.Items.Add(IP);
                            }
                        }
                    }

                    foreach (GatewayIPAddressInformation information in properties.GatewayAddresses)
                    {
                        if (information.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            string IP = information.Address.ToString();

                            if (IP.StartsWith("10.") || IP.StartsWith("172.") || IP.StartsWith("192."))
                            {
                                if (!addressGeted)
                                {
                                    gatewayCount++;
                                }

                                AdapterGatewayComboBox.Items.Add(IP);
                            }
                        }
                    }
                }
                AdapterAddressComboBox.SelectedIndex = addressCount;
                AdapterGatewayComboBox.SelectedIndex = gatewayCount;
            }

            if (Process.GetProcessesByName("tun2socks").Length == 1 && Process.GetProcessesByName("wv2ray").Length == 1)
            {
                status = "检测到 tun2socks 和 v2ray 服务已启动！";

                ControlButton.Text = "关闭";
            }
            else
            {
                Utils.SharedUtils.ExecuteCommand("TASKKILL /F /T /IM tun2socks.exe");
                Utils.SharedUtils.ExecuteCommand("TASKKILL /F /T /IM wv2ray.exe");
            }

            Task.Factory.StartNew(() =>
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
                            StatusLabel.Text = "当前状态：" + status;
                        });
                    }
                    catch (Exception)
                    {

                    }

                    Thread.Sleep(100);
                }
            });
        }

        private void v2rayServerPortTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void v2rayAlterIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TUNTAPPointsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void v2rayConfigReadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.CheckPathExists = true;
                dialog.CheckFileExists = true;
                dialog.Multiselect = false;
                dialog.Filter = "配置文件 (*.ini)|*.ini";
                
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileIniDataParser parser = new FileIniDataParser();
                    IniData data = parser.ReadFile(dialog.FileName);

                    v2rayServerAddressTextBox.Text = data["v2ray"]["ServerAddress"];
                    v2rayServerPortTextBox.Text = data["v2ray"]["ServerPort"];
                    v2rayUserIDTextBox.Text = data["v2ray"]["UserID"];
                    v2rayAlterIDTextBox.Text = data["v2ray"]["AlterID"];
                    v2rayTransferMethodComboBox.Text = data["v2ray"]["TransferMethod"];
                    v2rayPathTextBox.Text = data["v2ray"]["Path"];
                    v2rayDefaultDNSTextBox.Text = data["v2ray"]["DefaultDNS"];
                    v2rayChinaDNSTextBox.Text = data["v2ray"]["ChinaDNS"];
                    v2rayTLSSecureCheckBox.Checked = Boolean.Parse(data["v2ray"]["TLSSecure"]);
                }
            }
        }

        private void v2rayConfigWriteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("如果需要让程序每次启动时自动载入配置文件，请将文件命令为 defaultConfig.ini 保存在程序同目录下！", "使用提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.DefaultExt = "ini";
                dialog.AddExtension = true;
                dialog.Filter = "配置文件 (*.ini)|*.ini";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    IniData data = new IniData();
                    data["v2ray"]["ServerAddress"] = v2rayServerAddressTextBox.Text;
                    data["v2ray"]["ServerPort"] = v2rayServerPortTextBox.Text;
                    data["v2ray"]["UserID"] = v2rayUserIDTextBox.Text;
                    data["v2ray"]["AlterID"] = v2rayAlterIDTextBox.Text;
                    data["v2ray"]["TransferMethod"] = v2rayTransferMethodComboBox.Text;
                    data["v2ray"]["Path"] = v2rayPathTextBox.Text;
                    data["v2ray"]["DefaultDNS"] = v2rayDefaultDNSTextBox.Text;
                    data["v2ray"]["ChinaDNS"] = v2rayChinaDNSTextBox.Text;
                    data["v2ray"]["TLSSecure"] = v2rayTLSSecureCheckBox.Checked.ToString();

                    File.WriteAllText(dialog.FileName, data.ToString());
                }
            }
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            if (ControlButton.Text.Contains("启动"))
            {
                if (v2rayServerAddressTextBox.Text != "" && v2rayServerPortTextBox.Text != "" && v2rayUserIDTextBox.Text != "" && v2rayAlterIDTextBox.Text != "" && TUNTAPAddressTextBox.Text != "" && TUNTAPGatewayTextBox.Text != "" && TUNTAPDNSTextBox.Text != "" && TUNTAPPointsTextBox.Text != "")
                {
                    status = "启动中 ...";
                    ControlButton.Enabled = false;
                    ControlButton.Text = "稍等 ...";

                    string adapterAddress = AdapterAddressComboBox.Text;
                    string adapterGateway = AdapterGatewayComboBox.Text;
                    string v2rayDefaultDNS = v2rayDefaultDNSTextBox.Text;
                    string v2rayChinaDNS = v2rayChinaDNSTextBox.Text;
                    string v2rayServerAddress = v2rayServerAddressTextBox.Text;
                    string v2rayServerPort = v2rayServerPortTextBox.Text;
                    string v2rayUserID = v2rayUserIDTextBox.Text;
                    string v2rayAlterID = v2rayAlterIDTextBox.Text;
                    string v2rayTransferMethod;
                    switch (v2rayTransferMethodComboBox.Text)
                    {
                        case "TCP":
                            v2rayTransferMethod = "tcp";
                            break;
                        case "mKCP":
                            v2rayTransferMethod = "kcp";
                            break;
                        case "WebSockets":
                            v2rayTransferMethod = "ws";
                            break;
                        case "HTTP/2":
                            v2rayTransferMethod = "http";
                            break;
                        case "QUIC":
                            v2rayTransferMethod = "quic";
                            break;
                        default:
                            v2rayTransferMethod = "ws";
                            break;
                    }
                    string v2rayTLSSecure = (v2rayTLSSecureCheckBox.Checked) ? "tls" : "none";
                    string v2rayPath = v2rayPathTextBox.Text;

                    string TUNTAPGateway = TUNTAPGatewayTextBox.Text;
                    string TUNTAPAddress = TUNTAPAddressTextBox.Text;
                    string TUNTAPDNS = TUNTAPDNSTextBox.Text;
                    string TUNTAPPoints = TUNTAPPointsTextBox.Text;

                    Task.Factory.StartNew(() =>
                    {
                        status = "正在生成 v2ray 配置文件 ...";
                        string config = Encoding.UTF8.GetString(Convert.FromBase64String(v2tap.config));
                        config = config.Replace("adapterIPAddress", adapterAddress);
                        config = config.Replace("v2rayDefaultDNS", v2rayDefaultDNS);
                        config = config.Replace("v2rayChinaDNS", v2rayChinaDNS);
                        config = config.Replace("v2rayServerAddress", v2rayServerAddress);
                        config = config.Replace("v2rayServerPort", v2rayServerPort);
                        config = config.Replace("v2rayUserID", v2rayUserID);
                        config = config.Replace("v2rayAlterID", v2rayAlterID);
                        config = config.Replace("v2rayTransferMethod", v2rayTransferMethod);
                        config = config.Replace("v2rayTLSSecure", v2rayTLSSecure);
                        config = config.Replace("v2rayPath", v2rayPath);
                        File.WriteAllText("config.json", config);

                        Thread.Sleep(1000);
                        status = "正在启动 v2ray 服务 ...";
                        Utils.SharedUtils.ExecuteCommand("wv2ray.exe -config config.json");

                        Thread.Sleep(1000);
                        status = "正在启动 tun2socks 服务 ...";
                        Utils.SharedUtils.ExecuteCommand("RunHiddenConsole.exe tun2socks.exe -tun-gw " + TUNTAPGateway + " -tun-address " + TUNTAPAddress + " -tun-dns " + TUNTAPDNS + " -enable-dns-cache -public-only -local-socks-addr 127.0.0.1:1099");

                        Thread.Sleep(1000);
                        status = "正在配置 路由表 ...";
                        Utils.SharedUtils.ExecuteCommand("ROUTE CHANGE 0.0.0.0 MASK 0.0.0.0 " + adapterGateway + " METRIC 1000");
                        Utils.SharedUtils.ExecuteCommand("ROUTE ADD " + v2rayDefaultDNS + " MASK 255.255.255.255 " + adapterGateway + " METRIC 10");
                        Utils.SharedUtils.ExecuteCommand("ROUTE ADD " + v2rayChinaDNS + " MASK 255.255.255.255 " + adapterGateway + " METRIC 10");
                        if (TUNTAPDNS.Contains(","))
                        {
                            foreach (string IP in TUNTAPDNS.Split(",".ToCharArray()))
                            {
                                Utils.SharedUtils.ExecuteCommand("ROUTE ADD " + IP + " MASK 255.255.255.255 " + adapterGateway + " METRIC 10");
                            }
                        }
                        else
                        {
                            Utils.SharedUtils.ExecuteCommand("ROUTE ADD " + TUNTAPDNS + " MASK 255.255.255.255 " + adapterGateway + " METRIC 10");
                        }
                        Utils.SharedUtils.ExecuteCommand("ROUTE ADD 0.0.0.0 MASK 0.0.0.0 " + TUNTAPGateway + " METRIC " + TUNTAPPoints);

                        Thread.Sleep(1000);
                        ControlButton.Invoke((MethodInvoker)delegate
                        {
                            ControlButton.Enabled = true;
                            ControlButton.Text = "停止";
                        });
                        status = "启动完毕 ...";

                        try
                        {
                            File.Delete("config.json");
                        }
                        catch
                        {

                        }
                    });
                }
                else
                {
                    MessageBox.Show("配置信息不可为空", "配置错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                status = "停止中 ...";
                ControlButton.Enabled = false;
                ControlButton.Text = "稍等 ...";

                string v2rayDefaultDNS = v2rayDefaultDNSTextBox.Text;
                string v2rayChinaDNS = v2rayChinaDNSTextBox.Text;

                string TUNTAPDNS = TUNTAPDNSTextBox.Text;

                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(1000);
                    status = "正在关闭 v2ray 服务 ...";
                    Utils.SharedUtils.ExecuteCommand("TASKKILL /F /T /IM wv2ray.exe");

                    Thread.Sleep(1000);
                    status = "正在关闭 tun2socks 服务 ...";
                    Utils.SharedUtils.ExecuteCommand("TASKKILL /F /T /IM tun2socks.exe");

                    Thread.Sleep(1000);
                    status = "正在重置 路由表 ...";
                    Utils.SharedUtils.ExecuteCommand("ROUTE DELETE " + v2rayDefaultDNS);
                    Utils.SharedUtils.ExecuteCommand("ROUTE DELETE " + v2rayChinaDNS);
                    if (TUNTAPDNS.Contains(","))
                    {
                        foreach (string IP in TUNTAPDNS.Split(",".ToCharArray()))
                        {
                            Utils.SharedUtils.ExecuteCommand("ROUTE DELETE " + IP);
                        }
                    }
                    else
                    {
                        Utils.SharedUtils.ExecuteCommand("ROUTE DELETE " + TUNTAPDNS);
                    }

                    Thread.Sleep(1000);
                    ControlButton.Invoke((MethodInvoker)delegate
                    {
                        ControlButton.Enabled = true;
                        ControlButton.Text = "启动";
                    });
                    status = "停止完毕 ...";
                });
            }
        }
    }
}
