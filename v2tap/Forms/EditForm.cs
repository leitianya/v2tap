using System;
using System.Drawing;
using System.Windows.Forms;

namespace v2tap.Forms
{
    public partial class EditForm : Form
    {
        /// <summary>
        /// 窗体模式
        /// </summary>
        public string Mode;

        /// <summary>
        /// 默认配置
        /// </summary>
        public Objects.Server Server;

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            if (Mode == "Add")
            {
                Text = "添加 - v2tap";
                TransferMethodComboBox.SelectedIndex = 0;
            }
            else if (Mode == "Edit")
            {
                Text = "编辑 - v2tap";
                RemarkTextBox.Text = Global.Form.MainForm.v2rayProxyComboBox.Text;
                foreach (var item in Global.Proxies)
                {
                    if (item.Remark == RemarkTextBox.Text)
                    {
                        ServerAddressTextBox.Text = item.Address;
                        ServerPortTextBox.Text = item.Port.ToString();
                        UserIDTextBox.Text = item.UserID;
                        AlterIDTextBox.Text = item.AlterID.ToString();
                        PathTextBox.Text = item.Path;
                        switch (item.TransferMethod)
                        {
                            case "TCP":
                                TransferMethodComboBox.SelectedIndex = 0;
                                break;
                            case "mKCP":
                                TransferMethodComboBox.SelectedIndex = 1;
                                break;
                            case "WebSockets":
                                TransferMethodComboBox.SelectedIndex = 2;
                                break;
                            case "HTTP/2":
                                TransferMethodComboBox.SelectedIndex = 3;
                                break;
                            case "QUIC":
                                TransferMethodComboBox.SelectedIndex = 4;
                                break;
                            default:
                                TransferMethodComboBox.SelectedIndex = 0;
                                break;
                        }
                        TLSSecureCheckBox.Checked = item.TLSSecure;
                        Server = item;
                        break;
                    }
                }
            }
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.Form.MainForm.Show();
        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ControlButton_Click(object sender, EventArgs e)
        {
            if (Mode == "Add")
            {
                try
                {
                    var server = new Objects.Server()
                    {
                        ID = Guid.NewGuid().ToString(),
                        Remark = RemarkTextBox.Text,
                        Address = ServerAddressTextBox.Text,
                        Port = int.Parse(ServerPortTextBox.Text),
                        UserID = UserIDTextBox.Text,
                        AlterID = int.Parse(AlterIDTextBox.Text),
                        TransferMethod = TransferMethodComboBox.Text,
                        Path = PathTextBox.Text,
                        TLSSecure = TLSSecureCheckBox.Checked
                    };
                    Global.Proxies.Add(server);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Global.Form.MainForm.InitProxies();
                Utils.Util.SaveServersToFile();

                MessageBox.Show("保存成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Mode == "Edit")
            {
                var index = Utils.Util.GetServerIndexByID(Server.ID);
                Global.Proxies[index].Remark = RemarkTextBox.Text;
                Global.Proxies[index].Address = ServerAddressTextBox.Text;
                Global.Proxies[index].Port = int.Parse(ServerPortTextBox.Text);
                Global.Proxies[index].UserID = UserIDTextBox.Text;
                Global.Proxies[index].AlterID = int.Parse(AlterIDTextBox.Text);
                Global.Proxies[index].TransferMethod = TransferMethodComboBox.Text;
                Global.Proxies[index].Path = PathTextBox.Text;
                Global.Proxies[index].TLSSecure = TLSSecureCheckBox.Checked;

                Global.Form.MainForm.InitProxies();
                Utils.Util.SaveServersToFile();

                MessageBox.Show("保存成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
