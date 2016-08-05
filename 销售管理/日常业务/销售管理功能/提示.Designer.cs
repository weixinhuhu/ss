namespace 销售管理.日常业务.销售管理功能
{
    partial class 提示
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
            this.labTips = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTips
            // 
            this.labTips.BackColor = System.Drawing.Color.Transparent;
            this.labTips.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTips.Location = new System.Drawing.Point(35, 32);
            this.labTips.Name = "labTips";
            this.labTips.Size = new System.Drawing.Size(339, 81);
            this.labTips.TabIndex = 0;
            this.labTips.Text = "礼品未审核数目:\r\n餐费未审核数目:";
            this.labTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(166, 149);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // 提示
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(427, 193);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labTips);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "提示";
            this.Text = "提示";
            this.Load += new System.EventHandler(this.提示_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTips;
        private System.Windows.Forms.Button btnOK;
    }
}
