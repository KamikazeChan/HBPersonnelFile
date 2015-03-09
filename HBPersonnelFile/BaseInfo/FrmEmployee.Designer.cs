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
            this.cbSrh查询 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtSrh查询 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSrh查询 = new DevComponents.DotNetBar.ButtonX();
            this.txtC出生月份 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtX姓名 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtC出生年份 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtD电话 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtX性别 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtN年假 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtT特困基金 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtS剩余年假 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.txtG公积金 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtS社保 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtG工会费 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtB部门 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtR入职日期 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtL离职如期 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtY员工类型 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtZ状态 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelRight = new DevComponents.DotNetBar.PanelEx();
            this.btnPrt打印 = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd新增 = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit修改 = new DevComponents.DotNetBar.ButtonX();
            this.btnDel删除 = new DevComponents.DotNetBar.ButtonX();
            this.btnSave保存 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
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
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(425, 560);
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // panelTop
            // 
            this.panelTop.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.cbSrh查询);
            this.panelTop.Controls.Add(this.txtSrh查询);
            this.panelTop.Controls.Add(this.btnSrh查询);
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
            // cbSrh查询
            // 
            this.cbSrh查询.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSrh查询.DisplayMember = "Text";
            this.cbSrh查询.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSrh查询.FormattingEnabled = true;
            this.cbSrh查询.Location = new System.Drawing.Point(668, 6);
            this.cbSrh查询.Name = "cbSrh查询";
            this.cbSrh查询.Size = new System.Drawing.Size(80, 22);
            this.cbSrh查询.TabIndex = 16;
            // 
            // txtSrh查询
            // 
            this.txtSrh查询.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSrh查询.Border.Class = "TextBoxBorder";
            this.txtSrh查询.Location = new System.Drawing.Point(767, 7);
            this.txtSrh查询.Name = "txtSrh查询";
            this.txtSrh查询.Size = new System.Drawing.Size(80, 21);
            this.txtSrh查询.TabIndex = 1;
            this.txtSrh查询.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrh查询_KeyPress);
            // 
            // btnSrh查询
            // 
            this.btnSrh查询.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSrh查询.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSrh查询.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSrh查询.Location = new System.Drawing.Point(866, 6);
            this.btnSrh查询.Name = "btnSrh查询";
            this.btnSrh查询.Size = new System.Drawing.Size(75, 23);
            this.btnSrh查询.TabIndex = 0;
            this.btnSrh查询.Text = "查询";
            this.btnSrh查询.Click += new System.EventHandler(this.btnSrh查询_Click);
            // 
            // txtC出生月份
            // 
            // 
            // 
            // 
            this.txtC出生月份.Border.Class = "TextBoxBorder";
            this.txtC出生月份.Location = new System.Drawing.Point(75, 104);
            this.txtC出生月份.Name = "txtC出生月份";
            this.txtC出生月份.Size = new System.Drawing.Size(84, 21);
            this.txtC出生月份.TabIndex = 9;
            // 
            // txtX姓名
            // 
            // 
            // 
            // 
            this.txtX姓名.Border.Class = "TextBoxBorder";
            this.txtX姓名.Location = new System.Drawing.Point(75, 23);
            this.txtX姓名.Name = "txtX姓名";
            this.txtX姓名.Size = new System.Drawing.Size(84, 21);
            this.txtX姓名.TabIndex = 7;
            // 
            // txtC出生年份
            // 
            // 
            // 
            // 
            this.txtC出生年份.Border.Class = "TextBoxBorder";
            this.txtC出生年份.Location = new System.Drawing.Point(75, 77);
            this.txtC出生年份.Name = "txtC出生年份";
            this.txtC出生年份.Size = new System.Drawing.Size(84, 21);
            this.txtC出生年份.TabIndex = 5;
            // 
            // txtD电话
            // 
            // 
            // 
            // 
            this.txtD电话.Border.Class = "TextBoxBorder";
            this.txtD电话.Location = new System.Drawing.Point(75, 131);
            this.txtD电话.Name = "txtD电话";
            this.txtD电话.Size = new System.Drawing.Size(84, 21);
            this.txtD电话.TabIndex = 3;
            // 
            // txtX性别
            // 
            // 
            // 
            // 
            this.txtX性别.Border.Class = "TextBoxBorder";
            this.txtX性别.Location = new System.Drawing.Point(75, 50);
            this.txtX性别.Name = "txtX性别";
            this.txtX性别.Size = new System.Drawing.Size(84, 21);
            this.txtX性别.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.BackColor = System.Drawing.Color.Transparent;
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabControlPanel1);
            this.tabControl.Controls.Add(this.tabControlPanel2);
            this.tabControl.Location = new System.Drawing.Point(0, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(528, 521);
            this.tabControl.TabIndex = 4;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItem1);
            this.tabControl.Tabs.Add(this.tabItem2);
            this.tabControl.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.btnSave保存);
            this.tabControlPanel1.Controls.Add(this.labelX11);
            this.tabControlPanel1.Controls.Add(this.labelX12);
            this.tabControlPanel1.Controls.Add(this.labelX13);
            this.tabControlPanel1.Controls.Add(this.txtN年假);
            this.tabControlPanel1.Controls.Add(this.txtT特困基金);
            this.tabControlPanel1.Controls.Add(this.txtS剩余年假);
            this.tabControlPanel1.Controls.Add(this.labelX14);
            this.tabControlPanel1.Controls.Add(this.labelX15);
            this.tabControlPanel1.Controls.Add(this.labelX16);
            this.tabControlPanel1.Controls.Add(this.txtG公积金);
            this.tabControlPanel1.Controls.Add(this.txtS社保);
            this.tabControlPanel1.Controls.Add(this.txtG工会费);
            this.tabControlPanel1.Controls.Add(this.labelX6);
            this.tabControlPanel1.Controls.Add(this.labelX7);
            this.tabControlPanel1.Controls.Add(this.labelX8);
            this.tabControlPanel1.Controls.Add(this.labelX9);
            this.tabControlPanel1.Controls.Add(this.labelX10);
            this.tabControlPanel1.Controls.Add(this.txtB部门);
            this.tabControlPanel1.Controls.Add(this.txtR入职日期);
            this.tabControlPanel1.Controls.Add(this.txtL离职如期);
            this.tabControlPanel1.Controls.Add(this.txtY员工类型);
            this.tabControlPanel1.Controls.Add(this.txtZ状态);
            this.tabControlPanel1.Controls.Add(this.labelX5);
            this.tabControlPanel1.Controls.Add(this.labelX4);
            this.tabControlPanel1.Controls.Add(this.labelX3);
            this.tabControlPanel1.Controls.Add(this.labelX2);
            this.tabControlPanel1.Controls.Add(this.labelX1);
            this.tabControlPanel1.Controls.Add(this.txtC出生月份);
            this.tabControlPanel1.Controls.Add(this.txtX姓名);
            this.tabControlPanel1.Controls.Add(this.txtX性别);
            this.tabControlPanel1.Controls.Add(this.txtC出生年份);
            this.tabControlPanel1.Controls.Add(this.txtD电话);
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
            // txtN年假
            // 
            // 
            // 
            // 
            this.txtN年假.Border.Class = "TextBoxBorder";
            this.txtN年假.Location = new System.Drawing.Point(239, 229);
            this.txtN年假.Name = "txtN年假";
            this.txtN年假.Size = new System.Drawing.Size(84, 21);
            this.txtN年假.TabIndex = 34;
            // 
            // txtT特困基金
            // 
            // 
            // 
            // 
            this.txtT特困基金.Border.Class = "TextBoxBorder";
            this.txtT特困基金.Location = new System.Drawing.Point(239, 202);
            this.txtT特困基金.Name = "txtT特困基金";
            this.txtT特困基金.Size = new System.Drawing.Size(84, 21);
            this.txtT特困基金.TabIndex = 33;
            // 
            // txtS剩余年假
            // 
            // 
            // 
            // 
            this.txtS剩余年假.Border.Class = "TextBoxBorder";
            this.txtS剩余年假.Location = new System.Drawing.Point(239, 256);
            this.txtS剩余年假.Name = "txtS剩余年假";
            this.txtS剩余年假.Size = new System.Drawing.Size(84, 21);
            this.txtS剩余年假.TabIndex = 32;
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
            // txtG公积金
            // 
            // 
            // 
            // 
            this.txtG公积金.Border.Class = "TextBoxBorder";
            this.txtG公积金.Location = new System.Drawing.Point(75, 229);
            this.txtG公积金.Name = "txtG公积金";
            this.txtG公积金.Size = new System.Drawing.Size(84, 21);
            this.txtG公积金.TabIndex = 28;
            // 
            // txtS社保
            // 
            // 
            // 
            // 
            this.txtS社保.Border.Class = "TextBoxBorder";
            this.txtS社保.Location = new System.Drawing.Point(75, 202);
            this.txtS社保.Name = "txtS社保";
            this.txtS社保.Size = new System.Drawing.Size(84, 21);
            this.txtS社保.TabIndex = 27;
            // 
            // txtG工会费
            // 
            // 
            // 
            // 
            this.txtG工会费.Border.Class = "TextBoxBorder";
            this.txtG工会费.Location = new System.Drawing.Point(75, 256);
            this.txtG工会费.Name = "txtG工会费";
            this.txtG工会费.Size = new System.Drawing.Size(84, 21);
            this.txtG工会费.TabIndex = 26;
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
            // txtB部门
            // 
            // 
            // 
            // 
            this.txtB部门.Border.Class = "TextBoxBorder";
            this.txtB部门.Location = new System.Drawing.Point(239, 104);
            this.txtB部门.Name = "txtB部门";
            this.txtB部门.Size = new System.Drawing.Size(84, 21);
            this.txtB部门.TabIndex = 20;
            // 
            // txtR入职日期
            // 
            // 
            // 
            // 
            this.txtR入职日期.Border.Class = "TextBoxBorder";
            this.txtR入职日期.Location = new System.Drawing.Point(239, 23);
            this.txtR入职日期.Name = "txtR入职日期";
            this.txtR入职日期.Size = new System.Drawing.Size(84, 21);
            this.txtR入职日期.TabIndex = 19;
            // 
            // txtL离职如期
            // 
            // 
            // 
            // 
            this.txtL离职如期.Border.Class = "TextBoxBorder";
            this.txtL离职如期.Location = new System.Drawing.Point(239, 50);
            this.txtL离职如期.Name = "txtL离职如期";
            this.txtL离职如期.Size = new System.Drawing.Size(84, 21);
            this.txtL离职如期.TabIndex = 16;
            // 
            // txtY员工类型
            // 
            // 
            // 
            // 
            this.txtY员工类型.Border.Class = "TextBoxBorder";
            this.txtY员工类型.Location = new System.Drawing.Point(239, 77);
            this.txtY员工类型.Name = "txtY员工类型";
            this.txtY员工类型.Size = new System.Drawing.Size(84, 21);
            this.txtY员工类型.TabIndex = 18;
            // 
            // txtZ状态
            // 
            // 
            // 
            // 
            this.txtZ状态.Border.Class = "TextBoxBorder";
            this.txtZ状态.Location = new System.Drawing.Point(239, 131);
            this.txtZ状态.Name = "txtZ状态";
            this.txtZ状态.Size = new System.Drawing.Size(84, 21);
            this.txtZ状态.TabIndex = 17;
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
            this.panelRight.Controls.Add(this.btnPrt打印);
            this.panelRight.Controls.Add(this.btnAdd新增);
            this.panelRight.Controls.Add(this.btnEdit修改);
            this.panelRight.Controls.Add(this.btnDel删除);
            this.panelRight.Controls.Add(this.tabControl);
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
            // btnPrt打印
            // 
            this.btnPrt打印.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrt打印.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrt打印.Location = new System.Drawing.Point(15, 10);
            this.btnPrt打印.Name = "btnPrt打印";
            this.btnPrt打印.Size = new System.Drawing.Size(75, 23);
            this.btnPrt打印.TabIndex = 17;
            this.btnPrt打印.Text = "打 印";
            // 
            // btnAdd新增
            // 
            this.btnAdd新增.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd新增.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd新增.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd新增.Location = new System.Drawing.Point(279, 10);
            this.btnAdd新增.Name = "btnAdd新增";
            this.btnAdd新增.Size = new System.Drawing.Size(75, 23);
            this.btnAdd新增.TabIndex = 16;
            this.btnAdd新增.Text = "新 增";
            this.btnAdd新增.Click += new System.EventHandler(this.btnAdd新增_Click);
            // 
            // btnEdit修改
            // 
            this.btnEdit修改.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit修改.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit修改.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit修改.Location = new System.Drawing.Point(360, 10);
            this.btnEdit修改.Name = "btnEdit修改";
            this.btnEdit修改.Size = new System.Drawing.Size(75, 23);
            this.btnEdit修改.TabIndex = 16;
            this.btnEdit修改.Text = "修 改";
            this.btnEdit修改.Click += new System.EventHandler(this.btnEdit修改_Click);
            // 
            // btnDel删除
            // 
            this.btnDel删除.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel删除.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel删除.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel删除.Location = new System.Drawing.Point(441, 10);
            this.btnDel删除.Name = "btnDel删除";
            this.btnDel删除.Size = new System.Drawing.Size(75, 23);
            this.btnDel删除.TabIndex = 5;
            this.btnDel删除.Text = "删 除";
            this.btnDel删除.Click += new System.EventHandler(this.btnDel删除_Click);
            // 
            // btnSave保存
            // 
            this.btnSave保存.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave保存.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave保存.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave保存.Location = new System.Drawing.Point(15, 311);
            this.btnSave保存.Name = "btnSave保存";
            this.btnSave保存.Size = new System.Drawing.Size(75, 23);
            this.btnSave保存.TabIndex = 38;
            this.btnSave保存.Text = "保 存";
            this.btnSave保存.Click += new System.EventHandler(this.btnSave保存_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private DevComponents.DotNetBar.PanelEx panelTop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtC出生月份;
        private DevComponents.DotNetBar.Controls.TextBoxX txtX姓名;
        private DevComponents.DotNetBar.Controls.TextBoxX txtC出生年份;
        private DevComponents.DotNetBar.Controls.TextBoxX txtD电话;
        private DevComponents.DotNetBar.Controls.TextBoxX txtX性别;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSrh查询;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrh查询;
        private DevComponents.DotNetBar.ButtonX btnSrh查询;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.PanelEx panelRight;
        private DevComponents.DotNetBar.ButtonX btnAdd新增;
        private DevComponents.DotNetBar.ButtonX btnEdit修改;
        private DevComponents.DotNetBar.ButtonX btnDel删除;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtB部门;
        private DevComponents.DotNetBar.Controls.TextBoxX txtR入职日期;
        private DevComponents.DotNetBar.Controls.TextBoxX txtL离职如期;
        private DevComponents.DotNetBar.Controls.TextBoxX txtY员工类型;
        private DevComponents.DotNetBar.Controls.TextBoxX txtZ状态;
        private DevComponents.DotNetBar.ButtonX btnPrt打印;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX txtN年假;
        private DevComponents.DotNetBar.Controls.TextBoxX txtT特困基金;
        private DevComponents.DotNetBar.Controls.TextBoxX txtS剩余年假;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.TextBoxX txtG公积金;
        private DevComponents.DotNetBar.Controls.TextBoxX txtS社保;
        private DevComponents.DotNetBar.Controls.TextBoxX txtG工会费;
        private DevComponents.DotNetBar.ButtonX btnSave保存;

    }
}