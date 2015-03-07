using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HBPersonnelFile.BaseInfo;
using WeifenLuo.WinFormsUI.Docking;

namespace HBPersonnelFile
{
    public partial class FrmMain : Form
    {
        public static Form sMainForm;
        private FrmMainToolBox FrmToolBox;
        public static JXCClient.JXCServiceClient jxcClient;
        public static DockPanel sDPanel;

        public FrmMain()
        {
            InitializeComponent();
            InitSystem();//初始化系统
            jxcClient = new JXCClient.JXCServiceClient();
        }

        private void InitSystem()
        {
            sMainForm = this;
            sDPanel = dockPanelMain;

            main_Staus.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            Status_lbl_User.Alignment = ToolStripItemAlignment.Right;
            Status_lbl_ServerAddress.Alignment = ToolStripItemAlignment.Right;
            Status_lbl_LoginTime.Alignment = ToolStripItemAlignment.Right;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeUI();//初始化界面
            FrmEmployee frm = new FrmEmployee();
            frm.Show(sDPanel);
        }

        private void InitializeUI()
        {
            this.Show();
            this.Activate();

            SetStatusText();//设置状态栏信息

            //登陆界面
            /*预留*/

            menu_Main.Visible = false;

#if DEBUG
            menu_Main.Visible = true;
#endif
            //if (!Login())
            //    Application.Exit();
            ShowToolBox();
        }
        private bool Login()
        {
            FrmLogin frm = new FrmLogin();

            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return false;
            SetUserInfo();
            this.WindowState = FormWindowState.Maximized;
            return true;
        }
        private void SetUserInfo()
        {
         //   lblUserInfo.Text = "用户: " + User.UserName + "  登录时间:" + DateTime.Now.ToString();
        }

        private void SetStatusText()
        {
            Status_lbl_ServerAddress.Text = jxcClient.Endpoint.ListenUri.Authority.ToString().Replace(":", ".")+" |";
        }

        private void ShowToolBox()
        {
            FrmToolBox = new FrmMainToolBox(this);
            FrmToolBox.Show(sDPanel, DockState.DockLeft);
            sDPanel.DockLeftPortion = 0.15;
        }

        private void 人事资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseInfo.FrmEmployee frm = new BaseInfo.FrmEmployee();
            frm.Show(sDPanel);
        }

        internal void OpenMdiChildrenForm2(Model.Tcd菜单 t)
        {
            if (ChildFromCheck(t.FuncName)) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                try
                {
                    Type myType = Type.GetType("HBPersonnelFile." + t.FormName);

                    object obj = Activator.CreateInstance(myType);
                    if (obj is DockContent)
                    {
                        DockContent frm = (DockContent)obj;
                        frm.Show(sDPanel);

                    }
                    else
                    {
                        if (obj is Form)
                        {
                            Form f = (Form)obj;
                            f.ShowInTaskbar = false;
                            f.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool ChildFromCheck(string formName)
        {
            foreach (Form ChildrenForm in this.MdiChildren)
            {
                if (ChildrenForm.Text == formName)//检测是不是当前子窗体名称
                {
                    ChildrenForm.Visible = true;    //是的话就是把他显示
                    ChildrenForm.Activate();   //并激活该窗体
                    return true;
                }
            }
            return false;
        }
    }
}
