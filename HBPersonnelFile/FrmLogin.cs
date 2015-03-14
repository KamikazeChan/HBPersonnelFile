using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HBPersonnelFile
{
    public partial class FrmLogin : Form
    {
        public Action CreatMenu;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
         //tabControlPanel1.ta
           this.Text += "(Ver:" + Application.ProductVersion + ")";
            // CheckUpdate();//检查更新
            //  btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
                this.Cursor = Cursors.WaitCursor;
             
                var sql = "select ID, X姓名, Z帐号, B部门 from Tyg员工 where Z帐号='{0}' and M密码='{1}'";
                var dt = RemoteServer.GetTable(sql);
                if (dt.Rows.Count == 1)
                {
                    User.UserID =int.Parse(dt.Rows[0]["ID"].ToString() );
                    User.UserName = dt.Rows[0]["X姓名"].ToString();
                    User.LoginName=dt.Rows[0]["Z帐号"].ToString();
                    User.Department = dt.Rows[0]["B部门"].ToString();

                    this.Cursor = Cursors.Default;
                    if (CreatMenu != null)
                        CreatMenu();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                    MessageBox.Show("账号或密码输入错误.");
                this.Cursor = Cursors.Default;
            

        }
        private void CheckUpdate()
        {
            //从配置文件中读取, 是否开启自动更新
            string autoupdate = ConfigurationManager.AppSettings["autoupdate"];
            if (!bool.Parse(autoupdate)) return;

            //string sql = string.Format("select NewVersion from MyVersion ");
            //object obj = DBHelper.GetObject(sql);
            //if (obj != null)
            //{
            //    if (Application.ProductVersion != obj.ToString())
            //    {
            //        string msg = "发现新版本, 是否更新?";
            //        DialogResult dr = MessageBox.Show(msg, "提示", MessageBoxButtons.YesNo);
            //        if (dr == System.Windows.Forms.DialogResult.Yes)
            //        {
            //            if (File.Exists("LXUpdater.exe"))
            //            {
            //                System.Diagnostics.Process.Start("LXUpdater.exe");
            //                this.Close();
            //            }
            //            else
            //                MessageBox.Show("找不到更新程序.");

            //        }
            //    }
            //}
        }

        private void cbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin2.PerformClick();
        }
    }
}
