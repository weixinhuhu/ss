namespace 销售管理.Print
{
    partial class PrintModelSet
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
            this.documentSpace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentSpace1.Location = new System.Drawing.Point(0, 0);
            this.documentSpace1.Name = "documentSpace1";
            this.documentSpace1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.documentSpace1.Size = new System.Drawing.Size(920, 505);
            this.documentSpace1.TabIndex = 0;
            // 
            // PrintModelSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 505);
            this.Controls.Add(this.documentSpace1);
            this.Name = "PrintModelSet";
            this.Text = "打印模版设计";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Control.DocumentSpace documentSpace1;
    }
}