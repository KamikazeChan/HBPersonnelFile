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
            //Dgv读取数据
            string sql = "SELECT * FROM Tyg员工";
            dgv.DataSource = FrmMain.jxcClient.GetTable(sql,1);
            WinUI.SetRowNum(dgv);
            WinUI.FormatGrid(dgv);

            //设置CombBox
            DataTable dtComboBox = new DataTable();
            dtComboBox.Columns.Add("Text");
            dtComboBox.Columns.Add("Tag");
            dtComboBox.Rows.Add("姓名", "X姓名");
            dtComboBox.Rows.Add("部门", "B部门");
            dtComboBox.Rows.Add("状态", "Z状态");
            cbSrh查询.DataSource = dtComboBox;
            cbSrh查询.ValueMember = "Tag";
            cbSrh查询.DisplayMember = "Text";

            //初始化右侧资料区
            tabControlPanel1.Enabled = false;
            tabControlPanel2.Enabled = false;

        }

        private void btnSrh查询_Click(object sender, EventArgs e)
        {
            if (txtSrh查询.Text.Trim() == "")
                return;

            string sql = string.Format("SELECT * FROM Tyg员工 WHERE {0} like '%{1}%'",cbSrh查询.SelectedValue.ToString(),txtSrh查询.Text.Trim());
            dgv.DataSource = FrmMain.jxcClient.GetTable(sql, 1);
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void txtSrh查询_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnSrh查询_Click(null, null);
        }

    }
}
