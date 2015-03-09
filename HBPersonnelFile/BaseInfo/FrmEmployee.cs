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
            DisabledTabPage();

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
            if (dgv.Rows.Count < 1)
                return;
            DisabledTabPage();
        }

        private void txtSrh查询_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnSrh查询_Click(null, null);
        }

        private void btnAdd新增_Click(object sender, EventArgs e)
        {
            EnabledTabPage();
            foreach (Control c in tabControlPanel1.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                if (c is RichTextBox)
                    c.Text = "";
            }
        }

        //允许编辑右侧资料区
        private void EnabledTabPage()
        {
            tabControlPanel1.Enabled = true;
            tabControlPanel2.Enabled = true;
        }

        //禁止编辑右侧资料区
        private void DisabledTabPage()
        {
            tabControlPanel1.Enabled = false;
            tabControlPanel2.Enabled = false;
        }

        private void btnEdit修改_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count < 1)
                return;

            //设置右侧是否可以编辑
            if (!tabControlPanel1.Enabled)
                EnabledTabPage();
            else
                DisabledTabPage();
        }

        private void btnDel删除_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count < 1)
                return;

        }

        private void btnSave保存_Click(object sender, EventArgs e)
        {

        }

    }
}
