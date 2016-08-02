namespace 销售管理.系统设置
{
    partial class 消费卡维护
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
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.tCardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCards = new 销售管理.DAL.DataSetCards();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.t_CardsTableAdapter = new 销售管理.DAL.DataSetCardsTableAdapters.T_CardsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCards)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvCards
            // 
            this.dgvCards.AllowUserToAddRows = false;
            this.dgvCards.AllowUserToDeleteRows = false;
            this.dgvCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCards.AutoGenerateColumns = false;
            this.dgvCards.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColModify,
            this.ColDel,
            this.cardNameDataGridViewTextBoxColumn,
            this.cardBalanceDataGridViewTextBoxColumn,
            this.UserName});
            this.dgvCards.DataSource = this.tCardsBindingSource;
            this.dgvCards.Location = new System.Drawing.Point(24, 88);
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.ReadOnly = true;
            this.dgvCards.RowTemplate.Height = 23;
            this.dgvCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCards.Size = new System.Drawing.Size(945, 587);
            this.dgvCards.TabIndex = 1;
            this.dgvCards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCards_CellContentClick);
            // 
            // tCardsBindingSource
            // 
            this.tCardsBindingSource.DataMember = "T_Cards";
            this.tCardsBindingSource.DataSource = this.dataSetCards;
            // 
            // dataSetCards
            // 
            this.dataSetCards.DataSetName = "DataSetCards";
            this.dataSetCards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // llAdd
            // 
            this.llAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAdd.AutoSize = true;
            this.llAdd.Location = new System.Drawing.Point(833, 59);
            this.llAdd.Name = "llAdd";
            this.llAdd.Size = new System.Drawing.Size(65, 12);
            this.llAdd.TabIndex = 2;
            this.llAdd.TabStop = true;
            this.llAdd.Text = "添加礼品卡";
            this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
            // 
            // t_CardsTableAdapter
            // 
            this.t_CardsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // ColModify
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "修改";
            this.ColModify.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColModify.HeaderText = "修改";
            this.ColModify.Name = "ColModify";
            this.ColModify.ReadOnly = true;
            // 
            // ColDel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "删除";
            this.ColDel.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDel.HeaderText = "删除";
            this.ColDel.Name = "ColDel";
            this.ColDel.ReadOnly = true;
            // 
            // cardNameDataGridViewTextBoxColumn
            // 
            this.cardNameDataGridViewTextBoxColumn.DataPropertyName = "CardName";
            this.cardNameDataGridViewTextBoxColumn.HeaderText = "消费卡名称";
            this.cardNameDataGridViewTextBoxColumn.Name = "cardNameDataGridViewTextBoxColumn";
            this.cardNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardNameDataGridViewTextBoxColumn.Width = 400;
            // 
            // cardBalanceDataGridViewTextBoxColumn
            // 
            this.cardBalanceDataGridViewTextBoxColumn.DataPropertyName = "CardBalance";
            this.cardBalanceDataGridViewTextBoxColumn.HeaderText = "卡余额";
            this.cardBalanceDataGridViewTextBoxColumn.Name = "cardBalanceDataGridViewTextBoxColumn";
            this.cardBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardBalanceDataGridViewTextBoxColumn.Width = 200;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "领用人";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // 消费卡维护
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.dgvCards);
            this.Controls.Add(this.llAdd);
            this.Name = "消费卡维护";
            this.Load += new System.EventHandler(this.消费卡维护_Load);
            this.Controls.SetChildIndex(this.llAdd, 0);
            this.Controls.SetChildIndex(this.dgvCards, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCards;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.BindingSource tCardsBindingSource;
        private DAL.DataSetCards dataSetCards;
        private DAL.DataSetCardsTableAdapters.T_CardsTableAdapter t_CardsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}
