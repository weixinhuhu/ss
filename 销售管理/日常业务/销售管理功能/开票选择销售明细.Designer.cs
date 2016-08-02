namespace 销售管理.日常业务
{
    partial class 开票选择销售明细
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
            this.ColSaleDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStockOutNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCanInvoice = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtAmout = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSaleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.dgvCustomerSaleDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvInvoiceDetails, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1239, 576);
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
            this.dgvCustomerSaleDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvCustomerSaleDetails.MultiSelect = false;
            this.dgvCustomerSaleDetails.Name = "dgvCustomerSaleDetails";
            this.dgvCustomerSaleDetails.ReadOnly = true;
            this.dgvCustomerSaleDetails.RowTemplate.Height = 23;
            this.dgvCustomerSaleDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerSaleDetails.Size = new System.Drawing.Size(1233, 397);
            this.dgvCustomerSaleDetails.TabIndex = 5;
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
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(3, 452);
            this.dgvInvoiceDetails.MultiSelect = false;
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.ReadOnly = true;
            this.dgvInvoiceDetails.RowTemplate.Height = 23;
            this.dgvInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(1233, 121);
            this.dgvInvoiceDetails.TabIndex = 4;
            this.dgvInvoiceDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceDetails_CellClick);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnFiter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.cmbCanInvoice);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.txtAmout);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 40);
            this.panel1.TabIndex = 6;
            // 
            // cmbCanInvoice
            // 
            this.cmbCanInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCanInvoice.FormattingEnabled = true;
            this.cmbCanInvoice.Items.AddRange(new object[] {
            "所有",
            "可开票",
            "不可开票"});
            this.cmbCanInvoice.Location = new System.Drawing.Point(487, 16);
            this.cmbCanInvoice.Name = "cmbCanInvoice";
            this.cmbCanInvoice.Size = new System.Drawing.Size(121, 20);
            this.cmbCanInvoice.TabIndex = 10;
            this.cmbCanInvoice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(361, 14);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "确定";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtAmout
            // 
            this.txtAmout.Location = new System.Drawing.Point(80, 16);
            this.txtAmout.Name = "txtAmout";
            this.txtAmout.Size = new System.Drawing.Size(100, 21);
            this.txtAmout.TabIndex = 8;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(267, 14);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "↑";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "↓";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "数量";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(688, 16);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(125, 21);
            this.txtProductName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "产品名称";
            // 
            // btnFiter
            // 
            this.btnFiter.Location = new System.Drawing.Point(825, 14);
            this.btnFiter.Name = "btnFiter";
            this.btnFiter.Size = new System.Drawing.Size(71, 22);
            this.btnFiter.TabIndex = 13;
            this.btnFiter.Text = "筛选";
            this.btnFiter.UseVisualStyleBackColor = true;
            this.btnFiter.Click += new System.EventHandler(this.btnFiter_Click);
            // 
            // 开票选择销售明细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "开票选择销售明细";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "开票选择销售明细";
            this.Load += new System.EventHandler(this.开票选择销售明细_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSaleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvCustomerSaleDetails;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAmout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnApply;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaleDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockOutNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaleDate;
        private System.Windows.Forms.ComboBox cmbCanInvoice;
        private System.Windows.Forms.Button btnFiter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;

    }
}