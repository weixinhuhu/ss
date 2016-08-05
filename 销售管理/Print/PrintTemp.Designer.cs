namespace 销售管理.Print
{
    partial class PrintTemp
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Designer1 = new CustomControls.Designer();
            this.ButtonPreview = new System.Windows.Forms.Button();
            this.ButtonDesign = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtCustomerId = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Panel1.Controls.Add(this.Designer1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(712, 382);
            this.Panel1.TabIndex = 4;
            // 
            // Designer1
            // 
            this.Designer1.BackColor = System.Drawing.Color.White;
            this.Designer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Designer1.CanSelectItem = true;
            this.Designer1.Enabled = false;
            this.Designer1.IsDrawMousePosition = false;
            this.Designer1.IsDrawSelectRectangle = false;
            this.Designer1.Location = new System.Drawing.Point(12, 12);
            this.Designer1.Name = "Designer1";
            this.Designer1.RowHeight = 15;
            this.Designer1.ShowGrid = false;
            this.Designer1.Size = new System.Drawing.Size(326, 242);
            this.Designer1.TabIndex = 1;
            // 
            // ButtonPreview
            // 
            this.ButtonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonPreview.Location = new System.Drawing.Point(355, 428);
            this.ButtonPreview.Name = "ButtonPreview";
            this.ButtonPreview.Size = new System.Drawing.Size(116, 38);
            this.ButtonPreview.TabIndex = 6;
            this.ButtonPreview.Text = "打印预览";
            this.ButtonPreview.UseVisualStyleBackColor = true;
            this.ButtonPreview.Click += new System.EventHandler(this.ButtonPreview_Click);
            // 
            // ButtonDesign
            // 
            this.ButtonDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDesign.Location = new System.Drawing.Point(477, 428);
            this.ButtonDesign.Name = "ButtonDesign";
            this.ButtonDesign.Size = new System.Drawing.Size(116, 38);
            this.ButtonDesign.TabIndex = 8;
            this.ButtonDesign.Text = "设计模板";
            this.ButtonDesign.UseVisualStyleBackColor = true;
            this.ButtonDesign.Visible = false;
            this.ButtonDesign.Click += new System.EventHandler(this.ButtonDesign_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(165, 438);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(126, 20);
            this.ComboBox1.TabIndex = 7;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(106, 441);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 12);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "选择模板";
            // 
            // TxtCustomerId
            // 
            this.TxtCustomerId.Location = new System.Drawing.Point(71, 406);
            this.TxtCustomerId.Name = "TxtCustomerId";
            this.TxtCustomerId.ReadOnly = true;
            this.TxtCustomerId.Size = new System.Drawing.Size(144, 21);
            this.TxtCustomerId.TabIndex = 10;
            this.TxtCustomerId.TextChanged += new System.EventHandler(this.TxtCustomerId_TextChanged);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(12, 415);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(53, 12);
            this.Label14.TabIndex = 9;
            this.Label14.Text = "用户编号";
            // 
            // PrintTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 485);
            this.Controls.Add(this.TxtCustomerId);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.ButtonPreview);
            this.Controls.Add(this.ButtonDesign);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Name = "PrintTemp";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal CustomControls.Designer Designer1;
        internal System.Windows.Forms.Button ButtonPreview;
        internal System.Windows.Forms.Button ButtonDesign;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtCustomerId;
        internal System.Windows.Forms.Label Label14;
    }
}