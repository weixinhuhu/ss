namespace 配置连接字符串
{
    partial class 加密解密
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewStr = new System.Windows.Forms.TextBox();
            this.btnEn = new System.Windows.Forms.Button();
            this.btnDe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原文字符串";
            // 
            // txtOldStr
            // 
            this.txtOldStr.Location = new System.Drawing.Point(42, 31);
            this.txtOldStr.Multiline = true;
            this.txtOldStr.Name = "txtOldStr";
            this.txtOldStr.Size = new System.Drawing.Size(500, 120);
            this.txtOldStr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密文字符串";
            // 
            // txtNewStr
            // 
            this.txtNewStr.Location = new System.Drawing.Point(42, 180);
            this.txtNewStr.Multiline = true;
            this.txtNewStr.Name = "txtNewStr";
            this.txtNewStr.Size = new System.Drawing.Size(500, 120);
            this.txtNewStr.TabIndex = 1;
            // 
            // btnEn
            // 
            this.btnEn.Location = new System.Drawing.Point(203, 318);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(75, 23);
            this.btnEn.TabIndex = 2;
            this.btnEn.Text = "加密";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnDe
            // 
            this.btnDe.Location = new System.Drawing.Point(306, 318);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(75, 23);
            this.btnDe.TabIndex = 2;
            this.btnDe.Text = "解密";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // 加密解密
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnDe);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.txtNewStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldStr);
            this.Controls.Add(this.label1);
            this.Name = "加密解密";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewStr;
        private System.Windows.Forms.Button btnEn;
        private System.Windows.Forms.Button btnDe;
    }
}

