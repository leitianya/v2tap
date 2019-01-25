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
        /// 当工作于编辑模式下时指定配置索引号
        /// </summary>
        public int Index;

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
                FakeComboBox.SelectedIndex = 0;
            }
            else if (Mode == "Edit")
            {
                Text = "编辑 - v2tap";
                RemarkTextBox.Text = Global.Proxies[Index].Remark;
                ServerAddressTextBox.Text = Global.Proxies[Index].Address;
                ServerPortTextBox.Text = Global.Proxies[Index].Port.ToString();
                UserIDTextBox.Text = Global.Proxies[Index].UserID;
                AlterIDTextBox.Text = Global.Proxies[Index].AlterID.ToString();
                PathTextBox.Text = Global.Proxies[Index].Path;

                switch (Global.Proxies[Index].TransferMethod)
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

                switch (Global.Proxies[Index].FakeType)
                {
                    case "None":
                        FakeComboBox.SelectedIndex = 0;
                        break;
                    case "HTTP":
                        FakeComboBox.SelectedIndex = 1;
                        break;
                    case "SRTP":
                        FakeComboBox.SelectedIndex = 2;
                        break;
                    case "UTP":
                        FakeComboBox.SelectedIndex = 3;
                        break;
                    case "DTLS":
                        FakeComboBox.SelectedIndex = 4;
                        break;
                    case "WireGuard":
                        FakeComboBox.SelectedIndex = 5;
                        break;
                    case "WeChat":
                        FakeComboBox.SelectedIndex = 6;
                        break;
                    default:
                        FakeComboBox.SelectedIndex = 0;
                        break;
                }

                TLSSecureCheckBox.Checked = Global.Proxies[Index].TLSSecure;
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
                Global.Proxies[Index].Remark = RemarkTextBox.Text;
                Global.Proxies[Index].Address = ServerAddressTextBox.Text;
                Global.Proxies[Index].Port = int.Parse(ServerPortTextBox.Text);
                Global.Proxies[Index].UserID = UserIDTextBox.Text;
                Global.Proxies[Index].AlterID = int.Parse(AlterIDTextBox.Text);
                Global.Proxies[Index].TransferMethod = TransferMethodComboBox.Text;
                Global.Proxies[Index].Path = PathTextBox.Text;
                Global.Proxies[Index].FakeType = FakeComboBox.Text;
                Global.Proxies[Index].TLSSecure = TLSSecureCheckBox.Checked;

                Global.Form.MainForm.InitProxies();
                Utils.Util.SaveServersToFile();

                MessageBox.Show("保存成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
