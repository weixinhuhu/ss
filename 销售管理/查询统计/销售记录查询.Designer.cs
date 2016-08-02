namespace 销售管理.查询统计
{
    partial class 销售记录查询
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
            if (this.pictureBox1.Image != null)
            {
                this.pictureBox1.Image.Dispose();
            }
           
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
            this.lbInvoiceFlag = new System.Windows.Forms.Label();
            this.CmbInvoiceFlag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbProductSum = new System.Windows.Forms.RadioButton();
            this.rbSalerSum = new System.Windows.Forms.RadioButton();
            this.rbSum = new System.Windows.Forms.RadioButton();
            this.rbDetails = new System.Windows.Forms.RadioButton();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cmbProducts3 = new System.Windows.Forms.ComboBox();
            this.cmbProducts2 = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbPromary = new System.Windows.Forms.ComboBox();
            this.txtCustomer = new System.Windows.Forms.ComboBox();
            this.cmbProducts1 = new System.Windows.Forms.ComboBox();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbInvoiceFlag);
            this.groupBox1.Controls.Add(this.CmbInvoiceFlag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbProductSum);
            this.groupBox1.Controls.Add(this.rbSalerSum);
            this.groupBox1.Controls.Add(this.rbSum);
            this.groupBox1.Controls.Add(this.rbDetails);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbProducts3);
            this.groupBox1.Controls.Add(this.cmbProducts2);
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.cmbPromary);
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.cmbProducts1);
            this.groupBox1.Controls.Add(this.cmbUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查找";
            // 
            // lbInvoiceFlag
            // 
            this.lbInvoiceFlag.AutoSize = true;
            this.lbInvoiceFlag.BackColor = System.Drawing.Color.Transparent;
            this.lbInvoiceFlag.Location = new System.Drawing.Point(45, 113);
            this.lbInvoiceFlag.Name = "lbInvoiceFlag";
            this.lbInvoiceFlag.Size = new System.Drawing.Size(53, 12);
            this.lbInvoiceFlag.TabIndex = 14;
            this.lbInvoiceFlag.Text = "是否开票";
            this.lbInvoiceFlag.Click += new System.EventHandler(this.label9_Click);
            // 
            // CmbInvoiceFlag
            // 
            this.CmbInvoiceFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbInvoiceFlag.FormattingEnabled = true;
            this.CmbInvoiceFlag.Items.AddRange(new object[] {
            "全部",
            "不开票",
            "开票"});
            this.CmbInvoiceFlag.Location = new System.Drawing.Point(104, 110);
            this.CmbInvoiceFlag.Name = "CmbInvoiceFlag";
            this.CmbInvoiceFlag.Size = new System.Drawing.Size(121, 20);
            this.CmbInvoiceFlag.TabIndex = 13;
            this.CmbInvoiceFlag.SelectedIndexChanged += new System.EventHandler(this.CmbInvoiceFlag_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "客户名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "地区";
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
            this.rbProductSum.CheckedChanged += new System.EventHandler(this.rbProductSum_CheckedChanged);
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
            this.rbSalerSum.CheckedChanged += new System.EventHandler(this.rbSalerSum_CheckedChanged);
            // 
            // rbSum
            // 
            this.rbSum.AutoSize = true;
            this.rbSum.Location = new System.Drawing.Point(166, 58);
            this.rbSum.Name = "rbSum";
            this.rbSum.Size = new System.Drawing.Size(59, 16);
            this.rbSum.TabIndex = 4;
            this.rbSum.TabStop = true;
            this.rbSum.Text = "汇总表";
            this.rbSum.UseVisualStyleBackColor = true;
            this.rbSum.CheckedChanged += new System.EventHandler(this.rbSum_CheckedChanged);
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Location = new System.Drawing.Point(47, 60);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(83, 16);
            this.rbDetails.TabIndex = 4;
            this.rbDetails.TabStop = true;
            this.rbDetails.Text = "销售明细表";
            this.rbDetails.UseVisualStyleBackColor = true;
            this.rbDetails.CheckedChanged += new System.EventHandler(this.rbDetails_CheckedChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(870, 38);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(72, 43);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "导出到EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(790, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 43);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDate);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Location = new System.Drawing.Point(598, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "时间区间";
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(6, 20);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(72, 16);
            this.cbDate.TabIndex = 1;
            this.cbDate.Text = "时间区间";
            this.cbDate.UseVisualStyleBackColor = true;
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
            // cmbCity
            // 
            this.cmbCity.DropDownHeight = 300;
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.DropDownWidth = 200;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.IntegralHeight = false;
            this.cmbCity.Location = new System.Drawing.Point(471, 54);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 20);
            this.cmbCity.TabIndex = 1;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbProducts1_SelectedIndexChanged);
            // 
            // cmbPromary
            // 
            this.cmbPromary.DropDownHeight = 300;
            this.cmbPromary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPromary.DropDownWidth = 200;
            this.cmbPromary.FormattingEnabled = true;
            this.cmbPromary.IntegralHeight = false;
            this.cmbPromary.Location = new System.Drawing.Point(471, 28);
            this.cmbPromary.Name = "cmbPromary";
            this.cmbPromary.Size = new System.Drawing.Size(121, 20);
            this.cmbPromary.TabIndex = 1;
            this.cmbPromary.SelectedIndexChanged += new System.EventHandler(this.cmbPromary_SelectedIndexChanged);
            // 
            // txtCustomer
            // 
            this.txtCustomer.DisplayMember = "CompanyName";
            this.txtCustomer.DropDownHeight = 300;
            this.txtCustomer.DropDownWidth = 200;
            this.txtCustomer.FormattingEnabled = true;
            this.txtCustomer.IntegralHeight = false;
            this.txtCustomer.Location = new System.Drawing.Point(471, 77);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(121, 20);
            this.txtCustomer.TabIndex = 1;
            this.txtCustomer.ValueMember = "id";
            this.txtCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbProducts1_SelectedIndexChanged);
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
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(17, 162);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowTemplate.Height = 23;
            this.dgvReport.Size = new System.Drawing.Size(948, 515);
            this.dgvReport.TabIndex = 3;
            // 
            // 销售记录查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.groupBox1);
            this.Name = "销售记录查询";
            this.Load += new System.EventHandler(this.销售记录查询_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvReport, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProducts1;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cmbProducts3;
        private System.Windows.Forms.ComboBox cmbProducts2;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.RadioButton rbSum;
        private System.Windows.Forms.RadioButton rbDetails;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.RadioButton rbSalerSum;
        private System.Windows.Forms.RadioButton rbProductSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbPromary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtCustomer;
        private System.Windows.Forms.Label lbInvoiceFlag;
        private System.Windows.Forms.ComboBox CmbInvoiceFlag;

    }
}
