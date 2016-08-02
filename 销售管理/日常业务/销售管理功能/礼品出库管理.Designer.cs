namespace 销售管理.日常业务
{
    partial class 礼品出库管理
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
            this.cmbSotckOut = new System.Windows.Forms.ComboBox();
            this.cmbGifts = new System.Windows.Forms.ComboBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGiftStockOut = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColStockOut = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBack = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntUsedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasStockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGiftStockOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGiftStockOut = new 销售管理.DAL.DataSetGiftStockOut();
            this.t_GiftStockOutTableAdapter = new 销售管理.DAL.DataSetGiftStockOutTableAdapters.T_GiftStockOutTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftStockOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGiftStockOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGiftStockOut)).BeginInit();
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
            this.groupBox1.Controls.Add(this.cmbSotckOut);
            this.groupBox1.Controls.Add(this.cmbGifts);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.cmbUsers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1920, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查找";
            // 
            // CBoxUsed
            // 
            this.CBoxUsed.DropDownHeight = 300;
            this.CBoxUsed.DropDownWidth = 200;
            this.CBoxUsed.FormattingEnabled = true;
            this.CBoxUsed.IntegralHeight = false;
            this.CBoxUsed.Location = new System.Drawing.Point(132, 110);
            this.CBoxUsed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CBoxUsed.Name = "CBoxUsed";
            this.CBoxUsed.Size = new System.Drawing.Size(236, 32);
            this.CBoxUsed.TabIndex = 11;
            this.CBoxUsed.SelectedIndexChanged += new System.EventHandler(this.CBoxUsed_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "使用人";
            // 
            // CmbDepartmentName
            // 
            this.CmbDepartmentName.DisplayMember = "UserName";
            this.CmbDepartmentName.DropDownHeight = 300;
            this.CmbDepartmentName.DropDownWidth = 200;
            this.CmbDepartmentName.FormattingEnabled = true;
            this.CmbDepartmentName.IntegralHeight = false;
            this.CmbDepartmentName.Items.AddRange(new object[] {
            "销售",
            "领导",
            "财务",
            "融通创投",
            "RTM",
            "商务经理",
            "商务助理",
            "生产与质量"});
            this.CmbDepartmentName.Location = new System.Drawing.Point(528, 110);
            this.CmbDepartmentName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmbDepartmentName.Name = "CmbDepartmentName";
            this.CmbDepartmentName.Size = new System.Drawing.Size(346, 32);
            this.CmbDepartmentName.TabIndex = 9;
            this.CmbDepartmentName.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "所属部门";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(1720, 96);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(150, 46);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "导入EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // llAdd
            // 
            this.llAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(1718, 154);
            this.llAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llAdd.Name = "llAdd";
            this.llAdd.Size = new System.Drawing.Size(154, 24);
            this.llAdd.TabIndex = 0;
            this.llAdd.TabStop = true;
            this.llAdd.Text = "礼品出库申请";
            this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1720, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 46);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(1422, 110);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(250, 35);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = false;
            this.dtpStart.Location = new System.Drawing.Point(1422, 50);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowCheckBox = true;
            this.dtpStart.Size = new System.Drawing.Size(250, 35);
            this.dtpStart.TabIndex = 2;
            // 
            // cmbSotckOut
            // 
            this.cmbSotckOut.DropDownHeight = 300;
            this.cmbSotckOut.DropDownWidth = 200;
            this.cmbSotckOut.FormattingEnabled = true;
            this.cmbSotckOut.IntegralHeight = false;
            this.cmbSotckOut.Items.AddRange(new object[] {
            "已出库",
            "未出库"});
            this.cmbSotckOut.Location = new System.Drawing.Point(1032, 110);
            this.cmbSotckOut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbSotckOut.Name = "cmbSotckOut";
            this.cmbSotckOut.Size = new System.Drawing.Size(296, 32);
            this.cmbSotckOut.TabIndex = 1;
            // 
            // cmbGifts
            // 
            this.cmbGifts.DropDownHeight = 300;
            this.cmbGifts.DropDownWidth = 200;
            this.cmbGifts.FormattingEnabled = true;
            this.cmbGifts.IntegralHeight = false;
            this.cmbGifts.Location = new System.Drawing.Point(1032, 50);
            this.cmbGifts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbGifts.Name = "cmbGifts";
            this.cmbGifts.Size = new System.Drawing.Size(296, 32);
            this.cmbGifts.TabIndex = 1;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DisplayMember = "CompanyName";
            this.cmbCustomers.DropDownHeight = 300;
            this.cmbCustomers.DropDownWidth = 200;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.IntegralHeight = false;
            this.cmbCustomers.Location = new System.Drawing.Point(528, 50);
            this.cmbCustomers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(346, 32);
            this.cmbCustomers.TabIndex = 1;
            this.cmbCustomers.ValueMember = "Id";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownHeight = 300;
            this.cmbUsers.DropDownWidth = 200;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.IntegralHeight = false;
            this.cmbUsers.Location = new System.Drawing.Point(132, 50);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(236, 32);
            this.cmbUsers.TabIndex = 1;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1358, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(920, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "礼品名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1358, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "客户名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(920, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "出库状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 58);
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
            this.idDataGridViewTextBoxColumn,
            this.ColDel,
            this.ColModify,
            this.ColStockOut,
            this.ColBack,
            this.dataDateDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.IntUsedID,
            this.departmentnameDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.giftIdDataGridViewTextBoxColumn,
            this.giftNameDataGridViewTextBoxColumn,
            this.giftNumDataGridViewTextBoxColumn,
            this.giftPriceDataGridViewTextBoxColumn,
            this.giftSumDataGridViewTextBoxColumn,
            this.Status,
            this.HasStockOut,
            this.auditIdDataGridViewTextBoxColumn,
            this.auditDateDataGridViewTextBoxColumn,
            this.recDateDataGridViewTextBoxColumn});
            this.dgvGiftStockOut.DataSource = this.tGiftStockOutBindingSource;
            this.dgvGiftStockOut.Location = new System.Drawing.Point(40, 260);
            this.dgvGiftStockOut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvGiftStockOut.Name = "dgvGiftStockOut";
            this.dgvGiftStockOut.ReadOnly = true;
            this.dgvGiftStockOut.RowTemplate.Height = 23;
            this.dgvGiftStockOut.Size = new System.Drawing.Size(1920, 1100);
            this.dgvGiftStockOut.TabIndex = 2;
            this.dgvGiftStockOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiftStockOut_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 23;
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
            // ColStockOut
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "已出库";
            this.ColStockOut.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColStockOut.HeaderText = "出库";
            this.ColStockOut.Name = "ColStockOut";
            this.ColStockOut.ReadOnly = true;
            this.ColStockOut.Width = 64;
            // 
            // ColBack
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "退回";
            this.ColBack.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColBack.HeaderText = "退回";
            this.ColBack.Name = "ColBack";
            this.ColBack.ReadOnly = true;
            this.ColBack.Width = 64;
            // 
            // dataDateDataGridViewTextBoxColumn
            // 
            this.dataDateDataGridViewTextBoxColumn.DataPropertyName = "DataDate";
            this.dataDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.dataDateDataGridViewTextBoxColumn.Name = "dataDateDataGridViewTextBoxColumn";
            this.dataDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataDateDataGridViewTextBoxColumn.Width = 64;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "领用人";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userIdDataGridViewTextBoxColumn.Width = 88;
            // 
            // IntUsedID
            // 
            this.IntUsedID.DataPropertyName = "IntUsedID";
            this.IntUsedID.HeaderText = "使用人";
            this.IntUsedID.Name = "IntUsedID";
            this.IntUsedID.ReadOnly = true;
            this.IntUsedID.Width = 127;
            // 
            // departmentnameDataGridViewTextBoxColumn
            // 
            this.departmentnameDataGridViewTextBoxColumn.DataPropertyName = "departmentname";
            this.departmentnameDataGridViewTextBoxColumn.HeaderText = "所属部门";
            this.departmentnameDataGridViewTextBoxColumn.Name = "departmentnameDataGridViewTextBoxColumn";
            this.departmentnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentnameDataGridViewTextBoxColumn.Width = 151;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.customerIdDataGridViewTextBoxColumn.Width = 112;
            // 
            // giftIdDataGridViewTextBoxColumn
            // 
            this.giftIdDataGridViewTextBoxColumn.DataPropertyName = "GiftId";
            this.giftIdDataGridViewTextBoxColumn.HeaderText = "GiftId";
            this.giftIdDataGridViewTextBoxColumn.Name = "giftIdDataGridViewTextBoxColumn";
            this.giftIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.giftIdDataGridViewTextBoxColumn.Visible = false;
            this.giftIdDataGridViewTextBoxColumn.Width = 47;
            // 
            // giftNameDataGridViewTextBoxColumn
            // 
            this.giftNameDataGridViewTextBoxColumn.DataPropertyName = "GiftName";
            this.giftNameDataGridViewTextBoxColumn.HeaderText = "礼品名称";
            this.giftNameDataGridViewTextBoxColumn.Name = "giftNameDataGridViewTextBoxColumn";
            this.giftNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.giftNameDataGridViewTextBoxColumn.Width = 112;
            // 
            // giftNumDataGridViewTextBoxColumn
            // 
            this.giftNumDataGridViewTextBoxColumn.DataPropertyName = "GiftNum";
            this.giftNumDataGridViewTextBoxColumn.HeaderText = "数量";
            this.giftNumDataGridViewTextBoxColumn.Name = "giftNumDataGridViewTextBoxColumn";
            this.giftNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftNumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.giftNumDataGridViewTextBoxColumn.Width = 64;
            // 
            // giftPriceDataGridViewTextBoxColumn
            // 
            this.giftPriceDataGridViewTextBoxColumn.DataPropertyName = "GiftPrice";
            this.giftPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.giftPriceDataGridViewTextBoxColumn.Name = "giftPriceDataGridViewTextBoxColumn";
            this.giftPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftPriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.giftPriceDataGridViewTextBoxColumn.Width = 64;
            // 
            // giftSumDataGridViewTextBoxColumn
            // 
            this.giftSumDataGridViewTextBoxColumn.DataPropertyName = "GiftSum";
            this.giftSumDataGridViewTextBoxColumn.HeaderText = "金额";
            this.giftSumDataGridViewTextBoxColumn.Name = "giftSumDataGridViewTextBoxColumn";
            this.giftSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftSumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.giftSumDataGridViewTextBoxColumn.Width = 64;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Status.Width = 64;
            // 
            // HasStockOut
            // 
            this.HasStockOut.DataPropertyName = "HasStockOut";
            this.HasStockOut.HeaderText = "出库状态";
            this.HasStockOut.Name = "HasStockOut";
            this.HasStockOut.ReadOnly = true;
            this.HasStockOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HasStockOut.Width = 112;
            // 
            // auditIdDataGridViewTextBoxColumn
            // 
            this.auditIdDataGridViewTextBoxColumn.DataPropertyName = "AuditId";
            this.auditIdDataGridViewTextBoxColumn.HeaderText = "审批人";
            this.auditIdDataGridViewTextBoxColumn.Name = "auditIdDataGridViewTextBoxColumn";
            this.auditIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.auditIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.auditIdDataGridViewTextBoxColumn.Width = 88;
            // 
            // auditDateDataGridViewTextBoxColumn
            // 
            this.auditDateDataGridViewTextBoxColumn.DataPropertyName = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.HeaderText = "审批日期";
            this.auditDateDataGridViewTextBoxColumn.Name = "auditDateDataGridViewTextBoxColumn";
            this.auditDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.auditDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.auditDateDataGridViewTextBoxColumn.Width = 112;
            // 
            // recDateDataGridViewTextBoxColumn
            // 
            this.recDateDataGridViewTextBoxColumn.DataPropertyName = "RecDate";
            this.recDateDataGridViewTextBoxColumn.HeaderText = "提交时间";
            this.recDateDataGridViewTextBoxColumn.Name = "recDateDataGridViewTextBoxColumn";
            this.recDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.recDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.recDateDataGridViewTextBoxColumn.Visible = false;
            this.recDateDataGridViewTextBoxColumn.Width = 59;
            // 
            // tGiftStockOutBindingSource
            // 
            this.tGiftStockOutBindingSource.DataMember = "T_GiftStockOut";
            this.tGiftStockOutBindingSource.DataSource = this.dataSetGiftStockOut;
            // 
            // dataSetGiftStockOut
            // 
            this.dataSetGiftStockOut.DataSetName = "DataSetGiftStockOut";
            this.dataSetGiftStockOut.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_GiftStockOutTableAdapter
            // 
            this.t_GiftStockOutTableAdapter.ClearBeforeFill = true;
            // 
            // 礼品出库管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGiftStockOut);
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.Name = "礼品出库管理";
            this.Load += new System.EventHandler(this.礼品出库管理_Load);
            this.Controls.SetChildIndex(this.dgvGiftStockOut, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftStockOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGiftStockOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGiftStockOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGiftStockOut;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cmbGifts;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.BindingSource tGiftStockOutBindingSource;
        private DAL.DataSetGiftStockOut dataSetGiftStockOut;
        private DAL.DataSetGiftStockOutTableAdapters.T_GiftStockOutTableAdapter t_GiftStockOutTableAdapter;
        private System.Windows.Forms.ComboBox cmbSotckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox CmbDepartmentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewButtonColumn ColStockOut;
        private System.Windows.Forms.DataGridViewButtonColumn ColBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntUsedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasStockOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CBoxUsed;
        private System.Windows.Forms.Label label8;
    }
}
