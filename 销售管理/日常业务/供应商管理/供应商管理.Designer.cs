namespace 销售管理.日常业务.供应商管理
{
    partial class 供应商管理
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(供应商管理));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDaSupplier = new System.Windows.Forms.DataGridView();
            this.DaSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDaSuppContact = new System.Windows.Forms.DataGridView();
            this.DaSuppContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.llAddContact = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplierNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNav1 = new WinFormPager.DgvNav(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorPageSizeItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ds修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.注册资本 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.法人代表 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.税号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开户银行 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.银行帐号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.经营地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司网站 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司固话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司传真 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.邮编 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录入时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录入人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsc修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.姓名dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职务dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.固话dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.传真dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手机dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QQdsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emaildsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录入人dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录入时间dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaSuppContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaSuppContactBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNav1)).BeginInit();
            this.dgvNav1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvDaSupplier
            // 
            this.dgvDaSupplier.AllowUserToAddRows = false;
            this.dgvDaSupplier.AllowUserToDeleteRows = false;
            this.dgvDaSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDaSupplier.AutoGenerateColumns = false;
            this.dgvDaSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ds修改,
            this.编号,
            this.名称,
            this.注册资本,
            this.法人代表,
            this.税号,
            this.开户银行,
            this.银行帐号,
            this.经营地址,
            this.公司网站,
            this.公司固话,
            this.公司传真,
            this.邮编,
            this.备注,
            this.录入时间,
            this.录入人});
            this.dgvDaSupplier.DataSource = this.DaSupplierBindingSource;
            this.dgvDaSupplier.Location = new System.Drawing.Point(71, 162);
            this.dgvDaSupplier.MultiSelect = false;
            this.dgvDaSupplier.Name = "dgvDaSupplier";
            this.dgvDaSupplier.ReadOnly = true;
            this.dgvDaSupplier.RowTemplate.Height = 23;
            this.dgvDaSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaSupplier.Size = new System.Drawing.Size(842, 234);
            this.dgvDaSupplier.TabIndex = 2;
            this.dgvDaSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaSupplier_CellClick);
            this.dgvDaSupplier.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDaSupplier_RowPrePaint);
            this.dgvDaSupplier.SelectionChanged += new System.EventHandler(this.dgvDaSupplier_SelectionChanged);
            // 
            // dgvDaSuppContact
            // 
            this.dgvDaSuppContact.AllowUserToAddRows = false;
            this.dgvDaSuppContact.AllowUserToDeleteRows = false;
            this.dgvDaSuppContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDaSuppContact.AutoGenerateColumns = false;
            this.dgvDaSuppContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaSuppContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaSuppContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dsc修改,
            this.姓名dsc,
            this.职务dsc,
            this.固话dsc,
            this.传真dsc,
            this.手机dsc,
            this.QQdsc,
            this.Emaildsc,
            this.备注dsc,
            this.录入人dsc,
            this.录入时间dsc});
            this.dgvDaSuppContact.DataSource = this.DaSuppContactBindingSource;
            this.dgvDaSuppContact.Location = new System.Drawing.Point(71, 431);
            this.dgvDaSuppContact.MultiSelect = false;
            this.dgvDaSuppContact.Name = "dgvDaSuppContact";
            this.dgvDaSuppContact.ReadOnly = true;
            this.dgvDaSuppContact.RowTemplate.Height = 23;
            this.dgvDaSuppContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaSuppContact.Size = new System.Drawing.Size(842, 119);
            this.dgvDaSuppContact.TabIndex = 3;
            this.dgvDaSuppContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaSuppContact_CellClick);
            this.dgvDaSuppContact.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDaSuppContact_RowPrePaint);
            // 
            // llAddContact
            // 
            this.llAddContact.AutoSize = true;
            this.llAddContact.Location = new System.Drawing.Point(841, 416);
            this.llAddContact.Name = "llAddContact";
            this.llAddContact.Size = new System.Drawing.Size(65, 12);
            this.llAddContact.TabIndex = 4;
            this.llAddContact.TabStop = true;
            this.llAddContact.Text = "添加联系人";
            this.llAddContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddContact_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSupplierName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSupplierNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(71, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(729, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 24);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(300, 47);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(109, 21);
            this.txtSupplierName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "供应商名称";
            // 
            // txtSupplierNum
            // 
            this.txtSupplierNum.Location = new System.Drawing.Point(103, 47);
            this.txtSupplierNum.Name = "txtSupplierNum";
            this.txtSupplierNum.Size = new System.Drawing.Size(109, 21);
            this.txtSupplierNum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "供应商代码";
            // 
            // dgvNav1
            // 
            this.dgvNav1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dgvNav1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNav1.AutoSize = false;
            this.dgvNav1.ComparyChar = null;
            this.dgvNav1.Conn = null;
            this.dgvNav1.CountItem = this.bindingNavigatorCountItem;
            this.dgvNav1.DataSource = null;
            this.dgvNav1.DeleteItem = null;
            this.dgvNav1.Dock = System.Windows.Forms.DockStyle.None;
            this.dgvNav1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.dgvNav1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorPageSizeItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.dgvNav1.Location = new System.Drawing.Point(71, 136);
            this.dgvNav1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dgvNav1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dgvNav1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dgvNav1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dgvNav1.MyBs = this.DaSupplierBindingSource;
            this.dgvNav1.Name = "dgvNav1";
            this.dgvNav1.OrderDirection = null;
            this.dgvNav1.OrderField = null;
            this.dgvNav1.OriginSql = null;
            this.dgvNav1.PageSize = 100;
            this.dgvNav1.PageSizeItem = this.bindingNavigatorPageSizeItem;
            this.dgvNav1.PositionItem = this.bindingNavigatorPositionItem;
            this.dgvNav1.PrimaryKey = null;
            this.dgvNav1.Size = new System.Drawing.Size(842, 25);
            this.dgvNav1.TabIndex = 6;
            this.dgvNav1.Text = "dgvNav1";
            this.dgvNav1.TotalCount = 0;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "添加";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.llAdd_Clicked);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总页数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "第一页";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "上一页";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "BindingNavigatorPositionAccessibleName";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前页";
            // 
            // bindingNavigatorPageSizeItem
            // 
            this.bindingNavigatorPageSizeItem.AutoSize = false;
            this.bindingNavigatorPageSizeItem.Name = "bindingNavigatorPageSizeItem";
            this.bindingNavigatorPageSizeItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPageSizeItem.Text = "100";
            this.bindingNavigatorPageSizeItem.ToolTipText = "每页显示数量";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "下一页";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最后一页";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ds修改
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "修改";
            this.ds修改.DefaultCellStyle = dataGridViewCellStyle1;
            this.ds修改.HeaderText = "修改";
            this.ds修改.Name = "ds修改";
            this.ds修改.ReadOnly = true;
            this.ds修改.Width = 35;
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "VcNum";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.ReadOnly = true;
            this.编号.Width = 54;
            // 
            // 名称
            // 
            this.名称.DataPropertyName = "VcName";
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.Width = 54;
            // 
            // 注册资本
            // 
            this.注册资本.DataPropertyName = "VcRegCapital";
            this.注册资本.HeaderText = "注册资本";
            this.注册资本.Name = "注册资本";
            this.注册资本.ReadOnly = true;
            this.注册资本.Visible = false;
            this.注册资本.Width = 78;
            // 
            // 法人代表
            // 
            this.法人代表.DataPropertyName = "VcLegalRep";
            this.法人代表.HeaderText = "法人代表";
            this.法人代表.Name = "法人代表";
            this.法人代表.ReadOnly = true;
            this.法人代表.Visible = false;
            this.法人代表.Width = 78;
            // 
            // 税号
            // 
            this.税号.DataPropertyName = "VcTaxID";
            this.税号.HeaderText = "税号";
            this.税号.Name = "税号";
            this.税号.ReadOnly = true;
            this.税号.Visible = false;
            this.税号.Width = 54;
            // 
            // 开户银行
            // 
            this.开户银行.DataPropertyName = "VcOpeningBank";
            this.开户银行.HeaderText = "开户银行";
            this.开户银行.Name = "开户银行";
            this.开户银行.ReadOnly = true;
            this.开户银行.Visible = false;
            this.开户银行.Width = 78;
            // 
            // 银行帐号
            // 
            this.银行帐号.DataPropertyName = "VcBankAccount";
            this.银行帐号.HeaderText = "银行帐号";
            this.银行帐号.Name = "银行帐号";
            this.银行帐号.ReadOnly = true;
            this.银行帐号.Visible = false;
            this.银行帐号.Width = 78;
            // 
            // 经营地址
            // 
            this.经营地址.DataPropertyName = "VcAddress";
            this.经营地址.HeaderText = "经营地址";
            this.经营地址.Name = "经营地址";
            this.经营地址.ReadOnly = true;
            this.经营地址.Width = 78;
            // 
            // 公司网站
            // 
            this.公司网站.DataPropertyName = "VcWebsite";
            this.公司网站.HeaderText = "公司网站";
            this.公司网站.Name = "公司网站";
            this.公司网站.ReadOnly = true;
            this.公司网站.Width = 78;
            // 
            // 公司固话
            // 
            this.公司固话.DataPropertyName = "VcTel";
            this.公司固话.HeaderText = "公司固话";
            this.公司固话.Name = "公司固话";
            this.公司固话.ReadOnly = true;
            this.公司固话.Width = 78;
            // 
            // 公司传真
            // 
            this.公司传真.DataPropertyName = "VcFax";
            this.公司传真.HeaderText = "公司传真";
            this.公司传真.Name = "公司传真";
            this.公司传真.ReadOnly = true;
            this.公司传真.Width = 78;
            // 
            // 邮编
            // 
            this.邮编.DataPropertyName = "VcPostCode";
            this.邮编.HeaderText = "邮编";
            this.邮编.Name = "邮编";
            this.邮编.ReadOnly = true;
            this.邮编.Width = 54;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "VcRemark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 54;
            // 
            // 录入时间
            // 
            this.录入时间.DataPropertyName = "DtCreate";
            this.录入时间.HeaderText = "录入时间";
            this.录入时间.Name = "录入时间";
            this.录入时间.ReadOnly = true;
            this.录入时间.Width = 78;
            // 
            // 录入人
            // 
            this.录入人.DataPropertyName = "UserName";
            this.录入人.HeaderText = "录入人";
            this.录入人.Name = "录入人";
            this.录入人.ReadOnly = true;
            this.录入人.Width = 66;
            // 
            // dsc修改
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "修改";
            this.dsc修改.DefaultCellStyle = dataGridViewCellStyle2;
            this.dsc修改.HeaderText = "修改";
            this.dsc修改.Name = "dsc修改";
            this.dsc修改.ReadOnly = true;
            this.dsc修改.Width = 35;
            // 
            // 姓名dsc
            // 
            this.姓名dsc.DataPropertyName = "VcName";
            this.姓名dsc.HeaderText = "姓名";
            this.姓名dsc.Name = "姓名dsc";
            this.姓名dsc.ReadOnly = true;
            this.姓名dsc.Width = 54;
            // 
            // 职务dsc
            // 
            this.职务dsc.DataPropertyName = "VcPost";
            this.职务dsc.HeaderText = "职务";
            this.职务dsc.Name = "职务dsc";
            this.职务dsc.ReadOnly = true;
            this.职务dsc.Width = 54;
            // 
            // 固话dsc
            // 
            this.固话dsc.DataPropertyName = "VcTel";
            this.固话dsc.HeaderText = "固话";
            this.固话dsc.Name = "固话dsc";
            this.固话dsc.ReadOnly = true;
            this.固话dsc.Width = 54;
            // 
            // 传真dsc
            // 
            this.传真dsc.DataPropertyName = "VcFax";
            this.传真dsc.HeaderText = "传真";
            this.传真dsc.Name = "传真dsc";
            this.传真dsc.ReadOnly = true;
            this.传真dsc.Width = 54;
            // 
            // 手机dsc
            // 
            this.手机dsc.DataPropertyName = "VcMobile";
            this.手机dsc.HeaderText = "手机";
            this.手机dsc.Name = "手机dsc";
            this.手机dsc.ReadOnly = true;
            this.手机dsc.Width = 54;
            // 
            // QQdsc
            // 
            this.QQdsc.DataPropertyName = "VcQQ";
            this.QQdsc.HeaderText = "QQ";
            this.QQdsc.Name = "QQdsc";
            this.QQdsc.ReadOnly = true;
            this.QQdsc.Width = 42;
            // 
            // Emaildsc
            // 
            this.Emaildsc.DataPropertyName = "VcEmail";
            this.Emaildsc.HeaderText = "Email";
            this.Emaildsc.Name = "Emaildsc";
            this.Emaildsc.ReadOnly = true;
            this.Emaildsc.Width = 60;
            // 
            // 备注dsc
            // 
            this.备注dsc.DataPropertyName = "VcRemark";
            this.备注dsc.HeaderText = "备注";
            this.备注dsc.Name = "备注dsc";
            this.备注dsc.ReadOnly = true;
            this.备注dsc.Width = 54;
            // 
            // 录入人dsc
            // 
            this.录入人dsc.HeaderText = "录入人";
            this.录入人dsc.Name = "录入人dsc";
            this.录入人dsc.ReadOnly = true;
            this.录入人dsc.Width = 66;
            // 
            // 录入时间dsc
            // 
            this.录入时间dsc.DataPropertyName = "DtCreate";
            this.录入时间dsc.HeaderText = "录入时间";
            this.录入时间dsc.Name = "录入时间dsc";
            this.录入时间dsc.ReadOnly = true;
            this.录入时间dsc.Width = 78;
            // 
            // 供应商管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.dgvNav1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llAddContact);
            this.Controls.Add(this.dgvDaSuppContact);
            this.Controls.Add(this.dgvDaSupplier);
            this.Name = "供应商管理";
            this.Load += new System.EventHandler(this.供应商管理_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvDaSupplier, 0);
            this.Controls.SetChildIndex(this.dgvDaSuppContact, 0);
            this.Controls.SetChildIndex(this.llAddContact, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvNav1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaSuppContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaSuppContactBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNav1)).EndInit();
            this.dgvNav1.ResumeLayout(false);
            this.dgvNav1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDaSupplier;
        private System.Windows.Forms.DataGridView dgvDaSuppContact;
        private System.Windows.Forms.BindingSource DaSupplierBindingSource;
        private System.Windows.Forms.BindingSource DaSuppContactBindingSource;
        private System.Windows.Forms.LinkLabel llAddContact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private WinFormPager.DgvNav dgvNav1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPageSizeItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewButtonColumn ds修改;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 注册资本;
        private System.Windows.Forms.DataGridViewTextBoxColumn 法人代表;
        private System.Windows.Forms.DataGridViewTextBoxColumn 税号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开户银行;
        private System.Windows.Forms.DataGridViewTextBoxColumn 银行帐号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 经营地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司网站;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司固话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司传真;
        private System.Windows.Forms.DataGridViewTextBoxColumn 邮编;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录入时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录入人;
        private System.Windows.Forms.DataGridViewButtonColumn dsc修改;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职务dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn 固话dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn 传真dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手机dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn QQdsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emaildsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录入人dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录入时间dsc;
    }
}
