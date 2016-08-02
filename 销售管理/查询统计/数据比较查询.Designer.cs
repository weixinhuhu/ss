namespace 销售管理.查询统计
{
    partial class 数据比较查询
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
            //if (pictureBox1.Image !=null)
            //{
            //    pictureBox1.Image.Dispose();
            //}
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCompareType = new System.Windows.Forms.ComboBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.rbProductSum = new System.Windows.Forms.RadioButton();
            this.rbSalerSum = new System.Windows.Forms.RadioButton();
            this.rbProduct = new System.Windows.Forms.RadioButton();
            this.rbSaler = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cmbProducts3 = new System.Windows.Forms.ComboBox();
            this.cmbProducts2 = new System.Windows.Forms.ComboBox();
            this.cmbProducts1 = new System.Windows.Forms.ComboBox();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(942, 546);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbCompareType);
            this.groupBox1.Controls.Add(this.btnCompare);
            this.groupBox1.Controls.Add(this.rbProductSum);
            this.groupBox1.Controls.Add(this.rbSalerSum);
            this.groupBox1.Controls.Add(this.rbProduct);
            this.groupBox1.Controls.Add(this.rbSaler);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbProducts3);
            this.groupBox1.Controls.Add(this.cmbProducts2);
            this.groupBox1.Controls.Add(this.cmbProducts1);
            this.groupBox1.Controls.Add(this.cmbUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查找";
            // 
            // cmbCompareType
            // 
            this.cmbCompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompareType.FormattingEnabled = true;
            this.cmbCompareType.Items.AddRange(new object[] {
            "去年同期",
            "上月同期"});
            this.cmbCompareType.Location = new System.Drawing.Point(765, 51);
            this.cmbCompareType.Name = "cmbCompareType";
            this.cmbCompareType.Size = new System.Drawing.Size(89, 20);
            this.cmbCompareType.TabIndex = 6;
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Location = new System.Drawing.Point(860, 28);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(65, 43);
            this.btnCompare.TabIndex = 5;
            this.btnCompare.Text = "比较";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // rbProductSum
            // 
            this.rbProductSum.AutoSize = true;
            this.rbProductSum.Location = new System.Drawing.Point(166, 81);
            this.rbProductSum.Name = "rbProductSum";
            this.rbProductSum.Size = new System.Drawing.Size(107, 16);
            this.rbProductSum.TabIndex = 4;
            this.rbProductSum.TabStop = true;
            this.rbProductSum.Text = "所有产品汇总表";
            this.rbProductSum.UseVisualStyleBackColor = true;
            this.rbProductSum.Visible = false;
            // 
            // rbSalerSum
            // 
            this.rbSalerSum.AutoSize = true;
            this.rbSalerSum.Location = new System.Drawing.Point(47, 81);
            this.rbSalerSum.Name = "rbSalerSum";
            this.rbSalerSum.Size = new System.Drawing.Size(107, 16);
            this.rbSalerSum.TabIndex = 4;
            this.rbSalerSum.TabStop = true;
            this.rbSalerSum.Text = "所有销售汇总表";
            this.rbSalerSum.UseVisualStyleBackColor = true;
            this.rbSalerSum.Visible = false;
            // 
            // rbProduct
            // 
            this.rbProduct.AutoSize = true;
            this.rbProduct.Location = new System.Drawing.Point(166, 58);
            this.rbProduct.Name = "rbProduct";
            this.rbProduct.Size = new System.Drawing.Size(59, 16);
            this.rbProduct.TabIndex = 4;
            this.rbProduct.TabStop = true;
            this.rbProduct.Text = "按产品";
            this.rbProduct.UseVisualStyleBackColor = true;
            // 
            // rbSaler
            // 
            this.rbSaler.AutoSize = true;
            this.rbSaler.Location = new System.Drawing.Point(47, 60);
            this.rbSaler.Name = "rbSaler";
            this.rbSaler.Size = new System.Drawing.Size(59, 16);
            this.rbSaler.TabIndex = 4;
            this.rbSaler.TabStop = true;
            this.rbSaler.Text = "按销售";
            this.rbSaler.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDate);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Location = new System.Drawing.Point(426, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "时间区间";
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Checked = true;
            this.cbDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDate.Location = new System.Drawing.Point(6, 20);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(72, 16);
            this.cbDate.TabIndex = 1;
            this.cbDate.Text = "时间区间";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.Visible = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(83, 47);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(127, 21);
            this.dtpEnd.TabIndex = 0;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(83, 20);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(127, 21);
            this.dtpStart.TabIndex = 0;
            // 
            // cmbProducts3
            // 
            this.cmbProducts3.DropDownHeight = 300;
            this.cmbProducts3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts3.DropDownWidth = 200;
            this.cmbProducts3.FormattingEnabled = true;
            this.cmbProducts3.IntegralHeight = false;
            this.cmbProducts3.Location = new System.Drawing.Point(290, 77);
            this.cmbProducts3.Name = "cmbProducts3";
            this.cmbProducts3.Size = new System.Drawing.Size(121, 20);
            this.cmbProducts3.TabIndex = 1;
            this.cmbProducts3.SelectedIndexChanged += new System.EventHandler(this.cmbProducts3_SelectedIndexChanged);
            // 
            // cmbProducts2
            // 
            this.cmbProducts2.DropDownHeight = 300;
            this.cmbProducts2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts2.DropDownWidth = 200;
            this.cmbProducts2.FormattingEnabled = true;
            this.cmbProducts2.IntegralHeight = false;
            this.cmbProducts2.Location = new System.Drawing.Point(290, 54);
            this.cmbProducts2.Name = "cmbProducts2";
            this.cmbProducts2.Size = new System.Drawing.Size(121, 20);
            this.cmbProducts2.TabIndex = 1;
            this.cmbProducts2.SelectedIndexChanged += new System.EventHandler(this.cmbProducts2_SelectedIndexChanged);
            // 
            // cmbProducts1
            // 
            this.cmbProducts1.DropDownHeight = 300;
            this.cmbProducts1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts1.DropDownWidth = 200;
            this.cmbProducts1.FormattingEnabled = true;
            this.cmbProducts1.IntegralHeight = false;
            this.cmbProducts1.Location = new System.Drawing.Point(290, 28);
            this.cmbProducts1.Name = "cmbProducts1";
            this.cmbProducts1.Size = new System.Drawing.Size(121, 20);
            this.cmbProducts1.TabIndex = 1;
            this.cmbProducts1.SelectedIndexChanged += new System.EventHandler(this.cmbProducts1_SelectedIndexChanged);
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownHeight = 300;
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.DropDownWidth = 200;
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.IntegralHeight = false;
            this.cmbUsername.Location = new System.Drawing.Point(104, 28);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(121, 20);
            this.cmbUsername.TabIndex = 1;
            this.cmbUsername.SelectedIndexChanged += new System.EventHandler(this.cmbUsername_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "产品种类";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售名称";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(17, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(948, 566);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // 数据比较查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "数据比较查询";
            this.Load += new System.EventHandler(this.数据比较查询_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCompareType;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.RadioButton rbProductSum;
        private System.Windows.Forms.RadioButton rbSalerSum;
        private System.Windows.Forms.RadioButton rbProduct;
        private System.Windows.Forms.RadioButton rbSaler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cmbProducts3;
        private System.Windows.Forms.ComboBox cmbProducts2;
        private System.Windows.Forms.ComboBox cmbProducts1;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
