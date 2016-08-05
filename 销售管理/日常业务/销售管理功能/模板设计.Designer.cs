namespace 销售管理.日常业务
{
    partial class 模板设计
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.documentSpace1 = new CustomControls.Control.DocumentSpace();
            this.SuspendLayout();
            // 
            // documentSpace1
            // 
            this.documentSpace1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentSpace1.Location = new System.Drawing.Point(2, 1);
            this.documentSpace1.Name = "documentSpace1";
            this.documentSpace1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.documentSpace1.Size = new System.Drawing.Size(1051, 608);
            this.documentSpace1.TabIndex = 1;
            // 
            // 模板设计
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 618);
            this.Controls.Add(this.documentSpace1);
            this.Name = "模板设计";
            this.Text = "模板设计";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Control.DocumentSpace documentSpace1;

    }
}