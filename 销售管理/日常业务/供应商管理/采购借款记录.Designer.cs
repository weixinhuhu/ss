namespace 销售管理.日常业务.供应商管理
{
    partial class 采购借款记录
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvLoan = new System.Windows.Forms.DataGridView();
            this.DaLoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnWriteOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaLoanBindingSource)).BeginInit();
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
            // dgvLoan
            // 
            this.dgvLoan.AllowUserToAddRows = false;
            this.dgvLoan.AllowUserToDeleteRows = false;
            this.dgvLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoan.Location = new System.Drawing.Point(12, 12);
            this.dgvLoan.Name = "dgvLoan";
            this.dgvLoan.ReadOnly = true;
            this.dgvLoan.RowTemplate.Height = 23;
            this.dgvLoan.Size = new System.Drawing.Size(631, 281);
            this.dgvLoan.TabIndex = 2;
            // 
            // btnWriteOff
            // 
            this.btnWriteOff.Location = new System.Drawing.Point(134, 318);
            this.btnWriteOff.Name = "btnWriteOff";
            this.btnWriteOff.Size = new System.Drawing.Size(90, 40);
            this.btnWriteOff.TabIndex = 3;
            this.btnWriteOff.Text = "冲销";
            this.btnWriteOff.UseVisualStyleBackColor = true;
            this.btnWriteOff.Click += new System.EventHandler(this.btnWriteOff_Click);
            // 
            // 采购借款记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(655, 376);
            this.Controls.Add(this.btnWriteOff);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvLoan);
            this.Name = "采购借款记录";
            this.Text = "借款记录";
            this.Load += new System.EventHandler(this.采购借款记录_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaLoanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvLoan;
        private System.Windows.Forms.BindingSource DaLoanBindingSource;
        private System.Windows.Forms.Button btnWriteOff;
    }
}
