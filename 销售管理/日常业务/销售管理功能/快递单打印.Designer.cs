namespace 销售管理.日常业务
{
    partial class 快递单打印
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
            this.cmbComName = new System.Windows.Forms.ComboBox();
            this.tCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCustomers = new 销售管理.DAL.DataSetCustomers();
            this.label1 = new System.Windows.Forms.Label();
            this.t_CustomersTableAdapter = new 销售管理.DAL.DataSetCustomersTableAdapters.T_CustomersTableAdapter();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DeliverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbExpress = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintView = new System.Windows.Forms.Button();
            this.designer1 = new CustomControls.Designer();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // cmbComName
            // 
            this.cmbComName.DataSource = this.tCustomersBindingSource;
            this.cmbComName.DisplayMember = "CompanyName";
            this.cmbComName.FormattingEnabled = true;
            this.cmbComName.Location = new System.Drawing.Point(98, 72);
            this.cmbComName.Name = "cmbComName";
            this.cmbComName.Size = new System.Drawing.Size(290, 20);
            this.cmbComName.TabIndex = 1;
            this.cmbComName.SelectedIndexChanged += new System.EventHandler(this.cmbComName_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "公司名称";
            // 
            // t_CustomersTableAdapter
            // 
            this.t_CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AutoGenerateColumns = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColumnUserName,
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
            this.DeliverAddress,
            this.DeliverPhone});
            this.dgvResult.DataSource = this.tCustomersBindingSource;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(3, 17);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(918, 547);
            this.dgvResult.TabIndex = 3;
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
            // ColumnUserName
            // 
            this.ColumnUserName.DataPropertyName = "UserName";
            this.ColumnUserName.HeaderText = "销售名称";
            this.ColumnUserName.Name = "ColumnUserName";
            this.ColumnUserName.ReadOnly = true;
            this.ColumnUserName.Visible = false;
            this.ColumnUserName.Width = 78;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "公司名称";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // companyAddressDataGridViewTextBoxColumn
            // 
            this.companyAddressDataGridViewTextBoxColumn.DataPropertyName = "CompanyAddress";
            this.companyAddressDataGridViewTextBoxColumn.HeaderText = "公司地址";
            this.companyAddressDataGridViewTextBoxColumn.Name = "companyAddressDataGridViewTextBoxColumn";
            this.companyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyAddressDataGridViewTextBoxColumn.Width = 78;
            // 
            // BusinessContactName
            // 
            this.BusinessContactName.DataPropertyName = "BusinessContactName";
            this.BusinessContactName.HeaderText = "商务负责人";
            this.BusinessContactName.Name = "BusinessContactName";
            this.BusinessContactName.ReadOnly = true;
            this.BusinessContactName.Visible = false;
            this.BusinessContactName.Width = 90;
            // 
            // BusinessContactTel
            // 
            this.BusinessContactTel.DataPropertyName = "BusinessContactTel";
            this.BusinessContactTel.HeaderText = "商务负责人座机";
            this.BusinessContactTel.Name = "BusinessContactTel";
            this.BusinessContactTel.ReadOnly = true;
            this.BusinessContactTel.Visible = false;
            this.BusinessContactTel.Width = 114;
            // 
            // BusinessContactPhone
            // 
            this.BusinessContactPhone.DataPropertyName = "BusinessContactPhone";
            this.BusinessContactPhone.HeaderText = "商务负责人手机";
            this.BusinessContactPhone.Name = "BusinessContactPhone";
            this.BusinessContactPhone.ReadOnly = true;
            this.BusinessContactPhone.Visible = false;
            this.BusinessContactPhone.Width = 114;
            // 
            // BusinessContactEmail
            // 
            this.BusinessContactEmail.DataPropertyName = "BusinessContactEmail";
            this.BusinessContactEmail.HeaderText = "商务负责人邮箱";
            this.BusinessContactEmail.Name = "BusinessContactEmail";
            this.BusinessContactEmail.ReadOnly = true;
            this.BusinessContactEmail.Visible = false;
            this.BusinessContactEmail.Width = 114;
            // 
            // techContactNameDataGridViewTextBoxColumn
            // 
            this.techContactNameDataGridViewTextBoxColumn.DataPropertyName = "TechContactName";
            this.techContactNameDataGridViewTextBoxColumn.HeaderText = "技术负责人";
            this.techContactNameDataGridViewTextBoxColumn.Name = "techContactNameDataGridViewTextBoxColumn";
            this.techContactNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.techContactNameDataGridViewTextBoxColumn.Visible = false;
            this.techContactNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // techContactTelDataGridViewTextBoxColumn
            // 
            this.techContactTelDataGridViewTextBoxColumn.DataPropertyName = "TechContactTel";
            this.techContactTelDataGridViewTextBoxColumn.HeaderText = "技术负责人座机";
            this.techContactTelDataGridViewTextBoxColumn.Name = "techContactTelDataGridViewTextBoxColumn";
            this.techContactTelDataGridViewTextBoxColumn.ReadOnly = true;
            this.techContactTelDataGridViewTextBoxColumn.Visible = false;
            this.techContactTelDataGridViewTextBoxColumn.Width = 114;
            // 
            // techContactPhoneDataGridViewTextBoxColumn
            // 
            this.techContactPhoneDataGridViewTextBoxColumn.DataPropertyName = "TechContactPhone";
            this.techContactPhoneDataGridViewTextBoxColumn.HeaderText = "技术负责人手机";
            this.techContactPhoneDataGridViewTextBoxColumn.Name = "techContactPhoneDataGridViewTextBoxColumn";
            this.techContactPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.techContactPhoneDataGridViewTextBoxColumn.Visible = false;
            this.techContactPhoneDataGridViewTextBoxColumn.Width = 114;
            // 
            // techContactEmailDataGridViewTextBoxColumn
            // 
            this.techContactEmailDataGridViewTextBoxColumn.DataPropertyName = "TechContactEmail";
            this.techContactEmailDataGridViewTextBoxColumn.HeaderText = "技术负责人邮箱";
            this.techContactEmailDataGridViewTextBoxColumn.Name = "techContactEmailDataGridViewTextBoxColumn";
            this.techContactEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.techContactEmailDataGridViewTextBoxColumn.Visible = false;
            this.techContactEmailDataGridViewTextBoxColumn.Width = 114;
            // 
            // DeliverName
            // 
            this.DeliverName.DataPropertyName = "DeliverName";
            this.DeliverName.HeaderText = "收货人";
            this.DeliverName.Name = "DeliverName";
            this.DeliverName.ReadOnly = true;
            this.DeliverName.Width = 66;
            // 
            // DeliverAddress
            // 
            this.DeliverAddress.DataPropertyName = "DeliverAddress";
            this.DeliverAddress.HeaderText = "收货地址";
            this.DeliverAddress.Name = "DeliverAddress";
            this.DeliverAddress.ReadOnly = true;
            this.DeliverAddress.Width = 78;
            // 
            // DeliverPhone
            // 
            this.DeliverPhone.DataPropertyName = "DeliverPhone";
            this.DeliverPhone.HeaderText = "收货人手机";
            this.DeliverPhone.Name = "DeliverPhone";
            this.DeliverPhone.ReadOnly = true;
            this.DeliverPhone.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvResult);
            this.groupBox1.Location = new System.Drawing.Point(38, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 567);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询结果";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbExpress
            // 
            this.cmbExpress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExpress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpress.FormattingEnabled = true;
            this.cmbExpress.Location = new System.Drawing.Point(700, 72);
            this.cmbExpress.Name = "cmbExpress";
            this.cmbExpress.Size = new System.Drawing.Size(262, 20);
            this.cmbExpress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "快递单模板";
            // 
            // btnPrintView
            // 
            this.btnPrintView.Location = new System.Drawing.Point(490, 70);
            this.btnPrintView.Name = "btnPrintView";
            this.btnPrintView.Size = new System.Drawing.Size(75, 23);
            this.btnPrintView.TabIndex = 5;
            this.btnPrintView.Text = "打印预览";
            this.btnPrintView.UseVisualStyleBackColor = true;
            this.btnPrintView.Click += new System.EventHandler(this.btnPrePrintView_Click);
            // 
            // designer1
            // 
            this.designer1.BackColor = System.Drawing.Color.White;
            this.designer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designer1.CanSelectItem = true;
            this.designer1.IsDrawMousePosition = false;
            this.designer1.IsDrawSelectRectangle = false;
            this.designer1.Location = new System.Drawing.Point(98, 3);
            this.designer1.Name = "designer1";
            this.designer1.RowHeight = 15;
            this.designer1.ShowGrid = false;
            this.designer1.Size = new System.Drawing.Size(109, 42);
            this.designer1.TabIndex = 9;
            this.designer1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "快递模板设计";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(490, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "自定义打印";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 快递单打印
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.designer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbExpress);
            this.Controls.Add(this.btnPrintView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbComName);
            this.Name = "快递单打印";
            this.Load += new System.EventHandler(this.快递单打印cs_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.cmbComName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnPrintView, 0);
            this.Controls.SetChildIndex(this.cmbExpress, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.designer1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tCustomersBindingSource;
        private DAL.DataSetCustomers dataSetCustomers;
        private DAL.DataSetCustomersTableAdapters.T_CustomersTableAdapter t_CustomersTableAdapter;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn bussinessContactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bussinessContactAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bussinessContactTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bussinessContactPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bussinessContactEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbExpress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintView;
        private CustomControls.Designer designer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn operNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverPhone;
        private System.Windows.Forms.Button button3;
    }
}
