namespace 销售管理.系统设置
{
    partial class 产品管理
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("产品");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.nodes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(167, 18);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "0";
            treeNode1.Text = "产品";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(689, 658);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // nodes
            // 
            this.nodes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加toolStripMenuItem,
            this.删除toolStripMenuItem,
            this.修改名称ToolStripMenuItem});
            this.nodes.Name = "addNode";
            this.nodes.Size = new System.Drawing.Size(197, 70);
            // 
            // 添加toolStripMenuItem
            // 
            this.添加toolStripMenuItem.Name = "添加toolStripMenuItem";
            this.添加toolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.添加toolStripMenuItem.Text = "添加下级分类";
            this.添加toolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 删除toolStripMenuItem
            // 
            this.删除toolStripMenuItem.Name = "删除toolStripMenuItem";
            this.删除toolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.删除toolStripMenuItem.Text = "删除本产品分类或产品";
            this.删除toolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 修改名称ToolStripMenuItem
            // 
            this.修改名称ToolStripMenuItem.Name = "修改名称ToolStripMenuItem";
            this.修改名称ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.修改名称ToolStripMenuItem.Text = "修改产品名称";
            this.修改名称ToolStripMenuItem.Click += new System.EventHandler(this.修改名称ToolStripMenuItem_Click);
            // 
            // 产品管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.treeView1);
            this.Name = "产品管理";
            this.Load += new System.EventHandler(this.产品管理_Load);
            this.Controls.SetChildIndex(this.treeView1, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.nodes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip nodes;
        private System.Windows.Forms.ToolStripMenuItem 添加toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改名称ToolStripMenuItem;
    }
}
