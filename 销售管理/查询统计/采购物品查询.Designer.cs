namespace 销售管理.查询统计
{
    partial class 采购物品查询
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtGoodsNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDaGoods = new System.Windows.Forms.DataGridView();
            this.bsDaGoods = new System.Windows.Forms.BindingSource(this.components);
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.Col历史采购明细 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Col物品编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(841, 87);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(88, 24);
            this.btnExcel.TabIndex = 19;
            this.btnExcel.Text = "导出到EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(841, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 24);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtGoodsNum
            // 
            this.txtGoodsNum.Location = new System.Drawing.Point(103, 52);
            this.txtGoodsNum.Name = "txtGoodsNum";
            this.txtGoodsNum.Size = new System.Drawing.Size(132, 21);
            this.txtGoodsNum.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "物品代码";
            // 
            // dgvDaGoods
            // 
            this.dgvDaGoods.AllowUserToAddRows = false;
            this.dgvDaGoods.AllowUserToDeleteRows = false;
            this.dgvDaGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDaGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDaGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col历史采购明细,
            this.Col物品编号});
            this.dgvDaGoods.Location = new System.Drawing.Point(46, 151);
            this.dgvDaGoods.Name = "dgvDaGoods";
            this.dgvDaGoods.ReadOnly = true;
            this.dgvDaGoods.RowTemplate.Height = 23;
            this.dgvDaGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaGoods.Size = new System.Drawing.Size(910, 497);
            this.dgvDaGoods.TabIndex = 14;
            this.dgvDaGoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaGoods_CellClick);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(315, 52);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(177, 21);
            this.txtGoodsName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "物品名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "录入人";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(545, 52);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(136, 20);
            this.cmbUsers.TabIndex = 21;
            // 
            // Col历史采购明细
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "历史采购明细";
            this.Col历史采购明细.DefaultCellStyle = dataGridViewCellStyle1;
            this.Col历史采购明细.HeaderText = "历史采购明细";
            this.Col历史采购明细.Name = "Col历史采购明细";
            this.Col历史采购明细.ReadOnly = true;
            this.Col历史采购明细.Width = 83;
            // 
            // Col物品编号
            // 
            this.Col物品编号.DataPropertyName = "物品编号";
            this.Col物品编号.HeaderText = "物品编号";
            this.Col物品编号.Name = "Col物品编号";
            this.Col物品编号.ReadOnly = true;
            this.Col物品编号.Width = 78;
            // 
            // 采购物品查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.txtGoodsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDaGoods);
            this.Name = "采购物品查询";
            this.Load += new System.EventHandler(this.采购物品查询_Load);
            this.Controls.SetChildIndex(this.dgvDaGoods, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtGoodsNum, 0);
            this.Controls.SetChildIndex(this.txtGoodsName, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnExcel, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.cmbUsers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtGoodsNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDaGoods;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsDaGoods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.DataGridViewButtonColumn Col历史采购明细;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col物品编号;
    }
}
