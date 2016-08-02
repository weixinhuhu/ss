namespace 销售管理.日常业务.供应商管理
{
    partial class 选择供应商
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDaName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDaSupplier = new System.Windows.Forms.DataGridView();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.注册资本 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.法人代表 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.税号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开户银行 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.银行帐号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.经营地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司网站 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司固话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司传真 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.邮编 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录入时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录入人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(122, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供应商名称";
            // 
            // txtDaName
            // 
            this.txtDaName.Location = new System.Drawing.Point(193, 48);
            this.txtDaName.Name = "txtDaName";
            this.txtDaName.Size = new System.Drawing.Size(282, 21);
            this.txtDaName.TabIndex = 1;
            this.txtDaName.TextChanged += new System.EventHandler(this.txtDaName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(599, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvDaSupplier
            // 
            this.dgvDaSupplier.AllowUserToAddRows = false;
            this.dgvDaSupplier.AllowUserToDeleteRows = false;
            this.dgvDaSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDaSupplier.AutoGenerateColumns = false;
            this.dgvDaSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.名称,
            this.注册资本,
            this.法人代表,
            this.税号,
            this.开户银行,
            this.银行帐号,
            this.经营地址,
            this.公司网站,
            this.公司固话,
            this.公司传真,
            this.邮编,
            this.备注,
            this.录入时间,
            this.录入人});
            this.dgvDaSupplier.DataSource = this.DaSupplierBindingSource;
            this.dgvDaSupplier.Location = new System.Drawing.Point(12, 108);
            this.dgvDaSupplier.MultiSelect = false;
            this.dgvDaSupplier.Name = "dgvDaSupplier";
            this.dgvDaSupplier.ReadOnly = true;
            this.dgvDaSupplier.RowTemplate.Height = 23;
            this.dgvDaSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaSupplier.Size = new System.Drawing.Size(760, 317);
            this.dgvDaSupplier.TabIndex = 7;
            this.dgvDaSupplier.DoubleClick += new System.EventHandler(this.dgvDaSupplier_DoubleClick);
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "VcNum";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.ReadOnly = true;
            this.编号.Width = 54;
            // 
            // 名称
            // 
            this.名称.DataPropertyName = "VcName";
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.Width = 54;
            // 
            // 注册资本
            // 
            this.注册资本.DataPropertyName = "VcRegCapital";
            this.注册资本.HeaderText = "注册资本";
            this.注册资本.Name = "注册资本";
            this.注册资本.ReadOnly = true;
            this.注册资本.Width = 78;
            // 
            // 法人代表
            // 
            this.法人代表.DataPropertyName = "VcLegalRep";
            this.法人代表.HeaderText = "法人代表";
            this.法人代表.Name = "法人代表";
            this.法人代表.ReadOnly = true;
            this.法人代表.Width = 78;
            // 
            // 税号
            // 
            this.税号.DataPropertyName = "VcTaxID";
            this.税号.HeaderText = "税号";
            this.税号.Name = "税号";
            this.税号.ReadOnly = true;
            this.税号.Width = 54;
            // 
            // 开户银行
            // 
            this.开户银行.DataPropertyName = "VcOpeningBank";
            this.开户银行.HeaderText = "开户银行";
            this.开户银行.Name = "开户银行";
            this.开户银行.ReadOnly = true;
            this.开户银行.Width = 78;
            // 
            // 银行帐号
            // 
            this.银行帐号.DataPropertyName = "VcBankAccount";
            this.银行帐号.HeaderText = "银行帐号";
            this.银行帐号.Name = "银行帐号";
            this.银行帐号.ReadOnly = true;
            this.银行帐号.Width = 78;
            // 
            // 经营地址
            // 
            this.经营地址.DataPropertyName = "VcAddress";
            this.经营地址.HeaderText = "经营地址";
            this.经营地址.Name = "经营地址";
            this.经营地址.ReadOnly = true;
            this.经营地址.Width = 78;
            // 
            // 公司网站
            // 
            this.公司网站.DataPropertyName = "VcWebsite";
            this.公司网站.HeaderText = "公司网站";
            this.公司网站.Name = "公司网站";
            this.公司网站.ReadOnly = true;
            this.公司网站.Width = 78;
            // 
            // 公司固话
            // 
            this.公司固话.DataPropertyName = "VcTel";
            this.公司固话.HeaderText = "公司固话";
            this.公司固话.Name = "公司固话";
            this.公司固话.ReadOnly = true;
            this.公司固话.Width = 78;
            // 
            // 公司传真
            // 
            this.公司传真.DataPropertyName = "VcFax";
            this.公司传真.HeaderText = "公司传真";
            this.公司传真.Name = "公司传真";
            this.公司传真.ReadOnly = true;
            this.公司传真.Width = 78;
            // 
            // 邮编
            // 
            this.邮编.DataPropertyName = "VcPostCode";
            this.邮编.HeaderText = "邮编";
            this.邮编.Name = "邮编";
            this.邮编.ReadOnly = true;
            this.邮编.Width = 54;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "VcRemark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 54;
            // 
            // 录入时间
            // 
            this.录入时间.DataPropertyName = "DtCreate";
            this.录入时间.HeaderText = "录入时间";
            this.录入时间.Name = "录入时间";
            this.录入时间.ReadOnly = true;
            this.录入时间.Width = 78;
            // 
            // 录入人
            // 
            this.录入人.DataPropertyName = "UserName";
            this.录入人.HeaderText = "录入人";
            this.录入人.Name = "录入人";
            this.录入人.ReadOnly = true;
            this.录入人.Width = 66;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(521, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 34);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // 选择供应商
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 428);
            this.Controls.Add(this.dgvDaSupplier);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDaName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "选择供应商";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择供应商";
            this.Load += new System.EventHandler(this.选择供应商_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDaName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDaSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 注册资本;
        private System.Windows.Forms.DataGridViewTextBoxColumn 法人代表;
        private System.Windows.Forms.DataGridViewTextBoxColumn 税号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开户银行;
        private System.Windows.Forms.DataGridViewTextBoxColumn 银行帐号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 经营地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司网站;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司固话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司传真;
        private System.Windows.Forms.DataGridViewTextBoxColumn 邮编;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录入时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录入人;
        private System.Windows.Forms.BindingSource DaSupplierBindingSource;
        private System.Windows.Forms.Button btnOK;
    }
}