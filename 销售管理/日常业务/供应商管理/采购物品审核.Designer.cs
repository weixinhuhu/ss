namespace 销售管理.日常业务.供应商管理
{
    partial class 采购物品审核
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
            this.dgvDCG = new System.Windows.Forms.DataGridView();
            this.labContractNum = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDCGH = new System.Windows.Forms.DataGridView();
            this.CGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CGHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labSupplierName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCG)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvDCG);
            this.groupBox1.Location = new System.Drawing.Point(19, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 286);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采购物品";
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
            this.dgvDCG.Location = new System.Drawing.Point(3, 14);
            this.dgvDCG.Name = "dgvDCG";
            this.dgvDCG.ReadOnly = true;
            this.dgvDCG.RowTemplate.Height = 23;
            this.dgvDCG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDCG.Size = new System.Drawing.Size(698, 269);
            this.dgvDCG.TabIndex = 0;
            this.dgvDCG.SelectionChanged += new System.EventHandler(this.dgvDCG_SelectionChanged);
            // 
            // labContractNum
            // 
            this.labContractNum.AutoSize = true;
            this.labContractNum.BackColor = System.Drawing.Color.Transparent;
            this.labContractNum.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labContractNum.Location = new System.Drawing.Point(45, 9);
            this.labContractNum.Name = "labContractNum";
            this.labContractNum.Size = new System.Drawing.Size(125, 21);
            this.labContractNum.TabIndex = 2;
            this.labContractNum.Text = "合同编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvDCGH);
            this.groupBox2.Location = new System.Drawing.Point(19, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 173);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "历史采购记录";
            // 
            // dgvDCGH
            // 
            this.dgvDCGH.AllowUserToAddRows = false;
            this.dgvDCGH.AllowUserToDeleteRows = false;
            this.dgvDCGH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDCGH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDCGH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDCGH.Location = new System.Drawing.Point(3, 14);
            this.dgvDCGH.Name = "dgvDCGH";
            this.dgvDCGH.ReadOnly = true;
            this.dgvDCGH.RowTemplate.Height = 23;
            this.dgvDCGH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDCGH.Size = new System.Drawing.Size(698, 156);
            this.dgvDCGH.TabIndex = 0;
            // 
            // labSupplierName
            // 
            this.labSupplierName.AutoSize = true;
            this.labSupplierName.BackColor = System.Drawing.Color.Transparent;
            this.labSupplierName.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSupplierName.Location = new System.Drawing.Point(301, 11);
            this.labSupplierName.Name = "labSupplierName";
            this.labSupplierName.Size = new System.Drawing.Size(102, 21);
            this.labSupplierName.TabIndex = 4;
            this.labSupplierName.Text = "供应商：";
            // 
            // 采购物品审核
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(745, 525);
            this.Controls.Add(this.labSupplierName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labContractNum);
            this.Name = "采购物品审核";
            this.Text = "采购物品详细";
            this.Load += new System.EventHandler(this.采购物品审核_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDCG;
        private System.Windows.Forms.Label labContractNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDCGH;
        private System.Windows.Forms.BindingSource CGBindingSource;
        private System.Windows.Forms.BindingSource CGHBindingSource;
        private System.Windows.Forms.Label labSupplierName;
    }
}
