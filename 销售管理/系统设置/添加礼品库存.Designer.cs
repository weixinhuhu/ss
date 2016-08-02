namespace 销售管理.系统设置
{
    partial class 添加礼品库存
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(添加礼品库存));
            this.dgvGifts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGifts = new 销售管理.DAL.DataSetGifts();
            this.t_GiftsTableAdapter = new 销售管理.DAL.DataSetGiftsTableAdapters.T_GiftsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGiftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGifts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGifts
            // 
            this.dgvGifts.AllowUserToAddRows = false;
            this.dgvGifts.AllowUserToDeleteRows = false;
            this.dgvGifts.AutoGenerateColumns = false;
            this.dgvGifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.giftNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockNumDataGridViewTextBoxColumn});
            this.dgvGifts.DataSource = this.tGiftsBindingSource;
            this.dgvGifts.Location = new System.Drawing.Point(24, 12);
            this.dgvGifts.MultiSelect = false;
            this.dgvGifts.Name = "dgvGifts";
            this.dgvGifts.ReadOnly = true;
            this.dgvGifts.RowTemplate.Height = 23;
            this.dgvGifts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGifts.Size = new System.Drawing.Size(462, 248);
            this.dgvGifts.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // giftNameDataGridViewTextBoxColumn
            // 
            this.giftNameDataGridViewTextBoxColumn.DataPropertyName = "GiftName";
            this.giftNameDataGridViewTextBoxColumn.HeaderText = "礼品名称";
            this.giftNameDataGridViewTextBoxColumn.Name = "giftNameDataGridViewTextBoxColumn";
            this.giftNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.giftNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockNumDataGridViewTextBoxColumn
            // 
            this.stockNumDataGridViewTextBoxColumn.DataPropertyName = "StockNum";
            this.stockNumDataGridViewTextBoxColumn.HeaderText = "库存数量";
            this.stockNumDataGridViewTextBoxColumn.Name = "stockNumDataGridViewTextBoxColumn";
            this.stockNumDataGridViewTextBoxColumn.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(84, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "入库数量";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(143, 285);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 21);
            this.txtNum.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(288, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "入库";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // 添加礼品库存
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 356);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGifts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "添加礼品库存";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加礼品库存";
            this.Load += new System.EventHandler(this.添加礼品库存_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGiftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGifts;
        private DAL.DataSetGifts dataSetGifts;
        private System.Windows.Forms.BindingSource tGiftsBindingSource;
        private DAL.DataSetGiftsTableAdapters.T_GiftsTableAdapter t_GiftsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}