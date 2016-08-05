using System.Windows.Forms;

namespace WinFormPager
{
    partial class DgvPager : UserControl
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DgvPager));
            this.navi = new System.Windows.Forms.BindingNavigator(this.components);
            this.navSumPage = new System.Windows.Forms.ToolStripLabel();
            this.navFirstPage = new System.Windows.Forms.ToolStripButton();
            this.navPrePage = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.navCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.navNextPage = new System.Windows.Forms.ToolStripButton();
            this.navLastPage = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navi)).BeginInit();
            this.navi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // navi
            // 
            this.navi.AddNewItem = null;
            this.navi.CountItem = this.navSumPage;
            this.navi.DeleteItem = null;
            this.navi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navFirstPage,
            this.navPrePage,
            this.bindingNavigatorSeparator,
            this.navCurrentPage,
            this.navSumPage,
            this.bindingNavigatorSeparator1,
            this.navNextPage,
            this.navLastPage,
            this.bindingNavigatorSeparator2});
            this.navi.Location = new System.Drawing.Point(0, 0);
            this.navi.MoveFirstItem = this.navFirstPage;
            this.navi.MoveLastItem = this.navLastPage;
            this.navi.MoveNextItem = this.navNextPage;
            this.navi.MovePreviousItem = this.navPrePage;
            this.navi.Name = "navi";
            this.navi.PositionItem = this.navCurrentPage;
            this.navi.Size = new System.Drawing.Size(548, 25);
            this.navi.TabIndex = 1;
            this.navi.Text = "bindingNavigator1";
            // 
            // navSumPage
            // 
            this.navSumPage.Name = "navSumPage";
            this.navSumPage.Size = new System.Drawing.Size(32, 22);
            this.navSumPage.Text = "/ {0}";
            this.navSumPage.ToolTipText = "总项数";
            // 
            // navFirstPage
            // 
            this.navFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("navFirstPage.Image")));
            this.navFirstPage.Name = "navFirstPage";
            this.navFirstPage.RightToLeftAutoMirrorImage = true;
            this.navFirstPage.Size = new System.Drawing.Size(23, 22);
            this.navFirstPage.Text = "第一页";
            this.navFirstPage.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // navPrePage
            // 
            this.navPrePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navPrePage.Image = ((System.Drawing.Image)(resources.GetObject("navPrePage.Image")));
            this.navPrePage.Name = "navPrePage";
            this.navPrePage.RightToLeftAutoMirrorImage = true;
            this.navPrePage.Size = new System.Drawing.Size(23, 22);
            this.navPrePage.Text = "上一页";
            this.navPrePage.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // navCurrentPage
            // 
            this.navCurrentPage.AccessibleName = "位置";
            this.navCurrentPage.AutoSize = false;
            this.navCurrentPage.Name = "navCurrentPage";
            this.navCurrentPage.Size = new System.Drawing.Size(50, 23);
            this.navCurrentPage.Text = "0";
            this.navCurrentPage.ToolTipText = "当前位置";
            this.navCurrentPage.Leave += new System.EventHandler(this.navCurrentPage_Leave);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // navNextPage
            // 
            this.navNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navNextPage.Image = ((System.Drawing.Image)(resources.GetObject("navNextPage.Image")));
            this.navNextPage.Name = "navNextPage";
            this.navNextPage.RightToLeftAutoMirrorImage = true;
            this.navNextPage.Size = new System.Drawing.Size(23, 22);
            this.navNextPage.Text = "下一页";
            this.navNextPage.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // navLastPage
            // 
            this.navLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navLastPage.Image = ((System.Drawing.Image)(resources.GetObject("navLastPage.Image")));
            this.navLastPage.Name = "navLastPage";
            this.navLastPage.RightToLeftAutoMirrorImage = true;
            this.navLastPage.Size = new System.Drawing.Size(23, 22);
            this.navLastPage.Text = "最后一页";
            this.navLastPage.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 25);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(548, 321);
            this.dgv.TabIndex = 2;
            // 
            // DgvPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.navi);
            this.Name = "DgvPager";
            this.Size = new System.Drawing.Size(548, 346);
            ((System.ComponentModel.ISupportInitialize)(this.navi)).EndInit();
            this.navi.ResumeLayout(false);
            this.navi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator navi;
        private System.Windows.Forms.ToolStripLabel navSumPage;
        private System.Windows.Forms.ToolStripButton navFirstPage;
        private System.Windows.Forms.ToolStripButton navPrePage;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox navCurrentPage;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton navNextPage;
        private System.Windows.Forms.ToolStripButton navLastPage;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bs;
        public System.Windows.Forms.DataGridView dgv;
    }
}
