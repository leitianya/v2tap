using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace v2tap.Forms
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            // 读取订阅链接
            if (File.Exists("lastSubscriptionURL.txt")) SubscriptionURLTextBox.Text = File.ReadAllText("lastSubscriptionURL.txt");
        }

        private void ImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.Form.MainForm.Show();
        }

        private void SubscriptionImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                var client = Override.WebClient.GetClient();
                var data = client.DownloadString(SubscriptionURLTextBox.Text);

                if (data != "")
                {
                    var next = false;
                    for (int i = 0; i < 4; i++)
                    {
                        try
                        {
                            data = Encoding.UTF8.GetString(Convert.FromBase64String(data));
                        }
                        catch (FormatException)
                        {
                            data += "=";
                            continue;
                        }

                        next = true;
                        break;
                    }

                    if (next)
                    {
                        Global.Proxies.Clear();
                        using (StringReader sr = new StringReader(data))
                        {
                            string text;

                            while ((text = sr.ReadLine()) != null)
                            {
                                var server = ParseServer(text);

                                Global.Proxies.Add(server);
                            }
                        }

                        Global.Form.MainForm.InitProxies();
                        File.WriteAllText("lastSubscriptionURL.txt", SubscriptionURLTextBox.Text); // 保存订阅链接
                        MessageBox.Show("订阅已成功导入", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Base64 解码失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("返回数据为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            if (MyTextBox.Text == "")
            {
                MessageBox.Show("文本框为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Global.Proxies.Clear();
                using (StringReader sr = new StringReader(MyTextBox.Text))
                {
                    string text;

                    while ((text = sr.ReadLine()) != null)
                    {
                        var server = ParseServer(text);

                        Global.Proxies.Add(server);
                    }
                }

                Global.Form.MainForm.InitProxies();
                MessageBox.Show("订阅已成功导入", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Objects.Server ParseServer(string text)
        {
            var json = SimpleJSON.JSON.Parse(Encoding.UTF8.GetString(Convert.FromBase64String(text.Replace("vmess://", ""))));
            var server = new Objects.Server()
            {
                ID = Guid.NewGuid().ToString(),
                Remark = json["ps"].Value,
                Address = json["add"].Value,
                Port = json["port"].AsInt,
                UserID = json["id"].Value,
                AlterID = json["aid"].AsInt,
                Path = (json["path"].Value == "") ? "/" : json["path"].Value,
                TLSSecure = (json["tls"].Value == "") ? false : true
            };

            switch (json["net"].Value)
            {
                case "tcp":
                    server.TransferMethod = "TCP";
                    break;
                case "kcp":
                    server.TransferMethod = "mKCP";
                    break;
                case "ws":
                    server.TransferMethod = "WebSockets";
                    break;
                case "h2":
                    server.TransferMethod = "HTTP/2";
                    break;
                case "quic":
                    server.TransferMethod = "QUIC";
                    break;
                default:
                    break;
            }

            return server;
        }
    }
}
