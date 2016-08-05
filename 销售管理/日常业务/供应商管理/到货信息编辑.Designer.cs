namespace 销售管理.日常业务.供应商管理
{
    partial class 到货信息编辑
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStockInCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContractNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHasStockInCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockInName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContractCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(436, 123);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(150, 21);
            this.txtSum.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(340, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "入库金额";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(436, 69);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(150, 21);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(340, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "入库单价";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(436, 96);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(150, 21);
            this.txtUnit.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(340, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "入库单位";
            // 
            // txtStockInCount
            // 
            this.txtStockInCount.Location = new System.Drawing.Point(169, 123);
            this.txtStockInCount.Name = "txtStockInCount";
            this.txtStockInCount.Size = new System.Drawing.Size(150, 21);
            this.txtStockInCount.TabIndex = 11;
            this.txtStockInCount.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtStockInCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(73, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "入库数量";
            // 
            // txtContractNum
            // 
            this.txtContractNum.Location = new System.Drawing.Point(436, 42);
            this.txtContractNum.Name = "txtContractNum";
            this.txtContractNum.ReadOnly = true;
            this.txtContractNum.Size = new System.Drawing.Size(150, 21);
            this.txtContractNum.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(340, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "采购合同编号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(73, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "已入库数量";
            // 
            // txtHasStockInCount
            // 
            this.txtHasStockInCount.Location = new System.Drawing.Point(169, 96);
            this.txtHasStockInCount.Name = "txtHasStockInCount";
            this.txtHasStockInCount.ReadOnly = true;
            this.txtHasStockInCount.Size = new System.Drawing.Size(150, 21);
            this.txtHasStockInCount.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(73, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "入库物品名称";
            // 
            // txtStockInName
            // 
            this.txtStockInName.Location = new System.Drawing.Point(169, 42);
            this.txtStockInName.Name = "txtStockInName";
            this.txtStockInName.ReadOnly = true;
            this.txtStockInName.Size = new System.Drawing.Size(150, 21);
            this.txtStockInName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(73, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "采购数量";
            // 
            // txtContractCount
            // 
            this.txtContractCount.Location = new System.Drawing.Point(169, 69);
            this.txtContractCount.Name = "txtContractCount";
            this.txtContractCount.ReadOnly = true;
            this.txtContractCount.Size = new System.Drawing.Size(150, 21);
            this.txtContractCount.TabIndex = 12;
            // 
            // 到货信息编辑
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 252);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHasStockInCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStockInCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContractCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStockInName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContractNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "到货信息编辑";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "到货信息编辑";
            this.Load += new System.EventHandler(this.到货信息编辑_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStockInCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContractNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHasStockInCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockInName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContractCount;
    }
}