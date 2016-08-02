namespace 销售管理.系统设置
{
    partial class 上传新版本
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.版本号 = new System.Windows.Forms.Label();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpPath = new System.Windows.Forms.TextBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.Col删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Col文件名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col相对路径 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col文件目录 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.Location = new System.Drawing.Point(379, 168);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(141, 38);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "选择文件";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpload.Location = new System.Drawing.Point(526, 168);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(131, 38);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "上传";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // 版本号
            // 
            this.版本号.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.版本号.AutoSize = true;
            this.版本号.Location = new System.Drawing.Point(319, 117);
            this.版本号.Name = "版本号";
            this.版本号.Size = new System.Drawing.Size(41, 12);
            this.版本号.TabIndex = 4;
            this.版本号.Text = "版本号";
            // 
            // txtVer
            // 
            this.txtVer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVer.Location = new System.Drawing.Point(379, 114);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(278, 21);
            this.txtVer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "相对路径";
            // 
            // txtUpPath
            // 
            this.txtUpPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUpPath.Location = new System.Drawing.Point(379, 141);
            this.txtUpPath.Name = "txtUpPath";
            this.txtUpPath.Size = new System.Drawing.Size(278, 21);
            this.txtUpPath.TabIndex = 1;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col删除,
            this.Col文件名,
            this.Col相对路径,
            this.Col文件目录});
            this.dgvFiles.Location = new System.Drawing.Point(117, 223);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowTemplate.Height = 23;
            this.dgvFiles.ShowEditingIcon = false;
            this.dgvFiles.Size = new System.Drawing.Size(800, 432);
            this.dgvFiles.TabIndex = 5;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            // 
            // Col删除
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "删除";
            this.Col删除.DefaultCellStyle = dataGridViewCellStyle1;
            this.Col删除.HeaderText = "删除";
            this.Col删除.Name = "Col删除";
            this.Col删除.ReadOnly = true;
            this.Col删除.Width = 35;
            // 
            // Col文件名
            // 
            this.Col文件名.DataPropertyName = "文件名";
            this.Col文件名.HeaderText = "文件名";
            this.Col文件名.Name = "Col文件名";
            this.Col文件名.ReadOnly = true;
            this.Col文件名.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col文件名.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col文件名.Width = 47;
            // 
            // Col相对路径
            // 
            this.Col相对路径.DataPropertyName = "相对路径";
            this.Col相对路径.HeaderText = "相对路径";
            this.Col相对路径.Name = "Col相对路径";
            this.Col相对路径.ReadOnly = true;
            this.Col相对路径.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col相对路径.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col相对路径.Width = 59;
            // 
            // Col文件目录
            // 
            this.Col文件目录.DataPropertyName = "文件目录";
            this.Col文件目录.HeaderText = "文件目录";
            this.Col文件目录.Name = "Col文件目录";
            this.Col文件目录.ReadOnly = true;
            this.Col文件目录.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col文件目录.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col文件目录.Width = 59;
            // 
            // 上传新版本
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.txtVer);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtUpPath);
            this.Controls.Add(this.版本号);
            this.Controls.Add(this.label2);
            this.Name = "上传新版本";
            this.Load += new System.EventHandler(this.上传新版本_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.版本号, 0);
            this.Controls.SetChildIndex(this.txtUpPath, 0);
            this.Controls.SetChildIndex(this.btnUpload, 0);
            this.Controls.SetChildIndex(this.txtVer, 0);
            this.Controls.SetChildIndex(this.dgvFiles, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label 版本号;
        private System.Windows.Forms.TextBox txtVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpPath;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewButtonColumn Col删除;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col文件名;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col相对路径;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col文件目录;
    }
}
