namespace 销售管理
{
    partial class SplashScreen
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
            this.m_SplashPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_SplashPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_SplashPictureBox
            // 
            this.m_SplashPictureBox.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.m_SplashPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_SplashPictureBox.Location = new System.Drawing.Point(0, 0);
            this.m_SplashPictureBox.Name = "m_SplashPictureBox";
            this.m_SplashPictureBox.Size = new System.Drawing.Size(284, 262);
            this.m_SplashPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.m_SplashPictureBox.TabIndex = 0;
            this.m_SplashPictureBox.TabStop = false;
            this.m_SplashPictureBox.Click += new System.EventHandler(this.m_SplashPictureBox_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.m_SplashPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.m_SplashPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_SplashPictureBox;
    }
}