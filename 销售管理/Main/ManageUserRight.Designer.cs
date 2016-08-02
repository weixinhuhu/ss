namespace 销售管理.Main
{
    partial class ManageUserRight 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserRight));
            this.tvRight = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAreaCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRY = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIntRoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAreaCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbRYAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbLock = new System.Windows.Forms.ToolStripButton();
            this.tsbUnlock = new System.Windows.Forms.ToolStripButton();
            this.tsbRYDel = new System.Windows.Forms.ToolStripButton();
            this.tsbRYSave = new System.Windows.Forms.ToolStripButton();
            this.tsbResetPass = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvRYZ = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddRole = new System.Windows.Forms.ToolStripButton();
            this.tsbModify = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TabCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRY)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(1630, 0);
            // 
            // tvRight
            // 
            this.tvRight.CheckBoxes = true;
            this.tvRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRight.ImageIndex = 0;
            this.tvRight.ImageList = this.imageList1;
            this.tvRight.Location = new System.Drawing.Point(0, 0);
            this.tvRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tvRight.Name = "tvRight";
            this.tvRight.SelectedImageIndex = 0;
            this.tvRight.Size = new System.Drawing.Size(1056, 1002);
            this.tvRight.TabIndex = 1;
            this.tvRight.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvRight_AfterCheck);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TabCtrl
            // 
            this.TabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabCtrl.Controls.Add(this.tabPage1);
            this.TabCtrl.Controls.Add(this.tabPage2);
            this.TabCtrl.Location = new System.Drawing.Point(40, 64);
            this.TabCtrl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(1620, 1100);
            this.TabCtrl.TabIndex = 4;
            this.TabCtrl.SelectedIndexChanged += new System.EventHandler(this.TabCtrl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1604, 1053);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "系统用户";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 45);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1592, 1002);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1580, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882351F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel2.Controls.Add(this.cmbDepart, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtUserName, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLoginName, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAreaCode, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbRole, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 34);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1568, 138);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cmbDepart
            // 
            this.cmbDepart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbDepart.DisplayMember = "VcName";
            this.cmbDepart.DropDownHeight = 200;
            this.cmbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepart.DropDownWidth = 400;
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.IntegralHeight = false;
            this.cmbDepart.Location = new System.Drawing.Point(126, 87);
            this.cmbDepart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(366, 32);
            this.cmbDepart.TabIndex = 1;
            this.cmbDepart.ValueMember = "IntID";
            this.cmbDepart.Resize += new System.EventHandler(this.cmbSH_Resize);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserName.Location = new System.Drawing.Point(1157, 17);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(368, 35);
            this.txtUserName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1087, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓名";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLoginName.Location = new System.Drawing.Point(659, 17);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLoginName.MaxLength = 50;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(366, 35);
            this.txtLoginName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "登陆名称";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "区域代码";
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAreaCode.Location = new System.Drawing.Point(659, 86);
            this.txtAreaCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAreaCode.MaxLength = 10;
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(366, 35);
            this.txtAreaCode.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1087, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "角色";
            // 
            // cmbRole
            // 
            this.cmbRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbRole.DisplayMember = "ZMC";
            this.cmbRole.DropDownHeight = 200;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.DropDownWidth = 400;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.IntegralHeight = false;
            this.cmbRole.Location = new System.Drawing.Point(1157, 87);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(368, 32);
            this.cmbRole.TabIndex = 1;
            this.cmbRole.ValueMember = "ZBH";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "序号";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(126, 17);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtID.MaxLength = 4;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(366, 35);
            this.txtID.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRY);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(6, 196);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1580, 800);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户列表";
            // 
            // dgvRY
            // 
            this.dgvRY.AllowUserToAddRows = false;
            this.dgvRY.AllowUserToDeleteRows = false;
            this.dgvRY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColLoginName,
            this.ColUserName,
            this.ColDepartmentID,
            this.ColDepartmentName,
            this.ColIntRoleID,
            this.ColRoleName,
            this.ColAreaCode,
            this.ColUserStatus});
            this.dgvRY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRY.Location = new System.Drawing.Point(6, 34);
            this.dgvRY.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvRY.MultiSelect = false;
            this.dgvRY.Name = "dgvRY";
            this.dgvRY.ReadOnly = true;
            this.dgvRY.RowTemplate.Height = 23;
            this.dgvRY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRY.Size = new System.Drawing.Size(1568, 760);
            this.dgvRY.TabIndex = 1;
            this.dgvRY.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRY_CellClick);
            this.dgvRY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRY_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "Id";
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 79;
            // 
            // ColLoginName
            // 
            this.ColLoginName.DataPropertyName = "LoginName";
            this.ColLoginName.HeaderText = "登陆名称";
            this.ColLoginName.Name = "ColLoginName";
            this.ColLoginName.ReadOnly = true;
            this.ColLoginName.Width = 151;
            // 
            // ColUserName
            // 
            this.ColUserName.DataPropertyName = "UserName";
            this.ColUserName.HeaderText = "姓名";
            this.ColUserName.Name = "ColUserName";
            this.ColUserName.ReadOnly = true;
            this.ColUserName.Width = 103;
            // 
            // ColDepartmentID
            // 
            this.ColDepartmentID.DataPropertyName = "IntDepartmentID";
            this.ColDepartmentID.HeaderText = "DepartmentID";
            this.ColDepartmentID.Name = "ColDepartmentID";
            this.ColDepartmentID.ReadOnly = true;
            this.ColDepartmentID.Visible = false;
            this.ColDepartmentID.Width = 102;
            // 
            // ColDepartmentName
            // 
            this.ColDepartmentName.DataPropertyName = "部门名称";
            this.ColDepartmentName.HeaderText = "部门名称";
            this.ColDepartmentName.Name = "ColDepartmentName";
            this.ColDepartmentName.ReadOnly = true;
            this.ColDepartmentName.Width = 151;
            // 
            // ColIntRoleID
            // 
            this.ColIntRoleID.DataPropertyName = "IntRoleID";
            this.ColIntRoleID.HeaderText = "RoleID";
            this.ColIntRoleID.Name = "ColIntRoleID";
            this.ColIntRoleID.ReadOnly = true;
            this.ColIntRoleID.Visible = false;
            this.ColIntRoleID.Width = 66;
            // 
            // ColRoleName
            // 
            this.ColRoleName.DataPropertyName = "角色名";
            this.ColRoleName.HeaderText = "角色名";
            this.ColRoleName.Name = "ColRoleName";
            this.ColRoleName.ReadOnly = true;
            this.ColRoleName.Width = 127;
            // 
            // ColAreaCode
            // 
            this.ColAreaCode.DataPropertyName = "userChar";
            this.ColAreaCode.HeaderText = "区域代码";
            this.ColAreaCode.Name = "ColAreaCode";
            this.ColAreaCode.ReadOnly = true;
            this.ColAreaCode.Width = 151;
            // 
            // ColUserStatus
            // 
            this.ColUserStatus.DataPropertyName = "userstatus";
            this.ColUserStatus.HeaderText = "状态";
            this.ColUserStatus.Name = "ColUserStatus";
            this.ColUserStatus.ReadOnly = true;
            this.ColUserStatus.Width = 103;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRYAdd,
            this.tsbLock,
            this.tsbUnlock,
            this.tsbRYDel,
            this.tsbRYSave,
            this.tsbResetPass});
            this.toolStrip2.Location = new System.Drawing.Point(6, 6);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(1592, 39);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbRYAdd
            // 
            this.tsbRYAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbRYAdd.Image")));
            this.tsbRYAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRYAdd.Name = "tsbRYAdd";
            this.tsbRYAdd.Size = new System.Drawing.Size(98, 36);
            this.tsbRYAdd.Text = "创建";
            this.tsbRYAdd.Click += new System.EventHandler(this.tsbRYAdd_Click);
            // 
            // tsbLock
            // 
            this.tsbLock.Image = ((System.Drawing.Image)(resources.GetObject("tsbLock.Image")));
            this.tsbLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLock.Name = "tsbLock";
            this.tsbLock.Size = new System.Drawing.Size(98, 36);
            this.tsbLock.Text = "锁定";
            this.tsbLock.Click += new System.EventHandler(this.tsbLock_Click);
            // 
            // tsbUnlock
            // 
            this.tsbUnlock.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnlock.Image")));
            this.tsbUnlock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnlock.Name = "tsbUnlock";
            this.tsbUnlock.Size = new System.Drawing.Size(98, 36);
            this.tsbUnlock.Text = "解锁";
            this.tsbUnlock.Click += new System.EventHandler(this.tsbUnlock_Click);
            // 
            // tsbRYDel
            // 
            this.tsbRYDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbRYDel.Image")));
            this.tsbRYDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRYDel.Name = "tsbRYDel";
            this.tsbRYDel.Size = new System.Drawing.Size(98, 36);
            this.tsbRYDel.Text = "删除";
            this.tsbRYDel.Click += new System.EventHandler(this.tsbRYDel_Click);
            // 
            // tsbRYSave
            // 
            this.tsbRYSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbRYSave.Image")));
            this.tsbRYSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRYSave.Name = "tsbRYSave";
            this.tsbRYSave.Size = new System.Drawing.Size(98, 36);
            this.tsbRYSave.Text = "保存";
            this.tsbRYSave.Click += new System.EventHandler(this.tsbRYSave_Click);
            // 
            // tsbResetPass
            // 
            this.tsbResetPass.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetPass.Image")));
            this.tsbResetPass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetPass.Name = "tsbResetPass";
            this.tsbResetPass.Size = new System.Drawing.Size(146, 36);
            this.tsbResetPass.Text = "重置密码";
            this.tsbResetPass.Click += new System.EventHandler(this.tsbResetPass_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1604, 1053);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "系统角色";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(6, 45);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvRYZ);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tvRight);
            this.splitContainer1.Size = new System.Drawing.Size(1592, 1002);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.TabStop = false;
            // 
            // tvRYZ
            // 
            this.tvRYZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRYZ.HideSelection = false;
            this.tvRYZ.Location = new System.Drawing.Point(0, 0);
            this.tvRYZ.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tvRYZ.Name = "tvRYZ";
            this.tvRYZ.Size = new System.Drawing.Size(528, 1002);
            this.tvRYZ.TabIndex = 0;
            this.tvRYZ.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRYZ_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddRole,
            this.tsbModify,
            this.tsbDel,
            this.tsbSave});
            this.toolStrip1.Location = new System.Drawing.Point(6, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1592, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddRole
            // 
            this.tsbAddRole.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddRole.Image")));
            this.tsbAddRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddRole.Name = "tsbAddRole";
            this.tsbAddRole.Size = new System.Drawing.Size(98, 36);
            this.tsbAddRole.Text = "创建";
            this.tsbAddRole.Click += new System.EventHandler(this.tsbAddRole_Click);
            // 
            // tsbModify
            // 
            this.tsbModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbModify.Image")));
            this.tsbModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.Size = new System.Drawing.Size(98, 36);
            this.tsbModify.Text = "修改";
            this.tsbModify.Click += new System.EventHandler(this.tsbModify_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(98, 36);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(98, 36);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // ManageUserRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.BackgroundImage = global::销售管理.Properties.Resources.smallback;
            this.Controls.Add(this.TabCtrl);
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.Name = "ManageUserRight";
            this.Size = new System.Drawing.Size(1700, 1200);
            this.Load += new System.EventHandler(this.ManageUserRight_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.TabCtrl, 0);
            this.TabCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRY)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvRight;
        private System.Windows.Forms.TabControl TabCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvRYZ;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddRole;
        private System.Windows.Forms.ToolStripButton tsbModify;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRY;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbRYAdd;
        private System.Windows.Forms.ToolStripButton tsbLock;
        private System.Windows.Forms.ToolStripButton tsbRYDel;
        private System.Windows.Forms.ToolStripButton tsbRYSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAreaCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ToolStripButton tsbUnlock;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton tsbResetPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIntRoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAreaCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserStatus;
        private System.Windows.Forms.ComboBox cmbDepart;
    }
}
