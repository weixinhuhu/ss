namespace 销售管理.审核
{
    partial class 消费卡申请审核
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
            this.dgvExAllocation = new System.Windows.Forms.DataGridView();
            this.tMealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMeals = new 销售管理.DAL.DataSetMeals();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxDept = new System.Windows.Forms.ComboBox();
            this.btnAudit2 = new System.Windows.Forms.Button();
            this.btnAudit = new System.Windows.Forms.Button();
            this.cmbHasAudit = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCards = new System.Windows.Forms.ComboBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_MealsTableAdapter = new 销售管理.DAL.DataSetMealsTableAdapters.T_MealsTableAdapter();
            this.ColumnChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntUsedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBoxUsed = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMeals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
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
            this.dgvExAllocation.ColumnHeadersHeight = 30;
            this.dgvExAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExAllocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnChecked,
            this.idDataGridViewTextBoxColumn,
            this.dataDateDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.IntUsedID,
            this.DepartmentName,
            this.customerIdDataGridViewTextBoxColumn,
            this.mealMoneyDataGridViewTextBoxColumn,
            this.recDateDataGridViewTextBoxColumn,
            this.ColCardName,
            this.CardBalance,
            this.ed,
            this.operIdDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.auditIdDataGridViewTextBoxColumn,
            this.auditDateDataGridViewTextBoxColumn});
            this.dgvExAllocation.DataSource = this.tMealsBindingSource;
            this.dgvExAllocation.Location = new System.Drawing.Point(30, 133);
            this.dgvExAllocation.Name = "dgvExAllocation";
            this.dgvExAllocation.RowTemplate.Height = 23;
            this.dgvExAllocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExAllocation.ShowEditingIcon = false;
            this.dgvExAllocation.Size = new System.Drawing.Size(940, 540);
            this.dgvExAllocation.TabIndex = 10;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CBoxUsed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBoxDept);
            this.groupBox1.Controls.Add(this.btnAudit2);
            this.groupBox1.Controls.Add(this.btnAudit);
            this.groupBox1.Controls.Add(this.cmbHasAudit);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCards);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速搜索";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "所属部门";
            // 
            // CBoxDept
            // 
            this.CBoxDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBoxDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBoxDept.DisplayMember = "CompanyName";
            this.CBoxDept.DropDownHeight = 300;
            this.CBoxDept.DropDownWidth = 300;
            this.CBoxDept.FormattingEnabled = true;
            this.CBoxDept.IntegralHeight = false;
            this.CBoxDept.Location = new System.Drawing.Point(275, 65);
            this.CBoxDept.Name = "CBoxDept";
            this.CBoxDept.Size = new System.Drawing.Size(185, 20);
            this.CBoxDept.TabIndex = 9;
            this.CBoxDept.ValueMember = "Id";
            // 
            // btnAudit2
            // 
            this.btnAudit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudit2.Location = new System.Drawing.Point(830, 63);
            this.btnAudit2.Name = "btnAudit2";
            this.btnAudit2.Size = new System.Drawing.Size(104, 24);
            this.btnAudit2.TabIndex = 7;
            this.btnAudit2.Text = "批量审核不通过";
            this.btnAudit2.UseVisualStyleBackColor = true;
            this.btnAudit2.Click += new System.EventHandler(this.btnAudit2_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudit.Location = new System.Drawing.Point(713, 63);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(111, 24);
            this.btnAudit.TabIndex = 7;
            this.btnAudit.Text = "批量审核通过";
            this.btnAudit.UseVisualStyleBackColor = true;
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // cmbHasAudit
            // 
            this.cmbHasAudit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasAudit.FormattingEnabled = true;
            this.cmbHasAudit.Items.AddRange(new object[] {
            "未审核",
            "审核已通过",
            "审核未通过"});
            this.cmbHasAudit.Location = new System.Drawing.Point(729, 29);
            this.cmbHasAudit.Name = "cmbHasAudit";
            this.cmbHasAudit.Size = new System.Drawing.Size(95, 20);
            this.cmbHasAudit.TabIndex = 6;
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(850, 26);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(84, 26);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查找";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "审核状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "消费卡名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "客户名称";
            // 
            // cmbCards
            // 
            this.cmbCards.DropDownHeight = 300;
            this.cmbCards.DropDownWidth = 200;
            this.cmbCards.FormattingEnabled = true;
            this.cmbCards.IntegralHeight = false;
            this.cmbCards.Location = new System.Drawing.Point(542, 29);
            this.cmbCards.Name = "cmbCards";
            this.cmbCards.Size = new System.Drawing.Size(121, 20);
            this.cmbCards.TabIndex = 1;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomers.DisplayMember = "CompanyName";
            this.cmbCustomers.DropDownHeight = 300;
            this.cmbCustomers.DropDownWidth = 300;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.IntegralHeight = false;
            this.cmbCustomers.Location = new System.Drawing.Point(275, 29);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(185, 20);
            this.cmbCustomers.TabIndex = 1;
            this.cmbCustomers.ValueMember = "Id";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.DropDownWidth = 200;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(66, 29);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(121, 20);
            this.cmbUserName.TabIndex = 1;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "领用人";
            // 
            // t_MealsTableAdapter
            // 
            this.t_MealsTableAdapter.ClearBeforeFill = true;
            // 
            // ColumnChecked
            // 
            this.ColumnChecked.Frozen = true;
            this.ColumnChecked.HeaderText = "选择";
            this.ColumnChecked.Name = "ColumnChecked";
            this.ColumnChecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnChecked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnChecked.Width = 51;
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
            this.dataDateDataGridViewTextBoxColumn.HeaderText = "领用日期";
            this.dataDateDataGridViewTextBoxColumn.Name = "dataDateDataGridViewTextBoxColumn";
            this.dataDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDateDataGridViewTextBoxColumn.Width = 61;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "领用人";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 61;
            // 
            // IntUsedID
            // 
            this.IntUsedID.DataPropertyName = "IntUsedID";
            this.IntUsedID.HeaderText = "使用人";
            this.IntUsedID.Name = "IntUsedID";
            this.IntUsedID.ReadOnly = true;
            this.IntUsedID.Width = 61;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "所属部门";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            this.DepartmentName.Width = 61;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIdDataGridViewTextBoxColumn.Width = 61;
            // 
            // mealMoneyDataGridViewTextBoxColumn
            // 
            this.mealMoneyDataGridViewTextBoxColumn.DataPropertyName = "MealMoney";
            this.mealMoneyDataGridViewTextBoxColumn.HeaderText = "消费金额";
            this.mealMoneyDataGridViewTextBoxColumn.Name = "mealMoneyDataGridViewTextBoxColumn";
            this.mealMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.mealMoneyDataGridViewTextBoxColumn.Visible = false;
            this.mealMoneyDataGridViewTextBoxColumn.Width = 61;
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
            // ColCardName
            // 
            this.ColCardName.DataPropertyName = "CardName";
            this.ColCardName.HeaderText = "消费卡名称";
            this.ColCardName.Name = "ColCardName";
            this.ColCardName.Width = 72;
            // 
            // CardBalance
            // 
            this.CardBalance.DataPropertyName = "cardbalance";
            this.CardBalance.HeaderText = "消费卡余额";
            this.CardBalance.Name = "CardBalance";
            this.CardBalance.ReadOnly = true;
            this.CardBalance.Width = 72;
            // 
            // ed
            // 
            this.ed.DataPropertyName = "ed";
            this.ed.HeaderText = "本年剩余报销额度";
            this.ed.Name = "ed";
            this.ed.ReadOnly = true;
            this.ed.Width = 83;
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
            this.statusDataGridViewTextBoxColumn.Width = 51;
            // 
            // auditIdDataGridViewTextBoxColumn
            // 
            this.auditIdDataGridViewTextBoxColumn.DataPropertyName = "AuditId";
            this.auditIdDataGridViewTextBoxColumn.HeaderText = "审核人";
            this.auditIdDataGridViewTextBoxColumn.Name = "auditIdDataGridViewTextBoxColumn";
            this.auditIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.auditIdDataGridViewTextBoxColumn.Width = 61;
            // 
            // auditDateDataGridViewTextBoxColumn
            // 
            this.auditDateDataGridViewTextBoxColumn.DataPropertyName = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.HeaderText = "审核日期";
            this.auditDateDataGridViewTextBoxColumn.Name = "auditDateDataGridViewTextBoxColumn";
            this.auditDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.auditDateDataGridViewTextBoxColumn.Width = 61;
            // 
            // CBoxUsed
            // 
            this.CBoxUsed.DropDownHeight = 300;
            this.CBoxUsed.DropDownWidth = 200;
            this.CBoxUsed.FormattingEnabled = true;
            this.CBoxUsed.IntegralHeight = false;
            this.CBoxUsed.Location = new System.Drawing.Point(66, 65);
            this.CBoxUsed.Name = "CBoxUsed";
            this.CBoxUsed.Size = new System.Drawing.Size(121, 20);
            this.CBoxUsed.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "使用人";
            // 
            // 消费卡申请审核
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.dgvExAllocation);
            this.Controls.Add(this.groupBox1);
            this.Name = "消费卡申请审核";
            this.Load += new System.EventHandler(this.消费卡申请审核_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvExAllocation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMeals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExAllocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAudit2;
        private System.Windows.Forms.Button btnAudit;
        private System.Windows.Forms.ComboBox cmbHasAudit;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCards;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tMealsBindingSource;
        private DAL.DataSetMeals dataSetMeals;
        private DAL.DataSetMealsTableAdapters.T_MealsTableAdapter t_MealsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxDept;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntUsedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ed;
        private System.Windows.Forms.DataGridViewTextBoxColumn operIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CBoxUsed;
        private System.Windows.Forms.Label label6;
    }
}
