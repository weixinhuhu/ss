namespace 销售管理.日常业务.供应商管理
{
    partial class 采购报销
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDCG = new System.Windows.Forms.DataGridView();
            this.dcgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg物品编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg物品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg采购数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg已到货数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg已到票数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg已报销数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labContractNum = new System.Windows.Forms.Label();
            this.labSupplierName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpenseNum = new System.Windows.Forms.TextBox();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.btnExpense = new System.Windows.Forms.Button();
            this.labSum = new System.Windows.Forms.Label();
            this.expense删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.daExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daExpenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvDCG);
            this.groupBox1.Location = new System.Drawing.Point(39, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 232);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采购物品";
            // 
            // dgvDCG
            // 
            this.dgvDCG.AllowUserToAddRows = false;
            this.dgvDCG.AllowUserToDeleteRows = false;
            this.dgvDCG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDCG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDCG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcgID,
            this.dcg物品编码,
            this.dcg物品名称,
            this.dcg单价,
            this.dcg采购数量,
            this.dcg金额,
            this.dcg已到货数量,
            this.dcg已到票数量,
            this.dcg已报销数量});
            this.dgvDCG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDCG.Location = new System.Drawing.Point(3, 17);
            this.dgvDCG.Name = "dgvDCG";
            this.dgvDCG.ReadOnly = true;
            this.dgvDCG.RowTemplate.Height = 23;
            this.dgvDCG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDCG.Size = new System.Drawing.Size(720, 212);
            this.dgvDCG.TabIndex = 0;
            // 
            // dcgID
            // 
            this.dcgID.DataPropertyName = "IntID";
            this.dcgID.HeaderText = "ID";
            this.dcgID.Name = "dcgID";
            this.dcgID.ReadOnly = true;
            this.dcgID.Visible = false;
            this.dcgID.Width = 42;
            // 
            // dcg物品编码
            // 
            this.dcg物品编码.DataPropertyName = "VcNum";
            this.dcg物品编码.HeaderText = "物品编码";
            this.dcg物品编码.Name = "dcg物品编码";
            this.dcg物品编码.ReadOnly = true;
            this.dcg物品编码.Width = 78;
            // 
            // dcg物品名称
            // 
            this.dcg物品名称.DataPropertyName = "VcName";
            this.dcg物品名称.HeaderText = "物品名称";
            this.dcg物品名称.Name = "dcg物品名称";
            this.dcg物品名称.ReadOnly = true;
            this.dcg物品名称.Width = 78;
            // 
            // dcg单价
            // 
            this.dcg单价.DataPropertyName = "MonPrice";
            this.dcg单价.HeaderText = "单价";
            this.dcg单价.Name = "dcg单价";
            this.dcg单价.ReadOnly = true;
            this.dcg单价.Width = 54;
            // 
            // dcg采购数量
            // 
            this.dcg采购数量.DataPropertyName = "NumCount";
            this.dcg采购数量.HeaderText = "采购数量";
            this.dcg采购数量.Name = "dcg采购数量";
            this.dcg采购数量.ReadOnly = true;
            this.dcg采购数量.Width = 78;
            // 
            // dcg金额
            // 
            this.dcg金额.DataPropertyName = "MonSum";
            this.dcg金额.HeaderText = "金额";
            this.dcg金额.Name = "dcg金额";
            this.dcg金额.ReadOnly = true;
            this.dcg金额.Width = 54;
            // 
            // dcg已到货数量
            // 
            this.dcg已到货数量.DataPropertyName = "StockInSum";
            this.dcg已到货数量.HeaderText = "已到货数量";
            this.dcg已到货数量.Name = "dcg已到货数量";
            this.dcg已到货数量.ReadOnly = true;
            this.dcg已到货数量.Width = 90;
            // 
            // dcg已到票数量
            // 
            this.dcg已到票数量.DataPropertyName = "InvoiceSum";
            this.dcg已到票数量.HeaderText = "已到票数量";
            this.dcg已到票数量.Name = "dcg已到票数量";
            this.dcg已到票数量.ReadOnly = true;
            this.dcg已到票数量.Width = 90;
            // 
            // dcg已报销数量
            // 
            this.dcg已报销数量.DataPropertyName = "expenseSum";
            this.dcg已报销数量.HeaderText = "已报销数量";
            this.dcg已报销数量.Name = "dcg已报销数量";
            this.dcg已报销数量.ReadOnly = true;
            this.dcg已报销数量.Width = 90;
            // 
            // labContractNum
            // 
            this.labContractNum.AutoSize = true;
            this.labContractNum.BackColor = System.Drawing.Color.Transparent;
            this.labContractNum.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labContractNum.Location = new System.Drawing.Point(67, 20);
            this.labContractNum.Name = "labContractNum";
            this.labContractNum.Size = new System.Drawing.Size(125, 21);
            this.labContractNum.TabIndex = 2;
            this.labContractNum.Text = "合同编号：";
            // 
            // labSupplierName
            // 
            this.labSupplierName.AutoSize = true;
            this.labSupplierName.BackColor = System.Drawing.Color.Transparent;
            this.labSupplierName.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSupplierName.Location = new System.Drawing.Point(348, 20);
            this.labSupplierName.Name = "labSupplierName";
            this.labSupplierName.Size = new System.Drawing.Size(102, 21);
            this.labSupplierName.TabIndex = 2;
            this.labSupplierName.Text = "供应商：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(261, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "↓";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(69, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "报销数量";
            // 
            // txtExpenseNum
            // 
            this.txtExpenseNum.Location = new System.Drawing.Point(128, 296);
            this.txtExpenseNum.Name = "txtExpenseNum";
            this.txtExpenseNum.Size = new System.Drawing.Size(127, 21);
            this.txtExpenseNum.TabIndex = 6;
            // 
            // dgvExpense
            // 
            this.dgvExpense.AllowUserToAddRows = false;
            this.dgvExpense.AllowUserToDeleteRows = false;
            this.dgvExpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expense删除});
            this.dgvExpense.Location = new System.Drawing.Point(39, 323);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.ReadOnly = true;
            this.dgvExpense.RowTemplate.Height = 23;
            this.dgvExpense.Size = new System.Drawing.Size(723, 123);
            this.dgvExpense.TabIndex = 7;
            this.dgvExpense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpense_CellClick);
            // 
            // btnExpense
            // 
            this.btnExpense.Location = new System.Drawing.Point(690, 294);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(75, 23);
            this.btnExpense.TabIndex = 4;
            this.btnExpense.Text = "报销";
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // labSum
            // 
            this.labSum.AutoSize = true;
            this.labSum.BackColor = System.Drawing.Color.Transparent;
            this.labSum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSum.ForeColor = System.Drawing.Color.Red;
            this.labSum.Location = new System.Drawing.Point(349, 296);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(127, 16);
            this.labSum.TabIndex = 8;
            this.labSum.Text = "本次报销合计：";
            // 
            // expense删除
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "删除";
            this.expense删除.DefaultCellStyle = dataGridViewCellStyle1;
            this.expense删除.HeaderText = "删除";
            this.expense删除.Name = "expense删除";
            this.expense删除.ReadOnly = true;
            this.expense删除.Width = 35;
            // 
            // 采购报销
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(802, 484);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.dgvExpense);
            this.Controls.Add(this.txtExpenseNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labSupplierName);
            this.Controls.Add(this.labContractNum);
            this.Name = "采购报销";
            this.Text = "报销";
            this.Load += new System.EventHandler(this.采购报销_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daExpenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDCG;
        private System.Windows.Forms.Label labContractNum;
        private System.Windows.Forms.Label labSupplierName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpenseNum;
        private System.Windows.Forms.DataGridView dgvExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg物品编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg物品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg采购数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg已到货数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg已到票数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg已报销数量;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.DataGridViewButtonColumn expense删除;
        private System.Windows.Forms.BindingSource daExpenseBindingSource;
    }
}
