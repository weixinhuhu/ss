namespace 销售管理.日常业务
{
    partial class 餐费报销
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBoxUsed = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cmbCards = new System.Windows.Forms.ComboBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGiftStockOut = new System.Windows.Forms.DataGridView();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColGetCard = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBackCard = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntUsedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMeals = new 销售管理.DAL.DataSetMeals();
            this.t_MealsTableAdapter = new 销售管理.DAL.DataSetMealsTableAdapters.T_MealsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftStockOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CBoxUsed);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CmbDepartmentName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.llAdd);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.cmbCards);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbUsers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1888, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查找";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CBoxUsed
            // 
            this.CBoxUsed.DisplayMember = "UserName";
            this.CBoxUsed.DropDownHeight = 300;
            this.CBoxUsed.DropDownWidth = 200;
            this.CBoxUsed.FormattingEnabled = true;
            this.CBoxUsed.IntegralHeight = false;
            this.CBoxUsed.Location = new System.Drawing.Point(144, 120);
            this.CBoxUsed.Margin = new System.Windows.Forms.Padding(6);
            this.CBoxUsed.Name = "CBoxUsed";
            this.CBoxUsed.Size = new System.Drawing.Size(268, 32);
            this.CBoxUsed.TabIndex = 9;
            this.CBoxUsed.ValueMember = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "使用人";
            // 
            // CmbDepartmentName
            // 
            this.CmbDepartmentName.DisplayMember = "UserName";
            this.CmbDepartmentName.DropDownHeight = 300;
            this.CmbDepartmentName.DropDownWidth = 200;
            this.CmbDepartmentName.FormattingEnabled = true;
            this.CmbDepartmentName.IntegralHeight = false;
            this.CmbDepartmentName.Location = new System.Drawing.Point(546, 120);
            this.CmbDepartmentName.Margin = new System.Windows.Forms.Padding(6);
            this.CmbDepartmentName.Name = "CmbDepartmentName";
            this.CmbDepartmentName.Size = new System.Drawing.Size(346, 32);
            this.CmbDepartmentName.TabIndex = 7;
            this.CmbDepartmentName.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "所属部门";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(1694, 98);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(6);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(150, 46);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "导入EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // llAdd
            // 
            this.llAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(1692, 156);
            this.llAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llAdd.Name = "llAdd";
            this.llAdd.Size = new System.Drawing.Size(154, 24);
            this.llAdd.TabIndex = 0;
            this.llAdd.TabStop = true;
            this.llAdd.Text = "餐费报销录入";
            this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1694, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 46);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(1416, 120);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(6);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(250, 35);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = false;
            this.dtpStart.Location = new System.Drawing.Point(1416, 54);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowCheckBox = true;
            this.dtpStart.Size = new System.Drawing.Size(250, 35);
            this.dtpStart.TabIndex = 2;
            // 
            // cmbCards
            // 
            this.cmbCards.DisplayMember = "CardName";
            this.cmbCards.DropDownHeight = 300;
            this.cmbCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCards.DropDownWidth = 200;
            this.cmbCards.FormattingEnabled = true;
            this.cmbCards.IntegralHeight = false;
            this.cmbCards.Location = new System.Drawing.Point(1032, 54);
            this.cmbCards.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCards.Name = "cmbCards";
            this.cmbCards.Size = new System.Drawing.Size(296, 32);
            this.cmbCards.TabIndex = 1;
            this.cmbCards.ValueMember = "Id";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DisplayMember = "CompanyName";
            this.cmbCustomers.DropDownHeight = 300;
            this.cmbCustomers.DropDownWidth = 200;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.IntegralHeight = false;
            this.cmbCustomers.Location = new System.Drawing.Point(546, 54);
            this.cmbCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(346, 32);
            this.cmbCustomers.TabIndex = 1;
            this.cmbCustomers.ValueMember = "Id";
            this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbCustomers_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownHeight = 300;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.DropDownWidth = 200;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.IntegralHeight = false;
            this.cmbStatus.Items.AddRange(new object[] {
            "",
            "已领卡",
            "已还卡",
            "审核已通过",
            "审核未通过",
            "现金"});
            this.cmbStatus.Location = new System.Drawing.Point(1032, 120);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(296, 32);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // cmbUsers
            // 
            this.cmbUsers.DisplayMember = "UserName";
            this.cmbUsers.DropDownHeight = 300;
            this.cmbUsers.DropDownWidth = 200;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.IntegralHeight = false;
            this.cmbUsers.Location = new System.Drawing.Point(144, 54);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(268, 32);
            this.cmbUsers.TabIndex = 1;
            this.cmbUsers.ValueMember = "Id";
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1348, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(918, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "消费类别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1348, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(918, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "消费状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "客户名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "领用人";
            // 
            // dgvGiftStockOut
            // 
            this.dgvGiftStockOut.AllowUserToAddRows = false;
            this.dgvGiftStockOut.AllowUserToDeleteRows = false;
            this.dgvGiftStockOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiftStockOut.AutoGenerateColumns = false;
            this.dgvGiftStockOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGiftStockOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvGiftStockOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGiftStockOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDel,
            this.ColModify,
            this.ColGetCard,
            this.ColBackCard,
            this.idDataGridViewTextBoxColumn,
            this.dataDateDataGridViewTextBoxColumn,
            this.ColBackDate,
            this.userIdDataGridViewTextBoxColumn,
            this.IntUsedID,
            this.DepartmentNameDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.cardIdDataGridViewTextBoxColumn,
            this.CardId,
            this.mealMoneyDataGridViewTextBoxColumn,
            this.recDateDataGridViewTextBoxColumn,
            this.operIdDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvGiftStockOut.DataSource = this.tMealsBindingSource;
            this.dgvGiftStockOut.Location = new System.Drawing.Point(56, 252);
            this.dgvGiftStockOut.Margin = new System.Windows.Forms.Padding(6);
            this.dgvGiftStockOut.Name = "dgvGiftStockOut";
            this.dgvGiftStockOut.ReadOnly = true;
            this.dgvGiftStockOut.RowTemplate.Height = 23;
            this.dgvGiftStockOut.Size = new System.Drawing.Size(1888, 1100);
            this.dgvGiftStockOut.TabIndex = 4;
            this.dgvGiftStockOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiftStockOut_CellContentClick);
            // 
            // ColDel
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "删除";
            this.ColDel.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColDel.HeaderText = "删除";
            this.ColDel.Name = "ColDel";
            this.ColDel.ReadOnly = true;
            this.ColDel.Width = 64;
            // 
            // ColModify
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "修改";
            this.ColModify.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColModify.HeaderText = "修改";
            this.ColModify.Name = "ColModify";
            this.ColModify.ReadOnly = true;
            this.ColModify.Width = 64;
            // 
            // ColGetCard
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "领卡";
            this.ColGetCard.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColGetCard.HeaderText = "领卡";
            this.ColGetCard.Name = "ColGetCard";
            this.ColGetCard.ReadOnly = true;
            this.ColGetCard.Width = 64;
            // 
            // ColBackCard
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "还卡";
            this.ColBackCard.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColBackCard.HeaderText = "还卡";
            this.ColBackCard.Name = "ColBackCard";
            this.ColBackCard.ReadOnly = true;
            this.ColBackCard.Width = 64;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 42;
            // 
            // dataDateDataGridViewTextBoxColumn
            // 
            this.dataDateDataGridViewTextBoxColumn.DataPropertyName = "DataDate";
            this.dataDateDataGridViewTextBoxColumn.HeaderText = "使用日期";
            this.dataDateDataGridViewTextBoxColumn.Name = "dataDateDataGridViewTextBoxColumn";
            this.dataDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDateDataGridViewTextBoxColumn.Width = 151;
            // 
            // ColBackDate
            // 
            this.ColBackDate.DataPropertyName = "BackDate";
            this.ColBackDate.HeaderText = "还卡日期";
            this.ColBackDate.Name = "ColBackDate";
            this.ColBackDate.ReadOnly = true;
            this.ColBackDate.Width = 151;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "领用人";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 127;
            // 
            // IntUsedID
            // 
            this.IntUsedID.DataPropertyName = "IntUsedID";
            this.IntUsedID.HeaderText = "使用人";
            this.IntUsedID.Name = "IntUsedID";
            this.IntUsedID.ReadOnly = true;
            this.IntUsedID.Width = 127;
            // 
            // DepartmentNameDataGridViewTextBoxColumn
            // 
            this.DepartmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.DepartmentNameDataGridViewTextBoxColumn.HeaderText = "所属部门";
            this.DepartmentNameDataGridViewTextBoxColumn.Name = "DepartmentNameDataGridViewTextBoxColumn";
            this.DepartmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.DepartmentNameDataGridViewTextBoxColumn.Width = 151;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIdDataGridViewTextBoxColumn.Width = 151;
            // 
            // cardIdDataGridViewTextBoxColumn
            // 
            this.cardIdDataGridViewTextBoxColumn.DataPropertyName = "CardName";
            this.cardIdDataGridViewTextBoxColumn.HeaderText = "消费卡类型";
            this.cardIdDataGridViewTextBoxColumn.Name = "cardIdDataGridViewTextBoxColumn";
            this.cardIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardIdDataGridViewTextBoxColumn.Width = 175;
            // 
            // CardId
            // 
            this.CardId.DataPropertyName = "CardId";
            this.CardId.HeaderText = "CardId";
            this.CardId.Name = "CardId";
            this.CardId.ReadOnly = true;
            this.CardId.Visible = false;
            this.CardId.Width = 66;
            // 
            // mealMoneyDataGridViewTextBoxColumn
            // 
            this.mealMoneyDataGridViewTextBoxColumn.DataPropertyName = "MealMoney";
            this.mealMoneyDataGridViewTextBoxColumn.HeaderText = "消费金额";
            this.mealMoneyDataGridViewTextBoxColumn.Name = "mealMoneyDataGridViewTextBoxColumn";
            this.mealMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.mealMoneyDataGridViewTextBoxColumn.Width = 151;
            // 
            // recDateDataGridViewTextBoxColumn
            // 
            this.recDateDataGridViewTextBoxColumn.DataPropertyName = "RecDate";
            this.recDateDataGridViewTextBoxColumn.HeaderText = "RecDate";
            this.recDateDataGridViewTextBoxColumn.Name = "recDateDataGridViewTextBoxColumn";
            this.recDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.recDateDataGridViewTextBoxColumn.Visible = false;
            this.recDateDataGridViewTextBoxColumn.Width = 72;
            // 
            // operIdDataGridViewTextBoxColumn
            // 
            this.operIdDataGridViewTextBoxColumn.DataPropertyName = "OperId";
            this.operIdDataGridViewTextBoxColumn.HeaderText = "OperId";
            this.operIdDataGridViewTextBoxColumn.Name = "operIdDataGridViewTextBoxColumn";
            this.operIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.operIdDataGridViewTextBoxColumn.Visible = false;
            this.operIdDataGridViewTextBoxColumn.Width = 66;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 103;
            // 
            // tMealsBindingSource
            // 
            this.tMealsBindingSource.DataMember = "T_Meals";
            this.tMealsBindingSource.DataSource = this.dataSetMeals;
            // 
            // dataSetMeals
            // 
            this.dataSetMeals.DataSetName = "DataSetMeals";
            this.dataSetMeals.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_MealsTableAdapter
            // 
            this.t_MealsTableAdapter.ClearBeforeFill = true;
            // 
            // 餐费报销
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGiftStockOut);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "餐费报销";
            this.Load += new System.EventHandler(this.餐费报销_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvGiftStockOut, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftStockOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cmbCards;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGiftStockOut;
        private System.Windows.Forms.BindingSource tMealsBindingSource;
        private DAL.DataSetMeals dataSetMeals;
        private DAL.DataSetMealsTableAdapters.T_MealsTableAdapter t_MealsTableAdapter;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox CmbDepartmentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBoxUsed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewButtonColumn ColGetCard;
        private System.Windows.Forms.DataGridViewButtonColumn ColBackCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBackDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntUsedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
