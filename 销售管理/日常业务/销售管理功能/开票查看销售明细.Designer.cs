namespace 销售管理.日常业务
{
    partial class 开票查看销售明细
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCustomerSaleDetails = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHasInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoicing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCanInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockOutNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColSaleDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStockOutNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSaleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCustomerSaleDetails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvInvoiceDetails, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvCustomerSaleDetails
            // 
            this.dgvCustomerSaleDetails.AllowUserToAddRows = false;
            this.dgvCustomerSaleDetails.AllowUserToDeleteRows = false;
            this.dgvCustomerSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerSaleDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnUsername,
            this.ColumnCustomerName,
            this.ColumnProductName,
            this.ColumnPrice,
            this.ColumnAmount,
            this.ColumnSumMoney,
            this.ColumnHasInvoice,
            this.ColumnInvoicing,
            this.ColumnCanInvoice,
            this.ColumnSaleDate,
            this.ColumnStockOutNo});
            this.dgvCustomerSaleDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerSaleDetails.Location = new System.Drawing.Point(3, 243);
            this.dgvCustomerSaleDetails.MultiSelect = false;
            this.dgvCustomerSaleDetails.Name = "dgvCustomerSaleDetails";
            this.dgvCustomerSaleDetails.ReadOnly = true;
            this.dgvCustomerSaleDetails.RowTemplate.Height = 23;
            this.dgvCustomerSaleDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerSaleDetails.Size = new System.Drawing.Size(981, 235);
            this.dgvCustomerSaleDetails.TabIndex = 6;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id";
            this.ColumnId.HeaderText = "编号";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 60;
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.DataPropertyName = "username";
            this.ColumnUsername.HeaderText = "销售名称";
            this.ColumnUsername.Name = "ColumnUsername";
            this.ColumnUsername.ReadOnly = true;
            // 
            // ColumnCustomerName
            // 
            this.ColumnCustomerName.DataPropertyName = "customername";
            this.ColumnCustomerName.HeaderText = "客户名称";
            this.ColumnCustomerName.Name = "ColumnCustomerName";
            this.ColumnCustomerName.ReadOnly = true;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.DataPropertyName = "productname";
            this.ColumnProductName.HeaderText = "产品名称";
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "price";
            this.ColumnPrice.HeaderText = "单价";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.DataPropertyName = "amount";
            this.ColumnAmount.HeaderText = "数量";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            // 
            // ColumnSumMoney
            // 
            this.ColumnSumMoney.DataPropertyName = "summoney";
            this.ColumnSumMoney.HeaderText = "金额";
            this.ColumnSumMoney.Name = "ColumnSumMoney";
            this.ColumnSumMoney.ReadOnly = true;
            // 
            // ColumnHasInvoice
            // 
            this.ColumnHasInvoice.DataPropertyName = "hasinvoice";
            this.ColumnHasInvoice.HeaderText = "已开数量";
            this.ColumnHasInvoice.Name = "ColumnHasInvoice";
            this.ColumnHasInvoice.ReadOnly = true;
            // 
            // ColumnInvoicing
            // 
            this.ColumnInvoicing.DataPropertyName = "invoicing";
            this.ColumnInvoicing.HeaderText = "审核中";
            this.ColumnInvoicing.Name = "ColumnInvoicing";
            this.ColumnInvoicing.ReadOnly = true;
            // 
            // ColumnCanInvoice
            // 
            this.ColumnCanInvoice.DataPropertyName = "caninvoice";
            this.ColumnCanInvoice.HeaderText = "剩余可开数量";
            this.ColumnCanInvoice.Name = "ColumnCanInvoice";
            this.ColumnCanInvoice.ReadOnly = true;
            // 
            // ColumnSaleDate
            // 
            this.ColumnSaleDate.DataPropertyName = "saledate";
            this.ColumnSaleDate.HeaderText = "销售日期";
            this.ColumnSaleDate.Name = "ColumnSaleDate";
            this.ColumnSaleDate.ReadOnly = true;
            // 
            // ColumnStockOutNo
            // 
            this.ColumnStockOutNo.DataPropertyName = "StockOutNo";
            this.ColumnStockOutNo.HeaderText = "出库单编号";
            this.ColumnStockOutNo.Name = "ColumnStockOutNo";
            this.ColumnStockOutNo.ReadOnly = true;
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.AllowUserToAddRows = false;
            this.dgvInvoiceDetails.AllowUserToDeleteRows = false;
            this.dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSaleDetailsId,
            this.ColProductName,
            this.ColPrice,
            this.ColAmount,
            this.ColSumMoney,
            this.ColStockOutNo,
            this.ColSaleDate});
            this.dgvInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvInvoiceDetails.MultiSelect = false;
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.ReadOnly = true;
            this.dgvInvoiceDetails.RowTemplate.Height = 23;
            this.dgvInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(981, 234);
            this.dgvInvoiceDetails.TabIndex = 5;
            this.dgvInvoiceDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceDetails_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSum);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(314, 25);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(66, 21);
            this.txtSum.TabIndex = 101;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(242, 25);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(66, 21);
            this.txtNum.TabIndex = 100;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(169, 25);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(66, 21);
            this.txtPrice.TabIndex = 99;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 25);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(81, 21);
            this.txtName.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 97;
            this.label8.Text = "金额";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 96;
            this.label6.Text = "数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 95;
            this.label5.Text = "单价";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 94;
            this.label4.Text = "名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 102;
            this.label1.Text = "第1项";
            // 
            // ColSaleDetailsId
            // 
            this.ColSaleDetailsId.HeaderText = "编号";
            this.ColSaleDetailsId.Name = "ColSaleDetailsId";
            this.ColSaleDetailsId.ReadOnly = true;
            this.ColSaleDetailsId.Width = 60;
            // 
            // ColProductName
            // 
            this.ColProductName.HeaderText = "产品名称";
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.ReadOnly = true;
            this.ColProductName.Visible = false;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "单价";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            // 
            // ColAmount
            // 
            this.ColAmount.HeaderText = "数量";
            this.ColAmount.Name = "ColAmount";
            this.ColAmount.ReadOnly = true;
            // 
            // ColSumMoney
            // 
            this.ColSumMoney.HeaderText = "金额";
            this.ColSumMoney.Name = "ColSumMoney";
            this.ColSumMoney.ReadOnly = true;
            // 
            // ColStockOutNo
            // 
            this.ColStockOutNo.HeaderText = "出库单编号";
            this.ColStockOutNo.Name = "ColStockOutNo";
            this.ColStockOutNo.ReadOnly = true;
            // 
            // ColSaleDate
            // 
            this.ColSaleDate.HeaderText = "销售日期";
            this.ColSaleDate.Name = "ColSaleDate";
            this.ColSaleDate.ReadOnly = true;
            this.ColSaleDate.Visible = false;
            // 
            // 开票查看销售明细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "开票查看销售明细";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "开票查看销售明细";
            this.Load += new System.EventHandler(this.开票查看销售明细_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSaleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.DataGridView dgvCustomerSaleDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHasInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoicing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCanInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockOutNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSum;
        public System.Windows.Forms.TextBox txtNum;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaleDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockOutNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaleDate;
    }
}