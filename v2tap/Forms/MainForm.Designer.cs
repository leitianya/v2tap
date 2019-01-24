namespace v2tap.Forms
{
    partial class MainForm
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
            this.v2rayGroupBox = new System.Windows.Forms.GroupBox();
            this.v2rayEditButton = new System.Windows.Forms.Button();
            this.v2rayImportButton = new System.Windows.Forms.Button();
            this.v2rayDeleteButton = new System.Windows.Forms.Button();
            this.v2rayAddButton = new System.Windows.Forms.Button();
            this.v2rayModeComboBox = new System.Windows.Forms.ComboBox();
            this.v2rayModeLabel = new System.Windows.Forms.Label();
            this.v2rayProxyComboBox = new System.Windows.Forms.ComboBox();
            this.v2rayProxyLabel = new System.Windows.Forms.Label();
            this.AdvancedButton = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.UplinkLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DownlinkLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BandwidthLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.v2rayGroupBox.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // v2rayGroupBox
            // 
            this.v2rayGroupBox.Controls.Add(this.v2rayEditButton);
            this.v2rayGroupBox.Controls.Add(this.v2rayImportButton);
            this.v2rayGroupBox.Controls.Add(this.v2rayDeleteButton);
            this.v2rayGroupBox.Controls.Add(this.v2rayAddButton);
            this.v2rayGroupBox.Controls.Add(this.v2rayModeComboBox);
            this.v2rayGroupBox.Controls.Add(this.v2rayModeLabel);
            this.v2rayGroupBox.Controls.Add(this.v2rayProxyComboBox);
            this.v2rayGroupBox.Controls.Add(this.v2rayProxyLabel);
            this.v2rayGroupBox.Location = new System.Drawing.Point(14, 17);
            this.v2rayGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.v2rayGroupBox.Name = "v2rayGroupBox";
            this.v2rayGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.v2rayGroupBox.Size = new System.Drawing.Size(430, 111);
            this.v2rayGroupBox.TabIndex = 0;
            this.v2rayGroupBox.TabStop = false;
            this.v2rayGroupBox.Text = "v2ray 配置";
            // 
            // v2rayEditButton
            // 
            this.v2rayEditButton.Location = new System.Drawing.Point(268, 82);
            this.v2rayEditButton.Name = "v2rayEditButton";
            this.v2rayEditButton.Size = new System.Drawing.Size(75, 23);
            this.v2rayEditButton.TabIndex = 7;
            this.v2rayEditButton.Text = "编辑";
            this.v2rayEditButton.UseVisualStyleBackColor = true;
            this.v2rayEditButton.Click += new System.EventHandler(this.v2rayEditButton_Click);
            // 
            // v2rayImportButton
            // 
            this.v2rayImportButton.Location = new System.Drawing.Point(349, 82);
            this.v2rayImportButton.Name = "v2rayImportButton";
            this.v2rayImportButton.Size = new System.Drawing.Size(75, 23);
            this.v2rayImportButton.TabIndex = 6;
            this.v2rayImportButton.Text = "导入";
            this.v2rayImportButton.UseVisualStyleBackColor = true;
            this.v2rayImportButton.Click += new System.EventHandler(this.v2rayImportButton_Click);
            // 
            // v2rayDeleteButton
            // 
            this.v2rayDeleteButton.Location = new System.Drawing.Point(187, 82);
            this.v2rayDeleteButton.Name = "v2rayDeleteButton";
            this.v2rayDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.v2rayDeleteButton.TabIndex = 5;
            this.v2rayDeleteButton.Text = "删除";
            this.v2rayDeleteButton.UseVisualStyleBackColor = true;
            this.v2rayDeleteButton.Click += new System.EventHandler(this.v2rayDeleteButton_Click);
            // 
            // v2rayAddButton
            // 
            this.v2rayAddButton.Location = new System.Drawing.Point(106, 82);
            this.v2rayAddButton.Name = "v2rayAddButton";
            this.v2rayAddButton.Size = new System.Drawing.Size(75, 23);
            this.v2rayAddButton.TabIndex = 4;
            this.v2rayAddButton.Text = "添加";
            this.v2rayAddButton.UseVisualStyleBackColor = true;
            this.v2rayAddButton.Click += new System.EventHandler(this.v2rayAddButton_Click);
            // 
            // v2rayModeComboBox
            // 
            this.v2rayModeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.v2rayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v2rayModeComboBox.FormattingEnabled = true;
            this.v2rayModeComboBox.Items.AddRange(new object[] {
            "绕过局域网",
            "绕过局域网和中国"});
            this.v2rayModeComboBox.Location = new System.Drawing.Point(44, 51);
            this.v2rayModeComboBox.Name = "v2rayModeComboBox";
            this.v2rayModeComboBox.Size = new System.Drawing.Size(380, 24);
            this.v2rayModeComboBox.TabIndex = 3;
            this.v2rayModeComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // v2rayModeLabel
            // 
            this.v2rayModeLabel.AutoSize = true;
            this.v2rayModeLabel.Location = new System.Drawing.Point(4, 55);
            this.v2rayModeLabel.Name = "v2rayModeLabel";
            this.v2rayModeLabel.Size = new System.Drawing.Size(44, 17);
            this.v2rayModeLabel.TabIndex = 2;
            this.v2rayModeLabel.Text = "模式：";
            // 
            // v2rayProxyComboBox
            // 
            this.v2rayProxyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.v2rayProxyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v2rayProxyComboBox.FormattingEnabled = true;
            this.v2rayProxyComboBox.Location = new System.Drawing.Point(44, 20);
            this.v2rayProxyComboBox.Name = "v2rayProxyComboBox";
            this.v2rayProxyComboBox.Size = new System.Drawing.Size(380, 24);
            this.v2rayProxyComboBox.TabIndex = 1;
            this.v2rayProxyComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // v2rayProxyLabel
            // 
            this.v2rayProxyLabel.AutoSize = true;
            this.v2rayProxyLabel.Location = new System.Drawing.Point(4, 24);
            this.v2rayProxyLabel.Name = "v2rayProxyLabel";
            this.v2rayProxyLabel.Size = new System.Drawing.Size(44, 17);
            this.v2rayProxyLabel.TabIndex = 0;
            this.v2rayProxyLabel.Text = "代理：";
            // 
            // AdvancedButton
            // 
            this.AdvancedButton.Location = new System.Drawing.Point(14, 135);
            this.AdvancedButton.Name = "AdvancedButton";
            this.AdvancedButton.Size = new System.Drawing.Size(75, 23);
            this.AdvancedButton.TabIndex = 1;
            this.AdvancedButton.Text = "高级设置";
            this.AdvancedButton.UseVisualStyleBackColor = true;
            this.AdvancedButton.Click += new System.EventHandler(this.AdvancedButton_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(369, 135);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(75, 23);
            this.ControlButton.TabIndex = 2;
            this.ControlButton.Text = "启动";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(95, 138);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(128, 17);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "当前状态：等待指令中";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UplinkLabel,
            this.DownlinkLabel,
            this.BandwidthLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 163);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(456, 22);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 4;
            // 
            // UplinkLabel
            // 
            this.UplinkLabel.Name = "UplinkLabel";
            this.UplinkLabel.Size = new System.Drawing.Size(60, 17);
            this.UplinkLabel.Text = "↑：0KB/s";
            // 
            // DownlinkLabel
            // 
            this.DownlinkLabel.Name = "DownlinkLabel";
            this.DownlinkLabel.Size = new System.Drawing.Size(60, 17);
            this.DownlinkLabel.Text = "↓：0KB/s";
            // 
            // BandwidthLabel
            // 
            this.BandwidthLabel.Name = "BandwidthLabel";
            this.BandwidthLabel.Size = new System.Drawing.Size(83, 17);
            this.BandwidthLabel.Text = "总流量：0 KB";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 185);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.AdvancedButton);
            this.Controls.Add(this.v2rayGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v2tap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.v2rayGroupBox.ResumeLayout(false);
            this.v2rayGroupBox.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox v2rayGroupBox;
        public System.Windows.Forms.Label v2rayProxyLabel;
        public System.Windows.Forms.ComboBox v2rayProxyComboBox;
        public System.Windows.Forms.Button v2rayAddButton;
        public System.Windows.Forms.ComboBox v2rayModeComboBox;
        public System.Windows.Forms.Label v2rayModeLabel;
        public System.Windows.Forms.Button v2rayDeleteButton;
        public System.Windows.Forms.Button v2rayImportButton;
        private System.Windows.Forms.Button AdvancedButton;
        public System.Windows.Forms.Button v2rayEditButton;
        public System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel UplinkLabel;
        private System.Windows.Forms.ToolStripStatusLabel DownlinkLabel;
        private System.Windows.Forms.ToolStripStatusLabel BandwidthLabel;
    }
}