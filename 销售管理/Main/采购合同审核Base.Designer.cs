namespace 销售管理.Main
{
    partial class 采购合同审核Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(采购合同审核Base));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNav1 = new WinFormPager.DgvNav(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorPageSizeItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb审核通过 = new System.Windows.Forms.ToolStripButton();
            this.tsb审核不通过 = new System.Windows.Forms.ToolStripButton();
            this.DaPurchaseContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bgCondition = new System.Windows.Forms.GroupBox();
            this.cmbHasAudit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.labelUsers = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDaPurchaseContract = new System.Windows.Forms.DataGridView();
            this.dpc选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dpc采购物品 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNav1)).BeginInit();
            this.dgvNav1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaPurchaseContractBindingSource)).BeginInit();
            this.bgCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaPurchaseContract)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // dgvNav1
            // 
            this.dgvNav1.AddNewItem = null;
            this.dgvNav1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNav1.AutoSize = false;
            this.dgvNav1.ComparyChar = null;
            this.dgvNav1.Conn = null;
            this.dgvNav1.CountItem = this.bindingNavigatorCountItem;
            this.dgvNav1.DataSource = null;
            this.dgvNav1.DeleteItem = null;
            this.dgvNav1.Dock = System.Windows.Forms.DockStyle.None;
            this.dgvNav1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.dgvNav1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorPageSizeItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsb审核通过,
            this.tsb审核不通过});
            this.dgvNav1.Location = new System.Drawing.Point(45, 145);
            this.dgvNav1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dgvNav1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dgvNav1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dgvNav1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dgvNav1.MyBs = this.DaPurchaseContractBindingSource;
            this.dgvNav1.Name = "dgvNav1";
            this.dgvNav1.OrderDirection = null;
            this.dgvNav1.OrderField = null;
            this.dgvNav1.OriginSql = null;
            this.dgvNav1.PageSize = 100;
            this.dgvNav1.PageSizeItem = this.bindingNavigatorPageSizeItem;
            this.dgvNav1.PositionItem = this.bindingNavigatorPositionItem;
            this.dgvNav1.PrimaryKey = null;
            this.dgvNav1.Size = new System.Drawing.Size(910, 25);
            this.dgvNav1.TabIndex = 11;
            this.dgvNav1.Text = "dgvNav1";
            this.dgvNav1.TotalCount = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总页数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "第一页";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "上一页";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "BindingNavigatorPositionAccessibleName";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前页";
            // 
            // bindingNavigatorPageSizeItem
            // 
            this.bindingNavigatorPageSizeItem.AutoSize = false;
            this.bindingNavigatorPageSizeItem.Name = "bindingNavigatorPageSizeItem";
            this.bindingNavigatorPageSizeItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPageSizeItem.Text = "100";
            this.bindingNavigatorPageSizeItem.ToolTipText = "每页显示数量";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "下一页";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最后一页";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb审核通过
            // 
            this.tsb审核通过.Image = global::销售管理.Properties.Resources.Select;
            this.tsb审核通过.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb审核通过.Name = "tsb审核通过";
            this.tsb审核通过.Size = new System.Drawing.Size(76, 22);
            this.tsb审核通过.Text = "审核通过";
            // 
            // tsb审核不通过
            // 
            this.tsb审核不通过.Image = global::销售管理.Properties.Resources.Stop;
            this.tsb审核不通过.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb审核不通过.Name = "tsb审核不通过";
            this.tsb审核不通过.Size = new System.Drawing.Size(88, 22);
            this.tsb审核不通过.Text = "审核不通过";
            // 
            // bgCondition
            // 
            this.bgCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bgCondition.Controls.Add(this.cmbHasAudit);
            this.bgCondition.Controls.Add(this.label5);
            this.bgCondition.Controls.Add(this.cmbUserName);
            this.bgCondition.Controls.Add(this.labelUsers);
            this.bgCondition.Controls.Add(this.btnSearch);
            this.bgCondition.Controls.Add(this.txtNum);
            this.bgCondition.Controls.Add(this.label1);
            this.bgCondition.Location = new System.Drawing.Point(45, 23);
            this.bgCondition.Name = "bgCondition";
            this.bgCondition.Size = new System.Drawing.Size(910, 119);
            this.bgCondition.TabIndex = 10;
            this.bgCondition.TabStop = false;
            this.bgCondition.Text = "查询";
            // 
            // cmbHasAudit
            // 
            this.cmbHasAudit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasAudit.FormattingEnabled = true;
            this.cmbHasAudit.Location = new System.Drawing.Point(477, 49);
            this.cmbHasAudit.Name = "cmbHasAudit";
            this.cmbHasAudit.Size = new System.Drawing.Size(114, 20);
            this.cmbHasAudit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "审核状态";
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.DropDownWidth = 200;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(265, 48);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(140, 20);
            this.cmbUserName.TabIndex = 6;
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Location = new System.Drawing.Point(218, 51);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(41, 12);
            this.labelUsers.TabIndex = 5;
            this.labelUsers.Text = "录入人";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(791, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(100, 48);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 21);
            this.txtNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "合约编号";
            // 
            // dgvDaPurchaseContract
            // 
            this.dgvDaPurchaseContract.AllowUserToAddRows = false;
            this.dgvDaPurchaseContract.AllowUserToDeleteRows = false;
            this.dgvDaPurchaseContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDaPurchaseContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDaPurchaseContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDaPurchaseContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dpc选择,
            this.dpc采购物品});
            this.dgvDaPurchaseContract.Location = new System.Drawing.Point(45, 173);
            this.dgvDaPurchaseContract.Name = "dgvDaPurchaseContract";
            this.dgvDaPurchaseContract.RowTemplate.Height = 23;
            this.dgvDaPurchaseContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaPurchaseContract.ShowEditingIcon = false;
            this.dgvDaPurchaseContract.Size = new System.Drawing.Size(910, 505);
            this.dgvDaPurchaseContract.TabIndex = 9;
            // 
            // dpc选择
            // 
            this.dpc选择.HeaderText = "选择";
            this.dpc选择.Name = "dpc选择";
            this.dpc选择.Width = 35;
            // 
            // dpc采购物品
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "采购物品详细";
            this.dpc采购物品.DefaultCellStyle = dataGridViewCellStyle1;
            this.dpc采购物品.HeaderText = "采购物品";
            this.dpc采购物品.Name = "dpc采购物品";
            this.dpc采购物品.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dpc采购物品.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dpc采购物品.Width = 78;
            // 
            // 采购合同审核Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.dgvNav1);
            this.Controls.Add(this.bgCondition);
            this.Controls.Add(this.dgvDaPurchaseContract);
            this.Name = "采购合同审核Base";
            this.Load += new System.EventHandler(this.采购合同审核Base_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dgvDaPurchaseContract, 0);
            this.Controls.SetChildIndex(this.bgCondition, 0);
            this.Controls.SetChildIndex(this.dgvNav1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNav1)).EndInit();
            this.dgvNav1.ResumeLayout(false);
            this.dgvNav1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaPurchaseContractBindingSource)).EndInit();
            this.bgCondition.ResumeLayout(false);
            this.bgCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaPurchaseContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPageSizeItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.ToolStripButton tsb审核通过;
        public System.Windows.Forms.ToolStripButton tsb审核不通过;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridViewCheckBoxColumn dpc选择;
        public System.Windows.Forms.DataGridViewButtonColumn dpc采购物品;
        public WinFormPager.DgvNav dgvNav1;
        public System.Windows.Forms.BindingSource DaPurchaseContractBindingSource;
        public System.Windows.Forms.GroupBox bgCondition;
        public System.Windows.Forms.ComboBox cmbUserName;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.DataGridView dgvDaPurchaseContract;
        public System.Windows.Forms.TextBox txtNum;
        public System.Windows.Forms.ComboBox cmbHasAudit;
        private System.Windows.Forms.Label label5;
    }
}
