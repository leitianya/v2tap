namespace v2tap
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlButton = new System.Windows.Forms.Button();
            this.v2rayConfigInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.v2rayConfigReadButton = new System.Windows.Forms.Button();
            this.v2rayConfigWriteButton = new System.Windows.Forms.Button();
            this.v2rayChinaDNSTextBox = new System.Windows.Forms.TextBox();
            this.v2rayDefaultDNSTextBox = new System.Windows.Forms.TextBox();
            this.v2rayChinaDNSLabel = new System.Windows.Forms.Label();
            this.v2rayDefaultDNSLabel = new System.Windows.Forms.Label();
            this.v2rayTLSSecureCheckBox = new System.Windows.Forms.CheckBox();
            this.v2rayPathLabel = new System.Windows.Forms.Label();
            this.v2rayPathTextBox = new System.Windows.Forms.TextBox();
            this.v2rayTransferMethodComboBox = new System.Windows.Forms.ComboBox();
            this.v2rayTransferMethodLabel = new System.Windows.Forms.Label();
            this.v2rayServerPortTextBox = new System.Windows.Forms.TextBox();
            this.v2rayAlterIDTextBox = new System.Windows.Forms.TextBox();
            this.v2rayAlterIDLabel = new System.Windows.Forms.Label();
            this.v2rayUserIDTextBox = new System.Windows.Forms.TextBox();
            this.v2rayUserIDLabel = new System.Windows.Forms.Label();
            this.v2rayServerAddressTextBox = new System.Windows.Forms.TextBox();
            this.v2rayServerAddressLabel = new System.Windows.Forms.Label();
            this.v2rayServerLabel = new System.Windows.Forms.Label();
            this.TUNTAPConfigInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.TUNTAPPointsTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPPointsLabel = new System.Windows.Forms.Label();
            this.TUNTAPDNSTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPDNSLabel = new System.Windows.Forms.Label();
            this.TUNTAPGatewayTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPGatewayLabel = new System.Windows.Forms.Label();
            this.TUNTAPAddressTextBox = new System.Windows.Forms.TextBox();
            this.TUNTAPAddressLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.AdapterConfigInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.AdapterGatewayComboBox = new System.Windows.Forms.ComboBox();
            this.AdapterGatewayLabel = new System.Windows.Forms.Label();
            this.AdapterAddressComboBox = new System.Windows.Forms.ComboBox();
            this.AdapterAddressLabel = new System.Windows.Forms.Label();
            this.v2rayConfigInfoGroupBox.SuspendLayout();
            this.TUNTAPConfigInfoGroupBox.SuspendLayout();
            this.AdapterConfigInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(336, 449);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(75, 23);
            this.ControlButton.TabIndex = 0;
            this.ControlButton.Text = "启动";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // v2rayConfigInfoGroupBox
            // 
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayConfigReadButton);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayConfigWriteButton);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayChinaDNSTextBox);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayDefaultDNSTextBox);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayChinaDNSLabel);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayDefaultDNSLabel);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayTLSSecureCheckBox);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayPathLabel);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayPathTextBox);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayTransferMethodComboBox);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayTransferMethodLabel);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayServerPortTextBox);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayAlterIDTextBox);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayAlterIDLabel);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayUserIDTextBox);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayUserIDLabel);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayServerAddressTextBox);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayServerAddressLabel);
            this.v2rayConfigInfoGroupBox.Controls.Add(this.v2rayServerLabel);
            this.v2rayConfigInfoGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v2rayConfigInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.v2rayConfigInfoGroupBox.Name = "v2rayConfigInfoGroupBox";
            this.v2rayConfigInfoGroupBox.Size = new System.Drawing.Size(399, 224);
            this.v2rayConfigInfoGroupBox.TabIndex = 1;
            this.v2rayConfigInfoGroupBox.TabStop = false;
            this.v2rayConfigInfoGroupBox.Text = "v2ray 配置信息";
            // 
            // v2rayConfigReadButton
            // 
            this.v2rayConfigReadButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v2rayConfigReadButton.Location = new System.Drawing.Point(234, 195);
            this.v2rayConfigReadButton.Name = "v2rayConfigReadButton";
            this.v2rayConfigReadButton.Size = new System.Drawing.Size(75, 23);
            this.v2rayConfigReadButton.TabIndex = 18;
            this.v2rayConfigReadButton.Text = "读取配置";
            this.v2rayConfigReadButton.UseVisualStyleBackColor = true;
            this.v2rayConfigReadButton.Click += new System.EventHandler(this.v2rayConfigReadButton_Click);
            // 
            // v2rayConfigWriteButton
            // 
            this.v2rayConfigWriteButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v2rayConfigWriteButton.Location = new System.Drawing.Point(315, 195);
            this.v2rayConfigWriteButton.Name = "v2rayConfigWriteButton";
            this.v2rayConfigWriteButton.Size = new System.Drawing.Size(75, 23);
            this.v2rayConfigWriteButton.TabIndex = 17;
            this.v2rayConfigWriteButton.Text = "保存配置";
            this.v2rayConfigWriteButton.UseVisualStyleBackColor = true;
            this.v2rayConfigWriteButton.Click += new System.EventHandler(this.v2rayConfigWriteButton_Click);
            // 
            // v2rayChinaDNSTextBox
            // 
            this.v2rayChinaDNSTextBox.Location = new System.Drawing.Point(81, 169);
            this.v2rayChinaDNSTextBox.Name = "v2rayChinaDNSTextBox";
            this.v2rayChinaDNSTextBox.Size = new System.Drawing.Size(309, 23);
            this.v2rayChinaDNSTextBox.TabIndex = 16;
            this.v2rayChinaDNSTextBox.Text = "114.114.114.114";
            this.v2rayChinaDNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // v2rayDefaultDNSTextBox
            // 
            this.v2rayDefaultDNSTextBox.Location = new System.Drawing.Point(81, 140);
            this.v2rayDefaultDNSTextBox.Name = "v2rayDefaultDNSTextBox";
            this.v2rayDefaultDNSTextBox.Size = new System.Drawing.Size(309, 23);
            this.v2rayDefaultDNSTextBox.TabIndex = 15;
            this.v2rayDefaultDNSTextBox.Text = "8.8.8.8";
            this.v2rayDefaultDNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // v2rayChinaDNSLabel
            // 
            this.v2rayChinaDNSLabel.AutoSize = true;
            this.v2rayChinaDNSLabel.Location = new System.Drawing.Point(6, 172);
            this.v2rayChinaDNSLabel.Name = "v2rayChinaDNSLabel";
            this.v2rayChinaDNSLabel.Size = new System.Drawing.Size(74, 17);
            this.v2rayChinaDNSLabel.TabIndex = 14;
            this.v2rayChinaDNSLabel.Text = "中国 DNS：";
            // 
            // v2rayDefaultDNSLabel
            // 
            this.v2rayDefaultDNSLabel.AutoSize = true;
            this.v2rayDefaultDNSLabel.Location = new System.Drawing.Point(6, 143);
            this.v2rayDefaultDNSLabel.Name = "v2rayDefaultDNSLabel";
            this.v2rayDefaultDNSLabel.Size = new System.Drawing.Size(74, 17);
            this.v2rayDefaultDNSLabel.TabIndex = 13;
            this.v2rayDefaultDNSLabel.Text = "默认 DNS：";
            // 
            // v2rayTLSSecureCheckBox
            // 
            this.v2rayTLSSecureCheckBox.AutoSize = true;
            this.v2rayTLSSecureCheckBox.Checked = true;
            this.v2rayTLSSecureCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.v2rayTLSSecureCheckBox.Location = new System.Drawing.Point(8, 198);
            this.v2rayTLSSecureCheckBox.Name = "v2rayTLSSecureCheckBox";
            this.v2rayTLSSecureCheckBox.Size = new System.Drawing.Size(123, 21);
            this.v2rayTLSSecureCheckBox.TabIndex = 12;
            this.v2rayTLSSecureCheckBox.Text = "TLS 底层传输安全";
            this.v2rayTLSSecureCheckBox.UseVisualStyleBackColor = true;
            // 
            // v2rayPathLabel
            // 
            this.v2rayPathLabel.AutoSize = true;
            this.v2rayPathLabel.Location = new System.Drawing.Point(6, 114);
            this.v2rayPathLabel.Name = "v2rayPathLabel";
            this.v2rayPathLabel.Size = new System.Drawing.Size(44, 17);
            this.v2rayPathLabel.TabIndex = 11;
            this.v2rayPathLabel.Text = "路径：";
            // 
            // v2rayPathTextBox
            // 
            this.v2rayPathTextBox.Location = new System.Drawing.Point(81, 111);
            this.v2rayPathTextBox.Name = "v2rayPathTextBox";
            this.v2rayPathTextBox.Size = new System.Drawing.Size(309, 23);
            this.v2rayPathTextBox.TabIndex = 10;
            this.v2rayPathTextBox.Text = "/";
            this.v2rayPathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // v2rayTransferMethodComboBox
            // 
            this.v2rayTransferMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v2rayTransferMethodComboBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v2rayTransferMethodComboBox.FormattingEnabled = true;
            this.v2rayTransferMethodComboBox.Items.AddRange(new object[] {
            "TCP",
            "mKCP",
            "WebSockets",
            "HTTP/2",
            "QUIC"});
            this.v2rayTransferMethodComboBox.Location = new System.Drawing.Point(199, 81);
            this.v2rayTransferMethodComboBox.Name = "v2rayTransferMethodComboBox";
            this.v2rayTransferMethodComboBox.Size = new System.Drawing.Size(191, 25);
            this.v2rayTransferMethodComboBox.TabIndex = 9;
            // 
            // v2rayTransferMethodLabel
            // 
            this.v2rayTransferMethodLabel.AutoSize = true;
            this.v2rayTransferMethodLabel.Location = new System.Drawing.Point(138, 85);
            this.v2rayTransferMethodLabel.Name = "v2rayTransferMethodLabel";
            this.v2rayTransferMethodLabel.Size = new System.Drawing.Size(68, 17);
            this.v2rayTransferMethodLabel.TabIndex = 8;
            this.v2rayTransferMethodLabel.Text = "传输方式：";
            // 
            // v2rayServerPortTextBox
            // 
            this.v2rayServerPortTextBox.Location = new System.Drawing.Point(329, 22);
            this.v2rayServerPortTextBox.Name = "v2rayServerPortTextBox";
            this.v2rayServerPortTextBox.Size = new System.Drawing.Size(61, 23);
            this.v2rayServerPortTextBox.TabIndex = 7;
            this.v2rayServerPortTextBox.Text = "443";
            this.v2rayServerPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.v2rayServerPortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.v2rayServerPortTextBox_KeyPress);
            // 
            // v2rayAlterIDTextBox
            // 
            this.v2rayAlterIDTextBox.Location = new System.Drawing.Point(81, 82);
            this.v2rayAlterIDTextBox.Name = "v2rayAlterIDTextBox";
            this.v2rayAlterIDTextBox.Size = new System.Drawing.Size(56, 23);
            this.v2rayAlterIDTextBox.TabIndex = 5;
            this.v2rayAlterIDTextBox.Text = "0";
            this.v2rayAlterIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.v2rayAlterIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.v2rayAlterIDTextBox_KeyPress);
            // 
            // v2rayAlterIDLabel
            // 
            this.v2rayAlterIDLabel.AutoSize = true;
            this.v2rayAlterIDLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v2rayAlterIDLabel.Location = new System.Drawing.Point(6, 85);
            this.v2rayAlterIDLabel.Name = "v2rayAlterIDLabel";
            this.v2rayAlterIDLabel.Size = new System.Drawing.Size(61, 17);
            this.v2rayAlterIDLabel.TabIndex = 4;
            this.v2rayAlterIDLabel.Text = "额外 ID：";
            // 
            // v2rayUserIDTextBox
            // 
            this.v2rayUserIDTextBox.Location = new System.Drawing.Point(81, 51);
            this.v2rayUserIDTextBox.Name = "v2rayUserIDTextBox";
            this.v2rayUserIDTextBox.Size = new System.Drawing.Size(309, 23);
            this.v2rayUserIDTextBox.TabIndex = 3;
            this.v2rayUserIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // v2rayUserIDLabel
            // 
            this.v2rayUserIDLabel.AutoSize = true;
            this.v2rayUserIDLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v2rayUserIDLabel.Location = new System.Drawing.Point(6, 54);
            this.v2rayUserIDLabel.Name = "v2rayUserIDLabel";
            this.v2rayUserIDLabel.Size = new System.Drawing.Size(61, 17);
            this.v2rayUserIDLabel.TabIndex = 2;
            this.v2rayUserIDLabel.Text = "用户 ID：";
            // 
            // v2rayServerAddressTextBox
            // 
            this.v2rayServerAddressTextBox.Location = new System.Drawing.Point(81, 22);
            this.v2rayServerAddressTextBox.Name = "v2rayServerAddressTextBox";
            this.v2rayServerAddressTextBox.Size = new System.Drawing.Size(241, 23);
            this.v2rayServerAddressTextBox.TabIndex = 1;
            this.v2rayServerAddressTextBox.Text = "www.baidu.com";
            this.v2rayServerAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // v2rayServerAddressLabel
            // 
            this.v2rayServerAddressLabel.AutoSize = true;
            this.v2rayServerAddressLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.v2rayServerAddressLabel.Location = new System.Drawing.Point(7, 25);
            this.v2rayServerAddressLabel.Name = "v2rayServerAddressLabel";
            this.v2rayServerAddressLabel.Size = new System.Drawing.Size(80, 17);
            this.v2rayServerAddressLabel.TabIndex = 0;
            this.v2rayServerAddressLabel.Text = "服务器地址：";
            // 
            // v2rayServerLabel
            // 
            this.v2rayServerLabel.AutoSize = true;
            this.v2rayServerLabel.Location = new System.Drawing.Point(321, 25);
            this.v2rayServerLabel.Name = "v2rayServerLabel";
            this.v2rayServerLabel.Size = new System.Drawing.Size(11, 17);
            this.v2rayServerLabel.TabIndex = 6;
            this.v2rayServerLabel.Text = ":";
            // 
            // TUNTAPConfigInfoGroupBox
            // 
            this.TUNTAPConfigInfoGroupBox.Controls.Add(this.TUNTAPPointsTextBox);
            this.TUNTAPConfigInfoGroupBox.Controls.Add(this.TUNTAPPointsLabel);
            this.TUNTAPConfigInfoGroupBox.Controls.Add(this.TUNTAPDNSTextBox);
            this.TUNTAPConfigInfoGroupBox.Controls.Add(this.TUNTAPDNSLabel);
            this.TUNTAPConfigInfoGroupBox.Controls.Add(this.TUNTAPGatewayTextBox);
            this.TUNTAPConfigInfoGroupBox.Controls.Add(this.TUNTAPGatewayLabel);
            this.TUNTAPConfigInfoGroupBox.Controls.Add(this.TUNTAPAddressTextBox);
            this.TUNTAPConfigInfoGroupBox.Controls.Add(this.TUNTAPAddressLabel);
            this.TUNTAPConfigInfoGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TUNTAPConfigInfoGroupBox.Location = new System.Drawing.Point(12, 242);
            this.TUNTAPConfigInfoGroupBox.Name = "TUNTAPConfigInfoGroupBox";
            this.TUNTAPConfigInfoGroupBox.Size = new System.Drawing.Size(399, 109);
            this.TUNTAPConfigInfoGroupBox.TabIndex = 2;
            this.TUNTAPConfigInfoGroupBox.TabStop = false;
            this.TUNTAPConfigInfoGroupBox.Text = "TUN/TAP 配置信息";
            // 
            // TUNTAPPointsTextBox
            // 
            this.TUNTAPPointsTextBox.Location = new System.Drawing.Point(46, 77);
            this.TUNTAPPointsTextBox.Name = "TUNTAPPointsTextBox";
            this.TUNTAPPointsTextBox.Size = new System.Drawing.Size(41, 23);
            this.TUNTAPPointsTextBox.TabIndex = 7;
            this.TUNTAPPointsTextBox.Text = "100";
            this.TUNTAPPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TUNTAPPointsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TUNTAPPointsTextBox_KeyPress);
            // 
            // TUNTAPPointsLabel
            // 
            this.TUNTAPPointsLabel.AutoSize = true;
            this.TUNTAPPointsLabel.Location = new System.Drawing.Point(6, 80);
            this.TUNTAPPointsLabel.Name = "TUNTAPPointsLabel";
            this.TUNTAPPointsLabel.Size = new System.Drawing.Size(44, 17);
            this.TUNTAPPointsLabel.TabIndex = 6;
            this.TUNTAPPointsLabel.Text = "跃点：";
            // 
            // TUNTAPDNSTextBox
            // 
            this.TUNTAPDNSTextBox.Location = new System.Drawing.Point(46, 48);
            this.TUNTAPDNSTextBox.Name = "TUNTAPDNSTextBox";
            this.TUNTAPDNSTextBox.Size = new System.Drawing.Size(344, 23);
            this.TUNTAPDNSTextBox.TabIndex = 5;
            this.TUNTAPDNSTextBox.Text = "114.114.114.114,114.114.115.115";
            this.TUNTAPDNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPDNSLabel
            // 
            this.TUNTAPDNSLabel.AutoSize = true;
            this.TUNTAPDNSLabel.Location = new System.Drawing.Point(7, 51);
            this.TUNTAPDNSLabel.Name = "TUNTAPDNSLabel";
            this.TUNTAPDNSLabel.Size = new System.Drawing.Size(46, 17);
            this.TUNTAPDNSLabel.TabIndex = 4;
            this.TUNTAPDNSLabel.Text = "DNS：";
            // 
            // TUNTAPGatewayTextBox
            // 
            this.TUNTAPGatewayTextBox.Location = new System.Drawing.Point(237, 19);
            this.TUNTAPGatewayTextBox.Name = "TUNTAPGatewayTextBox";
            this.TUNTAPGatewayTextBox.Size = new System.Drawing.Size(153, 23);
            this.TUNTAPGatewayTextBox.TabIndex = 3;
            this.TUNTAPGatewayTextBox.Text = "10.0.100.1";
            this.TUNTAPGatewayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPGatewayLabel
            // 
            this.TUNTAPGatewayLabel.AutoSize = true;
            this.TUNTAPGatewayLabel.Location = new System.Drawing.Point(199, 22);
            this.TUNTAPGatewayLabel.Name = "TUNTAPGatewayLabel";
            this.TUNTAPGatewayLabel.Size = new System.Drawing.Size(44, 17);
            this.TUNTAPGatewayLabel.TabIndex = 2;
            this.TUNTAPGatewayLabel.Text = "网关：";
            // 
            // TUNTAPAddressTextBox
            // 
            this.TUNTAPAddressTextBox.Location = new System.Drawing.Point(46, 19);
            this.TUNTAPAddressTextBox.Name = "TUNTAPAddressTextBox";
            this.TUNTAPAddressTextBox.Size = new System.Drawing.Size(153, 23);
            this.TUNTAPAddressTextBox.TabIndex = 1;
            this.TUNTAPAddressTextBox.Text = "10.0.100.10";
            this.TUNTAPAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPAddressLabel
            // 
            this.TUNTAPAddressLabel.AutoSize = true;
            this.TUNTAPAddressLabel.Location = new System.Drawing.Point(8, 22);
            this.TUNTAPAddressLabel.Name = "TUNTAPAddressLabel";
            this.TUNTAPAddressLabel.Size = new System.Drawing.Size(44, 17);
            this.TUNTAPAddressLabel.TabIndex = 0;
            this.TUNTAPAddressLabel.Text = "地址：";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 451);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(141, 17);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "当前状态：初始化完毕 ...";
            // 
            // AdapterConfigInfoGroupBox
            // 
            this.AdapterConfigInfoGroupBox.Controls.Add(this.AdapterGatewayComboBox);
            this.AdapterConfigInfoGroupBox.Controls.Add(this.AdapterGatewayLabel);
            this.AdapterConfigInfoGroupBox.Controls.Add(this.AdapterAddressComboBox);
            this.AdapterConfigInfoGroupBox.Controls.Add(this.AdapterAddressLabel);
            this.AdapterConfigInfoGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AdapterConfigInfoGroupBox.Location = new System.Drawing.Point(12, 357);
            this.AdapterConfigInfoGroupBox.Name = "AdapterConfigInfoGroupBox";
            this.AdapterConfigInfoGroupBox.Size = new System.Drawing.Size(399, 86);
            this.AdapterConfigInfoGroupBox.TabIndex = 4;
            this.AdapterConfigInfoGroupBox.TabStop = false;
            this.AdapterConfigInfoGroupBox.Text = "适配器 配置信息";
            // 
            // AdapterGatewayComboBox
            // 
            this.AdapterGatewayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdapterGatewayComboBox.FormattingEnabled = true;
            this.AdapterGatewayComboBox.Location = new System.Drawing.Point(46, 53);
            this.AdapterGatewayComboBox.Name = "AdapterGatewayComboBox";
            this.AdapterGatewayComboBox.Size = new System.Drawing.Size(344, 25);
            this.AdapterGatewayComboBox.TabIndex = 2;
            // 
            // AdapterGatewayLabel
            // 
            this.AdapterGatewayLabel.AutoSize = true;
            this.AdapterGatewayLabel.Location = new System.Drawing.Point(6, 57);
            this.AdapterGatewayLabel.Name = "AdapterGatewayLabel";
            this.AdapterGatewayLabel.Size = new System.Drawing.Size(44, 17);
            this.AdapterGatewayLabel.TabIndex = 3;
            this.AdapterGatewayLabel.Text = "网关：";
            // 
            // AdapterAddressComboBox
            // 
            this.AdapterAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdapterAddressComboBox.FormattingEnabled = true;
            this.AdapterAddressComboBox.Location = new System.Drawing.Point(46, 22);
            this.AdapterAddressComboBox.Name = "AdapterAddressComboBox";
            this.AdapterAddressComboBox.Size = new System.Drawing.Size(344, 25);
            this.AdapterAddressComboBox.TabIndex = 0;
            // 
            // AdapterAddressLabel
            // 
            this.AdapterAddressLabel.AutoSize = true;
            this.AdapterAddressLabel.Location = new System.Drawing.Point(6, 26);
            this.AdapterAddressLabel.Name = "AdapterAddressLabel";
            this.AdapterAddressLabel.Size = new System.Drawing.Size(44, 17);
            this.AdapterAddressLabel.TabIndex = 1;
            this.AdapterAddressLabel.Text = "地址：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 480);
            this.Controls.Add(this.AdapterConfigInfoGroupBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.TUNTAPConfigInfoGroupBox);
            this.Controls.Add(this.v2rayConfigInfoGroupBox);
            this.Controls.Add(this.ControlButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v2tap";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.v2rayConfigInfoGroupBox.ResumeLayout(false);
            this.v2rayConfigInfoGroupBox.PerformLayout();
            this.TUNTAPConfigInfoGroupBox.ResumeLayout(false);
            this.TUNTAPConfigInfoGroupBox.PerformLayout();
            this.AdapterConfigInfoGroupBox.ResumeLayout(false);
            this.AdapterConfigInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.GroupBox v2rayConfigInfoGroupBox;
        private System.Windows.Forms.Label v2rayUserIDLabel;
        private System.Windows.Forms.Label v2rayServerAddressLabel;
        private System.Windows.Forms.TextBox v2rayAlterIDTextBox;
        private System.Windows.Forms.Label v2rayAlterIDLabel;
        private System.Windows.Forms.TextBox v2rayUserIDTextBox;
        private System.Windows.Forms.TextBox v2rayServerPortTextBox;
        private System.Windows.Forms.Label v2rayServerLabel;
        private System.Windows.Forms.ComboBox v2rayTransferMethodComboBox;
        private System.Windows.Forms.Label v2rayTransferMethodLabel;
        private System.Windows.Forms.TextBox v2rayServerAddressTextBox;
        private System.Windows.Forms.Label v2rayPathLabel;
        private System.Windows.Forms.TextBox v2rayPathTextBox;
        private System.Windows.Forms.CheckBox v2rayTLSSecureCheckBox;
        private System.Windows.Forms.GroupBox TUNTAPConfigInfoGroupBox;
        private System.Windows.Forms.TextBox TUNTAPGatewayTextBox;
        private System.Windows.Forms.Label TUNTAPGatewayLabel;
        private System.Windows.Forms.TextBox TUNTAPAddressTextBox;
        private System.Windows.Forms.Label TUNTAPAddressLabel;
        private System.Windows.Forms.Label TUNTAPDNSLabel;
        private System.Windows.Forms.TextBox TUNTAPDNSTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.GroupBox AdapterConfigInfoGroupBox;
        private System.Windows.Forms.Label AdapterAddressLabel;
        private System.Windows.Forms.TextBox TUNTAPPointsTextBox;
        private System.Windows.Forms.Label TUNTAPPointsLabel;
        private System.Windows.Forms.ComboBox AdapterGatewayComboBox;
        private System.Windows.Forms.Label AdapterGatewayLabel;
        private System.Windows.Forms.ComboBox AdapterAddressComboBox;
        private System.Windows.Forms.Label v2rayDefaultDNSLabel;
        private System.Windows.Forms.Label v2rayChinaDNSLabel;
        private System.Windows.Forms.TextBox v2rayChinaDNSTextBox;
        private System.Windows.Forms.TextBox v2rayDefaultDNSTextBox;
        private System.Windows.Forms.Button v2rayConfigReadButton;
        private System.Windows.Forms.Button v2rayConfigWriteButton;
    }
}

