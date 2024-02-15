namespace KALIMBA
{
    partial class SettingsForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkBoxPlaying = new System.Windows.Forms.CheckBox();
            this.linkLabelEctfyi = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(265, 90);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 37);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "保存";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(373, 90);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 37);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // checkBoxPlaying
            // 
            this.checkBoxPlaying.AutoSize = true;
            this.checkBoxPlaying.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPlaying.Location = new System.Drawing.Point(45, 33);
            this.checkBoxPlaying.Name = "checkBoxPlaying";
            this.checkBoxPlaying.Size = new System.Drawing.Size(100, 27);
            this.checkBoxPlaying.TabIndex = 8;
            this.checkBoxPlaying.Text = "播放音乐";
            this.checkBoxPlaying.UseVisualStyleBackColor = true;
            // 
            // linkLabelEctfyi
            // 
            this.linkLabelEctfyi.AutoSize = true;
            this.linkLabelEctfyi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.linkLabelEctfyi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEctfyi.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(153)))));
            this.linkLabelEctfyi.Location = new System.Drawing.Point(27, 97);
            this.linkLabelEctfyi.Name = "linkLabelEctfyi";
            this.linkLabelEctfyi.Size = new System.Drawing.Size(62, 20);
            this.linkLabelEctfyi.TabIndex = 9;
            this.linkLabelEctfyi.TabStop = true;
            this.linkLabelEctfyi.Text = "ect.fyi";
            this.linkLabelEctfyi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEctfyi_LinkClicked);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(486, 140);
            this.Controls.Add(this.linkLabelEctfyi);
            this.Controls.Add(this.checkBoxPlaying);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "KALIMBA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox checkBoxPlaying;
        private System.Windows.Forms.LinkLabel linkLabelEctfyi;
    }
}