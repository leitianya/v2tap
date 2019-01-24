using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace v2tap.Forms
{
    public partial class AdvancedForm : Form
    {
        public AdvancedForm()
        {
            InitializeComponent();
        }

        private void AdvancedForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void AdvancedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.Form.MainForm.Show();
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Global.Configs.TUNTAPAddress = TUNTAPAddressTextBox.Text;
            Global.Configs.TUNTAPGateway = TUNTAPGatewayTextBox.Text;
            Global.Configs.TUNTAPNetmask = TUNTAPNetmaskTextBox.Text;
            Global.Configs.TUNTAPDNS = TUNTAPDNSTextBox.Text;
            Global.Configs.TUNTAPMetric = int.Parse(TUNTAPMetricTextBox.Text);
            Global.Configs.AutoAdapterMetric = AutoAdapterMetricCheckBox.Checked;
            Global.Configs.AutoCheckAdapter = AutoCheckAdapterCheckBox.Checked;

            if (v2rayLoggingLevelComboBox.Text.Contains("DEBUG")) Global.Configs.v2rayLoggingLevel = "DEBUG";
            if (v2rayLoggingLevelComboBox.Text.Contains("INFO")) Global.Configs.v2rayLoggingLevel = "INFO";
            if (v2rayLoggingLevelComboBox.Text.Contains("WARNING")) Global.Configs.v2rayLoggingLevel = "WARNING";
            if (v2rayLoggingLevelComboBox.Text.Contains("ERROR")) Global.Configs.v2rayLoggingLevel = "ERROR";
            if (v2rayLoggingLevelComboBox.Text.Contains("NONE")) Global.Configs.v2rayLoggingLevel = "NONE";

            Utils.Util.SaveConfigsToFile();
            MessageBox.Show("保存成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("v2tap.ini", Encoding.UTF8.GetString(Properties.Resources.defaultConfig));

            Utils.Util.InitConfigsFromFile();
            Init();
            MessageBox.Show("重置成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Init()
        {
            TUNTAPAddressTextBox.Text = Global.Configs.TUNTAPAddress;
            TUNTAPGatewayTextBox.Text = Global.Configs.TUNTAPGateway;
            TUNTAPNetmaskTextBox.Text = Global.Configs.TUNTAPNetmask;
            TUNTAPDNSTextBox.Text = Global.Configs.TUNTAPDNS;
            TUNTAPMetricTextBox.Text = Global.Configs.TUNTAPMetric.ToString();
            AutoAdapterMetricCheckBox.Checked = Global.Configs.AutoAdapterMetric;
            AutoCheckAdapterCheckBox.Checked = Global.Configs.AutoCheckAdapter;

            foreach (var item in Global.Configs.AdapterAddress)
            {
                AdapterAddressComboBox.Items.Add(item);
            }

            AdapterAddressComboBox.SelectedIndex = Global.Configs.AdapterAddressIndex;

            foreach (var item in Global.Configs.AdapterGateway)
            {
                AdapterGatewayComboBox.Items.Add(item);
            }

            AdapterGatewayComboBox.SelectedIndex = Global.Configs.AdapterGatewayIndex;

            switch (Global.Configs.v2rayLoggingLevel)
            {
                case "DEBUG":
                    v2rayLoggingLevelComboBox.SelectedIndex = 0;
                    break;
                case "INFO":
                    v2rayLoggingLevelComboBox.SelectedIndex = 1;
                    break;
                case "WARNING":
                    v2rayLoggingLevelComboBox.SelectedIndex = 2;
                    break;
                case "ERROR":
                    v2rayLoggingLevelComboBox.SelectedIndex = 3;
                    break;
                case "NONE":
                    v2rayLoggingLevelComboBox.SelectedIndex = 4;
                    break;
                default:
                    v2rayLoggingLevelComboBox.SelectedIndex = 0;
                    break;
            }
        }
    }
}
