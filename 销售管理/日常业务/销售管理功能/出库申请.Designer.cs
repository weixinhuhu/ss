namespace 销售管理.日常业务
{
    partial class 出库申请
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.llAddStockOut = new System.Windows.Forms.LinkLabel();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStockOut = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settlementModesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessAuditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderAuditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keeperAuditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keeperDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOutNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tStockOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetStockOut = new 销售管理.DAL.DataSetStockOut();
            this.t_StockOutTableAdapter = new 销售管理.DAL.DataSetStockOutTableAdapters.T_StockOutTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStockOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStockOut)).BeginInit();
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
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.llAddStockOut);
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCusName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速搜索";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(746, 31);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 33);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "打印收货单";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.llAddStockOut.Text = "提交出库申请";
            this.llAddStockOut.Visible = false;
            this.llAddStockOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddStockOut_LinkClicked);
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(621, 38);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(110, 20);
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
            this.dtp1.Location = new System.Drawing.Point(421, 37);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShowCheckBox = true;
            this.dtp1.Size = new System.Drawing.Size(123, 21);
            this.dtp1.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(266, 38);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 21);
            this.txtProductName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "产品名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "日期";
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
            this.label1.Location = new System.Drawing.Point(574, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售员";
            this.label1.Visible = false;
            // 
            // dgvStockOut
            // 
            this.dgvStockOut.AllowUserToAddRows = false;
            this.dgvStockOut.AllowUserToDeleteRows = false;
            this.dgvStockOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStockOut.AutoGenerateColumns = false;
            this.dgvStockOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStockOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvStockOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sumMoneyDataGridViewTextBoxColumn,
            this.settlementModesDataGridViewTextBoxColumn,
            this.cityIDDataGridViewTextBoxColumn,
            this.submitDateDataGridViewTextBoxColumn,
            this.businessAuditDataGridViewTextBoxColumn,
            this.businessDateDataGridViewTextBoxColumn,
            this.leaderAuditDataGridViewTextBoxColumn,
            this.leaderDateDataGridViewTextBoxColumn,
            this.keeperAuditDataGridViewTextBoxColumn,
            this.keeperDateDataGridViewTextBoxColumn,
            this.stockOutNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvStockOut.DataSource = this.tStockOutBindingSource;
            this.dgvStockOut.Location = new System.Drawing.Point(30, 129);
            this.dgvStockOut.Name = "dgvStockOut";
            this.dgvStockOut.ReadOnly = true;
            this.dgvStockOut.RowTemplate.Height = 23;
            this.dgvStockOut.Size = new System.Drawing.Size(935, 551);
            this.dgvStockOut.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "销售员";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 61;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 61;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "销售日期";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleDateDataGridViewTextBoxColumn.Width = 61;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "产品名称";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 61;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 51;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 51;
            // 
            // sumMoneyDataGridViewTextBoxColumn
            // 
            this.sumMoneyDataGridViewTextBoxColumn.DataPropertyName = "SumMoney";
            this.sumMoneyDataGridViewTextBoxColumn.HeaderText = "金额";
            this.sumMoneyDataGridViewTextBoxColumn.Name = "sumMoneyDataGridViewTextBoxColumn";
            this.sumMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumMoneyDataGridViewTextBoxColumn.Width = 51;
            // 
            // settlementModesDataGridViewTextBoxColumn
            // 
            this.settlementModesDataGridViewTextBoxColumn.DataPropertyName = "SettlementModes";
            this.settlementModesDataGridViewTextBoxColumn.HeaderText = "结款方式";
            this.settlementModesDataGridViewTextBoxColumn.Name = "settlementModesDataGridViewTextBoxColumn";
            this.settlementModesDataGridViewTextBoxColumn.ReadOnly = true;
            this.settlementModesDataGridViewTextBoxColumn.Width = 61;
            // 
            // cityIDDataGridViewTextBoxColumn
            // 
            this.cityIDDataGridViewTextBoxColumn.DataPropertyName = "CityID";
            this.cityIDDataGridViewTextBoxColumn.HeaderText = "CityID";
            this.cityIDDataGridViewTextBoxColumn.Name = "cityIDDataGridViewTextBoxColumn";
            this.cityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // submitDateDataGridViewTextBoxColumn
            // 
            this.submitDateDataGridViewTextBoxColumn.DataPropertyName = "SubmitDate";
            this.submitDateDataGridViewTextBoxColumn.HeaderText = "提交日期";
            this.submitDateDataGridViewTextBoxColumn.Name = "submitDateDataGridViewTextBoxColumn";
            this.submitDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.submitDateDataGridViewTextBoxColumn.Width = 61;
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
            // leaderAuditDataGridViewTextBoxColumn
            // 
            this.leaderAuditDataGridViewTextBoxColumn.DataPropertyName = "LeaderAudit";
            this.leaderAuditDataGridViewTextBoxColumn.HeaderText = "领导审核人";
            this.leaderAuditDataGridViewTextBoxColumn.Name = "leaderAuditDataGridViewTextBoxColumn";
            this.leaderAuditDataGridViewTextBoxColumn.ReadOnly = true;
            this.leaderAuditDataGridViewTextBoxColumn.Width = 72;
            // 
            // leaderDateDataGridViewTextBoxColumn
            // 
            this.leaderDateDataGridViewTextBoxColumn.DataPropertyName = "LeaderDate";
            this.leaderDateDataGridViewTextBoxColumn.HeaderText = "领导审核日期";
            this.leaderDateDataGridViewTextBoxColumn.Name = "leaderDateDataGridViewTextBoxColumn";
            this.leaderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.leaderDateDataGridViewTextBoxColumn.Width = 72;
            // 
            // keeperAuditDataGridViewTextBoxColumn
            // 
            this.keeperAuditDataGridViewTextBoxColumn.DataPropertyName = "KeeperAudit";
            this.keeperAuditDataGridViewTextBoxColumn.HeaderText = "库管审核人";
            this.keeperAuditDataGridViewTextBoxColumn.Name = "keeperAuditDataGridViewTextBoxColumn";
            this.keeperAuditDataGridViewTextBoxColumn.ReadOnly = true;
            this.keeperAuditDataGridViewTextBoxColumn.Width = 72;
            // 
            // keeperDateDataGridViewTextBoxColumn
            // 
            this.keeperDateDataGridViewTextBoxColumn.DataPropertyName = "KeeperDate";
            this.keeperDateDataGridViewTextBoxColumn.HeaderText = "库管审核日期";
            this.keeperDateDataGridViewTextBoxColumn.Name = "keeperDateDataGridViewTextBoxColumn";
            this.keeperDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.keeperDateDataGridViewTextBoxColumn.Width = 72;
            // 
            // stockOutNoDataGridViewTextBoxColumn
            // 
            this.stockOutNoDataGridViewTextBoxColumn.DataPropertyName = "StockOutNo";
            this.stockOutNoDataGridViewTextBoxColumn.HeaderText = "出库单号";
            this.stockOutNoDataGridViewTextBoxColumn.Name = "stockOutNoDataGridViewTextBoxColumn";
            this.stockOutNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockOutNoDataGridViewTextBoxColumn.Width = 61;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 51;
            // 
            // tStockOutBindingSource
            // 
            this.tStockOutBindingSource.DataMember = "T_StockOut";
            this.tStockOutBindingSource.DataSource = this.dataSetStockOut;
            // 
            // dataSetStockOut
            // 
            this.dataSetStockOut.DataSetName = "DataSetStockOut";
            this.dataSetStockOut.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_StockOutTableAdapter
            // 
            this.t_StockOutTableAdapter.ClearBeforeFill = true;
            // 
            // 出库申请
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.dgvStockOut);
            this.Controls.Add(this.groupBox1);
            this.Name = "出库申请";
            this.Load += new System.EventHandler(this.出库申请_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvStockOut, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStockOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStockOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.LinkLabel llAddStockOut;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStockOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settlementModesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessAuditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderAuditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keeperAuditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keeperDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOutNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tStockOutBindingSource;
        private DAL.DataSetStockOut dataSetStockOut;
        private DAL.DataSetStockOutTableAdapters.T_StockOutTableAdapter t_StockOutTableAdapter;
    }
}
