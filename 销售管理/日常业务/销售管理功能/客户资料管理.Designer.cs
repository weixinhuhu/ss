namespace 销售管理.日常业务
{
    partial class 客户资料管理
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
            this.components = new System.ComponentModel.Container();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OperName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessContactTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessContactEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techContactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techContactTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techContactPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techContactEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverContactAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCustomers = new 销售管理.DAL.DataSetCustomers();
            this.t_CustomersTableAdapter = new 销售管理.DAL.DataSetCustomersTableAdapters.T_CustomersTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.btnSerch = new System.Windows.Forms.Button();
            this.txtTechName = new System.Windows.Forms.TextBox();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvContact
            // 
            this.dgvContact.AllowUserToAddRows = false;
            this.dgvContact.AllowUserToDeleteRows = false;
            this.dgvContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContact.AutoGenerateColumns = false;
            this.dgvContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContact.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColModify,
            this.ColDel,
            this.OperName,
            this.companyNameDataGridViewTextBoxColumn,
            this.companyAddressDataGridViewTextBoxColumn,
            this.BusinessContactName,
            this.BusinessContactTel,
            this.BusinessContactPhone,
            this.BusinessContactEmail,
            this.techContactNameDataGridViewTextBoxColumn,
            this.techContactTelDataGridViewTextBoxColumn,
            this.techContactPhoneDataGridViewTextBoxColumn,
            this.techContactEmailDataGridViewTextBoxColumn,
            this.DeliverName,
            this.DeliverPhone,
            this.DeliverContactAddress});
            this.dgvContact.DataSource = this.tCustomersBindingSource;
            this.dgvContact.Location = new System.Drawing.Point(26, 123);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.ReadOnly = true;
            this.dgvContact.RowTemplate.Height = 23;
            this.dgvContact.Size = new System.Drawing.Size(939, 551);
            this.dgvContact.TabIndex = 1;
            this.dgvContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContact_CellContentClick);
            this.dgvContact.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvContact_RowsAdded);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 42;
            // 
            // ColModify
            // 
            this.ColModify.Frozen = true;
            this.ColModify.HeaderText = "";
            this.ColModify.Name = "ColModify";
            this.ColModify.ReadOnly = true;
            this.ColModify.Text = "修改";
            this.ColModify.UseColumnTextForButtonValue = true;
            this.ColModify.Width = 5;
            // 
            // ColDel
            // 
            this.ColDel.Frozen = true;
            this.ColDel.HeaderText = "";
            this.ColDel.Name = "ColDel";
            this.ColDel.ReadOnly = true;
            this.ColDel.Text = "删除";
            this.ColDel.UseColumnTextForButtonValue = true;
            this.ColDel.Width = 5;
            // 
            // OperName
            // 
            this.OperName.DataPropertyName = "OperName1";
            this.OperName.HeaderText = "所属销售";
            this.OperName.Name = "OperName";
            this.OperName.ReadOnly = true;
            this.OperName.Width = 61;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "公司名称";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyNameDataGridViewTextBoxColumn.Width = 61;
            // 
            // companyAddressDataGridViewTextBoxColumn
            // 
            this.companyAddressDataGridViewTextBoxColumn.DataPropertyName = "CompanyAddress";
            this.companyAddressDataGridViewTextBoxColumn.HeaderText = "公司地址";
            this.companyAddressDataGridViewTextBoxColumn.Name = "companyAddressDataGridViewTextBoxColumn";
            this.companyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyAddressDataGridViewTextBoxColumn.Width = 61;
            // 
            // BusinessContactName
            // 
            this.BusinessContactName.DataPropertyName = "BusinessContactName";
            this.BusinessContactName.HeaderText = "商务负责人";
            this.BusinessContactName.Name = "BusinessContactName";
            this.BusinessContactName.ReadOnly = true;
            this.BusinessContactName.Width = 72;
            // 
            // BusinessContactTel
            // 
            this.BusinessContactTel.DataPropertyName = "BusinessContactTel";
            this.BusinessContactTel.HeaderText = "商务负责人座机";
            this.BusinessContactTel.Name = "BusinessContactTel";
            this.BusinessContactTel.ReadOnly = true;
            this.BusinessContactTel.Width = 83;
            // 
            // BusinessContactPhone
            // 
            this.BusinessContactPhone.DataPropertyName = "BusinessContactPhone";
            this.BusinessContactPhone.HeaderText = "商务负责人手机";
            this.BusinessContactPhone.Name = "BusinessContactPhone";
            this.BusinessContactPhone.ReadOnly = true;
            this.BusinessContactPhone.Width = 83;
            // 
            // BusinessContactEmail
            // 
            this.BusinessContactEmail.DataPropertyName = "BusinessContactEmail";
            this.BusinessContactEmail.HeaderText = "商务负责人邮箱";
            this.BusinessContactEmail.Name = "BusinessContactEmail";
            this.BusinessContactEmail.ReadOnly = true;
            this.BusinessContactEmail.Width = 83;
            // 
            // techContactNameDataGridViewTextBoxColumn
            // 
            this.techContactNameDataGridViewTextBoxColumn.DataPropertyName = "TechContactName";
            this.techContactNameDataGridViewTextBoxColumn.HeaderText = "技术负责人";
            this.techContactNameDataGridViewTextBoxColumn.Name = "techContactNameDataGridViewTextBoxColumn";
            this.techContactNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.techContactNameDataGridViewTextBoxColumn.Width = 72;
            // 
            // techContactTelDataGridViewTextBoxColumn
            // 
            this.techContactTelDataGridViewTextBoxColumn.DataPropertyName = "TechContactTel";
            this.techContactTelDataGridViewTextBoxColumn.HeaderText = "技术负责人座机";
            this.techContactTelDataGridViewTextBoxColumn.Name = "techContactTelDataGridViewTextBoxColumn";
            this.techContactTelDataGridViewTextBoxColumn.ReadOnly = true;
            this.techContactTelDataGridViewTextBoxColumn.Width = 83;
            // 
            // techContactPhoneDataGridViewTextBoxColumn
            // 
            this.techContactPhoneDataGridViewTextBoxColumn.DataPropertyName = "TechContactPhone";
            this.techContactPhoneDataGridViewTextBoxColumn.HeaderText = "技术负责人手机";
            this.techContactPhoneDataGridViewTextBoxColumn.Name = "techContactPhoneDataGridViewTextBoxColumn";
            this.techContactPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.techContactPhoneDataGridViewTextBoxColumn.Width = 83;
            // 
            // techContactEmailDataGridViewTextBoxColumn
            // 
            this.techContactEmailDataGridViewTextBoxColumn.DataPropertyName = "TechContactEmail";
            this.techContactEmailDataGridViewTextBoxColumn.HeaderText = "技术负责人邮箱";
            this.techContactEmailDataGridViewTextBoxColumn.Name = "techContactEmailDataGridViewTextBoxColumn";
            this.techContactEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.techContactEmailDataGridViewTextBoxColumn.Width = 83;
            // 
            // DeliverName
            // 
            this.DeliverName.DataPropertyName = "DeliverName";
            this.DeliverName.HeaderText = "收件人";
            this.DeliverName.Name = "DeliverName";
            this.DeliverName.ReadOnly = true;
            this.DeliverName.Width = 61;
            // 
            // DeliverPhone
            // 
            this.DeliverPhone.DataPropertyName = "DeliverPhone";
            this.DeliverPhone.HeaderText = "收件人手机";
            this.DeliverPhone.Name = "DeliverPhone";
            this.DeliverPhone.ReadOnly = true;
            this.DeliverPhone.Width = 72;
            // 
            // DeliverContactAddress
            // 
            this.DeliverContactAddress.DataPropertyName = "DeliverAddress";
            this.DeliverContactAddress.HeaderText = "收件人地址";
            this.DeliverContactAddress.Name = "DeliverContactAddress";
            this.DeliverContactAddress.ReadOnly = true;
            this.DeliverContactAddress.Width = 72;
            // 
            // tCustomersBindingSource
            // 
            this.tCustomersBindingSource.DataMember = "T_Customers";
            this.tCustomersBindingSource.DataSource = this.dataSetCustomers;
            // 
            // dataSetCustomers
            // 
            this.dataSetCustomers.DataSetName = "DataSetCustomers";
            this.dataSetCustomers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_CustomersTableAdapter
            // 
            this.t_CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbUserName);
            this.groupBox1.Controls.Add(this.llAdd);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.txtTechName);
            this.groupBox1.Controls.Add(this.txtBusinessName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtComName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速搜索";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(621, 36);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(121, 20);
            this.cmbUserName.TabIndex = 4;
            this.cmbUserName.DataSourceChanged += new System.EventHandler(this.cmbUserName_DataSourceChanged);
            // 
            // llAdd
            // 
            this.llAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(818, 69);
            this.llAdd.Name = "llAdd";
            this.llAdd.Size = new System.Drawing.Size(77, 12);
            this.llAdd.TabIndex = 3;
            this.llAdd.TabStop = true;
            this.llAdd.Text = "添加客户资料";
            this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerch.Location = new System.Drawing.Point(816, 28);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(84, 34);
            this.btnSerch.TabIndex = 2;
            this.btnSerch.Text = "查找";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // txtTechName
            // 
            this.txtTechName.Location = new System.Drawing.Point(456, 36);
            this.txtTechName.Name = "txtTechName";
            this.txtTechName.Size = new System.Drawing.Size(100, 21);
            this.txtTechName.TabIndex = 1;
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(279, 36);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(100, 21);
            this.txtBusinessName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "所属销售";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "技术负责人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "商务负责人";
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(99, 36);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(100, 21);
            this.txtComName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "公司名称";
            // 
            // 客户资料管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvContact);
            this.Name = "客户资料管理";
            this.Load += new System.EventHandler(this.客户资料管理_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvContact, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.BindingSource tCustomersBindingSource;
        private DAL.DataSetCustomers dataSetCustomers;
        private DAL.DataSetCustomersTableAdapters.T_CustomersTableAdapter t_CustomersTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.TextBox txtTechName;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessContactTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessContactEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn techContactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techContactTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techContactPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techContactEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverContactAddress;
    }
}
