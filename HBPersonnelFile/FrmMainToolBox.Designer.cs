namespace HBPersonnelFile
{
    partial class FrmMainToolBox
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
            this.components = new System.ComponentModel.Container();
            this.Main_TreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Main_TreeView
            // 
            this.Main_TreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_TreeView.Location = new System.Drawing.Point(0, 0);
            this.Main_TreeView.Name = "Main_TreeView";
            this.Main_TreeView.Size = new System.Drawing.Size(255, 601);
            this.Main_TreeView.StateImageList = this.imageList1;
            this.Main_TreeView.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMainToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 601);
            this.CloseButtonVisible = false;
            this.Controls.Add(this.Main_TreeView);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinimizeBox = false;
            this.Name = "FrmMainToolBox";
            this.Text = "菜单";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Main_TreeView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}