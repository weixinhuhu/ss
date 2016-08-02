namespace 销售管理.日常业务
{
    partial class 销售明细维护
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSettlementModes = new System.Windows.Forms.ComboBox();
            this.cbInvoice = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInvoiceContent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpInvioceDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbInvoiceType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.cmbProduct1 = new System.Windows.Forms.ComboBox();
            this.cmbProduct2 = new System.Windows.Forms.ComboBox();
            this.cmbProduct3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.txtStockOutNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CmbInvoiceFlag = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(80, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(139, 66);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(382, 20);
            this.cmbCustomerName.TabIndex = 1;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            this.cmbCustomerName.SelectionChangeCommitted += new System.EventHandler(this.cmbCustomerName_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(104, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "日期";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpDate1
            // 
            this.dtpDate1.Location = new System.Drawing.Point(139, 143);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(169, 21);
            this.dtpDate1.TabIndex = 2;
            this.dtpDate1.ValueChanged += new System.EventHandler(this.dtpDate1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(80, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "产品名称";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(322, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "数量";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(352, 144);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(169, 21);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(310, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "出库单";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(139, 185);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(169, 21);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(322, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "金额";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(352, 185);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(169, 21);
            this.txtSum.TabIndex = 3;
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(80, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "结款方式";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbSettlementModes
            // 
            this.cmbSettlementModes.FormattingEnabled = true;
            this.cmbSettlementModes.Items.AddRange(new object[] {
            "月结",
            "货到付款",
            "支票",
            "已回款",
            "现金",
            "发票到后付款",
            "款到发货",
            "已回款不开票"});
            this.cmbSettlementModes.Location = new System.Drawing.Point(139, 224);
            this.cmbSettlementModes.Name = "cmbSettlementModes";
            this.cmbSettlementModes.Size = new System.Drawing.Size(169, 20);
            this.cmbSettlementModes.TabIndex = 1;
            this.cmbSettlementModes.SelectedIndexChanged += new System.EventHandler(this.cmbSettlementModes_SelectedIndexChanged);
            // 
            // cbInvoice
            // 
            this.cbInvoice.AutoSize = true;
            this.cbInvoice.BackColor = System.Drawing.Color.Transparent;
            this.cbInvoice.Location = new System.Drawing.Point(333, 349);
            this.cbInvoice.Name = "cbInvoice";
            this.cbInvoice.Size = new System.Drawing.Size(72, 16);
            this.cbInvoice.TabIndex = 4;
            this.cbInvoice.Text = "是否开票";
            this.cbInvoice.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(431, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "开票内容";
            this.label9.Visible = false;
            // 
            // txtInvoiceContent
            // 
            this.txtInvoiceContent.Location = new System.Drawing.Point(490, 298);
            this.txtInvoiceContent.Name = "txtInvoiceContent";
            this.txtInvoiceContent.Size = new System.Drawing.Size(169, 21);
            this.txtInvoiceContent.TabIndex = 3;
            this.txtInvoiceContent.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(440, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "开票日期";
            this.label11.Visible = false;
            // 
            // dtpInvioceDate
            // 
            this.dtpInvioceDate.Location = new System.Drawing.Point(499, 298);
            this.dtpInvioceDate.Name = "dtpInvioceDate";
            this.dtpInvioceDate.Size = new System.Drawing.Size(169, 21);
            this.dtpInvioceDate.TabIndex = 2;
            this.dtpInvioceDate.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(441, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "发票类型";
            this.label12.Visible = false;
            // 
            // cmbInvoiceType
            // 
            this.cmbInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoiceType.FormattingEnabled = true;
            this.cmbInvoiceType.Items.AddRange(new object[] {
            "增值税发票",
            "普通发票"});
            this.cmbInvoiceType.Location = new System.Drawing.Point(500, 296);
            this.cmbInvoiceType.Name = "cmbInvoiceType";
            this.cmbInvoiceType.Size = new System.Drawing.Size(169, 20);
            this.cmbInvoiceType.TabIndex = 1;
            this.cmbInvoiceType.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(443, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "发票号";
            this.label13.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(312, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(172, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(490, 301);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(106, 21);
            this.txtInvoiceNo.TabIndex = 3;
            this.txtInvoiceNo.Visible = false;
            // 
            // cmbProduct1
            // 
            this.cmbProduct1.DisplayMember = "name";
            this.cmbProduct1.DropDownHeight = 300;
            this.cmbProduct1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct1.DropDownWidth = 200;
            this.cmbProduct1.FormattingEnabled = true;
            this.cmbProduct1.IntegralHeight = false;
            this.cmbProduct1.Location = new System.Drawing.Point(138, 107);
            this.cmbProduct1.Name = "cmbProduct1";
            this.cmbProduct1.Size = new System.Drawing.Size(123, 20);
            this.cmbProduct1.TabIndex = 7;
            this.cmbProduct1.ValueMember = "Id";
            this.cmbProduct1.SelectedIndexChanged += new System.EventHandler(this.cmbProduct1_SelectedIndexChanged);
            // 
            // cmbProduct2
            // 
            this.cmbProduct2.DisplayMember = "name";
            this.cmbProduct2.DropDownHeight = 300;
            this.cmbProduct2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct2.DropDownWidth = 200;
            this.cmbProduct2.FormattingEnabled = true;
            this.cmbProduct2.IntegralHeight = false;
            this.cmbProduct2.Location = new System.Drawing.Point(267, 107);
            this.cmbProduct2.Name = "cmbProduct2";
            this.cmbProduct2.Size = new System.Drawing.Size(123, 20);
            this.cmbProduct2.TabIndex = 7;
            this.cmbProduct2.ValueMember = "Id";
            this.cmbProduct2.Visible = false;
            this.cmbProduct2.SelectedIndexChanged += new System.EventHandler(this.cmbProduct2_SelectedIndexChanged);
            // 
            // cmbProduct3
            // 
            this.cmbProduct3.DisplayMember = "name";
            this.cmbProduct3.DropDownHeight = 300;
            this.cmbProduct3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct3.DropDownWidth = 200;
            this.cmbProduct3.FormattingEnabled = true;
            this.cmbProduct3.IntegralHeight = false;
            this.cmbProduct3.Location = new System.Drawing.Point(398, 107);
            this.cmbProduct3.Name = "cmbProduct3";
            this.cmbProduct3.Size = new System.Drawing.Size(123, 20);
            this.cmbProduct3.TabIndex = 7;
            this.cmbProduct3.ValueMember = "Id";
            this.cmbProduct3.Visible = false;
            this.cmbProduct3.SelectedIndexChanged += new System.EventHandler(this.cmbProduct3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(80, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "销售名称";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(139, 26);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(382, 20);
            this.cmbUserName.TabIndex = 8;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged_1);
            this.cmbUserName.SelectionChangeCommitted += new System.EventHandler(this.cmbUserName_SelectionChangeCommitted);
            // 
            // txtStockOutNo
            // 
            this.txtStockOutNo.Location = new System.Drawing.Point(352, 224);
            this.txtStockOutNo.Name = "txtStockOutNo";
            this.txtStockOutNo.Size = new System.Drawing.Size(169, 21);
            this.txtStockOutNo.TabIndex = 3;
            this.txtStockOutNo.TextChanged += new System.EventHandler(this.txtStockOutNo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(104, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "单价";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(-138, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "单价";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(316, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "单位";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(433, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Visible = false;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "张",
            "个",
            "颗",
            "台",
            "块"});
            this.cmbUnit.Location = new System.Drawing.Point(352, 261);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(169, 20);
            this.cmbUnit.TabIndex = 1;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(80, 269);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 14;
            this.label16.Text = "是否开票";
            // 
            // CmbInvoiceFlag
            // 
            this.CmbInvoiceFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbInvoiceFlag.FormattingEnabled = true;
            this.CmbInvoiceFlag.Items.AddRange(new object[] {
            "开票",
            "不开票"});
            this.CmbInvoiceFlag.Location = new System.Drawing.Point(139, 264);
            this.CmbInvoiceFlag.Name = "CmbInvoiceFlag";
            this.CmbInvoiceFlag.Size = new System.Drawing.Size(169, 20);
            this.CmbInvoiceFlag.TabIndex = 13;
            // 
            // 销售明细维护
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 363);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CmbInvoiceFlag);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.cmbProduct3);
            this.Controls.Add(this.cmbProduct2);
            this.Controls.Add(this.cmbProduct1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbInvoice);
            this.Controls.Add(this.txtStockOutNo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.txtInvoiceContent);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dtpInvioceDate);
            this.Controls.Add(this.dtpDate1);
            this.Controls.Add(this.cmbInvoiceType);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.cmbSettlementModes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbCustomerName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "销售明细维护";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售明细录入";
            this.Load += new System.EventHandler(this.销售明细维护_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSettlementModes;
        private System.Windows.Forms.CheckBox cbInvoice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInvoiceContent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpInvioceDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbInvoiceType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.ComboBox cmbProduct1;
        private System.Windows.Forms.ComboBox cmbProduct2;
        private System.Windows.Forms.ComboBox cmbProduct3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.TextBox txtStockOutNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CmbInvoiceFlag;
    }
}