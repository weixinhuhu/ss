namespace 销售管理.日常业务.供应商管理
{
    partial class 采购物品详细
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(采购物品详细));
            this.labContractNum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb到货记录 = new System.Windows.Forms.ToolStripButton();
            this.tsb到票记录 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb到货 = new System.Windows.Forms.ToolStripButton();
            this.tsb到票 = new System.Windows.Forms.ToolStripButton();
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
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCG)).BeginInit();
            this.SuspendLayout();
            // 
            // labContractNum
            // 
            this.labContractNum.AutoSize = true;
            this.labContractNum.BackColor = System.Drawing.Color.Transparent;
            this.labContractNum.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labContractNum.Location = new System.Drawing.Point(57, 38);
            this.labContractNum.Name = "labContractNum";
            this.labContractNum.Size = new System.Drawing.Size(125, 21);
            this.labContractNum.TabIndex = 0;
            this.labContractNum.Text = "合同编号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.dgvDCG);
            this.groupBox1.Location = new System.Drawing.Point(29, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采购物品";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb到货记录,
            this.tsb到票记录,
            this.toolStripSeparator1,
            this.tsb到货,
            this.tsb到票});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(698, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb到货记录
            // 
            this.tsb到货记录.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb到货记录.Image = ((System.Drawing.Image)(resources.GetObject("tsb到货记录.Image")));
            this.tsb到货记录.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb到货记录.Name = "tsb到货记录";
            this.tsb到货记录.Size = new System.Drawing.Size(60, 22);
            this.tsb到货记录.Text = "到货记录";
            this.tsb到货记录.Click += new System.EventHandler(this.tsb到货记录_Click);
            // 
            // tsb到票记录
            // 
            this.tsb到票记录.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb到票记录.Image = ((System.Drawing.Image)(resources.GetObject("tsb到票记录.Image")));
            this.tsb到票记录.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb到票记录.Name = "tsb到票记录";
            this.tsb到票记录.Size = new System.Drawing.Size(60, 22);
            this.tsb到票记录.Text = "到票记录";
            this.tsb到票记录.Click += new System.EventHandler(this.tsb到票记录_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb到货
            // 
            this.tsb到货.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb到货.Image = ((System.Drawing.Image)(resources.GetObject("tsb到货.Image")));
            this.tsb到货.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb到货.Name = "tsb到货";
            this.tsb到货.Size = new System.Drawing.Size(36, 22);
            this.tsb到货.Text = "到货";
            this.tsb到货.Click += new System.EventHandler(this.tsb到货_Click);
            // 
            // tsb到票
            // 
            this.tsb到票.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb到票.Image = ((System.Drawing.Image)(resources.GetObject("tsb到票.Image")));
            this.tsb到票.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb到票.Name = "tsb到票";
            this.tsb到票.Size = new System.Drawing.Size(36, 22);
            this.tsb到票.Text = "到票";
            this.tsb到票.Click += new System.EventHandler(this.tsb到票_Click);
            // 
            // dgvDCG
            // 
            this.dgvDCG.AllowUserToAddRows = false;
            this.dgvDCG.AllowUserToDeleteRows = false;
            this.dgvDCG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvDCG.Location = new System.Drawing.Point(3, 42);
            this.dgvDCG.Name = "dgvDCG";
            this.dgvDCG.ReadOnly = true;
            this.dgvDCG.RowTemplate.Height = 23;
            this.dgvDCG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDCG.Size = new System.Drawing.Size(698, 308);
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
            // 采购物品详细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(759, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labContractNum);
            this.Name = "采购物品详细";
            this.Text = "采购物品详细";
            this.Load += new System.EventHandler(this.采购物品详细_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labContractNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDCG;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb到货记录;
        private System.Windows.Forms.ToolStripButton tsb到票记录;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb到货;
        private System.Windows.Forms.ToolStripButton tsb到票;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg物品编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg物品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg采购数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg已到货数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg已到票数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg已报销数量;
    }
}
