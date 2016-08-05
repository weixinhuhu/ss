namespace 销售管理.日常业务.供应商管理
{
    partial class 发票信息编辑
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
            this.txtContractNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoTaxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoTaxSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvoiceNum = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContractGoodsName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPriceTax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHasInvoice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "采购合同编号";
            // 
            // txtContractNum
            // 
            this.txtContractNum.Location = new System.Drawing.Point(133, 27);
            this.txtContractNum.Name = "txtContractNum";
            this.txtContractNum.ReadOnly = true;
            this.txtContractNum.Size = new System.Drawing.Size(188, 21);
            this.txtContractNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(376, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "到票数量";
            // 
            // txtInvoiceCount
            // 
            this.txtInvoiceCount.Location = new System.Drawing.Point(448, 54);
            this.txtInvoiceCount.Name = "txtInvoiceCount";
            this.txtInvoiceCount.Size = new System.Drawing.Size(188, 21);
            this.txtInvoiceCount.TabIndex = 1;
            this.txtInvoiceCount.TextChanged += new System.EventHandler(this.txtInvoiceCount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(84, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "单位";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(133, 136);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(188, 21);
            this.txtUnit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(48, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "不含税单价";
            // 
            // txtNoTaxPrice
            // 
            this.txtNoTaxPrice.Location = new System.Drawing.Point(133, 81);
            this.txtNoTaxPrice.Name = "txtNoTaxPrice";
            this.txtNoTaxPrice.Size = new System.Drawing.Size(188, 21);
            this.txtNoTaxPrice.TabIndex = 1;
            this.txtNoTaxPrice.TextChanged += new System.EventHandler(this.txtInvoiceCount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(48, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "不含税合计";
            // 
            // txtNoTaxSum
            // 
            this.txtNoTaxSum.Location = new System.Drawing.Point(133, 108);
            this.txtNoTaxSum.Name = "txtNoTaxSum";
            this.txtNoTaxSum.ReadOnly = true;
            this.txtNoTaxSum.Size = new System.Drawing.Size(188, 21);
            this.txtNoTaxSum.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(376, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "含税合计";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(448, 108);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(188, 21);
            this.txtSum.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(60, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "发票号码";
            // 
            // txtInvoiceNum
            // 
            this.txtInvoiceNum.Location = new System.Drawing.Point(133, 54);
            this.txtInvoiceNum.Name = "txtInvoiceNum";
            this.txtInvoiceNum.Size = new System.Drawing.Size(188, 21);
            this.txtInvoiceNum.TabIndex = 1;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(133, 165);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(503, 63);
            this.txtRemark.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(84, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "备注";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(352, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "采购物品名称";
            // 
            // txtContractGoodsName
            // 
            this.txtContractGoodsName.Location = new System.Drawing.Point(448, 27);
            this.txtContractGoodsName.Name = "txtContractGoodsName";
            this.txtContractGoodsName.ReadOnly = true;
            this.txtContractGoodsName.Size = new System.Drawing.Size(188, 21);
            this.txtContractGoodsName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(376, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "合同单价";
            // 
            // txtPriceTax
            // 
            this.txtPriceTax.Location = new System.Drawing.Point(448, 81);
            this.txtPriceTax.Name = "txtPriceTax";
            this.txtPriceTax.ReadOnly = true;
            this.txtPriceTax.Size = new System.Drawing.Size(188, 21);
            this.txtPriceTax.TabIndex = 1;
            this.txtPriceTax.TextChanged += new System.EventHandler(this.txtInvoiceCount_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(364, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "已到票数量";
            // 
            // txtHasInvoice
            // 
            this.txtHasInvoice.Location = new System.Drawing.Point(448, 136);
            this.txtHasInvoice.Name = "txtHasInvoice";
            this.txtHasInvoice.ReadOnly = true;
            this.txtHasInvoice.Size = new System.Drawing.Size(188, 21);
            this.txtHasInvoice.TabIndex = 1;
            // 
            // 发票信息编辑
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 299);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoTaxSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPriceTax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNoTaxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHasInvoice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvoiceCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInvoiceNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContractGoodsName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtContractNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "发票信息编辑";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发票信息编辑";
            this.Load += new System.EventHandler(this.发票信息编辑_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContractNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoiceCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoTaxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoTaxSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInvoiceNum;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContractGoodsName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPriceTax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHasInvoice;
    }
}