namespace HBPersonnelFile.SYS
{
    partial class FrmResetPwd
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
            this.txtcfxmm重复新密码 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSure = new System.Windows.Forms.Button();
            this.txtxmm新密码 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtymm原密码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtzh帐户 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcfxmm重复新密码
            // 
            this.txtcfxmm重复新密码.Location = new System.Drawing.Point(185, 205);
            this.txtcfxmm重复新密码.Name = "txtcfxmm重复新密码";
            this.txtcfxmm重复新密码.PasswordChar = '*';
            this.txtcfxmm重复新密码.Size = new System.Drawing.Size(151, 21);
            this.txtcfxmm重复新密码.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "重复新密码";
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(216, 263);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(120, 23);
            this.btnSure.TabIndex = 15;
            this.btnSure.Text = "修改帐户和密码";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // txtxmm新密码
            // 
            this.txtxmm新密码.Location = new System.Drawing.Point(185, 161);
            this.txtxmm新密码.Name = "txtxmm新密码";
            this.txtxmm新密码.PasswordChar = '*';
            this.txtxmm新密码.Size = new System.Drawing.Size(151, 21);
            this.txtxmm新密码.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "新  密  码";
            // 
            // txtymm原密码
            // 
            this.txtymm原密码.Location = new System.Drawing.Point(185, 115);
            this.txtymm原密码.Name = "txtymm原密码";
            this.txtymm原密码.PasswordChar = '*';
            this.txtymm原密码.Size = new System.Drawing.Size(151, 21);
            this.txtymm原密码.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "原  密  码";
            // 
            // txtzh帐户
            // 
            this.txtzh帐户.Location = new System.Drawing.Point(185, 71);
            this.txtzh帐户.Name = "txtzh帐户";
            this.txtzh帐户.Size = new System.Drawing.Size(151, 21);
            this.txtzh帐户.TabIndex = 10;
            this.txtzh帐户.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "账      号";
            // 
            // FrmResetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.txtcfxmm重复新密码);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.txtxmm新密码);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtymm原密码);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtzh帐户);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmResetPwd";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmResetPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcfxmm重复新密码;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.TextBox txtxmm新密码;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtymm原密码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtzh帐户;
        private System.Windows.Forms.Label label1;
    }
}