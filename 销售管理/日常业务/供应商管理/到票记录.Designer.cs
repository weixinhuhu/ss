namespace 销售管理.日常业务.供应商管理
{
    partial class 到票记录
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
            this.DaInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDaInvoice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DaInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(275, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDaInvoice
            // 
            this.dgvDaInvoice.AllowUserToAddRows = false;
            this.dgvDaInvoice.AllowUserToDeleteRows = false;
            this.dgvDaInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaInvoice.Location = new System.Drawing.Point(12, 12);
            this.dgvDaInvoice.Name = "dgvDaInvoice";
            this.dgvDaInvoice.ReadOnly = true;
            this.dgvDaInvoice.RowTemplate.Height = 23;
            this.dgvDaInvoice.Size = new System.Drawing.Size(631, 281);
            this.dgvDaInvoice.TabIndex = 2;
            // 
            // 到票记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(679, 378);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDaInvoice);
            this.Name = "到票记录";
            this.Text = "到票记录";
            this.Load += new System.EventHandler(this.到票记录_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DaInvoiceBindingSource;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDaInvoice;
    }
}
