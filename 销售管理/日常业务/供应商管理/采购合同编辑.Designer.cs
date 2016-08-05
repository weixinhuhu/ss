namespace 销售管理.日常业务.供应商管理
{
    partial class 采购合同编辑
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContractNum = new System.Windows.Forms.TextBox();
            this.btnSelectGoods = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DaSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLinkMan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.cmbDaType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCabinet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseGoods = new System.Windows.Forms.DataGridView();
            this.ds删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dcg物品Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg物品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcg金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApplicantDep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApplicant = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbApplicantCom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DaSupplierBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "采购合同编号";
            // 
            // txtContractNum
            // 
            this.txtContractNum.Location = new System.Drawing.Point(131, 27);
            this.txtContractNum.Name = "txtContractNum";
            this.txtContractNum.ReadOnly = true;
            this.txtContractNum.Size = new System.Drawing.Size(173, 21);
            this.txtContractNum.TabIndex = 1;
            this.txtContractNum.TabStop = false;
            // 
            // btnSelectGoods
            // 
            this.btnSelectGoods.Location = new System.Drawing.Point(836, 133);
            this.btnSelectGoods.Name = "btnSelectGoods";
            this.btnSelectGoods.Size = new System.Drawing.Size(89, 23);
            this.btnSelectGoods.TabIndex = 4;
            this.btnSelectGoods.Text = "添加采购物品";
            this.btnSelectGoods.UseVisualStyleBackColor = true;
            this.btnSelectGoods.Click += new System.EventHandler(this.btnSelectGoods_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(309, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "供货方";
            // 
            // txtLinkMan
            // 
            this.txtLinkMan.Location = new System.Drawing.Point(657, 27);
            this.txtLinkMan.Name = "txtLinkMan";
            this.txtLinkMan.Size = new System.Drawing.Size(173, 21);
            this.txtLinkMan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(574, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "联系人";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(131, 54);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(173, 21);
            this.txtTel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(48, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "联系电话";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(574, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "手机";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(657, 54);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(173, 21);
            this.txtMobile.TabIndex = 10;
            // 
            // cmbDaType
            // 
            this.cmbDaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDaType.FormattingEnabled = true;
            this.cmbDaType.Location = new System.Drawing.Point(392, 81);
            this.cmbDaType.Name = "cmbDaType";
            this.cmbDaType.Size = new System.Drawing.Size(173, 20);
            this.cmbDaType.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(309, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "采购类型";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(574, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "合同存放柜";
            // 
            // txtCabinet
            // 
            this.txtCabinet.Location = new System.Drawing.Point(657, 81);
            this.txtCabinet.Name = "txtCabinet";
            this.txtCabinet.Size = new System.Drawing.Size(173, 21);
            this.txtCabinet.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(48, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "合同存档卷宗";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(131, 108);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(173, 21);
            this.txtFolder.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(836, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 49);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(309, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "备注";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(392, 108);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(173, 21);
            this.txtRemark.TabIndex = 12;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(657, 108);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(173, 21);
            this.txtStatus.TabIndex = 30;
            this.txtStatus.Visible = false;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Location = new System.Drawing.Point(574, 113);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 12);
            this.lbStatus.TabIndex = 29;
            this.lbStatus.Text = "合同状态";
            this.lbStatus.Visible = false;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(392, 55);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(173, 21);
            this.txtFax.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(309, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "传真";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(131, 81);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(173, 21);
            this.txtSum.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(48, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 35;
            this.label15.Text = "总价";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvPurchaseGoods);
            this.groupBox1.Location = new System.Drawing.Point(50, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 327);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采购物品详细";
            // 
            // dgvPurchaseGoods
            // 
            this.dgvPurchaseGoods.AllowUserToAddRows = false;
            this.dgvPurchaseGoods.AllowUserToDeleteRows = false;
            this.dgvPurchaseGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ds删除,
            this.dcg物品Id,
            this.dcg物品名称,
            this.dcg单价,
            this.dcg数量,
            this.dcg金额});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseGoods.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchaseGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseGoods.Location = new System.Drawing.Point(3, 17);
            this.dgvPurchaseGoods.Name = "dgvPurchaseGoods";
            this.dgvPurchaseGoods.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseGoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchaseGoods.RowTemplate.Height = 23;
            this.dgvPurchaseGoods.Size = new System.Drawing.Size(859, 307);
            this.dgvPurchaseGoods.TabIndex = 0;
            this.dgvPurchaseGoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseGoods_CellClick);
            // 
            // ds删除
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "删除";
            this.ds删除.DefaultCellStyle = dataGridViewCellStyle2;
            this.ds删除.HeaderText = "删除";
            this.ds删除.Name = "ds删除";
            this.ds删除.ReadOnly = true;
            this.ds删除.Width = 35;
            // 
            // dcg物品Id
            // 
            this.dcg物品Id.DataPropertyName = "IntID";
            this.dcg物品Id.HeaderText = "物品Id";
            this.dcg物品Id.Name = "dcg物品Id";
            this.dcg物品Id.ReadOnly = true;
            this.dcg物品Id.Visible = false;
            // 
            // dcg物品名称
            // 
            this.dcg物品名称.DataPropertyName = "VcName";
            this.dcg物品名称.HeaderText = "物品名称";
            this.dcg物品名称.Name = "dcg物品名称";
            this.dcg物品名称.ReadOnly = true;
            this.dcg物品名称.Width = 78;
            // 
            // dcg单价
            // 
            this.dcg单价.DataPropertyName = "MonPrice";
            this.dcg单价.HeaderText = "单价";
            this.dcg单价.Name = "dcg单价";
            this.dcg单价.ReadOnly = true;
            this.dcg单价.Width = 54;
            // 
            // dcg数量
            // 
            this.dcg数量.DataPropertyName = "NumCount";
            this.dcg数量.HeaderText = "数量";
            this.dcg数量.Name = "dcg数量";
            this.dcg数量.ReadOnly = true;
            this.dcg数量.Width = 54;
            // 
            // dcg金额
            // 
            this.dcg金额.DataPropertyName = "MonSum";
            this.dcg金额.HeaderText = "金额";
            this.dcg金额.Name = "dcg金额";
            this.dcg金额.ReadOnly = true;
            this.dcg金额.Width = 54;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(392, 27);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(136, 21);
            this.txtSupplier.TabIndex = 38;
            this.txtSupplier.TabStop = false;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(528, 26);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(37, 23);
            this.btnSupplier.TabIndex = 39;
            this.btnSupplier.Text = "选择";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(48, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "申请部门";
            // 
            // txtApplicantDep
            // 
            this.txtApplicantDep.Location = new System.Drawing.Point(131, 135);
            this.txtApplicantDep.Name = "txtApplicantDep";
            this.txtApplicantDep.Size = new System.Drawing.Size(173, 21);
            this.txtApplicantDep.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(309, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "申请人";
            // 
            // txtApplicant
            // 
            this.txtApplicant.Location = new System.Drawing.Point(392, 135);
            this.txtApplicant.Name = "txtApplicant";
            this.txtApplicant.Size = new System.Drawing.Size(173, 21);
            this.txtApplicant.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(836, 106);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "清空采购物品";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(574, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "申请公司";
            // 
            // cmbApplicantCom
            // 
            this.cmbApplicantCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApplicantCom.FormattingEnabled = true;
            this.cmbApplicantCom.Items.AddRange(new object[] {
            "外购入库",
            "委外加工"});
            this.cmbApplicantCom.Location = new System.Drawing.Point(657, 135);
            this.cmbApplicantCom.Name = "cmbApplicantCom";
            this.cmbApplicantCom.Size = new System.Drawing.Size(173, 20);
            this.cmbApplicantCom.TabIndex = 14;
            // 
            // 采购合同编辑
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 503);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbApplicantCom);
            this.Controls.Add(this.cmbDaType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApplicant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtApplicantDep);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCabinet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLinkMan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectGoods);
            this.Controls.Add(this.txtContractNum);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "采购合同编辑";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购合同编辑";
            this.Load += new System.EventHandler(this.采购合同编辑_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaSupplierBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContractNum;
        private System.Windows.Forms.Button btnSelectGoods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLinkMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.ComboBox cmbDaType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCabinet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource DaSupplierBindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPurchaseGoods;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApplicantDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApplicant;
        private System.Windows.Forms.DataGridViewButtonColumn ds删除;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg物品Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg物品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcg金额;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbApplicantCom;
    }
}