﻿namespace 销售管理.日常业务.供应商管理
{
    partial class 报销记录
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
            this.DaExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDaStockIn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DaExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaStockIn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(302, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDaStockIn
            // 
            this.dgvDaStockIn.AllowUserToAddRows = false;
            this.dgvDaStockIn.AllowUserToDeleteRows = false;
            this.dgvDaStockIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaStockIn.Location = new System.Drawing.Point(39, 23);
            this.dgvDaStockIn.Name = "dgvDaStockIn";
            this.dgvDaStockIn.ReadOnly = true;
            this.dgvDaStockIn.RowTemplate.Height = 23;
            this.dgvDaStockIn.Size = new System.Drawing.Size(631, 281);
            this.dgvDaStockIn.TabIndex = 2;
            // 
            // 报销记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(699, 382);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDaStockIn);
            this.Name = "报销记录";
            this.Text = "报销记录";
            this.Load += new System.EventHandler(this.报销记录_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaStockIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DaExpenseBindingSource;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDaStockIn;
    }
}
