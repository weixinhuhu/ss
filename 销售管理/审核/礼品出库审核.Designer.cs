namespace 销售管理.审核
{
    partial class 礼品出库审核
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
            this.tGiftStockOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGiftStockOut = new 销售管理.DAL.DataSetGiftStockOut();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBoxUsed = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxDept = new System.Windows.Forms.ComboBox();
            this.btnAudit2 = new System.Windows.Forms.Button();
            this.btnAudit = new System.Windows.Forms.Button();
            this.cmbHasAudit = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGifts = new System.Windows.Forms.ComboBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_GiftStockOutTableAdapter = new 销售管理.DAL.DataSetGiftStockOutTableAdapters.T_GiftStockOutTableAdapter();
            this.ColumnChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntUsedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col当前额度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGiftStockOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGiftStockOut)).BeginInit();
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
            this.dgvExAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExAllocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnChecked,
            this.idDataGridViewTextBoxColumn,
            this.dataDateDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.IntUsedID,
            this.DepartmentName,
            this.customerIdDataGridViewTextBoxColumn,
            this.giftIdDataGridViewTextBoxColumn,
            this.giftNameDataGridViewTextBoxColumn,
            this.giftNumDataGridViewTextBoxColumn,
            this.giftPriceDataGridViewTextBoxColumn,
            this.giftSumDataGridViewTextBoxColumn,
            this.Col当前额度,
            this.statusDataGridViewTextBoxColumn,
            this.auditDateDataGridViewTextBoxColumn,
            this.recDateDataGridViewTextBoxColumn});
            this.dgvExAllocation.DataSource = this.tGiftStockOutBindingSource;
            this.dgvExAllocation.Location = new System.Drawing.Point(60, 272);
            this.dgvExAllocation.Margin = new System.Windows.Forms.Padding(6);
            this.dgvExAllocation.Name = "dgvExAllocation";
            this.dgvExAllocation.RowTemplate.Height = 23;
            this.dgvExAllocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExAllocation.ShowEditingIcon = false;
            this.dgvExAllocation.Size = new System.Drawing.Size(1880, 1080);
            this.dgvExAllocation.TabIndex = 8;
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
            this.groupBox1.Controls.Add(this.cmbGifts);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1880, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速搜索";
            // 
            // CBoxUsed
            // 
            this.CBoxUsed.DropDownHeight = 300;
            this.CBoxUsed.DropDownWidth = 200;
            this.CBoxUsed.FormattingEnabled = true;
            this.CBoxUsed.IntegralHeight = false;
            this.CBoxUsed.Location = new System.Drawing.Point(136, 132);
            this.CBoxUsed.Margin = new System.Windows.Forms.Padding(6);
            this.CBoxUsed.Name = "CBoxUsed";
            this.CBoxUsed.Size = new System.Drawing.Size(238, 32);
            this.CBoxUsed.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "使用人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 12;
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
            this.CBoxDept.Location = new System.Drawing.Point(530, 132);
            this.CBoxDept.Margin = new System.Windows.Forms.Padding(6);
            this.CBoxDept.Name = "CBoxDept";
            this.CBoxDept.Size = new System.Drawing.Size(366, 32);
            this.CBoxDept.TabIndex = 13;
            this.CBoxDept.ValueMember = "Id";
            // 
            // btnAudit2
            // 
            this.btnAudit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudit2.Location = new System.Drawing.Point(1660, 126);
            this.btnAudit2.Margin = new System.Windows.Forms.Padding(6);
            this.btnAudit2.Name = "btnAudit2";
            this.btnAudit2.Size = new System.Drawing.Size(208, 48);
            this.btnAudit2.TabIndex = 7;
            this.btnAudit2.Text = "批量审核不通过";
            this.btnAudit2.UseVisualStyleBackColor = true;
            this.btnAudit2.Click += new System.EventHandler(this.btnAudit2_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudit.Location = new System.Drawing.Point(1404, 126);
            this.btnAudit.Margin = new System.Windows.Forms.Padding(6);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(222, 48);
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
            this.cmbHasAudit.Location = new System.Drawing.Point(1436, 58);
            this.cmbHasAudit.Margin = new System.Windows.Forms.Padding(6);
            this.cmbHasAudit.Name = "cmbHasAudit";
            this.cmbHasAudit.Size = new System.Drawing.Size(186, 32);
            this.cmbHasAudit.TabIndex = 6;
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(1700, 52);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(168, 52);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查找";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1322, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "审核状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(938, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "礼品名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "客户名称";
            // 
            // cmbGifts
            // 
            this.cmbGifts.DropDownHeight = 300;
            this.cmbGifts.DropDownWidth = 200;
            this.cmbGifts.FormattingEnabled = true;
            this.cmbGifts.IntegralHeight = false;
            this.cmbGifts.Location = new System.Drawing.Point(1052, 58);
            this.cmbGifts.Margin = new System.Windows.Forms.Padding(6);
            this.cmbGifts.Name = "cmbGifts";
            this.cmbGifts.Size = new System.Drawing.Size(238, 32);
            this.cmbGifts.TabIndex = 1;
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
            this.cmbCustomers.Location = new System.Drawing.Point(530, 58);
            this.cmbCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(366, 32);
            this.cmbCustomers.TabIndex = 1;
            this.cmbCustomers.ValueMember = "Id";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownHeight = 300;
            this.cmbUserName.DropDownWidth = 200;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(136, 58);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(238, 32);
            this.cmbUserName.TabIndex = 1;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "领用人";
            // 
            // t_GiftStockOutTableAdapter
            // 
            this.t_GiftStockOutTableAdapter.ClearBeforeFill = true;
            // 
            // ColumnChecked
            // 
            this.ColumnChecked.Frozen = true;
            this.ColumnChecked.HeaderText = "选择";
            this.ColumnChecked.Name = "ColumnChecked";
            this.ColumnChecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnChecked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnChecked.Width = 103;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 79;
            // 
            // dataDateDataGridViewTextBoxColumn
            // 
            this.dataDateDataGridViewTextBoxColumn.DataPropertyName = "DataDate";
            this.dataDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.dataDateDataGridViewTextBoxColumn.Name = "dataDateDataGridViewTextBoxColumn";
            this.dataDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDateDataGridViewTextBoxColumn.Width = 103;
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
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "所属部门";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Width = 151;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIdDataGridViewTextBoxColumn.Width = 151;
            // 
            // giftIdDataGridViewTextBoxColumn
            // 
            this.giftIdDataGridViewTextBoxColumn.DataPropertyName = "GiftId";
            this.giftIdDataGridViewTextBoxColumn.HeaderText = "GiftId";
            this.giftIdDataGridViewTextBoxColumn.Name = "giftIdDataGridViewTextBoxColumn";
            this.giftIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftIdDataGridViewTextBoxColumn.Visible = false;
            this.giftIdDataGridViewTextBoxColumn.Width = 127;
            // 
            // giftNameDataGridViewTextBoxColumn
            // 
            this.giftNameDataGridViewTextBoxColumn.DataPropertyName = "GiftName";
            this.giftNameDataGridViewTextBoxColumn.HeaderText = "礼品名称";
            this.giftNameDataGridViewTextBoxColumn.Name = "giftNameDataGridViewTextBoxColumn";
            this.giftNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftNameDataGridViewTextBoxColumn.Width = 151;
            // 
            // giftNumDataGridViewTextBoxColumn
            // 
            this.giftNumDataGridViewTextBoxColumn.DataPropertyName = "GiftNum";
            this.giftNumDataGridViewTextBoxColumn.HeaderText = "领用数量";
            this.giftNumDataGridViewTextBoxColumn.Name = "giftNumDataGridViewTextBoxColumn";
            this.giftNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftNumDataGridViewTextBoxColumn.Width = 151;
            // 
            // giftPriceDataGridViewTextBoxColumn
            // 
            this.giftPriceDataGridViewTextBoxColumn.DataPropertyName = "GiftPrice";
            this.giftPriceDataGridViewTextBoxColumn.HeaderText = "礼品单价";
            this.giftPriceDataGridViewTextBoxColumn.Name = "giftPriceDataGridViewTextBoxColumn";
            this.giftPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftPriceDataGridViewTextBoxColumn.Width = 151;
            // 
            // giftSumDataGridViewTextBoxColumn
            // 
            this.giftSumDataGridViewTextBoxColumn.DataPropertyName = "GiftSum";
            this.giftSumDataGridViewTextBoxColumn.HeaderText = "礼品金额";
            this.giftSumDataGridViewTextBoxColumn.Name = "giftSumDataGridViewTextBoxColumn";
            this.giftSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftSumDataGridViewTextBoxColumn.Width = 151;
            // 
            // Col当前额度
            // 
            this.Col当前额度.DataPropertyName = "ed";
            this.Col当前额度.HeaderText = "本年剩余额度";
            this.Col当前额度.Name = "Col当前额度";
            this.Col当前额度.Width = 140;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 97;
            // 
            // auditDateDataGridViewTextBoxColumn
            // 
            this.auditDateDataGridViewTextBoxColumn.DataPropertyName = "AuditDate";
            this.auditDateDataGridViewTextBoxColumn.HeaderText = "审核时间";
            this.auditDateDataGridViewTextBoxColumn.Name = "auditDateDataGridViewTextBoxColumn";
            this.auditDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.auditDateDataGridViewTextBoxColumn.Width = 118;
            // 
            // recDateDataGridViewTextBoxColumn
            // 
            this.recDateDataGridViewTextBoxColumn.DataPropertyName = "RecDate";
            this.recDateDataGridViewTextBoxColumn.HeaderText = "RecDate";
            this.recDateDataGridViewTextBoxColumn.Name = "recDateDataGridViewTextBoxColumn";
            this.recDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.recDateDataGridViewTextBoxColumn.Visible = false;
            this.recDateDataGridViewTextBoxColumn.Width = 139;
            // 
            // 礼品出库审核
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.Controls.Add(this.dgvExAllocation);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "礼品出库审核";
            this.Load += new System.EventHandler(this.礼品出库审核_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvExAllocation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGiftStockOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGiftStockOut)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGifts;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.BindingSource tGiftStockOutBindingSource;
        private DAL.DataSetGiftStockOut dataSetGiftStockOut;
        private DAL.DataSetGiftStockOutTableAdapters.T_GiftStockOutTableAdapter t_GiftStockOutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CBoxUsed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxDept;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntUsedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col当前额度;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recDateDataGridViewTextBoxColumn;
    }
}
