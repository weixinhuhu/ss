namespace 销售管理.审核
{
    partial class 采购合同审核_部门经理
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
            ((System.ComponentModel.ISupportInitialize)(this.DaPurchaseContractBindingSource)).BeginInit();
            this.bgCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // 采购合同审核_部门经理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Name = "采购合同审核_部门经理";
            this.Load += new System.EventHandler(this.采购合同审核_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaPurchaseContractBindingSource)).EndInit();
            this.bgCondition.ResumeLayout(false);
            this.bgCondition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

    }
}
