namespace 销售管理.日常业务
{
    partial class 申请开票
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.llAddStockOut = new System.Windows.Forms.LinkLabel();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInoviceNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tInvoiceQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInvoice = new 销售管理.DAL.DataSetInvoice();
            this.t_InvoiceQTableAdapter = new 销售管理.DAL.DataSetInvoiceTableAdapters.T_InvoiceQTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tInvoiceQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInvoice)).BeginInit();
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
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.llAddStockOut);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtInoviceNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCusName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速搜索";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "--";
            // 
            // dtp2
            // 
            this.dtp2.Checked = false;
            this.dtp2.Location = new System.Drawing.Point(398, 37);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(123, 21);
            this.dtp2.TabIndex = 6;
            // 
            // llAddStockOut
            // 
            this.llAddStockOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAddStockOut.AutoSize = true;
            this.llAddStockOut.Location = new System.Drawing.Point(839, 73);
            this.llAddStockOut.Name = "llAddStockOut";
            this.llAddStockOut.Size = new System.Drawing.Size(77, 12);
            this.llAddStockOut.TabIndex = 5;
            this.llAddStockOut.TabStop = true;
            this.llAddStockOut.Text = "提交开票申请";
            this.llAddStockOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddStockOut_LinkClicked);
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.DropDownWidth = 200;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(574, 37);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(140, 20);
            this.cmbUserName.TabIndex = 4;
            this.cmbUserName.Visible = false;
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(851, 29);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(63, 36);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "快速查找";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // dtp1
            // 
            this.dtp1.Checked = false;
            this.dtp1.Location = new System.Drawing.Point(256, 37);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShowCheckBox = true;
            this.dtp1.Size = new System.Drawing.Size(123, 21);
            this.dtp1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "日期";
            // 
            // txtInoviceNo
            // 
            this.txtInoviceNo.Location = new System.Drawing.Point(101, 70);
            this.txtInoviceNo.Name = "txtInoviceNo";
            this.txtInoviceNo.Size = new System.Drawing.Size(100, 21);
            this.txtInoviceNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "发票号";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(101, 38);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(100, 21);
            this.txtCusName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "客户名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售员";
            this.label1.Visible = false;
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
            this.ColModify,
            this.userNameDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.InvoiceNo,
            this.invoiceContentDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.invoiceTypeDataGridViewTextBoxColumn,
            this.invoiceMoneyDataGridViewTextBoxColumn,
            this.submitDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvInvoice.DataSource = this.tInvoiceQBindingSource;
            this.dgvInvoice.Location = new System.Drawing.Point(30, 126);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RowTemplate.Height = 23;
            this.dgvInvoice.Size = new System.Drawing.Size(935, 554);
            this.dgvInvoice.TabIndex = 5;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            this.dgvInvoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellDoubleClick);
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
            // ColModify
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "修改";
            this.ColModify.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColModify.HeaderText = "修改";
            this.ColModify.Name = "ColModify";
            this.ColModify.ReadOnly = true;
            this.ColModify.UseColumnTextForButtonValue = true;
            this.ColModify.Width = 35;
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
            // InvoiceNo
            // 
            this.InvoiceNo.DataPropertyName = "InvoiceNo";
            this.InvoiceNo.HeaderText = "发票号";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.ReadOnly = true;
            this.InvoiceNo.Width = 66;
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
            this.invoiceTypeDataGridViewTextBoxColumn.HeaderText = "发票类型";
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
            // submitDateDataGridViewTextBoxColumn
            // 
            this.submitDateDataGridViewTextBoxColumn.DataPropertyName = "SubmitDate";
            this.submitDateDataGridViewTextBoxColumn.HeaderText = "提交日期";
            this.submitDateDataGridViewTextBoxColumn.Name = "submitDateDataGridViewTextBoxColumn";
            this.submitDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.submitDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 54;
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
            // t_InvoiceQTableAdapter
            // 
            this.t_InvoiceQTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "状态";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "全部",
            "已通过",
            "未通过",
            "审核中"});
            this.cmbStatus.Location = new System.Drawing.Point(256, 70);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(123, 20);
            this.cmbStatus.TabIndex = 8;
            // 
            // 申请开票
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.groupBox1);
            this.Name = "申请开票";
            this.Load += new System.EventHandler(this.申请开票_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvInvoice, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tInvoiceQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llAddStockOut;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.BindingSource tInvoiceQBindingSource;
        private DAL.DataSetInvoice dataSetInvoice;
        private DAL.DataSetInvoiceTableAdapters.T_InvoiceQTableAdapter t_InvoiceQTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtInoviceNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}
