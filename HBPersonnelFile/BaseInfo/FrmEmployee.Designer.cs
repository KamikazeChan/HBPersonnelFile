namespace HBPersonnelFile.BaseInfo
{
    partial class FrmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelTop = new DevComponents.DotNetBar.PanelEx();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX8 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX6 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX9 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX10 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX11 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelRight = new DevComponents.DotNetBar.PanelEx();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnDel = new DevComponents.DotNetBar.ButtonX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX12 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX13 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX14 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX15 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX16 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX17 = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 35);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(425, 560);
            this.dgv.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.comboBoxEx1);
            this.panelTop.Controls.Add(this.textBoxX1);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(953, 35);
            this.panelTop.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTop.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelTop.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelTop.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTop.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTop.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTop.Style.GradientAngle = 90;
            this.panelTop.TabIndex = 1;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.Location = new System.Drawing.Point(668, 6);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(80, 22);
            this.comboBoxEx1.TabIndex = 16;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(767, 7);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(80, 21);
            this.textBoxX1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(866, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            // 
            // textBoxX8
            // 
            // 
            // 
            // 
            this.textBoxX8.Border.Class = "TextBoxBorder";
            this.textBoxX8.Location = new System.Drawing.Point(75, 104);
            this.textBoxX8.Name = "textBoxX8";
            this.textBoxX8.Size = new System.Drawing.Size(84, 21);
            this.textBoxX8.TabIndex = 9;
            // 
            // textBoxX7
            // 
            // 
            // 
            // 
            this.textBoxX7.Border.Class = "TextBoxBorder";
            this.textBoxX7.Location = new System.Drawing.Point(75, 23);
            this.textBoxX7.Name = "textBoxX7";
            this.textBoxX7.Size = new System.Drawing.Size(84, 21);
            this.textBoxX7.TabIndex = 7;
            // 
            // textBoxX5
            // 
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Location = new System.Drawing.Point(75, 77);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.Size = new System.Drawing.Size(84, 21);
            this.textBoxX5.TabIndex = 5;
            // 
            // textBoxX6
            // 
            // 
            // 
            // 
            this.textBoxX6.Border.Class = "TextBoxBorder";
            this.textBoxX6.Location = new System.Drawing.Point(75, 131);
            this.textBoxX6.Name = "textBoxX6";
            this.textBoxX6.Size = new System.Drawing.Size(84, 21);
            this.textBoxX6.TabIndex = 3;
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Location = new System.Drawing.Point(75, 50);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(84, 21);
            this.textBoxX4.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.Transparent;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 521);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.labelX11);
            this.tabControlPanel1.Controls.Add(this.labelX12);
            this.tabControlPanel1.Controls.Add(this.labelX13);
            this.tabControlPanel1.Controls.Add(this.textBoxX12);
            this.tabControlPanel1.Controls.Add(this.textBoxX13);
            this.tabControlPanel1.Controls.Add(this.textBoxX14);
            this.tabControlPanel1.Controls.Add(this.labelX14);
            this.tabControlPanel1.Controls.Add(this.labelX15);
            this.tabControlPanel1.Controls.Add(this.labelX16);
            this.tabControlPanel1.Controls.Add(this.textBoxX15);
            this.tabControlPanel1.Controls.Add(this.textBoxX16);
            this.tabControlPanel1.Controls.Add(this.textBoxX17);
            this.tabControlPanel1.Controls.Add(this.labelX6);
            this.tabControlPanel1.Controls.Add(this.labelX7);
            this.tabControlPanel1.Controls.Add(this.labelX8);
            this.tabControlPanel1.Controls.Add(this.labelX9);
            this.tabControlPanel1.Controls.Add(this.labelX10);
            this.tabControlPanel1.Controls.Add(this.textBoxX2);
            this.tabControlPanel1.Controls.Add(this.textBoxX3);
            this.tabControlPanel1.Controls.Add(this.textBoxX9);
            this.tabControlPanel1.Controls.Add(this.textBoxX10);
            this.tabControlPanel1.Controls.Add(this.textBoxX11);
            this.tabControlPanel1.Controls.Add(this.labelX5);
            this.tabControlPanel1.Controls.Add(this.labelX4);
            this.tabControlPanel1.Controls.Add(this.labelX3);
            this.tabControlPanel1.Controls.Add(this.labelX2);
            this.tabControlPanel1.Controls.Add(this.labelX1);
            this.tabControlPanel1.Controls.Add(this.textBoxX8);
            this.tabControlPanel1.Controls.Add(this.textBoxX7);
            this.tabControlPanel1.Controls.Add(this.textBoxX4);
            this.tabControlPanel1.Controls.Add(this.textBoxX5);
            this.tabControlPanel1.Controls.Add(this.textBoxX6);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(528, 495);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(179, 100);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(54, 23);
            this.labelX6.TabIndex = 25;
            this.labelX6.Text = "部门";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(179, 73);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(54, 23);
            this.labelX7.TabIndex = 24;
            this.labelX7.Text = "员工类型";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Location = new System.Drawing.Point(179, 127);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(54, 23);
            this.labelX8.TabIndex = 23;
            this.labelX8.Text = "状态";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Location = new System.Drawing.Point(179, 46);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(54, 23);
            this.labelX9.TabIndex = 22;
            this.labelX9.Text = "离职日期";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            this.labelX10.Location = new System.Drawing.Point(179, 19);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(54, 23);
            this.labelX10.TabIndex = 21;
            this.labelX10.Text = "入职日期";
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Location = new System.Drawing.Point(239, 104);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(84, 21);
            this.textBoxX2.TabIndex = 20;
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Location = new System.Drawing.Point(239, 23);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(84, 21);
            this.textBoxX3.TabIndex = 19;
            // 
            // textBoxX9
            // 
            // 
            // 
            // 
            this.textBoxX9.Border.Class = "TextBoxBorder";
            this.textBoxX9.Location = new System.Drawing.Point(239, 50);
            this.textBoxX9.Name = "textBoxX9";
            this.textBoxX9.Size = new System.Drawing.Size(84, 21);
            this.textBoxX9.TabIndex = 16;
            // 
            // textBoxX10
            // 
            // 
            // 
            // 
            this.textBoxX10.Border.Class = "TextBoxBorder";
            this.textBoxX10.Location = new System.Drawing.Point(239, 77);
            this.textBoxX10.Name = "textBoxX10";
            this.textBoxX10.Size = new System.Drawing.Size(84, 21);
            this.textBoxX10.TabIndex = 18;
            // 
            // textBoxX11
            // 
            // 
            // 
            // 
            this.textBoxX11.Border.Class = "TextBoxBorder";
            this.textBoxX11.Location = new System.Drawing.Point(239, 131);
            this.textBoxX11.Name = "textBoxX11";
            this.textBoxX11.Size = new System.Drawing.Size(84, 21);
            this.textBoxX11.TabIndex = 17;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(15, 100);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(54, 23);
            this.labelX5.TabIndex = 15;
            this.labelX5.Text = "出生月份";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(15, 73);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(54, 23);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "出生年份";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(15, 127);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(54, 23);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "电话";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(15, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 23);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "性别";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(15, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(54, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "姓名";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "基本资料";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(528, 495);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "合同情况";
            // 
            // panelRight
            // 
            this.panelRight.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelRight.Controls.Add(this.btnPrint);
            this.panelRight.Controls.Add(this.btnAdd);
            this.panelRight.Controls.Add(this.btnEdit);
            this.panelRight.Controls.Add(this.btnDel);
            this.panelRight.Controls.Add(this.tabControl1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(425, 35);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(528, 560);
            this.panelRight.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelRight.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelRight.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelRight.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelRight.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelRight.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelRight.Style.GradientAngle = 90;
            this.panelRight.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Location = new System.Drawing.Point(15, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "打印";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(279, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "新增";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Location = new System.Drawing.Point(360, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "修改";
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel.Location = new System.Drawing.Point(441, 10);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            this.labelX11.Location = new System.Drawing.Point(179, 225);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(54, 23);
            this.labelX11.TabIndex = 37;
            this.labelX11.Text = "年假";
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            this.labelX12.Location = new System.Drawing.Point(179, 198);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(54, 23);
            this.labelX12.TabIndex = 36;
            this.labelX12.Text = "特困基金";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            this.labelX13.Location = new System.Drawing.Point(179, 252);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(54, 23);
            this.labelX13.TabIndex = 35;
            this.labelX13.Text = "剩余年假";
            // 
            // textBoxX12
            // 
            // 
            // 
            // 
            this.textBoxX12.Border.Class = "TextBoxBorder";
            this.textBoxX12.Location = new System.Drawing.Point(239, 229);
            this.textBoxX12.Name = "textBoxX12";
            this.textBoxX12.Size = new System.Drawing.Size(84, 21);
            this.textBoxX12.TabIndex = 34;
            // 
            // textBoxX13
            // 
            // 
            // 
            // 
            this.textBoxX13.Border.Class = "TextBoxBorder";
            this.textBoxX13.Location = new System.Drawing.Point(239, 202);
            this.textBoxX13.Name = "textBoxX13";
            this.textBoxX13.Size = new System.Drawing.Size(84, 21);
            this.textBoxX13.TabIndex = 33;
            // 
            // textBoxX14
            // 
            // 
            // 
            // 
            this.textBoxX14.Border.Class = "TextBoxBorder";
            this.textBoxX14.Location = new System.Drawing.Point(239, 256);
            this.textBoxX14.Name = "textBoxX14";
            this.textBoxX14.Size = new System.Drawing.Size(84, 21);
            this.textBoxX14.TabIndex = 32;
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            this.labelX14.Location = new System.Drawing.Point(15, 225);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(54, 23);
            this.labelX14.TabIndex = 31;
            this.labelX14.Text = "公积金";
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            this.labelX15.Location = new System.Drawing.Point(15, 198);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(54, 23);
            this.labelX15.TabIndex = 30;
            this.labelX15.Text = "社保";
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            this.labelX16.Location = new System.Drawing.Point(15, 252);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(54, 23);
            this.labelX16.TabIndex = 29;
            this.labelX16.Text = "工会费";
            // 
            // textBoxX15
            // 
            // 
            // 
            // 
            this.textBoxX15.Border.Class = "TextBoxBorder";
            this.textBoxX15.Location = new System.Drawing.Point(75, 229);
            this.textBoxX15.Name = "textBoxX15";
            this.textBoxX15.Size = new System.Drawing.Size(84, 21);
            this.textBoxX15.TabIndex = 28;
            // 
            // textBoxX16
            // 
            // 
            // 
            // 
            this.textBoxX16.Border.Class = "TextBoxBorder";
            this.textBoxX16.Location = new System.Drawing.Point(75, 202);
            this.textBoxX16.Name = "textBoxX16";
            this.textBoxX16.Size = new System.Drawing.Size(84, 21);
            this.textBoxX16.TabIndex = 27;
            // 
            // textBoxX17
            // 
            // 
            // 
            // 
            this.textBoxX17.Border.Class = "TextBoxBorder";
            this.textBoxX17.Location = new System.Drawing.Point(75, 256);
            this.textBoxX17.Name = "textBoxX17";
            this.textBoxX17.Size = new System.Drawing.Size(84, 21);
            this.textBoxX17.TabIndex = 26;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 595);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmEmployee";
            this.Text = "人事资料";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private DevComponents.DotNetBar.PanelEx panelTop;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX8;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX7;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX6;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.PanelEx panelRight;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnDel;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX9;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX10;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX11;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX12;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX13;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX14;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX15;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX16;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX17;

    }
}