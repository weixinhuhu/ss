namespace Client.Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBXM = new System.Windows.Forms.TextBox();
            this.CBoxSH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBGH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBDH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBoxRole = new System.Windows.Forms.ComboBox();
            this.GBoxSex = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRY = new System.Windows.Forms.DataGridView();
            this.ColSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSHMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColXM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColZMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColZT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.GBoxSex.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(815, 0);
            // 
            // tvRight
            // 
            this.tvRight.CheckBoxes = true;
            this.tvRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRight.ImageIndex = 0;
            this.tvRight.ImageList = this.imageList1;
            this.tvRight.Location = new System.Drawing.Point(0, 0);
            this.tvRight.Name = "tvRight";
            this.tvRight.SelectedImageIndex = 0;
            this.tvRight.Size = new System.Drawing.Size(528, 493);
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
            this.TabCtrl.Location = new System.Drawing.Point(20, 32);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(810, 550);
            this.TabCtrl.TabIndex = 4;
            this.TabCtrl.SelectedIndexChanged += new System.EventHandler(this.TabCtrl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Client.Properties.Resources.smallback;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 524);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 493);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882351F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882351F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TBXM, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.CBoxSH, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.TBGH, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TBDH, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.CBoxRole, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.GBoxSex, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 72);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所属网点";
            // 
            // TBXM
            // 
            this.TBXM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBXM.Location = new System.Drawing.Point(571, 7);
            this.TBXM.MaxLength = 8;
            this.TBXM.Name = "TBXM";
            this.TBXM.Size = new System.Drawing.Size(210, 21);
            this.TBXM.TabIndex = 2;
            // 
            // CBoxSH
            // 
            this.CBoxSH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CBoxSH.DisplayMember = "BMMC";
            this.CBoxSH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSH.FormattingEnabled = true;
            this.CBoxSH.Location = new System.Drawing.Point(63, 8);
            this.CBoxSH.Name = "CBoxSH";
            this.CBoxSH.Size = new System.Drawing.Size(206, 20);
            this.CBoxSH.TabIndex = 1;
            this.CBoxSH.ValueMember = "BMBM";
            this.CBoxSH.Resize += new System.EventHandler(this.cmbSH_Resize);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓名";
            // 
            // TBGH
            // 
            this.TBGH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBGH.Location = new System.Drawing.Point(317, 7);
            this.TBGH.MaxLength = 4;
            this.TBGH.Name = "TBGH";
            this.TBGH.Size = new System.Drawing.Size(206, 21);
            this.TBGH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "工号";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "电话";
            // 
            // TBDH
            // 
            this.TBDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBDH.Location = new System.Drawing.Point(317, 43);
            this.TBDH.MaxLength = 16;
            this.TBDH.Name = "TBDH";
            this.TBDH.Size = new System.Drawing.Size(206, 21);
            this.TBDH.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "角色";
            // 
            // CBoxRole
            // 
            this.CBoxRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CBoxRole.DisplayMember = "ZMC";
            this.CBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxRole.FormattingEnabled = true;
            this.CBoxRole.Location = new System.Drawing.Point(571, 44);
            this.CBoxRole.Name = "CBoxRole";
            this.CBoxRole.Size = new System.Drawing.Size(210, 20);
            this.CBoxRole.TabIndex = 1;
            this.CBoxRole.ValueMember = "ZBH";
            // 
            // GBoxSex
            // 
            this.GBoxSex.Controls.Add(this.rbFemale);
            this.GBoxSex.Controls.Add(this.rbMale);
            this.GBoxSex.Location = new System.Drawing.Point(63, 39);
            this.GBoxSex.Name = "GBoxSex";
            this.GBoxSex.Size = new System.Drawing.Size(206, 28);
            this.GBoxSex.TabIndex = 3;
            this.GBoxSex.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(115, 11);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(35, 16);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "女";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(56, 11);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(35, 16);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRY);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 389);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户列表";
            // 
            // dgvRY
            // 
            this.dgvRY.AllowUserToAddRows = false;
            this.dgvRY.AllowUserToDeleteRows = false;
            this.dgvRY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSH,
            this.ColSHMC,
            this.ColGH,
            this.ColXM,
            this.ColXB,
            this.ColDH,
            this.ColJB,
            this.ColZMC,
            this.ColZT});
            this.dgvRY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRY.Location = new System.Drawing.Point(3, 17);
            this.dgvRY.MultiSelect = false;
            this.dgvRY.Name = "dgvRY";
            this.dgvRY.ReadOnly = true;
            this.dgvRY.RowTemplate.Height = 23;
            this.dgvRY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRY.Size = new System.Drawing.Size(784, 369);
            this.dgvRY.TabIndex = 1;
            this.dgvRY.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRY_CellClick);
            // 
            // ColSH
            // 
            this.ColSH.DataPropertyName = "SH";
            this.ColSH.HeaderText = "所属网点";
            this.ColSH.Name = "ColSH";
            this.ColSH.ReadOnly = true;
            this.ColSH.Visible = false;
            // 
            // ColSHMC
            // 
            this.ColSHMC.DataPropertyName = "SHMC";
            this.ColSHMC.HeaderText = "所属网点";
            this.ColSHMC.Name = "ColSHMC";
            this.ColSHMC.ReadOnly = true;
            // 
            // ColGH
            // 
            this.ColGH.DataPropertyName = "GH";
            this.ColGH.HeaderText = "工号";
            this.ColGH.Name = "ColGH";
            this.ColGH.ReadOnly = true;
            // 
            // ColXM
            // 
            this.ColXM.DataPropertyName = "XM";
            this.ColXM.HeaderText = "姓名";
            this.ColXM.Name = "ColXM";
            this.ColXM.ReadOnly = true;
            // 
            // ColXB
            // 
            this.ColXB.DataPropertyName = "XB";
            this.ColXB.HeaderText = "性别";
            this.ColXB.Name = "ColXB";
            this.ColXB.ReadOnly = true;
            // 
            // ColDH
            // 
            this.ColDH.DataPropertyName = "DH";
            this.ColDH.HeaderText = "电话";
            this.ColDH.Name = "ColDH";
            this.ColDH.ReadOnly = true;
            // 
            // ColJB
            // 
            this.ColJB.DataPropertyName = "JB";
            this.ColJB.HeaderText = "用户组";
            this.ColJB.Name = "ColJB";
            this.ColJB.ReadOnly = true;
            this.ColJB.Visible = false;
            // 
            // ColZMC
            // 
            this.ColZMC.DataPropertyName = "ZMC";
            this.ColZMC.HeaderText = "用户组";
            this.ColZMC.Name = "ColZMC";
            this.ColZMC.ReadOnly = true;
            // 
            // ColZT
            // 
            this.ColZT.DataPropertyName = "ZT";
            this.ColZT.HeaderText = "状态";
            this.ColZT.Name = "ColZT";
            this.ColZT.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRYAdd,
            this.tsbLock,
            this.tsbUnlock,
            this.tsbRYDel,
            this.tsbRYSave,
            this.tsbResetPass});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(796, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbRYAdd
            // 
            this.tsbRYAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbRYAdd.Image")));
            this.tsbRYAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRYAdd.Name = "tsbRYAdd";
            this.tsbRYAdd.Size = new System.Drawing.Size(52, 22);
            this.tsbRYAdd.Text = "创建";
            this.tsbRYAdd.Click += new System.EventHandler(this.tsbRYAdd_Click);
            // 
            // tsbLock
            // 
            this.tsbLock.Image = ((System.Drawing.Image)(resources.GetObject("tsbLock.Image")));
            this.tsbLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLock.Name = "tsbLock";
            this.tsbLock.Size = new System.Drawing.Size(52, 22);
            this.tsbLock.Text = "锁定";
            this.tsbLock.Click += new System.EventHandler(this.tsbLock_Click);
            // 
            // tsbUnlock
            // 
            this.tsbUnlock.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnlock.Image")));
            this.tsbUnlock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnlock.Name = "tsbUnlock";
            this.tsbUnlock.Size = new System.Drawing.Size(52, 22);
            this.tsbUnlock.Text = "解锁";
            this.tsbUnlock.Click += new System.EventHandler(this.tsbUnlock_Click);
            // 
            // tsbRYDel
            // 
            this.tsbRYDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbRYDel.Image")));
            this.tsbRYDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRYDel.Name = "tsbRYDel";
            this.tsbRYDel.Size = new System.Drawing.Size(52, 22);
            this.tsbRYDel.Text = "删除";
            this.tsbRYDel.Click += new System.EventHandler(this.tsbRYDel_Click);
            // 
            // tsbRYSave
            // 
            this.tsbRYSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbRYSave.Image")));
            this.tsbRYSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRYSave.Name = "tsbRYSave";
            this.tsbRYSave.Size = new System.Drawing.Size(52, 22);
            this.tsbRYSave.Text = "保存";
            this.tsbRYSave.Click += new System.EventHandler(this.tsbRYSave_Click);
            // 
            // tsbResetPass
            // 
            this.tsbResetPass.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetPass.Image")));
            this.tsbResetPass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetPass.Name = "tsbResetPass";
            this.tsbResetPass.Size = new System.Drawing.Size(76, 22);
            this.tsbResetPass.Text = "重置密码";
            this.tsbResetPass.Click += new System.EventHandler(this.tsbResetPass_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "系统角色";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvRYZ);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tvRight);
            this.splitContainer1.Size = new System.Drawing.Size(796, 493);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.TabStop = false;
            // 
            // tvRYZ
            // 
            this.tvRYZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRYZ.HideSelection = false;
            this.tvRYZ.Location = new System.Drawing.Point(0, 0);
            this.tvRYZ.Name = "tvRYZ";
            this.tvRYZ.Size = new System.Drawing.Size(264, 493);
            this.tvRYZ.TabIndex = 0;
            this.tvRYZ.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRYZ_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddRole,
            this.tsbModify,
            this.tsbDel,
            this.tsbSave});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(796, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddRole
            // 
            this.tsbAddRole.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddRole.Image")));
            this.tsbAddRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddRole.Name = "tsbAddRole";
            this.tsbAddRole.Size = new System.Drawing.Size(52, 22);
            this.tsbAddRole.Text = "创建";
            this.tsbAddRole.Click += new System.EventHandler(this.tsbAddRole_Click);
            // 
            // tsbModify
            // 
            this.tsbModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbModify.Image")));
            this.tsbModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.Size = new System.Drawing.Size(52, 22);
            this.tsbModify.Text = "修改";
            this.tsbModify.Click += new System.EventHandler(this.tsbModify_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(52, 22);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // ManageUserRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.BackgroundImage = global::Client.Properties.Resources.smallback;
            this.Controls.Add(this.TabCtrl);
            this.Name = "ManageUserRight";
            this.Size = new System.Drawing.Size(850, 600);
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
            this.GBoxSex.ResumeLayout(false);
            this.GBoxSex.PerformLayout();
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
        private System.Windows.Forms.TextBox TBXM;
        private System.Windows.Forms.ComboBox CBoxSH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBGH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBDH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBoxRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSHMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColXM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColZMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColZT;
        private System.Windows.Forms.ToolStripButton tsbUnlock;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox GBoxSex;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ToolStripButton tsbResetPass;
    }
}
