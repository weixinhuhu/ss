namespace 销售管理.日常业务
{
    partial class 申请餐费报销
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
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataDate = new System.Windows.Forms.DateTimePicker();
            this.txtMealMoney = new System.Windows.Forms.TextBox();
            this.txtMaxSum = new System.Windows.Forms.TextBox();
            this.txtCardBalance = new System.Windows.Forms.TextBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.labDatadate = new System.Windows.Forms.Label();
            this.labMealMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCard = new System.Windows.Forms.ComboBox();
            this.labCardBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CBoxUsed = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(180, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CBoxUsed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDataDate);
            this.groupBox1.Controls.Add(this.txtMealMoney);
            this.groupBox1.Controls.Add(this.txtMaxSum);
            this.groupBox1.Controls.Add(this.txtCardBalance);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.labDatadate);
            this.groupBox1.Controls.Add(this.labMealMoney);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbCard);
            this.groupBox1.Controls.Add(this.labCardBalance);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUsers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "领用信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpDataDate
            // 
            this.dtpDataDate.Location = new System.Drawing.Point(121, 248);
            this.dtpDataDate.Name = "dtpDataDate";
            this.dtpDataDate.Size = new System.Drawing.Size(240, 21);
            this.dtpDataDate.TabIndex = 15;
            // 
            // txtMealMoney
            // 
            this.txtMealMoney.Location = new System.Drawing.Point(121, 216);
            this.txtMealMoney.Name = "txtMealMoney";
            this.txtMealMoney.Size = new System.Drawing.Size(240, 21);
            this.txtMealMoney.TabIndex = 12;
            // 
            // txtMaxSum
            // 
            this.txtMaxSum.Location = new System.Drawing.Point(121, 90);
            this.txtMaxSum.Name = "txtMaxSum";
            this.txtMaxSum.ReadOnly = true;
            this.txtMaxSum.Size = new System.Drawing.Size(240, 21);
            this.txtMaxSum.TabIndex = 13;
            // 
            // txtCardBalance
            // 
            this.txtCardBalance.Location = new System.Drawing.Point(121, 184);
            this.txtCardBalance.Name = "txtCardBalance";
            this.txtCardBalance.ReadOnly = true;
            this.txtCardBalance.Size = new System.Drawing.Size(240, 21);
            this.txtCardBalance.TabIndex = 13;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DisplayMember = "CompanyName";
            this.cmbCustomers.DropDownHeight = 300;
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.DropDownWidth = 260;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.IntegralHeight = false;
            this.cmbCustomers.Location = new System.Drawing.Point(121, 122);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(240, 20);
            this.cmbCustomers.TabIndex = 10;
            this.cmbCustomers.ValueMember = "Id";
            // 
            // labDatadate
            // 
            this.labDatadate.AutoSize = true;
            this.labDatadate.BackColor = System.Drawing.Color.Transparent;
            this.labDatadate.Location = new System.Drawing.Point(64, 254);
            this.labDatadate.Name = "labDatadate";
            this.labDatadate.Size = new System.Drawing.Size(53, 12);
            this.labDatadate.TabIndex = 7;
            this.labDatadate.Text = "消费日期";
            // 
            // labMealMoney
            // 
            this.labMealMoney.AutoSize = true;
            this.labMealMoney.BackColor = System.Drawing.Color.Transparent;
            this.labMealMoney.Location = new System.Drawing.Point(40, 220);
            this.labMealMoney.Name = "labMealMoney";
            this.labMealMoney.Size = new System.Drawing.Size(77, 12);
            this.labMealMoney.TabIndex = 7;
            this.labMealMoney.Text = "本次消费金额";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(64, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "客户名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(64, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "剩余额度";
            // 
            // cmbCard
            // 
            this.cmbCard.DisplayMember = "CardName";
            this.cmbCard.DropDownHeight = 300;
            this.cmbCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCard.DropDownWidth = 260;
            this.cmbCard.FormattingEnabled = true;
            this.cmbCard.IntegralHeight = false;
            this.cmbCard.Location = new System.Drawing.Point(121, 153);
            this.cmbCard.Name = "cmbCard";
            this.cmbCard.Size = new System.Drawing.Size(240, 20);
            this.cmbCard.TabIndex = 11;
            this.cmbCard.ValueMember = "Id";
            this.cmbCard.SelectedIndexChanged += new System.EventHandler(this.cmbCard_SelectedIndexChanged);
            // 
            // labCardBalance
            // 
            this.labCardBalance.AutoSize = true;
            this.labCardBalance.BackColor = System.Drawing.Color.Transparent;
            this.labCardBalance.Location = new System.Drawing.Point(52, 188);
            this.labCardBalance.Name = "labCardBalance";
            this.labCardBalance.Size = new System.Drawing.Size(65, 12);
            this.labCardBalance.TabIndex = 6;
            this.labCardBalance.Text = "消费卡余额";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(52, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "消费卡名称";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DisplayMember = "UserName";
            this.cmbUsers.DropDownHeight = 300;
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.DropDownWidth = 260;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.IntegralHeight = false;
            this.cmbUsers.Location = new System.Drawing.Point(121, 28);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(240, 20);
            this.cmbUsers.TabIndex = 9;
            this.cmbUsers.ValueMember = "Id";
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(76, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "领用人";
            // 
            // CBoxUsed
            // 
            this.CBoxUsed.DisplayMember = "UserName";
            this.CBoxUsed.DropDownHeight = 300;
            this.CBoxUsed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxUsed.DropDownWidth = 260;
            this.CBoxUsed.FormattingEnabled = true;
            this.CBoxUsed.IntegralHeight = false;
            this.CBoxUsed.Location = new System.Drawing.Point(121, 59);
            this.CBoxUsed.Name = "CBoxUsed";
            this.CBoxUsed.Size = new System.Drawing.Size(240, 20);
            this.CBoxUsed.TabIndex = 17;
            this.CBoxUsed.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(76, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "使用人";
            // 
            // 申请餐费报销
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 362);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "申请餐费报销";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "申请餐费报销";
            this.Load += new System.EventHandler(this.申请餐费报销_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataDate;
        private System.Windows.Forms.TextBox txtMealMoney;
        private System.Windows.Forms.TextBox txtMaxSum;
        private System.Windows.Forms.TextBox txtCardBalance;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label labDatadate;
        private System.Windows.Forms.Label labMealMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCard;
        private System.Windows.Forms.Label labCardBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox CBoxUsed;
        private System.Windows.Forms.Label label4;
    }
}