namespace 销售管理.日常业务
{
    partial class 费用分配审核_领导
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.t_ExpenseAllocationTableAdapter = new 销售管理.DAL.DataSetExpenseAllocationTableAdapters.T_ExpenseAllocationTableAdapter();
            this.dataSetExpenseAllocation = new 销售管理.DAL.DataSetExpenseAllocation();
            this.tExpenseAllocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvExAllocation = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMoney = new System.Windows.Forms.ComboBox();
            this.btnAudit2 = new System.Windows.Forms.Button();
            this.btnAudit = new System.Windows.Forms.Button();
            this.cmbHasAudit = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColAudit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColAudit1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleWagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleComissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentCommissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitySaler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitySum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityWages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitySalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitySaleSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitySaleCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessAuditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinanceAudit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderAudit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDetailsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetExpenseAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tExpenseAllocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExAllocation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // t_ExpenseAllocationTableAdapter
            // 
            this.t_ExpenseAllocationTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetExpenseAllocation
            // 
            this.dataSetExpenseAllocation.DataSetName = "DataSetExpenseAllocation";
            this.dataSetExpenseAllocation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tExpenseAllocationBindingSource
            // 
            this.tExpenseAllocationBindingSource.DataMember = "T_ExpenseAllocation";
            this.tExpenseAllocationBindingSource.DataSource = this.dataSetExpenseAllocation;
            // 
            // dgvExAllocation
            // 
            this.dgvExAllocation.AllowUserToAddRows = false;
            this.dgvExAllocation.AllowUserToDeleteRows = false;
            this.dgvExAllocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExAllocation.AutoGenerateColumns = false;
            this.dgvExAllocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExAllocation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvExAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExAllocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColumnChecked,
            this.ColAudit,
            this.ColAudit1,
            this.userNameDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.tableNoDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.deliverPriceDataGridViewTextBoxColumn,
            this.deliverSumDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.saleSumDataGridViewTextBoxColumn,
            this.departSumDataGridViewTextBoxColumn,
            this.saleWagesDataGridViewTextBoxColumn,
            this.commissionPriceDataGridViewTextBoxColumn,
            this.commissionSumDataGridViewTextBoxColumn,
            this.saleComissionDataGridViewTextBoxColumn,
            this.agentPriceDataGridViewTextBoxColumn,
            this.agentSumDataGridViewTextBoxColumn,
            this.agentCommissionDataGridViewTextBoxColumn,
            this.CitySaler,
            this.CitySum,
            this.CityWages,
            this.CitySalePrice,
            this.CitySaleSum,
            this.CitySaleCommission,
            this.isPaidDataGridViewTextBoxColumn,
            this.paidDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.businessAuditDataGridViewTextBoxColumn,
            this.businessDateDataGridViewTextBoxColumn,
            this.FinanceAudit,
            this.FinanceDate,
            this.LeaderAudit,
            this.LeaderDate,
            this.recDateDataGridViewTextBoxColumn,
            this.saleDetailsIdDataGridViewTextBoxColumn});
            this.dgvExAllocation.DataSource = this.tExpenseAllocationBindingSource;
            this.dgvExAllocation.Location = new System.Drawing.Point(36, 125);
            this.dgvExAllocation.Name = "dgvExAllocation";
            this.dgvExAllocation.RowTemplate.Height = 23;
            this.dgvExAllocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExAllocation.ShowEditingIcon = false;
            this.dgvExAllocation.Size = new System.Drawing.Size(934, 538);
            this.dgvExAllocation.TabIndex = 6;
            this.dgvExAllocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExAllocation_CellContentClick);
            this.dgvExAllocation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExAllocation_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbMoney);
            this.groupBox1.Controls.Add(this.btnAudit2);
            this.groupBox1.Controls.Add(this.btnAudit);
            this.groupBox1.Controls.Add(this.cmbHasAudit);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTableNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速搜索";
            // 
            // cmbMoney
            // 
            this.cmbMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoney.FormattingEnabled = true;
            this.cmbMoney.Items.AddRange(new object[] {
            "全部",
            "已付款",
            "未付款"});
            this.cmbMoney.Location = new System.Drawing.Point(783, 50);
            this.cmbMoney.Name = "cmbMoney";
            this.cmbMoney.Size = new System.Drawing.Size(71, 20);
            this.cmbMoney.TabIndex = 8;
            // 
            // btnAudit2
            // 
            this.btnAudit2.Location = new System.Drawing.Point(140, 50);
            this.btnAudit2.Name = "btnAudit2";
            this.btnAudit2.Size = new System.Drawing.Size(104, 24);
            this.btnAudit2.TabIndex = 7;
            this.btnAudit2.Text = "批量审核不通过";
            this.btnAudit2.UseVisualStyleBackColor = true;
            this.btnAudit2.Click += new System.EventHandler(this.btnAudit2_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.Location = new System.Drawing.Point(23, 50);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(111, 24);
            this.btnAudit.TabIndex = 7;
            this.btnAudit.Text = "批量审核通过";
            this.btnAudit.UseVisualStyleBackColor = true;
            this.btnAudit.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbHasAudit
            // 
            this.cmbHasAudit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasAudit.FormattingEnabled = true;
            this.cmbHasAudit.Items.AddRange(new object[] {
            "未审核",
            "审核已通过",
            "审核未通过"});
            this.cmbHasAudit.Location = new System.Drawing.Point(783, 24);
            this.cmbHasAudit.Name = "cmbHasAudit";
            this.cmbHasAudit.Size = new System.Drawing.Size(71, 20);
            this.cmbHasAudit.TabIndex = 6;
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(844, 20);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(84, 26);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查找";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(623, 24);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 21);
            this.txtProductName.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(457, 24);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "是否付佣金";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(729, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "审核状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "产品名称";
            // 
            // txtTableNo
            // 
            this.txtTableNo.Location = new System.Drawing.Point(287, 24);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(100, 21);
            this.txtTableNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "客户名称";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.DropDownWidth = 200;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(68, 24);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(121, 20);
            this.cmbUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "费用分配表号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售员";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 42;
            // 
            // ColumnChecked
            // 
            this.ColumnChecked.Frozen = true;
            this.ColumnChecked.HeaderText = "选择";
            this.ColumnChecked.Name = "ColumnChecked";
            this.ColumnChecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnChecked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnChecked.Width = 54;
            // 
            // ColAudit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "通过";
            this.ColAudit.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColAudit.Frozen = true;
            this.ColAudit.HeaderText = "审核通过";
            this.ColAudit.Name = "ColAudit";
            this.ColAudit.UseColumnTextForButtonValue = true;
            this.ColAudit.Visible = false;
            this.ColAudit.Width = 59;
            // 
            // ColAudit1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "不通过";
            this.ColAudit1.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColAudit1.Frozen = true;
            this.ColAudit1.HeaderText = "审核不通过";
            this.ColAudit1.Name = "ColAudit1";
            this.ColAudit1.UseColumnTextForButtonValue = true;
            this.ColAudit1.Visible = false;
            this.ColAudit1.Width = 71;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.Frozen = true;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "销售员";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 66;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Frozen = true;
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Frozen = true;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "产品名称";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.Frozen = true;
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "类别";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productTypeDataGridViewTextBoxColumn.Width = 54;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "项目名称";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectNameDataGridViewTextBoxColumn.Visible = false;
            this.projectNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // tableNoDataGridViewTextBoxColumn
            // 
            this.tableNoDataGridViewTextBoxColumn.DataPropertyName = "TableNo";
            this.tableNoDataGridViewTextBoxColumn.HeaderText = "费用分配表号";
            this.tableNoDataGridViewTextBoxColumn.Name = "tableNoDataGridViewTextBoxColumn";
            this.tableNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tableNoDataGridViewTextBoxColumn.Width = 72;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "数目";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 51;
            // 
            // deliverPriceDataGridViewTextBoxColumn
            // 
            this.deliverPriceDataGridViewTextBoxColumn.DataPropertyName = "DeliverPrice";
            this.deliverPriceDataGridViewTextBoxColumn.HeaderText = "发货价格";
            this.deliverPriceDataGridViewTextBoxColumn.Name = "deliverPriceDataGridViewTextBoxColumn";
            this.deliverPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverPriceDataGridViewTextBoxColumn.Width = 61;
            // 
            // deliverSumDataGridViewTextBoxColumn
            // 
            this.deliverSumDataGridViewTextBoxColumn.DataPropertyName = "DeliverSum";
            this.deliverSumDataGridViewTextBoxColumn.HeaderText = "发货额";
            this.deliverSumDataGridViewTextBoxColumn.Name = "deliverSumDataGridViewTextBoxColumn";
            this.deliverSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverSumDataGridViewTextBoxColumn.Width = 61;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "销售单价";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.salePriceDataGridViewTextBoxColumn.Width = 61;
            // 
            // saleSumDataGridViewTextBoxColumn
            // 
            this.saleSumDataGridViewTextBoxColumn.DataPropertyName = "SaleSum";
            this.saleSumDataGridViewTextBoxColumn.HeaderText = "个人销售额";
            this.saleSumDataGridViewTextBoxColumn.Name = "saleSumDataGridViewTextBoxColumn";
            this.saleSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleSumDataGridViewTextBoxColumn.Width = 72;
            // 
            // departSumDataGridViewTextBoxColumn
            // 
            this.departSumDataGridViewTextBoxColumn.DataPropertyName = "DepartSum";
            this.departSumDataGridViewTextBoxColumn.HeaderText = "部门销售额";
            this.departSumDataGridViewTextBoxColumn.Name = "departSumDataGridViewTextBoxColumn";
            this.departSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.departSumDataGridViewTextBoxColumn.Width = 72;
            // 
            // saleWagesDataGridViewTextBoxColumn
            // 
            this.saleWagesDataGridViewTextBoxColumn.DataPropertyName = "SaleWages";
            this.saleWagesDataGridViewTextBoxColumn.HeaderText = "销售工资";
            this.saleWagesDataGridViewTextBoxColumn.Name = "saleWagesDataGridViewTextBoxColumn";
            this.saleWagesDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleWagesDataGridViewTextBoxColumn.Width = 61;
            // 
            // commissionPriceDataGridViewTextBoxColumn
            // 
            this.commissionPriceDataGridViewTextBoxColumn.DataPropertyName = "CommissionPrice";
            this.commissionPriceDataGridViewTextBoxColumn.HeaderText = "提成单价";
            this.commissionPriceDataGridViewTextBoxColumn.Name = "commissionPriceDataGridViewTextBoxColumn";
            this.commissionPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.commissionPriceDataGridViewTextBoxColumn.Width = 61;
            // 
            // commissionSumDataGridViewTextBoxColumn
            // 
            this.commissionSumDataGridViewTextBoxColumn.DataPropertyName = "CommissionSum";
            this.commissionSumDataGridViewTextBoxColumn.HeaderText = "提成销售额";
            this.commissionSumDataGridViewTextBoxColumn.Name = "commissionSumDataGridViewTextBoxColumn";
            this.commissionSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.commissionSumDataGridViewTextBoxColumn.Width = 72;
            // 
            // saleComissionDataGridViewTextBoxColumn
            // 
            this.saleComissionDataGridViewTextBoxColumn.DataPropertyName = "SaleComission";
            this.saleComissionDataGridViewTextBoxColumn.HeaderText = "销售提成";
            this.saleComissionDataGridViewTextBoxColumn.Name = "saleComissionDataGridViewTextBoxColumn";
            this.saleComissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleComissionDataGridViewTextBoxColumn.Width = 61;
            // 
            // agentPriceDataGridViewTextBoxColumn
            // 
            this.agentPriceDataGridViewTextBoxColumn.DataPropertyName = "AgentPrice";
            this.agentPriceDataGridViewTextBoxColumn.HeaderText = "代理商单价";
            this.agentPriceDataGridViewTextBoxColumn.Name = "agentPriceDataGridViewTextBoxColumn";
            this.agentPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentPriceDataGridViewTextBoxColumn.Width = 72;
            // 
            // agentSumDataGridViewTextBoxColumn
            // 
            this.agentSumDataGridViewTextBoxColumn.DataPropertyName = "AgentSum";
            this.agentSumDataGridViewTextBoxColumn.HeaderText = "代理商额度";
            this.agentSumDataGridViewTextBoxColumn.Name = "agentSumDataGridViewTextBoxColumn";
            this.agentSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentSumDataGridViewTextBoxColumn.Width = 72;
            // 
            // agentCommissionDataGridViewTextBoxColumn
            // 
            this.agentCommissionDataGridViewTextBoxColumn.DataPropertyName = "AgentCommission";
            this.agentCommissionDataGridViewTextBoxColumn.HeaderText = "代理商税后佣金";
            this.agentCommissionDataGridViewTextBoxColumn.Name = "agentCommissionDataGridViewTextBoxColumn";
            this.agentCommissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentCommissionDataGridViewTextBoxColumn.Width = 83;
            // 
            // CitySaler
            // 
            this.CitySaler.DataPropertyName = "CitySaler";
            this.CitySaler.HeaderText = "跨区域销售";
            this.CitySaler.Name = "CitySaler";
            this.CitySaler.ReadOnly = true;
            this.CitySaler.Width = 72;
            // 
            // CitySum
            // 
            this.CitySum.DataPropertyName = "CitySum";
            this.CitySum.HeaderText = "跨区域销售额";
            this.CitySum.Name = "CitySum";
            this.CitySum.ReadOnly = true;
            this.CitySum.Width = 72;
            // 
            // CityWages
            // 
            this.CityWages.DataPropertyName = "CityWages";
            this.CityWages.HeaderText = "跨区域销售工资";
            this.CityWages.Name = "CityWages";
            this.CityWages.ReadOnly = true;
            this.CityWages.Width = 83;
            // 
            // CitySalePrice
            // 
            this.CitySalePrice.DataPropertyName = "CitySalePrice";
            this.CitySalePrice.HeaderText = "跨区销售提成单价";
            this.CitySalePrice.Name = "CitySalePrice";
            this.CitySalePrice.ReadOnly = true;
            this.CitySalePrice.Width = 83;
            // 
            // CitySaleSum
            // 
            this.CitySaleSum.DataPropertyName = "CitySaleSum";
            this.CitySaleSum.HeaderText = "跨区销售提成额";
            this.CitySaleSum.Name = "CitySaleSum";
            this.CitySaleSum.ReadOnly = true;
            this.CitySaleSum.Width = 83;
            // 
            // CitySaleCommission
            // 
            this.CitySaleCommission.DataPropertyName = "CitySaleCommission";
            this.CitySaleCommission.HeaderText = "跨区销售提成";
            this.CitySaleCommission.Name = "CitySaleCommission";
            this.CitySaleCommission.ReadOnly = true;
            this.CitySaleCommission.Width = 72;
            // 
            // isPaidDataGridViewTextBoxColumn
            // 
            this.isPaidDataGridViewTextBoxColumn.DataPropertyName = "IsPaid";
            this.isPaidDataGridViewTextBoxColumn.HeaderText = "是否付佣金";
            this.isPaidDataGridViewTextBoxColumn.Name = "isPaidDataGridViewTextBoxColumn";
            this.isPaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.isPaidDataGridViewTextBoxColumn.Width = 72;
            // 
            // paidDateDataGridViewTextBoxColumn
            // 
            this.paidDateDataGridViewTextBoxColumn.DataPropertyName = "PaidDate";
            this.paidDateDataGridViewTextBoxColumn.HeaderText = "付款日期";
            this.paidDateDataGridViewTextBoxColumn.Name = "paidDateDataGridViewTextBoxColumn";
            this.paidDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidDateDataGridViewTextBoxColumn.Width = 61;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "订单状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 61;
            // 
            // businessAuditDataGridViewTextBoxColumn
            // 
            this.businessAuditDataGridViewTextBoxColumn.DataPropertyName = "BusinessAudit";
            this.businessAuditDataGridViewTextBoxColumn.HeaderText = "商务审核人";
            this.businessAuditDataGridViewTextBoxColumn.Name = "businessAuditDataGridViewTextBoxColumn";
            this.businessAuditDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessAuditDataGridViewTextBoxColumn.Width = 72;
            // 
            // businessDateDataGridViewTextBoxColumn
            // 
            this.businessDateDataGridViewTextBoxColumn.DataPropertyName = "BusinessDate";
            this.businessDateDataGridViewTextBoxColumn.HeaderText = "商务审核日期";
            this.businessDateDataGridViewTextBoxColumn.Name = "businessDateDataGridViewTextBoxColumn";
            this.businessDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessDateDataGridViewTextBoxColumn.Width = 72;
            // 
            // FinanceAudit
            // 
            this.FinanceAudit.DataPropertyName = "FinanceAudit";
            this.FinanceAudit.HeaderText = "财务审核人";
            this.FinanceAudit.Name = "FinanceAudit";
            this.FinanceAudit.ReadOnly = true;
            this.FinanceAudit.Width = 72;
            // 
            // FinanceDate
            // 
            this.FinanceDate.DataPropertyName = "FinanceDate";
            this.FinanceDate.HeaderText = "财务审核日期";
            this.FinanceDate.Name = "FinanceDate";
            this.FinanceDate.ReadOnly = true;
            this.FinanceDate.Width = 72;
            // 
            // LeaderAudit
            // 
            this.LeaderAudit.DataPropertyName = "LeaderAudit";
            this.LeaderAudit.HeaderText = "领导审核人";
            this.LeaderAudit.Name = "LeaderAudit";
            this.LeaderAudit.ReadOnly = true;
            this.LeaderAudit.Width = 72;
            // 
            // LeaderDate
            // 
            this.LeaderDate.DataPropertyName = "LeaderDate";
            this.LeaderDate.HeaderText = "领导审核日期";
            this.LeaderDate.Name = "LeaderDate";
            this.LeaderDate.ReadOnly = true;
            this.LeaderDate.Width = 72;
            // 
            // recDateDataGridViewTextBoxColumn
            // 
            this.recDateDataGridViewTextBoxColumn.DataPropertyName = "RecDate";
            this.recDateDataGridViewTextBoxColumn.HeaderText = "申请时间";
            this.recDateDataGridViewTextBoxColumn.Name = "recDateDataGridViewTextBoxColumn";
            this.recDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.recDateDataGridViewTextBoxColumn.Width = 61;
            // 
            // saleDetailsIdDataGridViewTextBoxColumn
            // 
            this.saleDetailsIdDataGridViewTextBoxColumn.DataPropertyName = "SaleDetailsId";
            this.saleDetailsIdDataGridViewTextBoxColumn.HeaderText = "SaleDetailsId";
            this.saleDetailsIdDataGridViewTextBoxColumn.Name = "saleDetailsIdDataGridViewTextBoxColumn";
            this.saleDetailsIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleDetailsIdDataGridViewTextBoxColumn.Visible = false;
            this.saleDetailsIdDataGridViewTextBoxColumn.Width = 108;
            // 
            // 费用分配审核_领导
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.dgvExAllocation);
            this.Controls.Add(this.groupBox1);
            this.Name = "费用分配审核_领导";
            this.Load += new System.EventHandler(this.费用分配审核_领导_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvExAllocation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetExpenseAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tExpenseAllocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExAllocation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DAL.DataSetExpenseAllocationTableAdapters.T_ExpenseAllocationTableAdapter t_ExpenseAllocationTableAdapter;
        private DAL.DataSetExpenseAllocation dataSetExpenseAllocation;
        private System.Windows.Forms.BindingSource tExpenseAllocationBindingSource;
        private System.Windows.Forms.DataGridView dgvExAllocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHasAudit;
        private System.Windows.Forms.Button btnAudit2;
        private System.Windows.Forms.Button btnAudit;
        private System.Windows.Forms.ComboBox cmbMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnChecked;
        private System.Windows.Forms.DataGridViewButtonColumn ColAudit;
        private System.Windows.Forms.DataGridViewButtonColumn ColAudit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleWagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleComissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentCommissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySaler;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityWages;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySaleSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySaleCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessAuditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinanceAudit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderAudit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn recDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDetailsIdDataGridViewTextBoxColumn;
    }
}
