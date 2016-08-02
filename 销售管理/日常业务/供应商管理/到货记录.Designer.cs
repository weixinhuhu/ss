namespace 销售管理.日常业务.供应商管理
{
    partial class 到货记录
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
            this.dgvDaStockIn = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.DaStockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaStockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaStockInBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDaStockIn
            // 
            this.dgvDaStockIn.AllowUserToAddRows = false;
            this.dgvDaStockIn.AllowUserToDeleteRows = false;
            this.dgvDaStockIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaStockIn.Location = new System.Drawing.Point(12, 12);
            this.dgvDaStockIn.Name = "dgvDaStockIn";
            this.dgvDaStockIn.ReadOnly = true;
            this.dgvDaStockIn.RowTemplate.Height = 23;
            this.dgvDaStockIn.Size = new System.Drawing.Size(631, 281);
            this.dgvDaStockIn.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(275, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // 到货记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(655, 370);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDaStockIn);
            this.Name = "到货记录";
            this.Text = "到货记录";
            this.Load += new System.EventHandler(this.到货记录_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaStockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaStockInBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDaStockIn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource DaStockInBindingSource;
    }
}
