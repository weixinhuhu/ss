namespace 销售管理.日常业务
{
    partial class 开票审核_财务
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHasAudit = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tInvoiceQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInvoice = new 销售管理.DAL.DataSetInvoice();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.t_InvoiceQTableAdapter = new 销售管理.DAL.DataSetInvoiceTableAdapters.T_InvoiceQTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCombine = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColCancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColAudit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColAudit1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessAuditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinanceAudit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tInvoiceQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
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
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbHasAudit);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速搜索";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(767, 28);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(72, 33);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "导出到EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dtp1
            // 
            this.dtp1.Checked = false;
            this.dtp1.Location = new System.Drawing.Point(446, 34);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShowCheckBox = true;
            this.dtp1.Size = new System.Drawing.Size(123, 21);
            this.dtp1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "提交日期";
            // 
            // cmbHasAudit
            // 
            this.cmbHasAudit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasAudit.FormattingEnabled = true;
            this.cmbHasAudit.Items.AddRange(new object[] {
            "未审核",
            "已审核"});
            this.cmbHasAudit.Location = new System.Drawing.Point(584, 35);
            this.cmbHasAudit.Name = "cmbHasAudit";
            this.cmbHasAudit.Size = new System.Drawing.Size(88, 20);
            this.cmbHasAudit.TabIndex = 4;
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(845, 27);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(84, 34);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "查找";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(269, 35);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "客户名称";
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(62, 35);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(121, 20);
            this.cmbUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售员";
            // 
            // tInvoiceQBindingSource
            // 
            this.tInvoiceQBindingSource.DataMember = "T_InvoiceQ";
            this.tInvoiceQBindingSource.DataSource = this.dataSetInvoice;
            // 
            // dataSetInvoice
            // 
            this.dataSetInvoice.DataSetName = "DataSetInvoice";
            this.dataSetInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoice.AutoGenerateColumns = false;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColCombine,
            this.ColModify,
            this.ColCancel,
            this.ColAudit,
            this.ColAudit1,
            this.userNameDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.invoiceContentDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.invoiceTypeDataGridViewTextBoxColumn,
            this.invoiceMoneyDataGridViewTextBoxColumn,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.submitDateDataGridViewTextBoxColumn,
            this.businessAuditDataGridViewTextBoxColumn,
            this.businessDateDataGridViewTextBoxColumn,
            this.FinanceAudit,
            this.FinanceDate,
            this.statusDataGridViewTextBoxColumn});
            this.dgvInvoice.DataSource = this.tInvoiceQBindingSource;
            this.dgvInvoice.Location = new System.Drawing.Point(30, 99);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowTemplate.Height = 23;
            this.dgvInvoice.ShowEditingIcon = false;
            this.dgvInvoice.Size = new System.Drawing.Size(935, 579);
            this.dgvInvoice.TabIndex = 5;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            this.dgvInvoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellDoubleClick);
            // 
            // t_InvoiceQTableAdapter
            // 
            this.t_InvoiceQTableAdapter.ClearBeforeFill = true;
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
            // ColCombine
            // 
            this.ColCombine.HeaderText = "导出";
            this.ColCombine.Name = "ColCombine";
            this.ColCombine.Width = 35;
            // 
            // ColModify
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "修改票号";
            this.ColModify.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColModify.HeaderText = "修改票号";
            this.ColModify.Name = "ColModify";
            this.ColModify.Visible = false;
            this.ColModify.Width = 59;
            // 
            // ColCancel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "发票作废";
            this.ColCancel.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColCancel.HeaderText = "发票作废";
            this.ColCancel.Name = "ColCancel";
            this.ColCancel.Width = 59;
            // 
            // ColAudit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "审核通过";
            this.ColAudit.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColAudit.HeaderText = "审核通过";
            this.ColAudit.Name = "ColAudit";
            this.ColAudit.ReadOnly = true;
            this.ColAudit.UseColumnTextForButtonValue = true;
            this.ColAudit.Width = 59;
            // 
            // ColAudit1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "审核不通过";
            this.ColAudit1.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColAudit1.HeaderText = "审核不通过";
            this.ColAudit1.Name = "ColAudit1";
            this.ColAudit1.ReadOnly = true;
            this.ColAudit1.UseColumnTextForButtonValue = true;
            this.ColAudit1.Width = 71;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "销售员";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 66;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // invoiceContentDataGridViewTextBoxColumn
            // 
            this.invoiceContentDataGridViewTextBoxColumn.DataPropertyName = "InvoiceContent";
            this.invoiceContentDataGridViewTextBoxColumn.HeaderText = "开票内容";
            this.invoiceContentDataGridViewTextBoxColumn.Name = "invoiceContentDataGridViewTextBoxColumn";
            this.invoiceContentDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceContentDataGridViewTextBoxColumn.Width = 78;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "开票日期";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // invoiceTypeDataGridViewTextBoxColumn
            // 
            this.invoiceTypeDataGridViewTextBoxColumn.DataPropertyName = "InvoiceType";
            this.invoiceTypeDataGridViewTextBoxColumn.HeaderText = "开票类型";
            this.invoiceTypeDataGridViewTextBoxColumn.Name = "invoiceTypeDataGridViewTextBoxColumn";
            this.invoiceTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceTypeDataGridViewTextBoxColumn.Width = 78;
            // 
            // invoiceMoneyDataGridViewTextBoxColumn
            // 
            this.invoiceMoneyDataGridViewTextBoxColumn.DataPropertyName = "InvoiceMoney";
            this.invoiceMoneyDataGridViewTextBoxColumn.HeaderText = "开票金额";
            this.invoiceMoneyDataGridViewTextBoxColumn.Name = "invoiceMoneyDataGridViewTextBoxColumn";
            this.invoiceMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceMoneyDataGridViewTextBoxColumn.Width = 78;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "发票号";
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // submitDateDataGridViewTextBoxColumn
            // 
            this.submitDateDataGridViewTextBoxColumn.DataPropertyName = "SubmitDate";
            this.submitDateDataGridViewTextBoxColumn.HeaderText = "提交日期";
            this.submitDateDataGridViewTextBoxColumn.Name = "submitDateDataGridViewTextBoxColumn";
            this.submitDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.submitDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // businessAuditDataGridViewTextBoxColumn
            // 
            this.businessAuditDataGridViewTextBoxColumn.DataPropertyName = "BusinessAudit";
            this.businessAuditDataGridViewTextBoxColumn.HeaderText = "商务审核人";
            this.businessAuditDataGridViewTextBoxColumn.Name = "businessAuditDataGridViewTextBoxColumn";
            this.businessAuditDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessAuditDataGridViewTextBoxColumn.Width = 90;
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
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 51;
            // 
            // 开票审核_财务
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.groupBox1);
            this.Name = "开票审核_财务";
            this.Load += new System.EventHandler(this.开票审核_财务_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvInvoice, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tInvoiceQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHasAudit;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tInvoiceQBindingSource;
        private DAL.DataSetInvoice dataSetInvoice;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private DAL.DataSetInvoiceTableAdapters.T_InvoiceQTableAdapter t_InvoiceQTableAdapter;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCombine;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewButtonColumn ColCancel;
        private System.Windows.Forms.DataGridViewButtonColumn ColAudit;
        private System.Windows.Forms.DataGridViewButtonColumn ColAudit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessAuditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinanceAudit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
