namespace HBPersonnelFile
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.main_Staus = new System.Windows.Forms.StatusStrip();
            this.Status_lbl_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_lbl_ServerAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_lbl_LoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.main_Staus.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_Staus
            // 
            this.main_Staus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_lbl_User,
            this.Status_lbl_ServerAddress,
            this.Status_lbl_LoginTime});
            this.main_Staus.Location = new System.Drawing.Point(0, 578);
            this.main_Staus.Name = "main_Staus";
            this.main_Staus.Size = new System.Drawing.Size(935, 22);
            this.main_Staus.TabIndex = 0;
            this.main_Staus.Text = "main_Staus";
            // 
            // Status_lbl_User
            // 
            this.Status_lbl_User.Name = "Status_lbl_User";
            this.Status_lbl_User.Size = new System.Drawing.Size(35, 17);
            this.Status_lbl_User.Text = "User";
            // 
            // Status_lbl_ServerAddress
            // 
            this.Status_lbl_ServerAddress.Name = "Status_lbl_ServerAddress";
            this.Status_lbl_ServerAddress.Size = new System.Drawing.Size(19, 17);
            this.Status_lbl_ServerAddress.Text = "IP";
            // 
            // Status_lbl_LoginTime
            // 
            this.Status_lbl_LoginTime.Name = "Status_lbl_LoginTime";
            this.Status_lbl_LoginTime.Size = new System.Drawing.Size(36, 17);
            this.Status_lbl_LoginTime.Text = "Time";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 600);
            this.Controls.Add(this.main_Staus);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.main_Staus.ResumeLayout(false);
            this.main_Staus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip main_Staus;
        private System.Windows.Forms.ToolStripStatusLabel Status_lbl_User;
        private System.Windows.Forms.ToolStripStatusLabel Status_lbl_ServerAddress;
        private System.Windows.Forms.ToolStripStatusLabel Status_lbl_LoginTime;
    }
}

