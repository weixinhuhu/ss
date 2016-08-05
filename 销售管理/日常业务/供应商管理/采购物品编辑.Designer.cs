namespace 销售管理.日常业务.供应商管理
{
    partial class 采购物品编辑
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
            this.txtNorms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.ZDUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbCaiGou = new System.Windows.Forms.RadioButton();
            this.rbWeiWai = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ZDUnitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNorms
            // 
            this.txtNorms.Location = new System.Drawing.Point(169, 119);
            this.txtNorms.Name = "txtNorms";
            this.txtNorms.Size = new System.Drawing.Size(161, 21);
            this.txtNorms.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(98, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "规格型号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(98, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "单位";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 21);
            this.txtName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(98, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "名称";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(169, 146);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.ReadOnly = true;
            this.txtTypeName.Size = new System.Drawing.Size(161, 21);
            this.txtTypeName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(98, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "所属类目";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(169, 173);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(161, 21);
            this.txtRemark.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(98, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "备注";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DataSource = this.ZDUnitBindingSource;
            this.cmbUnit.DisplayMember = "IntID";
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(169, 66);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(161, 20);
            this.cmbUnit.TabIndex = 20;
            this.cmbUnit.ValueMember = "IntID";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 49);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(98, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "参考价格";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(169, 92);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(161, 21);
            this.txtPrice.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(98, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "物品编码";
            this.label7.Visible = false;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(169, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(161, 21);
            this.txtNum.TabIndex = 11;
            this.txtNum.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(98, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "物品类型";
            // 
            // rbCaiGou
            // 
            this.rbCaiGou.AutoSize = true;
            this.rbCaiGou.BackColor = System.Drawing.Color.Transparent;
            this.rbCaiGou.Checked = true;
            this.rbCaiGou.Location = new System.Drawing.Point(190, 202);
            this.rbCaiGou.Name = "rbCaiGou";
            this.rbCaiGou.Size = new System.Drawing.Size(47, 16);
            this.rbCaiGou.TabIndex = 28;
            this.rbCaiGou.TabStop = true;
            this.rbCaiGou.Text = "采购";
            this.rbCaiGou.UseVisualStyleBackColor = false;
            this.rbCaiGou.CheckedChanged += new System.EventHandler(this.rbCaiGou_CheckedChanged);
            // 
            // rbWeiWai
            // 
            this.rbWeiWai.AutoSize = true;
            this.rbWeiWai.BackColor = System.Drawing.Color.Transparent;
            this.rbWeiWai.Location = new System.Drawing.Point(259, 202);
            this.rbWeiWai.Name = "rbWeiWai";
            this.rbWeiWai.Size = new System.Drawing.Size(71, 16);
            this.rbWeiWai.TabIndex = 28;
            this.rbWeiWai.Text = "委外加工";
            this.rbWeiWai.UseVisualStyleBackColor = false;
            this.rbWeiWai.CheckedChanged += new System.EventHandler(this.rbCaiGou_CheckedChanged);
            // 
            // 采购物品编辑
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 286);
            this.Controls.Add(this.rbWeiWai);
            this.Controls.Add(this.rbCaiGou);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNorms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "采购物品编辑";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购物品编辑";
            this.Load += new System.EventHandler(this.采购物品编辑_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZDUnitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNorms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.BindingSource ZDUnitBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbCaiGou;
        private System.Windows.Forms.RadioButton rbWeiWai;
    }
}