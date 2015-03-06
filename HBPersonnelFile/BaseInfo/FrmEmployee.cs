using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HBPersonnelFile.BaseInfo
{
    public partial class FrmEmployee :DockContent
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void panelEx2_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Tyg员工";
            dgv.DataSource = FrmMain.jxcClient.GetTable(sql,1);
        }
    }
}
