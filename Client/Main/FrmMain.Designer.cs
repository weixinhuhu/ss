namespace Client.Main
{
    partial class FrmMain
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
            this.StaStripMain = new System.Windows.Forms.StatusStrip();
            this.TSSLblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLblDatetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLblDbInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择卡片类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFast = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xPanderPanelList1 = new BSE.Windows.Forms.XPanderPanelList();
            this.PnlClient = new System.Windows.Forms.Panel();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.LblTip = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.StaStripMain.SuspendLayout();
            this.MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaStripMain
            // 
            this.StaStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLblUser,
            this.TSSLblDatetime,
            this.TSSLblDbInfo});
            this.StaStripMain.Location = new System.Drawing.Point(0, 682);
            this.StaStripMain.Name = "StaStripMain";
            this.StaStripMain.ShowItemToolTips = true;
            this.StaStripMain.Size = new System.Drawing.Size(1008, 22);
            this.StaStripMain.TabIndex = 1;
            this.StaStripMain.Text = "statusStrip1";
            // 
            // TSSLblUser
            // 
            this.TSSLblUser.AutoSize = false;
            this.TSSLblUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TSSLblUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.TSSLblUser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TSSLblUser.Name = "TSSLblUser";
            this.TSSLblUser.Size = new System.Drawing.Size(148, 17);
            this.TSSLblUser.Text = "用户";
            this.TSSLblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TSSLblDatetime
            // 
            this.TSSLblDatetime.AutoSize = false;
            this.TSSLblDatetime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TSSLblDatetime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.TSSLblDatetime.Name = "TSSLblDatetime";
            this.TSSLblDatetime.Size = new System.Drawing.Size(160, 17);
            this.TSSLblDatetime.Text = "登录时间";
            this.TSSLblDatetime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TSSLblDbInfo
            // 
            this.TSSLblDbInfo.AutoSize = false;
            this.TSSLblDbInfo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TSSLblDbInfo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.TSSLblDbInfo.Name = "TSSLblDbInfo";
            this.TSSLblDbInfo.Size = new System.Drawing.Size(220, 17);
            this.TSSLblDbInfo.Text = "数据库";
            // 
            // MenuMain
            // 
            this.MenuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.选择卡片类型ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.菜单配置ToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(1008, 25);
            this.MenuMain.TabIndex = 2;
            this.MenuMain.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.修改密码ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统ToolStripMenuItem.Text = "系统(&S)";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 选择卡片类型ToolStripMenuItem
            // 
            this.选择卡片类型ToolStripMenuItem.Name = "选择卡片类型ToolStripMenuItem";
            this.选择卡片类型ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.选择卡片类型ToolStripMenuItem.Text = "工具";
            this.选择卡片类型ToolStripMenuItem.Visible = false;
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItemHelp,
            this.toolStripSeparator1,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // TSMenuItemHelp
            // 
            this.TSMenuItemHelp.Name = "TSMenuItemHelp";
            this.TSMenuItemHelp.Size = new System.Drawing.Size(124, 22);
            this.TSMenuItemHelp.Text = "查看帮助";
            this.TSMenuItemHelp.Click += new System.EventHandler(this.TSMenuItemHelp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.ShowShortcutKeys = false;
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于系统";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 菜单配置ToolStripMenuItem
            // 
            this.菜单配置ToolStripMenuItem.Name = "菜单配置ToolStripMenuItem";
            this.菜单配置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.菜单配置ToolStripMenuItem.Text = "菜单配置";
            this.菜单配置ToolStripMenuItem.Visible = false;
            this.菜单配置ToolStripMenuItem.Click += new System.EventHandler(this.菜单配置ToolStripMenuItem_Click);
            // 
            // toolStripFast
            // 
            this.toolStripFast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.toolStripFast.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFast.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripFast.Location = new System.Drawing.Point(0, 25);
            this.toolStripFast.Name = "toolStripFast";
            this.toolStripFast.Size = new System.Drawing.Size(1008, 25);
            this.toolStripFast.TabIndex = 5;
            this.toolStripFast.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xPanderPanelList1);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PnlClient);
            this.splitContainer1.Panel2.Controls.Add(this.PnlTitle);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(1008, 632);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 6;
            // 
            // xPanderPanelList1
            // 
            this.xPanderPanelList1.CaptionStyle = BSE.Windows.Forms.CaptionStyle.Normal;
            this.xPanderPanelList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanderPanelList1.GradientBackground = System.Drawing.Color.Empty;
            this.xPanderPanelList1.Location = new System.Drawing.Point(0, 0);
            this.xPanderPanelList1.Name = "xPanderPanelList1";
            this.xPanderPanelList1.PanelColors = null;
            this.xPanderPanelList1.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPanelList1.Size = new System.Drawing.Size(150, 632);
            this.xPanderPanelList1.TabIndex = 0;
            this.xPanderPanelList1.Text = "xPanderPanelList1";
            // 
            // PnlClient
            // 
            this.PnlClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClient.Location = new System.Drawing.Point(0, 26);
            this.PnlClient.Name = "PnlClient";
            this.PnlClient.Size = new System.Drawing.Size(854, 606);
            this.PnlClient.TabIndex = 0;
            this.PnlClient.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PnlClient_ControlRemoved);
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PnlTitle.Controls.Add(this.LblTip);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(854, 26);
            this.PnlTitle.TabIndex = 1;
            // 
            // LblTip
            // 
            this.LblTip.AutoSize = true;
            this.LblTip.Location = new System.Drawing.Point(24, 7);
            this.LblTip.Name = "LblTip";
            this.LblTip.Size = new System.Drawing.Size(149, 12);
            this.LblTip.TabIndex = 0;
            this.LblTip.Text = "欢迎使用一卡多表管理系统";
            // 
            // timer
            // 
            this.timer.Interval = 300000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 704);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripFast);
            this.Controls.Add(this.StaStripMain);
            this.Controls.Add(this.MenuMain);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MenuMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "一卡多表管理系统RTYKT(V1.0)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.StaStripMain.ResumeLayout(false);
            this.StaStripMain.PerformLayout();
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StaStripMain;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel TSSLblUser;
        private System.Windows.Forms.ToolStrip toolStripFast;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BSE.Windows.Forms.XPanderPanelList xPanderPanelList1;
        private System.Windows.Forms.Panel PnlClient;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Label LblTip;
        private System.Windows.Forms.ToolStripMenuItem 选择卡片类型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜单配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TSSLblDatetime;
        private System.Windows.Forms.ToolStripStatusLabel TSSLblDbInfo;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Timer timer;
    }
}

