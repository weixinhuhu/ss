namespace 销售管理.系统设置
{
    partial class 礼品库维护
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llNum = new System.Windows.Forms.LinkLabel();
            this.llType = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGiftsName = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvGifts = new System.Windows.Forms.DataGridView();
            this.tGiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGifts = new 销售管理.DAL.DataSetGifts();
            this.t_GiftsTableAdapter = new 销售管理.DAL.DataSetGiftsTableAdapters.T_GiftsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.giftNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGiftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGifts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.llNum);
            this.groupBox1.Controls.Add(this.llType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbGiftsName);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Location = new System.Drawing.Point(31, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查找";
            // 
            // llNum
            // 
            this.llNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llNum.AutoSize = true;
            this.llNum.Location = new System.Drawing.Point(817, 57);
            this.llNum.Name = "llNum";
            this.llNum.Size = new System.Drawing.Size(77, 12);
            this.llNum.TabIndex = 4;
            this.llNum.TabStop = true;
            this.llNum.Text = "添加礼品库存";
            this.llNum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNum_LinkClicked);
            // 
            // llType
            // 
            this.llType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llType.AutoSize = true;
            this.llType.Location = new System.Drawing.Point(724, 57);
            this.llType.Name = "llType";
            this.llType.Size = new System.Drawing.Size(77, 12);
            this.llType.TabIndex = 3;
            this.llType.TabStop = true;
            this.llType.Text = "添加礼品种类";
            this.llType.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llType_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "礼品名称";
            // 
            // cmbGiftsName
            // 
            this.cmbGiftsName.DropDownWidth = 300;
            this.cmbGiftsName.FormattingEnabled = true;
            this.cmbGiftsName.Location = new System.Drawing.Point(110, 30);
            this.cmbGiftsName.Name = "cmbGiftsName";
            this.cmbGiftsName.Size = new System.Drawing.Size(192, 20);
            this.cmbGiftsName.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(819, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(71, 29);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "查找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvGifts
            // 
            this.dgvGifts.AllowUserToAddRows = false;
            this.dgvGifts.AllowUserToDeleteRows = false;
            this.dgvGifts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGifts.AutoGenerateColumns = false;
            this.dgvGifts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvGifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColDel,
            this.ColModify,
            this.giftNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockNumDataGridViewTextBoxColumn});
            this.dgvGifts.DataSource = this.tGiftsBindingSource;
            this.dgvGifts.Location = new System.Drawing.Point(31, 100);
            this.dgvGifts.Name = "dgvGifts";
            this.dgvGifts.RowTemplate.Height = 23;
            this.dgvGifts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGifts.Size = new System.Drawing.Size(934, 570);
            this.dgvGifts.TabIndex = 2;
            this.dgvGifts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGifts_CellContentClick);
            // 
            // tGiftsBindingSource
            // 
            this.tGiftsBindingSource.DataMember = "T_Gifts";
            this.tGiftsBindingSource.DataSource = this.dataSetGifts;
            // 
            // dataSetGifts
            // 
            this.dataSetGifts.DataSetName = "DataSetGifts";
            this.dataSetGifts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_GiftsTableAdapter
            // 
            this.t_GiftsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // ColDel
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "删除";
            this.ColDel.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColDel.HeaderText = "删除";
            this.ColDel.Name = "ColDel";
            // 
            // ColModify
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "修改";
            this.ColModify.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColModify.HeaderText = "修改";
            this.ColModify.Name = "ColModify";
            // 
            // giftNameDataGridViewTextBoxColumn
            // 
            this.giftNameDataGridViewTextBoxColumn.DataPropertyName = "GiftName";
            this.giftNameDataGridViewTextBoxColumn.HeaderText = "礼品名称";
            this.giftNameDataGridViewTextBoxColumn.Name = "giftNameDataGridViewTextBoxColumn";
            this.giftNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockNumDataGridViewTextBoxColumn
            // 
            this.stockNumDataGridViewTextBoxColumn.DataPropertyName = "StockNum";
            this.stockNumDataGridViewTextBoxColumn.HeaderText = "库存数量";
            this.stockNumDataGridViewTextBoxColumn.Name = "stockNumDataGridViewTextBoxColumn";
            this.stockNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockNumDataGridViewTextBoxColumn.Width = 200;
            // 
            // 礼品库维护
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGifts);
            this.Name = "礼品库维护";
            this.Load += new System.EventHandler(this.礼品库维护_Load);
            this.Controls.SetChildIndex(this.dgvGifts, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGiftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGifts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGifts;
        private System.Windows.Forms.BindingSource tGiftsBindingSource;
        private DAL.DataSetGifts dataSetGifts;
        private DAL.DataSetGiftsTableAdapters.T_GiftsTableAdapter t_GiftsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGiftsName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.LinkLabel llNum;
        private System.Windows.Forms.LinkLabel llType;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNumDataGridViewTextBoxColumn;
    }
}
