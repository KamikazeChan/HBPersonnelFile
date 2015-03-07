using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HBPersonnelFile.SYS
{
    public partial class FrmResetPwd : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FrmResetPwd()
        {
            InitializeComponent();
        }

        private void FrmResetPwd_Load(object sender, EventArgs e)
        {
            txtzh帐户.Text = User.LoginName;
        }

        private bool UserInputValid()
        {
            if (txtzh帐户.Text.Trim() == "")
            {
                MessageBox.Show("帐户不能为空.");
                return false;
            }
            if (txtymm原密码.Text.Trim() == "")
            {
                MessageBox.Show("原密码不能为空.");
                return false;
            }
            if (txtxmm新密码.Text.Trim() == "")
            {
                MessageBox.Show("新密码不能为空.");
                return false;
            }
            if (txtcfxmm重复新密码.Text.Trim() == "")
            {
                MessageBox.Show("重复新密码不能为空.");
                return false;
            }
            if (txtxmm新密码.Text != txtcfxmm重复新密码.Text)
            {
                MessageBox.Show("新密码 和 重复新密码 输入的内容不相同.");
                return false;
            }
            return true;
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (!UserInputValid()) return;
            string sql = string.Format("SELECT count(*) from Tyg员工 where ID={0} and M密码='{1}'", User.UserID, txtymm原密码.Text);
            var count = RemoteServer.ExecScalar<int>(sql);
            if (count < 1)
            {
                MessageBox.Show("原密码输入不正确.");
                return;
            }
            sql =string.Format( "udpate Tyg员工 set M密码='{0}' where ID={1}",txtxmm新密码.Text, User.UserID);
            count = RemoteServer.ExecSQL(sql);
            if (count > 0)
            {
                MessageBox.Show("修改成功.");
                this.Close();
            }
            else
            {
                MessageBox.Show("保存失败.");
            }
        }
    }
}
