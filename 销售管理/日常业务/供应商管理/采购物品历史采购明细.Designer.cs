namespace 销售管理.日常业务.供应商管理
{
    partial class 采购物品历史采购明细
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDCGH = new System.Windows.Forms.DataGridView();
            this.bsHistory = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvDCGH);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 435);
            this.groupBox2.TabIndex = 4;
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
            this.dgvDCGH.AutoGenerateColumns = false;
            this.dgvDCGH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDCGH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDCGH.DataSource = this.bsHistory;
            this.dgvDCGH.Location = new System.Drawing.Point(3, 14);
            this.dgvDCGH.Name = "dgvDCGH";
            this.dgvDCGH.ReadOnly = true;
            this.dgvDCGH.RowTemplate.Height = 23;
            this.dgvDCGH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDCGH.Size = new System.Drawing.Size(777, 415);
            this.dgvDCGH.TabIndex = 0;
            // 
            // 采购物品历史采购明细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.groupBox2);
            this.Name = "采购物品历史采购明细";
            this.Text = "历史采购明细";
            this.Load += new System.EventHandler(this.采购物品历史采购明细_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDCGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDCGH;
        private System.Windows.Forms.BindingSource bsHistory;
    }
}
