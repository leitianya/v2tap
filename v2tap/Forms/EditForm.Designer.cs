namespace v2tap.Forms
{
    partial class EditForm
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
            this.ConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.TLSSecureCheckBox = new System.Windows.Forms.CheckBox();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.TransferMethodComboBox = new System.Windows.Forms.ComboBox();
            this.TransferMethodLabel = new System.Windows.Forms.Label();
            this.AlterIDTextBox = new System.Windows.Forms.TextBox();
            this.AlterIDLabel = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.ServerAddressTextBox = new System.Windows.Forms.TextBox();
            this.ServerAddressLabel = new System.Windows.Forms.Label();
            this.RemarkTextBox = new System.Windows.Forms.TextBox();
            this.RemarkLabel = new System.Windows.Forms.Label();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.ControlButton = new System.Windows.Forms.Button();
            this.ConfigGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigGroupBox
            // 
            this.ConfigGroupBox.Controls.Add(this.TLSSecureCheckBox);
            this.ConfigGroupBox.Controls.Add(this.AlertLabel);
            this.ConfigGroupBox.Controls.Add(this.PathTextBox);
            this.ConfigGroupBox.Controls.Add(this.PathLabel);
            this.ConfigGroupBox.Controls.Add(this.TransferMethodComboBox);
            this.ConfigGroupBox.Controls.Add(this.TransferMethodLabel);
            this.ConfigGroupBox.Controls.Add(this.AlterIDTextBox);
            this.ConfigGroupBox.Controls.Add(this.AlterIDLabel);
            this.ConfigGroupBox.Controls.Add(this.UserIDTextBox);
            this.ConfigGroupBox.Controls.Add(this.UserIDLabel);
            this.ConfigGroupBox.Controls.Add(this.ServerPortTextBox);
            this.ConfigGroupBox.Controls.Add(this.ServerAddressTextBox);
            this.ConfigGroupBox.Controls.Add(this.ServerAddressLabel);
            this.ConfigGroupBox.Controls.Add(this.RemarkTextBox);
            this.ConfigGroupBox.Controls.Add(this.RemarkLabel);
            this.ConfigGroupBox.Controls.Add(this.ServerPortLabel);
            this.ConfigGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ConfigGroupBox.Name = "ConfigGroupBox";
            this.ConfigGroupBox.Size = new System.Drawing.Size(377, 229);
            this.ConfigGroupBox.TabIndex = 0;
            this.ConfigGroupBox.TabStop = false;
            this.ConfigGroupBox.Text = "配置信息";
            // 
            // TLSSecureCheckBox
            // 
            this.TLSSecureCheckBox.AutoSize = true;
            this.TLSSecureCheckBox.Location = new System.Drawing.Point(248, 164);
            this.TLSSecureCheckBox.Name = "TLSSecureCheckBox";
            this.TLSSecureCheckBox.Size = new System.Drawing.Size(123, 21);
            this.TLSSecureCheckBox.TabIndex = 15;
            this.TLSSecureCheckBox.Text = "TLS 底层传输安全";
            this.TLSSecureCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.ForeColor = System.Drawing.Color.Red;
            this.AlertLabel.Location = new System.Drawing.Point(6, 188);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(366, 34);
            this.AlertLabel.TabIndex = 14;
            this.AlertLabel.Text = "提醒：路径是 WebSockets 和 HTTP/2 的，如果不是这两种传输方\r\n式就不用管\r\n";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(79, 135);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(292, 23);
            this.PathTextBox.TabIndex = 13;
            this.PathTextBox.Text = "/";
            this.PathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(9, 138);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(44, 17);
            this.PathLabel.TabIndex = 12;
            this.PathLabel.Text = "路径：";
            // 
            // TransferMethodComboBox
            // 
            this.TransferMethodComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TransferMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransferMethodComboBox.FormattingEnabled = true;
            this.TransferMethodComboBox.Items.AddRange(new object[] {
            "TCP",
            "mKCP",
            "WebSockets",
            "HTTP/2",
            "QUIC"});
            this.TransferMethodComboBox.Location = new System.Drawing.Point(215, 105);
            this.TransferMethodComboBox.Name = "TransferMethodComboBox";
            this.TransferMethodComboBox.Size = new System.Drawing.Size(156, 24);
            this.TransferMethodComboBox.TabIndex = 11;
            this.TransferMethodComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // TransferMethodLabel
            // 
            this.TransferMethodLabel.AutoSize = true;
            this.TransferMethodLabel.Location = new System.Drawing.Point(151, 109);
            this.TransferMethodLabel.Name = "TransferMethodLabel";
            this.TransferMethodLabel.Size = new System.Drawing.Size(68, 17);
            this.TransferMethodLabel.TabIndex = 10;
            this.TransferMethodLabel.Text = "传输方式：";
            // 
            // AlterIDTextBox
            // 
            this.AlterIDTextBox.Location = new System.Drawing.Point(79, 106);
            this.AlterIDTextBox.Name = "AlterIDTextBox";
            this.AlterIDTextBox.Size = new System.Drawing.Size(70, 23);
            this.AlterIDTextBox.TabIndex = 9;
            this.AlterIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AlterIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // AlterIDLabel
            // 
            this.AlterIDLabel.AutoSize = true;
            this.AlterIDLabel.Location = new System.Drawing.Point(9, 109);
            this.AlterIDLabel.Name = "AlterIDLabel";
            this.AlterIDLabel.Size = new System.Drawing.Size(61, 17);
            this.AlterIDLabel.TabIndex = 8;
            this.AlterIDLabel.Text = "额外 ID：";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(79, 77);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(292, 23);
            this.UserIDTextBox.TabIndex = 7;
            this.UserIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Location = new System.Drawing.Point(8, 80);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(61, 17);
            this.UserIDLabel.TabIndex = 6;
            this.UserIDLabel.Text = "用户 ID：";
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Location = new System.Drawing.Point(308, 48);
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(63, 23);
            this.ServerPortTextBox.TabIndex = 5;
            this.ServerPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ServerPortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // ServerAddressTextBox
            // 
            this.ServerAddressTextBox.Location = new System.Drawing.Point(79, 48);
            this.ServerAddressTextBox.Name = "ServerAddressTextBox";
            this.ServerAddressTextBox.Size = new System.Drawing.Size(223, 23);
            this.ServerAddressTextBox.TabIndex = 3;
            this.ServerAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerAddressLabel
            // 
            this.ServerAddressLabel.AutoSize = true;
            this.ServerAddressLabel.Location = new System.Drawing.Point(8, 51);
            this.ServerAddressLabel.Name = "ServerAddressLabel";
            this.ServerAddressLabel.Size = new System.Drawing.Size(80, 17);
            this.ServerAddressLabel.TabIndex = 2;
            this.ServerAddressLabel.Text = "服务器地址：";
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.Location = new System.Drawing.Point(79, 19);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.Size = new System.Drawing.Size(292, 23);
            this.RemarkTextBox.TabIndex = 1;
            this.RemarkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.Location = new System.Drawing.Point(8, 22);
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.Size = new System.Drawing.Size(44, 17);
            this.RemarkLabel.TabIndex = 0;
            this.RemarkLabel.Text = "备注：";
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(300, 51);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(11, 17);
            this.ServerPortLabel.TabIndex = 4;
            this.ServerPortLabel.Text = ":";
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(315, 247);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(75, 23);
            this.ControlButton.TabIndex = 1;
            this.ControlButton.Text = "保存";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 280);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.ConfigGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加/编辑 - v2tap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ConfigGroupBox.ResumeLayout(false);
            this.ConfigGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConfigGroupBox;
        private System.Windows.Forms.ComboBox TransferMethodComboBox;
        private System.Windows.Forms.Label TransferMethodLabel;
        private System.Windows.Forms.TextBox AlterIDTextBox;
        private System.Windows.Forms.Label AlterIDLabel;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.TextBox ServerPortTextBox;
        private System.Windows.Forms.TextBox ServerAddressTextBox;
        private System.Windows.Forms.Label ServerAddressLabel;
        private System.Windows.Forms.TextBox RemarkTextBox;
        private System.Windows.Forms.Label RemarkLabel;
        private System.Windows.Forms.Label ServerPortLabel;
        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.CheckBox TLSSecureCheckBox;
    }
}