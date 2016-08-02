namespace 销售管理.日常业务
{
    partial class 礼品出库申请
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataDate = new System.Windows.Forms.DateTimePicker();
            this.txtCurrentNum = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtGiftPrice = new System.Windows.Forms.TextBox();
            this.txtMaxSum = new System.Windows.Forms.TextBox();
            this.txtStockNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGifts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CBoxUser = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CBoxUser);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpDataDate);
            this.groupBox1.Controls.Add(this.txtCurrentNum);
            this.groupBox1.Controls.Add(this.txtSum);
            this.groupBox1.Controls.Add(this.txtGiftPrice);
            this.groupBox1.Controls.Add(this.txtMaxSum);
            this.groupBox1.Controls.Add(this.txtStockNum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbGifts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUsers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "领用信息";
            // 
            // dtpDataDate
            // 
            this.dtpDataDate.Location = new System.Drawing.Point(101, 270);
            this.dtpDataDate.Name = "dtpDataDate";
            this.dtpDataDate.Size = new System.Drawing.Size(260, 21);
            this.dtpDataDate.TabIndex = 15;
            // 
            // txtCurrentNum
            // 
            this.txtCurrentNum.Location = new System.Drawing.Point(101, 214);
            this.txtCurrentNum.Name = "txtCurrentNum";
            this.txtCurrentNum.Size = new System.Drawing.Size(260, 21);
            this.txtCurrentNum.TabIndex = 12;
            this.txtCurrentNum.TextChanged += new System.EventHandler(this.txtCurrentNum_TextChanged);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(101, 242);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(260, 21);
            this.txtSum.TabIndex = 12;
            // 
            // txtGiftPrice
            // 
            this.txtGiftPrice.Location = new System.Drawing.Point(101, 186);
            this.txtGiftPrice.Name = "txtGiftPrice";
            this.txtGiftPrice.ReadOnly = true;
            this.txtGiftPrice.Size = new System.Drawing.Size(260, 21);
            this.txtGiftPrice.TabIndex = 14;
            // 
            // txtMaxSum
            // 
            this.txtMaxSum.Location = new System.Drawing.Point(101, 76);
            this.txtMaxSum.Name = "txtMaxSum";
            this.txtMaxSum.ReadOnly = true;
            this.txtMaxSum.Size = new System.Drawing.Size(260, 21);
            this.txtMaxSum.TabIndex = 13;
            // 
            // txtStockNum
            // 
            this.txtStockNum.Location = new System.Drawing.Point(101, 158);
            this.txtStockNum.Name = "txtStockNum";
            this.txtStockNum.ReadOnly = true;
            this.txtStockNum.Size = new System.Drawing.Size(260, 21);
            this.txtStockNum.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(42, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "领用数量";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DropDownHeight = 300;
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.DropDownWidth = 260;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.IntegralHeight = false;
            this.cmbCustomers.Location = new System.Drawing.Point(101, 104);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(260, 20);
            this.cmbCustomers.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(42, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "领用日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(66, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "金额";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "客户名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(66, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "单价";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(42, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "剩余额度";
            // 
            // cmbGifts
            // 
            this.cmbGifts.DropDownHeight = 300;
            this.cmbGifts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGifts.DropDownWidth = 260;
            this.cmbGifts.FormattingEnabled = true;
            this.cmbGifts.IntegralHeight = false;
            this.cmbGifts.Location = new System.Drawing.Point(101, 131);
            this.cmbGifts.Name = "cmbGifts";
            this.cmbGifts.Size = new System.Drawing.Size(260, 20);
            this.cmbGifts.TabIndex = 11;
            this.cmbGifts.SelectedIndexChanged += new System.EventHandler(this.cmbGifts_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(42, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "库存数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(42, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "礼品名称";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownHeight = 300;
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.DropDownWidth = 260;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.IntegralHeight = false;
            this.cmbUsers.Location = new System.Drawing.Point(101, 22);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(260, 20);
            this.cmbUsers.TabIndex = 9;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "领用人";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CBoxUser
            // 
            this.CBoxUser.DropDownHeight = 300;
            this.CBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxUser.DropDownWidth = 260;
            this.CBoxUser.FormattingEnabled = true;
            this.CBoxUser.IntegralHeight = false;
            this.CBoxUser.Location = new System.Drawing.Point(101, 49);
            this.CBoxUser.Name = "CBoxUser";
            this.CBoxUser.Size = new System.Drawing.Size(260, 20);
            this.CBoxUser.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(54, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "使用人";
            // 
            // 礼品出库申请
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 382);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "礼品出库申请";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "礼品出库申请";
            this.Load += new System.EventHandler(this.礼品出库申请_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtGiftPrice;
        private System.Windows.Forms.TextBox txtStockNum;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGifts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCurrentNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpDataDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaxSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBoxUser;
        private System.Windows.Forms.Label label10;
    }
}