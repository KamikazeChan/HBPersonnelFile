using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using WeifenLuo.WinFormsUI.Docking;

namespace HBPersonnelFile.BaseInfo
{
    public partial class FrmEmployee :DockContent
    {
        BindingSource bind = new BindingSource();
        bool boolOnce = true;

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
            LoadData("");

            //设置查询CombBox
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

            //设置绑定
            SetBinding();
            bind.CurrentChanged += bind_CurrentChanged;//增加一个当前行变化的事件
        }   

        void bind_CurrentChanged(object sender, EventArgs e)
        {
            if (dgv.Rows.Count < 1)
                return;

            if(dgv.SelectedRows.Count>0&&dgv.SelectedRows[0].Cells["ID"].Value!=null)
                txtX姓名.Tag = dgv.SelectedRows[0].Cells["ID"].Value.ToString();

        }

        private void LoadData(string strWhere)
        {
            string sql = "SELECT * FROM Tyg员工 "+strWhere;
            DataTable dt = FrmMain.jxcClient.GetTable(sql, User.UserID);
            bind.DataSource = dt;
            dgv.DataSource = bind;
            //boolOnce = true;
            //SetBinding();
            WinUI.SetRowNum(dgv);
            WinUI.FormatGrid(dgv);
        }

        private void btnSrh查询_Click(object sender, EventArgs e)
        {
            if (txtSrh查询.Text.Trim() == "")
            {
                LoadData("");
            }
            else
            {
                string strWhere = string.Format("where {0} like '%{1}%'",cbSrh查询.SelectedValue.ToString(),txtSrh查询.Text.Trim());
                LoadData(strWhere);
            }

            dgv.Enabled = true;
            btnAdd新增.Enabled = true;
            btnEdit修改.Enabled = true;
            btnDel删除.Enabled = true;
            DisabledTabPage();
            labStaus.Text = "状态:";
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void SetBinding()
        {
            if (!boolOnce)
                return;

            txtX姓名.DataBindings.Add(new Binding("Text", bind, "X姓名", true));
            txtX性别.DataBindings.Add(new Binding("Text", bind, "X性别", true));
            txtB部门.DataBindings.Add(new Binding("Text", bind, "B部门", true));
            txtC出生年份.DataBindings.Add(new Binding("Text", bind, "C出生年份", true));
            txtC出生月份.DataBindings.Add(new Binding("Text", bind, "C出生月份", true));
            txtD电话.DataBindings.Add(new Binding("Text", bind, "D电话", true));
            txtG工会费.DataBindings.Add(new Binding("Text", bind, "G工会费", true));
            txtG公积金.DataBindings.Add(new Binding("Text", bind, "G公积金", true));
            txtL离职日期.DataBindings.Add(new Binding("Text", bind, "L离职日期", true));
            txtN年假.DataBindings.Add(new Binding("Text", bind, "N年假", true));
            txtR入职日期.DataBindings.Add(new Binding("Text", bind, "R入职日期", true));
            txtS社保.DataBindings.Add(new Binding("Text", bind, "S社保", true));
            txtS剩余年假.DataBindings.Add(new Binding("Text", bind, "S剩余年假", true));
            txtT特困基金.DataBindings.Add(new Binding("Text", bind, "T特困基金", true));
            txtY员工类型.DataBindings.Add(new Binding("Text", bind, "Y员工类型", true));
            txtZ状态.DataBindings.Add(new Binding("Text", bind, "Z状态", true));
            txtP排序.DataBindings.Add(new Binding("Text", bind, "P排序", true));
            txtX姓名.Tag = dgv.SelectedRows[0].Cells["ID"].Value.ToString();

            boolOnce = false;
        }

        private void txtSrh查询_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnSrh查询_Click(null, null);
        }

        private void btnAdd新增_Click(object sender, EventArgs e)
        {
            if (labStaus.Text != "状态:新增")
            {
                EnabledTabPage();
                bind.AddNew();

                //dgv选中行移到最后一行
                int rows = dgv.Rows.Count;
                dgv.Rows[dgv.SelectedRows[0].Index].Selected = false;
                dgv.Rows[rows - 1].Selected = true;

                //设置其他控件状态
                labStaus.Text = "状态:新增";
                txtX姓名.Tag = 0;
                dgv.Enabled = false;
                btnEdit修改.Enabled = false;
                btnDel删除.Enabled = false;
            }
            else
            {
                DisabledTabPage();
                bind.RemoveCurrent();
                labStaus.Text = "状态:";
                dgv.Enabled = true;
                btnEdit修改.Enabled = true;
                btnDel删除.Enabled = true;
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
            {
                labStaus.Text = "状态:编辑";
                EnabledTabPage();
                btnAdd新增.Enabled = false;
                btnDel删除.Enabled = false;
                dgv.Enabled = false;
            }
            else
            {
                DisabledTabPage();
                labStaus.Text = "状态:";
                btnAdd新增.Enabled = true;
                btnDel删除.Enabled = true;
                dgv.Enabled = true;
            }
        }

        private void btnDel删除_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count < 1)
                return;
            if (MessageBox.Show("是否删除该员工资料?", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string sql = string.Format("delete Tyg员工 WHERE ID={0}",txtX姓名.Tag.ToString());
            int reNum = FrmMain.jxcClient.ExecSQL(sql,User.UserID);
            LoadData("");
        }

        private void btnSave保存_Click(object sender, EventArgs e)
        {
            string sql = string.Empty;
            if (labStaus.Text == "状态:新增")
            {
                sql = string.Format("INSERT INTO Tyg员工 (X姓名, X性别, Y员工类型, Z状态, B部门, D电话, R入职日期, L离职日期, "+
                                    "C出生年份, C出生月份, N年假, S剩余年假, S社保, G公积金, G工会费, T特困基金, P排序) VALUES "+
                                    "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')",
                                    txtX姓名.Text.Trim(), txtX性别.Text, txtY员工类型.Text, txtZ状态.Text, txtB部门.Text, txtD电话.Text, txtR入职日期.Text,
                                    txtL离职日期.Text, txtC出生年份.Text, txtC出生月份.Text, txtN年假.Text, txtS剩余年假.Text, txtS社保.Text,
                                    txtG公积金.Text, txtG工会费.Text, txtT特困基金.Text, txtP排序.Text );
            }
            else
            {
                sql = string.Format("UPDATE Tyg员工 SET "+
                                    "X姓名 ='{0}', X性别 ='{1}', Y员工类型 ='{2}', Z状态 ='{3}', B部门 ='{4}', D电话 ='{5}', "+
                                    "R入职日期 ='{6}', L离职日期 ='{7}', C出生年份 ='{8}', C出生月份 ='{9}', N年假 ='{10}', "+
                                    "S剩余年假 ='{11}', S社保 ='{12}', G公积金 ='{13}', G工会费 ='{14}', T特困基金 ='{15}', P排序 ='{16}' "+
                                    "WHERE ID='{17}'", txtX姓名.Text.Trim(), txtX性别.Text, txtY员工类型.Text, txtZ状态.Text, txtB部门.Text, txtD电话.Text, 
                                    txtR入职日期.Text, txtL离职日期.Text, txtC出生年份.Text, txtC出生月份.Text, txtN年假.Text, txtS剩余年假.Text, txtS社保.Text,
                                    txtG公积金.Text, txtG工会费.Text, txtT特困基金.Text, txtP排序.Text,txtX姓名.Tag.ToString());
            }
            int reNum = FrmMain.jxcClient.ExecSQL(sql, User.UserID);
            if (reNum == 1)
            {
                labB保存.Text = "保存成功";
                labB保存.Visible = true;

                dgv.Enabled = true;
                DisabledTabPage();
                btnAdd新增.Enabled = true;
                btnDel删除.Enabled = true;
                btnEdit修改.Enabled = true;
                labStaus.Text = "状态:";
            }
            else
            {
                labB保存.Text = "保存失败";
                labB保存.Visible = true;
                labB保存.ForeColor = Color.Red;
            }
            timer1.Enabled = true;
        }

        private void btnKJNJ扣减年假_Click(object sender, EventArgs e)
        {
            var str=txtS剩余年假.Text;
            if(str=="")
            {
                MessageBox.Show("未设置年假, 不能扣减", "错误");
                return;
            }
            var leftDay = float.Parse(str);//剩余年假天数
            if(leftDay==0)
            {
                MessageBox.Show("没有年假可以扣了.", "错误");
                return;
            }

           string input = Interaction.InputBox("请输入扣减天数, 不能大于剩余年假", "年假扣减", "", 300, 300);
           float uinput = 0;//用户输入的扣减天数
           float.TryParse(input, out uinput);
            if(uinput==0)
            {
                MessageBox.Show("输入不正确.","错误");
                return;
            }
            if(uinput>leftDay)
            {
                MessageBox.Show("输入扣减年假不能大于剩余年假.", "错误");
                return;
            }

            var left = leftDay - uinput;//最后剩余年假
            txtS剩余年假.Text = left.ToString();
            //Save
            //log
            var msg = string.Format("{0}的剩余年假由{1}天扣减到{2}天",txtX姓名.Text,leftDay,left);
            SysLoger.Info(msg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labB保存.Visible = false;
            timer1.Enabled = false;
        }

    }
}
