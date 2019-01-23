namespace v2tap.Forms
{
    partial class AdvancedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TUNTAPGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoAdapterMetricCheckBox = new System.Windows.Forms.CheckBox();
            this.TUNTAPMetricTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPMetricLabel = new System.Windows.Forms.Label();
            this.TUNTAPDNSTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPDNSLabel = new System.Windows.Forms.Label();
            this.TUNTAPNetmaskTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPNetmaskLabel = new System.Windows.Forms.Label();
            this.TUNTAPGatewayTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPGatewayLabel = new System.Windows.Forms.Label();
            this.TUNTAPAddressTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPAddressLabel = new System.Windows.Forms.Label();
            this.AdapterGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoCheckAdapterCheckBox = new System.Windows.Forms.CheckBox();
            this.AdapterGatewayComboBox = new System.Windows.Forms.ComboBox();
            this.AdapterAddressComboBox = new System.Windows.Forms.ComboBox();
            this.AdapterAddressLabel = new System.Windows.Forms.Label();
            this.AdapterGatewayLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.OtherGroupBox = new System.Windows.Forms.GroupBox();
            this.v2rayLoggingLevelComboBox = new System.Windows.Forms.ComboBox();
            this.v2rayLoggingLevelLabel = new System.Windows.Forms.Label();
            this.TUNTAPGroupBox.SuspendLayout();
            this.AdapterGroupBox.SuspendLayout();
            this.OtherGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TUNTAPGroupBox
            // 
            this.TUNTAPGroupBox.Controls.Add(this.AutoAdapterMetricCheckBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPMetricTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPMetricLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPDNSTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPDNSLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPNetmaskTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPNetmaskLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPGatewayTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPGatewayLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPAddressTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPAddressLabel);
            this.TUNTAPGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TUNTAPGroupBox.Name = "TUNTAPGroupBox";
            this.TUNTAPGroupBox.Size = new System.Drawing.Size(335, 164);
            this.TUNTAPGroupBox.TabIndex = 0;
            this.TUNTAPGroupBox.TabStop = false;
            this.TUNTAPGroupBox.Text = "TUN/TAP";
            // 
            // AutoAdapterMetricCheckBox
            // 
            this.AutoAdapterMetricCheckBox.AutoSize = true;
            this.AutoAdapterMetricCheckBox.Checked = true;
            this.AutoAdapterMetricCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoAdapterMetricCheckBox.Location = new System.Drawing.Point(182, 136);
            this.AutoAdapterMetricCheckBox.Name = "AutoAdapterMetricCheckBox";
            this.AutoAdapterMetricCheckBox.Size = new System.Drawing.Size(147, 21);
            this.AutoAdapterMetricCheckBox.TabIndex = 10;
            this.AutoAdapterMetricCheckBox.Text = "自动降低适配器跃点数";
            this.AutoAdapterMetricCheckBox.UseVisualStyleBackColor = true;
            // 
            // TUNTAPMetricTextBox
            // 
            this.TUNTAPMetricTextBox.Location = new System.Drawing.Point(56, 134);
            this.TUNTAPMetricTextBox.Name = "TUNTAPMetricTextBox";
            this.TUNTAPMetricTextBox.Size = new System.Drawing.Size(66, 23);
            this.TUNTAPMetricTextBox.TabIndex = 9;
            this.TUNTAPMetricTextBox.Text = "100";
            this.TUNTAPMetricTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPMetricLabel
            // 
            this.TUNTAPMetricLabel.AutoSize = true;
            this.TUNTAPMetricLabel.Location = new System.Drawing.Point(6, 137);
            this.TUNTAPMetricLabel.Name = "TUNTAPMetricLabel";
            this.TUNTAPMetricLabel.Size = new System.Drawing.Size(56, 17);
            this.TUNTAPMetricLabel.TabIndex = 8;
            this.TUNTAPMetricLabel.Text = "跃点数：";
            // 
            // TUNTAPDNSTextBox
            // 
            this.TUNTAPDNSTextBox.Location = new System.Drawing.Point(46, 105);
            this.TUNTAPDNSTextBox.Name = "TUNTAPDNSTextBox";
            this.TUNTAPDNSTextBox.Size = new System.Drawing.Size(283, 23);
            this.TUNTAPDNSTextBox.TabIndex = 7;
            this.TUNTAPDNSTextBox.Text = "114.114.114.114,114.114.115.115";
            this.TUNTAPDNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPDNSLabel
            // 
            this.TUNTAPDNSLabel.AutoSize = true;
            this.TUNTAPDNSLabel.Location = new System.Drawing.Point(6, 108);
            this.TUNTAPDNSLabel.Name = "TUNTAPDNSLabel";
            this.TUNTAPDNSLabel.Size = new System.Drawing.Size(46, 17);
            this.TUNTAPDNSLabel.TabIndex = 6;
            this.TUNTAPDNSLabel.Text = "DNS：";
            // 
            // TUNTAPNetmaskTextBox
            // 
            this.TUNTAPNetmaskTextBox.Location = new System.Drawing.Point(46, 76);
            this.TUNTAPNetmaskTextBox.Name = "TUNTAPNetmaskTextBox";
            this.TUNTAPNetmaskTextBox.Size = new System.Drawing.Size(283, 23);
            this.TUNTAPNetmaskTextBox.TabIndex = 5;
            this.TUNTAPNetmaskTextBox.Text = "255.255.255.0";
            this.TUNTAPNetmaskTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPNetmaskLabel
            // 
            this.TUNTAPNetmaskLabel.AutoSize = true;
            this.TUNTAPNetmaskLabel.Location = new System.Drawing.Point(6, 79);
            this.TUNTAPNetmaskLabel.Name = "TUNTAPNetmaskLabel";
            this.TUNTAPNetmaskLabel.Size = new System.Drawing.Size(44, 17);
            this.TUNTAPNetmaskLabel.TabIndex = 4;
            this.TUNTAPNetmaskLabel.Text = "掩码：";
            // 
            // TUNTAPGatewayTextBox
            // 
            this.TUNTAPGatewayTextBox.Location = new System.Drawing.Point(46, 47);
            this.TUNTAPGatewayTextBox.Name = "TUNTAPGatewayTextBox";
            this.TUNTAPGatewayTextBox.Size = new System.Drawing.Size(283, 23);
            this.TUNTAPGatewayTextBox.TabIndex = 3;
            this.TUNTAPGatewayTextBox.Text = "10.0.100.1";
            this.TUNTAPGatewayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPGatewayLabel
            // 
            this.TUNTAPGatewayLabel.AutoSize = true;
            this.TUNTAPGatewayLabel.Location = new System.Drawing.Point(6, 50);
            this.TUNTAPGatewayLabel.Name = "TUNTAPGatewayLabel";
            this.TUNTAPGatewayLabel.Size = new System.Drawing.Size(44, 17);
            this.TUNTAPGatewayLabel.TabIndex = 2;
            this.TUNTAPGatewayLabel.Text = "网关：";
            // 
            // TUNTAPAddressTextBox
            // 
            this.TUNTAPAddressTextBox.Location = new System.Drawing.Point(46, 18);
            this.TUNTAPAddressTextBox.Name = "TUNTAPAddressTextBox";
            this.TUNTAPAddressTextBox.Size = new System.Drawing.Size(283, 23);
            this.TUNTAPAddressTextBox.TabIndex = 1;
            this.TUNTAPAddressTextBox.Text = "10.0.100.10";
            this.TUNTAPAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPAddressLabel
            // 
            this.TUNTAPAddressLabel.AutoSize = true;
            this.TUNTAPAddressLabel.Location = new System.Drawing.Point(6, 21);
            this.TUNTAPAddressLabel.Name = "TUNTAPAddressLabel";
            this.TUNTAPAddressLabel.Size = new System.Drawing.Size(44, 17);
            this.TUNTAPAddressLabel.TabIndex = 0;
            this.TUNTAPAddressLabel.Text = "地址：";
            // 
            // AdapterGroupBox
            // 
            this.AdapterGroupBox.Controls.Add(this.AutoCheckAdapterCheckBox);
            this.AdapterGroupBox.Controls.Add(this.AdapterGatewayComboBox);
            this.AdapterGroupBox.Controls.Add(this.AdapterAddressComboBox);
            this.AdapterGroupBox.Controls.Add(this.AdapterAddressLabel);
            this.AdapterGroupBox.Controls.Add(this.AdapterGatewayLabel);
            this.AdapterGroupBox.Location = new System.Drawing.Point(12, 182);
            this.AdapterGroupBox.Name = "AdapterGroupBox";
            this.AdapterGroupBox.Size = new System.Drawing.Size(335, 105);
            this.AdapterGroupBox.TabIndex = 1;
            this.AdapterGroupBox.TabStop = false;
            this.AdapterGroupBox.Text = "适配器";
            // 
            // AutoCheckAdapterCheckBox
            // 
            this.AutoCheckAdapterCheckBox.AutoSize = true;
            this.AutoCheckAdapterCheckBox.Checked = true;
            this.AutoCheckAdapterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoCheckAdapterCheckBox.Enabled = false;
            this.AutoCheckAdapterCheckBox.Location = new System.Drawing.Point(194, 79);
            this.AutoCheckAdapterCheckBox.Name = "AutoCheckAdapterCheckBox";
            this.AutoCheckAdapterCheckBox.Size = new System.Drawing.Size(135, 21);
            this.AutoCheckAdapterCheckBox.TabIndex = 4;
            this.AutoCheckAdapterCheckBox.Text = "自动检测出网适配器";
            this.AutoCheckAdapterCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdapterGatewayComboBox
            // 
            this.AdapterGatewayComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AdapterGatewayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdapterGatewayComboBox.FormattingEnabled = true;
            this.AdapterGatewayComboBox.Location = new System.Drawing.Point(46, 49);
            this.AdapterGatewayComboBox.Name = "AdapterGatewayComboBox";
            this.AdapterGatewayComboBox.Size = new System.Drawing.Size(283, 24);
            this.AdapterGatewayComboBox.TabIndex = 2;
            this.AdapterGatewayComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // AdapterAddressComboBox
            // 
            this.AdapterAddressComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AdapterAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdapterAddressComboBox.FormattingEnabled = true;
            this.AdapterAddressComboBox.Location = new System.Drawing.Point(46, 18);
            this.AdapterAddressComboBox.Name = "AdapterAddressComboBox";
            this.AdapterAddressComboBox.Size = new System.Drawing.Size(283, 24);
            this.AdapterAddressComboBox.TabIndex = 1;
            this.AdapterAddressComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // AdapterAddressLabel
            // 
            this.AdapterAddressLabel.AutoSize = true;
            this.AdapterAddressLabel.Location = new System.Drawing.Point(6, 22);
            this.AdapterAddressLabel.Name = "AdapterAddressLabel";
            this.AdapterAddressLabel.Size = new System.Drawing.Size(44, 17);
            this.AdapterAddressLabel.TabIndex = 0;
            this.AdapterAddressLabel.Text = "地址：";
            // 
            // AdapterGatewayLabel
            // 
            this.AdapterGatewayLabel.AutoSize = true;
            this.AdapterGatewayLabel.Location = new System.Drawing.Point(6, 53);
            this.AdapterGatewayLabel.Name = "AdapterGatewayLabel";
            this.AdapterGatewayLabel.Size = new System.Drawing.Size(44, 17);
            this.AdapterGatewayLabel.TabIndex = 3;
            this.AdapterGatewayLabel.Text = "网关：";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(272, 350);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 350);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "重置";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // OtherGroupBox
            // 
            this.OtherGroupBox.Controls.Add(this.v2rayLoggingLevelComboBox);
            this.OtherGroupBox.Controls.Add(this.v2rayLoggingLevelLabel);
            this.OtherGroupBox.Location = new System.Drawing.Point(12, 293);
            this.OtherGroupBox.Name = "OtherGroupBox";
            this.OtherGroupBox.Size = new System.Drawing.Size(335, 51);
            this.OtherGroupBox.TabIndex = 4;
            this.OtherGroupBox.TabStop = false;
            this.OtherGroupBox.Text = "其他";
            // 
            // v2rayLoggingLevelComboBox
            // 
            this.v2rayLoggingLevelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.v2rayLoggingLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v2rayLoggingLevelComboBox.FormattingEnabled = true;
            this.v2rayLoggingLevelComboBox.Items.AddRange(new object[] {
            "调试（DEBUG）",
            "信息（INFO）",
            "警告（WARNING）",
            "错误（ERROR）",
            "无（NONE）"});
            this.v2rayLoggingLevelComboBox.Location = new System.Drawing.Point(100, 18);
            this.v2rayLoggingLevelComboBox.Name = "v2rayLoggingLevelComboBox";
            this.v2rayLoggingLevelComboBox.Size = new System.Drawing.Size(229, 24);
            this.v2rayLoggingLevelComboBox.TabIndex = 1;
            this.v2rayLoggingLevelComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // v2rayLoggingLevelLabel
            // 
            this.v2rayLoggingLevelLabel.AutoSize = true;
            this.v2rayLoggingLevelLabel.Location = new System.Drawing.Point(6, 22);
            this.v2rayLoggingLevelLabel.Name = "v2rayLoggingLevelLabel";
            this.v2rayLoggingLevelLabel.Size = new System.Drawing.Size(103, 17);
            this.v2rayLoggingLevelLabel.TabIndex = 0;
            this.v2rayLoggingLevelLabel.Text = "v2ray 日志级别：";
            // 
            // AdvancedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 382);
            this.Controls.Add(this.OtherGroupBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AdapterGroupBox);
            this.Controls.Add(this.TUNTAPGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AdvancedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高级设置 - v2tap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvancedForm_FormClosing);
            this.Load += new System.EventHandler(this.AdvancedForm_Load);
            this.TUNTAPGroupBox.ResumeLayout(false);
            this.TUNTAPGroupBox.PerformLayout();
            this.AdapterGroupBox.ResumeLayout(false);
            this.AdapterGroupBox.PerformLayout();
            this.OtherGroupBox.ResumeLayout(false);
            this.OtherGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TUNTAPGroupBox;
        private System.Windows.Forms.TextBox TUNTAPAddressTextBox;
        private System.Windows.Forms.Label TUNTAPAddressLabel;
        private System.Windows.Forms.TextBox TUNTAPDNSTextBox;
        private System.Windows.Forms.Label TUNTAPDNSLabel;
        private System.Windows.Forms.TextBox TUNTAPNetmaskTextBox;
        private System.Windows.Forms.Label TUNTAPNetmaskLabel;
        private System.Windows.Forms.TextBox TUNTAPGatewayTextBox;
        private System.Windows.Forms.Label TUNTAPGatewayLabel;
        private System.Windows.Forms.TextBox TUNTAPMetricTextBox;
        private System.Windows.Forms.Label TUNTAPMetricLabel;
        private System.Windows.Forms.CheckBox AutoAdapterMetricCheckBox;
        private System.Windows.Forms.GroupBox AdapterGroupBox;
        private System.Windows.Forms.ComboBox AdapterGatewayComboBox;
        private System.Windows.Forms.ComboBox AdapterAddressComboBox;
        private System.Windows.Forms.Label AdapterAddressLabel;
        private System.Windows.Forms.Label AdapterGatewayLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.CheckBox AutoCheckAdapterCheckBox;
        private System.Windows.Forms.GroupBox OtherGroupBox;
        private System.Windows.Forms.Label v2rayLoggingLevelLabel;
        private System.Windows.Forms.ComboBox v2rayLoggingLevelComboBox;
    }
}