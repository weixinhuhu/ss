namespace 销售管理.日常业务
{
    partial class 出库单详细
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
            this.cmbProduct3 = new System.Windows.Forms.ComboBox();
            this.cmbProduct2 = new System.Windows.Forms.ComboBox();
            this.cmbProduct1 = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.cmbSettlementModes = new System.Windows.Forms.ComboBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStockOutNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbProduct3
            // 
            this.cmbProduct3.DisplayMember = "name";
            this.cmbProduct3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct3.FormattingEnabled = true;
            this.cmbProduct3.Location = new System.Drawing.Point(370, 122);
            this.cmbProduct3.Name = "cmbProduct3";
            this.cmbProduct3.Size = new System.Drawing.Size(118, 20);
            this.cmbProduct3.TabIndex = 26;
            this.cmbProduct3.ValueMember = "Id";
            this.cmbProduct3.Visible = false;
            this.cmbProduct3.SelectedIndexChanged += new System.EventHandler(this.cmbProduct3_SelectedIndexChanged);
            // 
            // cmbProduct2
            // 
            this.cmbProduct2.DisplayMember = "name";
            this.cmbProduct2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct2.FormattingEnabled = true;
            this.cmbProduct2.Location = new System.Drawing.Point(247, 122);
            this.cmbProduct2.Name = "cmbProduct2";
            this.cmbProduct2.Size = new System.Drawing.Size(118, 20);
            this.cmbProduct2.TabIndex = 27;
            this.cmbProduct2.ValueMember = "Id";
            this.cmbProduct2.Visible = false;
            this.cmbProduct2.SelectedIndexChanged += new System.EventHandler(this.cmbProduct2_SelectedIndexChanged);
            // 
            // cmbProduct1
            // 
            this.cmbProduct1.DisplayMember = "name";
            this.cmbProduct1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct1.FormattingEnabled = true;
            this.cmbProduct1.Location = new System.Drawing.Point(126, 122);
            this.cmbProduct1.Name = "cmbProduct1";
            this.cmbProduct1.Size = new System.Drawing.Size(118, 20);
            this.cmbProduct1.TabIndex = 28;
            this.cmbProduct1.ValueMember = "Id";
            this.cmbProduct1.SelectedIndexChanged += new System.EventHandler(this.cmbProduct1_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(318, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 35);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(126, 200);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(149, 21);
            this.txtPrice.TabIndex = 20;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(339, 200);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(149, 21);
            this.txtSum.TabIndex = 21;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(339, 159);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(149, 21);
            this.txtAmount.TabIndex = 22;
            // 
            // dtpDate1
            // 
            this.dtpDate1.Location = new System.Drawing.Point(126, 158);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(149, 21);
            this.dtpDate1.TabIndex = 19;
            // 
            // cmbSettlementModes
            // 
            this.cmbSettlementModes.FormattingEnabled = true;
            this.cmbSettlementModes.Location = new System.Drawing.Point(126, 248);
            this.cmbSettlementModes.Name = "cmbSettlementModes";
            this.cmbSettlementModes.Size = new System.Drawing.Size(149, 20);
            this.cmbSettlementModes.TabIndex = 18;
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(126, 41);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(362, 20);
            this.cmbUserName.TabIndex = 16;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(126, 81);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(362, 20);
            this.cmbCustomerName.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(67, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "结款方式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(91, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "单价";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(304, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "金额";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(91, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(304, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(67, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "销售名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(67, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "产品名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(67, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "客户名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(304, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "状态";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(339, 247);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(149, 21);
            this.txtStatus.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(67, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "出库单号";
            // 
            // txtStockOutNo
            // 
            this.txtStockOutNo.Location = new System.Drawing.Point(126, 288);
            this.txtStockOutNo.Name = "txtStockOutNo";
            this.txtStockOutNo.Size = new System.Drawing.Size(149, 21);
            this.txtStockOutNo.TabIndex = 21;
            // 
            // 出库单详细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 425);
            this.Controls.Add(this.cmbProduct3);
            this.Controls.Add(this.cmbProduct2);
            this.Controls.Add(this.cmbProduct1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStockOutNo);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dtpDate1);
            this.Controls.Add(this.cmbSettlementModes);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.cmbCustomerName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "出库单详细";
            this.Text = "出库单详细";
            this.Load += new System.EventHandler(this.出库单详细_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProduct3;
        private System.Windows.Forms.ComboBox cmbProduct2;
        private System.Windows.Forms.ComboBox cmbProduct1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.ComboBox cmbSettlementModes;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStockOutNo;
    }
}