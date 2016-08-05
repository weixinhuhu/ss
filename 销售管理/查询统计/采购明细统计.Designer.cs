namespace 销售管理.查询统计
{
    partial class 采购明细统计
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
            this.DaPurchaseContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDaPurchaseContract = new System.Windows.Forms.DataGridView();
            this.dpc录入时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc物料编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc采购物品 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc规格型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc供应商长代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc供应商名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc单据号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc币别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc发票单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc发票数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc不含税单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc不含税合计 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc含税合计 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc入库单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc入库数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc入库单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpc入库金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGoodsNumStart = new System.Windows.Forms.TextBox();
            this.txtGoodsNumEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierNumEnd = new System.Windows.Forms.TextBox();
            this.txtSupplierNumStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DaPurchaseContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaPurchaseContract)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvDaPurchaseContract
            // 
            this.dgvDaPurchaseContract.AllowUserToAddRows = false;
            this.dgvDaPurchaseContract.AllowUserToDeleteRows = false;
            this.dgvDaPurchaseContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDaPurchaseContract.AutoGenerateColumns = false;
            this.dgvDaPurchaseContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaPurchaseContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDaPurchaseContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dpc录入时间,
            this.dpc物料编号,
            this.dpc采购物品,
            this.dpc规格型号,
            this.dpc供应商长代码,
            this.dpc供应商名称,
            this.dpc单据号码,
            this.dpc币别,
            this.dpc发票单位,
            this.dpc发票数量,
            this.dpc不含税单价,
            this.dpc不含税合计,
            this.dpc含税合计,
            this.dpc入库单位,
            this.dpc入库数量,
            this.dpc入库单价,
            this.dpc入库金额});
            this.dgvDaPurchaseContract.DataSource = this.DaPurchaseContractBindingSource;
            this.dgvDaPurchaseContract.Location = new System.Drawing.Point(46, 145);
            this.dgvDaPurchaseContract.Name = "dgvDaPurchaseContract";
            this.dgvDaPurchaseContract.ReadOnly = true;
            this.dgvDaPurchaseContract.RowTemplate.Height = 23;
            this.dgvDaPurchaseContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaPurchaseContract.Size = new System.Drawing.Size(910, 497);
            this.dgvDaPurchaseContract.TabIndex = 4;
            // 
            // dpc录入时间
            // 
            this.dpc录入时间.DataPropertyName = "日期";
            this.dpc录入时间.HeaderText = "时间";
            this.dpc录入时间.Name = "dpc录入时间";
            this.dpc录入时间.ReadOnly = true;
            this.dpc录入时间.Width = 54;
            // 
            // dpc物料编号
            // 
            this.dpc物料编号.DataPropertyName = "物料代码";
            this.dpc物料编号.HeaderText = "物料代码";
            this.dpc物料编号.Name = "dpc物料编号";
            this.dpc物料编号.ReadOnly = true;
            this.dpc物料编号.Width = 78;
            // 
            // dpc采购物品
            // 
            this.dpc采购物品.DataPropertyName = "物料名称";
            this.dpc采购物品.HeaderText = "物料名称";
            this.dpc采购物品.Name = "dpc采购物品";
            this.dpc采购物品.ReadOnly = true;
            this.dpc采购物品.Width = 78;
            // 
            // dpc规格型号
            // 
            this.dpc规格型号.DataPropertyName = "规格型号";
            this.dpc规格型号.HeaderText = "规格型号";
            this.dpc规格型号.Name = "dpc规格型号";
            this.dpc规格型号.ReadOnly = true;
            this.dpc规格型号.Width = 78;
            // 
            // dpc供应商长代码
            // 
            this.dpc供应商长代码.DataPropertyName = "供应商长代码";
            this.dpc供应商长代码.HeaderText = "供应商长代码";
            this.dpc供应商长代码.Name = "dpc供应商长代码";
            this.dpc供应商长代码.ReadOnly = true;
            this.dpc供应商长代码.Width = 102;
            // 
            // dpc供应商名称
            // 
            this.dpc供应商名称.DataPropertyName = "供应商名称";
            this.dpc供应商名称.HeaderText = "供应商名称";
            this.dpc供应商名称.Name = "dpc供应商名称";
            this.dpc供应商名称.ReadOnly = true;
            this.dpc供应商名称.Width = 90;
            // 
            // dpc单据号码
            // 
            this.dpc单据号码.DataPropertyName = "单据号码";
            this.dpc单据号码.HeaderText = "单据号码";
            this.dpc单据号码.Name = "dpc单据号码";
            this.dpc单据号码.ReadOnly = true;
            this.dpc单据号码.Width = 78;
            // 
            // dpc币别
            // 
            this.dpc币别.DataPropertyName = "币别";
            this.dpc币别.HeaderText = "币别";
            this.dpc币别.Name = "dpc币别";
            this.dpc币别.ReadOnly = true;
            this.dpc币别.Width = 54;
            // 
            // dpc发票单位
            // 
            this.dpc发票单位.DataPropertyName = "发票单位";
            this.dpc发票单位.HeaderText = "发票单位";
            this.dpc发票单位.Name = "dpc发票单位";
            this.dpc发票单位.ReadOnly = true;
            this.dpc发票单位.Width = 78;
            // 
            // dpc发票数量
            // 
            this.dpc发票数量.DataPropertyName = "发票数量";
            this.dpc发票数量.HeaderText = "发票数量";
            this.dpc发票数量.Name = "dpc发票数量";
            this.dpc发票数量.ReadOnly = true;
            this.dpc发票数量.Width = 78;
            // 
            // dpc不含税单价
            // 
            this.dpc不含税单价.DataPropertyName = "不含税单价";
            this.dpc不含税单价.HeaderText = "不含税单价";
            this.dpc不含税单价.Name = "dpc不含税单价";
            this.dpc不含税单价.ReadOnly = true;
            this.dpc不含税单价.Width = 90;
            // 
            // dpc不含税合计
            // 
            this.dpc不含税合计.DataPropertyName = "不含税合计";
            this.dpc不含税合计.HeaderText = "不含税合计";
            this.dpc不含税合计.Name = "dpc不含税合计";
            this.dpc不含税合计.ReadOnly = true;
            this.dpc不含税合计.Width = 90;
            // 
            // dpc含税合计
            // 
            this.dpc含税合计.DataPropertyName = "含税合计";
            this.dpc含税合计.HeaderText = "含税合计";
            this.dpc含税合计.Name = "dpc含税合计";
            this.dpc含税合计.ReadOnly = true;
            this.dpc含税合计.Width = 78;
            // 
            // dpc入库单位
            // 
            this.dpc入库单位.DataPropertyName = "入库单位";
            this.dpc入库单位.HeaderText = "入库单位";
            this.dpc入库单位.Name = "dpc入库单位";
            this.dpc入库单位.ReadOnly = true;
            this.dpc入库单位.Width = 78;
            // 
            // dpc入库数量
            // 
            this.dpc入库数量.DataPropertyName = "入库数量";
            this.dpc入库数量.HeaderText = "入库数量";
            this.dpc入库数量.Name = "dpc入库数量";
            this.dpc入库数量.ReadOnly = true;
            this.dpc入库数量.Width = 78;
            // 
            // dpc入库单价
            // 
            this.dpc入库单价.DataPropertyName = "入库单价";
            this.dpc入库单价.HeaderText = "入库单价";
            this.dpc入库单价.Name = "dpc入库单价";
            this.dpc入库单价.ReadOnly = true;
            this.dpc入库单价.Width = 78;
            // 
            // dpc入库金额
            // 
            this.dpc入库金额.DataPropertyName = "入库金额";
            this.dpc入库金额.HeaderText = "入库金额";
            this.dpc入库金额.Name = "dpc入库金额";
            this.dpc入库金额.ReadOnly = true;
            this.dpc入库金额.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "物品代码";
            // 
            // txtGoodsNumStart
            // 
            this.txtGoodsNumStart.Location = new System.Drawing.Point(103, 46);
            this.txtGoodsNumStart.Name = "txtGoodsNumStart";
            this.txtGoodsNumStart.Size = new System.Drawing.Size(109, 21);
            this.txtGoodsNumStart.TabIndex = 6;
            // 
            // txtGoodsNumEnd
            // 
            this.txtGoodsNumEnd.Location = new System.Drawing.Point(103, 84);
            this.txtGoodsNumEnd.Name = "txtGoodsNumEnd";
            this.txtGoodsNumEnd.Size = new System.Drawing.Size(109, 21);
            this.txtGoodsNumEnd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "--";
            // 
            // txtSupplierNumEnd
            // 
            this.txtSupplierNumEnd.Location = new System.Drawing.Point(294, 84);
            this.txtSupplierNumEnd.Name = "txtSupplierNumEnd";
            this.txtSupplierNumEnd.Size = new System.Drawing.Size(109, 21);
            this.txtSupplierNumEnd.TabIndex = 9;
            // 
            // txtSupplierNumStart
            // 
            this.txtSupplierNumStart.Location = new System.Drawing.Point(294, 46);
            this.txtSupplierNumStart.Name = "txtSupplierNumStart";
            this.txtSupplierNumStart.Size = new System.Drawing.Size(109, 21);
            this.txtSupplierNumStart.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "供应商代码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "采购类型";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "全部",
            "外购入库",
            "委外加工"});
            this.cmbType.Location = new System.Drawing.Point(481, 46);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(95, 20);
            this.cmbType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "时间";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(625, 46);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowCheckBox = true;
            this.dtpStart.Size = new System.Drawing.Size(174, 21);
            this.dtpStart.TabIndex = 12;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(625, 81);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(174, 21);
            this.dtpEnd.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "--";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(841, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 24);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(841, 81);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(88, 24);
            this.btnExcel.TabIndex = 13;
            this.btnExcel.Text = "导出到EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "录入人";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Items.AddRange(new object[] {
            "全部",
            "外购入库",
            "委外加工"});
            this.cmbUsers.Location = new System.Drawing.Point(481, 85);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(95, 20);
            this.cmbUsers.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "物品名称";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(103, 114);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(300, 21);
            this.txtGoodsName.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "供应商代码";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(481, 117);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(318, 21);
            this.txtSupplierName.TabIndex = 9;
            // 
            // 采购明细统计
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierNumEnd);
            this.Controls.Add(this.txtSupplierNumStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.txtGoodsNumEnd);
            this.Controls.Add(this.txtGoodsNumStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDaPurchaseContract);
            this.Name = "采购明细统计";
            this.Load += new System.EventHandler(this.采购明细统计_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvDaPurchaseContract, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtGoodsNumStart, 0);
            this.Controls.SetChildIndex(this.txtGoodsNumEnd, 0);
            this.Controls.SetChildIndex(this.txtGoodsName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtSupplierNumStart, 0);
            this.Controls.SetChildIndex(this.txtSupplierNumEnd, 0);
            this.Controls.SetChildIndex(this.txtSupplierName, 0);
            this.Controls.SetChildIndex(this.cmbType, 0);
            this.Controls.SetChildIndex(this.cmbUsers, 0);
            this.Controls.SetChildIndex(this.dtpStart, 0);
            this.Controls.SetChildIndex(this.dtpEnd, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnExcel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DaPurchaseContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaPurchaseContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource DaPurchaseContractBindingSource;
        private System.Windows.Forms.DataGridView dgvDaPurchaseContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGoodsNumStart;
        private System.Windows.Forms.TextBox txtGoodsNumEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierNumEnd;
        private System.Windows.Forms.TextBox txtSupplierNumStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc录入时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc物料编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc采购物品;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc规格型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc供应商长代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc供应商名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc单据号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc币别;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc发票单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc发票数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc不含税单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc不含税合计;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc含税合计;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc入库单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc入库数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc入库单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpc入库金额;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSupplierName;
    }
}
