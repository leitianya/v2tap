namespace v2tap.Forms
{
    partial class ImportForm
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
            this.ImportFromSubscriptionURLGroupBox = new System.Windows.Forms.GroupBox();
            this.SubscriptionImportButton = new System.Windows.Forms.Button();
            this.SubscriptionURLTextBox = new System.Windows.Forms.TextBox();
            this.SubscriptionURLLabel = new System.Windows.Forms.Label();
            this.ImportFromTextBoxGroupBox = new System.Windows.Forms.GroupBox();
            this.MyButton = new System.Windows.Forms.Button();
            this.MyTextBox = new System.Windows.Forms.TextBox();
            this.ImportFromSubscriptionURLGroupBox.SuspendLayout();
            this.ImportFromTextBoxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportFromSubscriptionURLGroupBox
            // 
            this.ImportFromSubscriptionURLGroupBox.Controls.Add(this.SubscriptionImportButton);
            this.ImportFromSubscriptionURLGroupBox.Controls.Add(this.SubscriptionURLTextBox);
            this.ImportFromSubscriptionURLGroupBox.Controls.Add(this.SubscriptionURLLabel);
            this.ImportFromSubscriptionURLGroupBox.Location = new System.Drawing.Point(14, 17);
            this.ImportFromSubscriptionURLGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImportFromSubscriptionURLGroupBox.Name = "ImportFromSubscriptionURLGroupBox";
            this.ImportFromSubscriptionURLGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImportFromSubscriptionURLGroupBox.Size = new System.Drawing.Size(559, 78);
            this.ImportFromSubscriptionURLGroupBox.TabIndex = 0;
            this.ImportFromSubscriptionURLGroupBox.TabStop = false;
            this.ImportFromSubscriptionURLGroupBox.Text = "从订阅链接导入";
            // 
            // SubscriptionImportButton
            // 
            this.SubscriptionImportButton.Location = new System.Drawing.Point(478, 49);
            this.SubscriptionImportButton.Name = "SubscriptionImportButton";
            this.SubscriptionImportButton.Size = new System.Drawing.Size(75, 23);
            this.SubscriptionImportButton.TabIndex = 2;
            this.SubscriptionImportButton.Text = "导入";
            this.SubscriptionImportButton.UseVisualStyleBackColor = true;
            this.SubscriptionImportButton.Click += new System.EventHandler(this.SubscriptionImportButton_Click);
            // 
            // SubscriptionURLTextBox
            // 
            this.SubscriptionURLTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubscriptionURLTextBox.Location = new System.Drawing.Point(44, 20);
            this.SubscriptionURLTextBox.Name = "SubscriptionURLTextBox";
            this.SubscriptionURLTextBox.Size = new System.Drawing.Size(509, 22);
            this.SubscriptionURLTextBox.TabIndex = 1;
            // 
            // SubscriptionURLLabel
            // 
            this.SubscriptionURLLabel.AutoSize = true;
            this.SubscriptionURLLabel.Location = new System.Drawing.Point(8, 23);
            this.SubscriptionURLLabel.Name = "SubscriptionURLLabel";
            this.SubscriptionURLLabel.Size = new System.Drawing.Size(44, 17);
            this.SubscriptionURLLabel.TabIndex = 0;
            this.SubscriptionURLLabel.Text = "链接：";
            // 
            // ImportFromTextBoxGroupBox
            // 
            this.ImportFromTextBoxGroupBox.Controls.Add(this.MyButton);
            this.ImportFromTextBoxGroupBox.Controls.Add(this.MyTextBox);
            this.ImportFromTextBoxGroupBox.Location = new System.Drawing.Point(12, 102);
            this.ImportFromTextBoxGroupBox.Name = "ImportFromTextBoxGroupBox";
            this.ImportFromTextBoxGroupBox.Size = new System.Drawing.Size(561, 260);
            this.ImportFromTextBoxGroupBox.TabIndex = 1;
            this.ImportFromTextBoxGroupBox.TabStop = false;
            this.ImportFromTextBoxGroupBox.Text = "从文本框中导入";
            // 
            // MyButton
            // 
            this.MyButton.Location = new System.Drawing.Point(480, 231);
            this.MyButton.Name = "MyButton";
            this.MyButton.Size = new System.Drawing.Size(75, 23);
            this.MyButton.TabIndex = 1;
            this.MyButton.Text = "导入";
            this.MyButton.UseVisualStyleBackColor = true;
            this.MyButton.Click += new System.EventHandler(this.MyButton_Click);
            // 
            // MyTextBox
            // 
            this.MyTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyTextBox.Location = new System.Drawing.Point(13, 22);
            this.MyTextBox.Multiline = true;
            this.MyTextBox.Name = "MyTextBox";
            this.MyTextBox.Size = new System.Drawing.Size(542, 203);
            this.MyTextBox.TabIndex = 0;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 375);
            this.Controls.Add(this.ImportFromTextBoxGroupBox);
            this.Controls.Add(this.ImportFromSubscriptionURLGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入 - v2tap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportForm_FormClosing);
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ImportFromSubscriptionURLGroupBox.ResumeLayout(false);
            this.ImportFromSubscriptionURLGroupBox.PerformLayout();
            this.ImportFromTextBoxGroupBox.ResumeLayout(false);
            this.ImportFromTextBoxGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ImportFromSubscriptionURLGroupBox;
        private System.Windows.Forms.Button SubscriptionImportButton;
        private System.Windows.Forms.TextBox SubscriptionURLTextBox;
        private System.Windows.Forms.Label SubscriptionURLLabel;
        private System.Windows.Forms.GroupBox ImportFromTextBoxGroupBox;
        private System.Windows.Forms.TextBox MyTextBox;
        private System.Windows.Forms.Button MyButton;
    }
}