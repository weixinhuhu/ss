namespace 销售管理.日常业务.供应商管理
{
    partial class 选择采购物品
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDaGoods = new System.Windows.Forms.DataGridView();
            this.dg物品编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg参考价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg规格型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg所属类目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg录入时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg录入人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGoodsNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DaSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaGoodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaSupplierBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(634, 75);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 34);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(374, 25);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(282, 21);
            this.txtGoodsName.TabIndex = 9;
            this.txtGoodsName.TextChanged += new System.EventHandler(this.txtGoodsNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(291, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "采购物品名称";
            // 
            // dgvDaGoods
            // 
            this.dgvDaGoods.AllowUserToAddRows = false;
            this.dgvDaGoods.AllowUserToDeleteRows = false;
            this.dgvDaGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDaGoods.AutoGenerateColumns = false;
            this.dgvDaGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg物品编码,
            this.dg名称,
            this.dg参考价格,
            this.dg单位,
            this.dg规格型号,
            this.dg所属类目,
            this.dg备注,
            this.dg录入时间,
            this.dg录入人});
            this.dgvDaGoods.DataSource = this.DaGoodsBindingSource;
            this.dgvDaGoods.Location = new System.Drawing.Point(27, 134);
            this.dgvDaGoods.MultiSelect = false;
            this.dgvDaGoods.Name = "dgvDaGoods";
            this.dgvDaGoods.ReadOnly = true;
            this.dgvDaGoods.RowTemplate.Height = 23;
            this.dgvDaGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaGoods.Size = new System.Drawing.Size(758, 352);
            this.dgvDaGoods.TabIndex = 11;
            this.dgvDaGoods.SelectionChanged += new System.EventHandler(this.dgvDaGoods_SelectionChanged);
            this.dgvDaGoods.DoubleClick += new System.EventHandler(this.dgvDaGoods_DoubleClick);
            // 
            // dg物品编码
            // 
            this.dg物品编码.DataPropertyName = "VcNum";
            this.dg物品编码.HeaderText = "物品编码";
            this.dg物品编码.Name = "dg物品编码";
            this.dg物品编码.ReadOnly = true;
            this.dg物品编码.Width = 78;
            // 
            // dg名称
            // 
            this.dg名称.DataPropertyName = "VcName";
            this.dg名称.HeaderText = "名称";
            this.dg名称.Name = "dg名称";
            this.dg名称.ReadOnly = true;
            this.dg名称.Width = 54;
            // 
            // dg参考价格
            // 
            this.dg参考价格.DataPropertyName = "MonPrice";
            this.dg参考价格.HeaderText = "参考价格";
            this.dg参考价格.Name = "dg参考价格";
            this.dg参考价格.ReadOnly = true;
            this.dg参考价格.Width = 78;
            // 
            // dg单位
            // 
            this.dg单位.HeaderText = "单位";
            this.dg单位.Name = "dg单位";
            this.dg单位.ReadOnly = true;
            this.dg单位.Width = 54;
            // 
            // dg规格型号
            // 
            this.dg规格型号.DataPropertyName = "VcNorms";
            this.dg规格型号.HeaderText = "规格型号";
            this.dg规格型号.Name = "dg规格型号";
            this.dg规格型号.ReadOnly = true;
            this.dg规格型号.Width = 78;
            // 
            // dg所属类目
            // 
            this.dg所属类目.HeaderText = "所属类目";
            this.dg所属类目.Name = "dg所属类目";
            this.dg所属类目.ReadOnly = true;
            this.dg所属类目.Width = 78;
            // 
            // dg备注
            // 
            this.dg备注.DataPropertyName = "VcRemark";
            this.dg备注.HeaderText = "备注";
            this.dg备注.Name = "dg备注";
            this.dg备注.ReadOnly = true;
            this.dg备注.Width = 54;
            // 
            // dg录入时间
            // 
            this.dg录入时间.DataPropertyName = "DtCreate";
            this.dg录入时间.HeaderText = "录入时间";
            this.dg录入时间.Name = "dg录入时间";
            this.dg录入时间.ReadOnly = true;
            this.dg录入时间.Width = 78;
            // 
            // dg录入人
            // 
            this.dg录入人.HeaderText = "录入人";
            this.dg录入人.Name = "dg录入人";
            this.dg录入人.ReadOnly = true;
            this.dg录入人.Width = 66;
            // 
            // txtGoodsNum
            // 
            this.txtGoodsNum.Location = new System.Drawing.Point(103, 25);
            this.txtGoodsNum.Name = "txtGoodsNum";
            this.txtGoodsNum.Size = new System.Drawing.Size(182, 21);
            this.txtGoodsNum.TabIndex = 13;
            this.txtGoodsNum.TextChanged += new System.EventHandler(this.txtGoodsNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(44, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "物品编码";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(483, 83);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(124, 21);
            this.txtSum.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(441, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 41;
            this.label15.Text = "总价";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(125, 83);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 21);
            this.txtPrice.TabIndex = 40;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(262, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 39;
            this.label14.Text = "数量";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(304, 83);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(124, 21);
            this.txtCount.TabIndex = 38;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(83, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "单价";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGoodsName);
            this.groupBox1.Controls.Add(this.txtGoodsNum);
            this.groupBox1.Location = new System.Drawing.Point(49, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 64);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查找";
            // 
            // 选择采购物品
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDaGoods);
            this.Controls.Add(this.btnOK);
            this.Name = "选择采购物品";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择采购物品";
            this.Load += new System.EventHandler(this.选择采购物品_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaGoodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaSupplierBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDaGoods;
        private System.Windows.Forms.TextBox txtGoodsNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource DaGoodsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg物品编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg参考价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg规格型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg所属类目;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg录入时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg录入人;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource DaSupplierBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtSum;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtCount;
    }
}