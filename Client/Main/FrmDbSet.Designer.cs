namespace Client.Main
{
    partial class FrmDbSet
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CBoxDbType = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GBS = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnTest = new System.Windows.Forms.Button();
            this.txtDBPass = new System.Windows.Forms.TextBox();
            this.txtDBUser = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GBA = new System.Windows.Forms.GroupBox();
            this.BtnTestAccess = new System.Windows.Forms.Button();
            this.BtnSaveAccess = new System.Windows.Forms.Button();
            this.BtnAccess = new System.Windows.Forms.Button();
            this.txtAccess = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox1.SuspendLayout();
            this.GBS.SuspendLayout();
            this.GBA.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.CBoxDbType);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.GBS);
            this.GroupBox1.Controls.Add(this.GBA);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(327, 324);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "数据库信息";
            // 
            // CBoxDbType
            // 
            this.CBoxDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxDbType.FormattingEnabled = true;
            this.CBoxDbType.Items.AddRange(new object[] {
            "SQL Server"});
            this.CBoxDbType.Location = new System.Drawing.Point(138, 33);
            this.CBoxDbType.Name = "CBoxDbType";
            this.CBoxDbType.Size = new System.Drawing.Size(121, 20);
            this.CBoxDbType.TabIndex = 1;
            this.CBoxDbType.SelectedIndexChanged += new System.EventHandler(this.cmbDB_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(67, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 12);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "数据库类型";
            // 
            // GBS
            // 
            this.GBS.Controls.Add(this.BtnSave);
            this.GBS.Controls.Add(this.BtnTest);
            this.GBS.Controls.Add(this.txtDBPass);
            this.GBS.Controls.Add(this.txtDBUser);
            this.GBS.Controls.Add(this.txtDBName);
            this.GBS.Controls.Add(this.txtPort);
            this.GBS.Controls.Add(this.txtAddress);
            this.GBS.Controls.Add(this.Label4);
            this.GBS.Controls.Add(this.Label5);
            this.GBS.Controls.Add(this.Label3);
            this.GBS.Controls.Add(this.Label6);
            this.GBS.Controls.Add(this.Label2);
            this.GBS.Location = new System.Drawing.Point(17, 68);
            this.GBS.Name = "GBS";
            this.GBS.Size = new System.Drawing.Size(292, 235);
            this.GBS.TabIndex = 2;
            this.GBS.TabStop = false;
            this.GBS.Text = "SQL Server";
            this.GBS.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(157, 182);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "保存设置";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(60, 182);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 7;
            this.BtnTest.Text = "测试连接";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtDBPass
            // 
            this.txtDBPass.Location = new System.Drawing.Point(106, 111);
            this.txtDBPass.MaxLength = 9;
            this.txtDBPass.Name = "txtDBPass";
            this.txtDBPass.PasswordChar = '*';
            this.txtDBPass.Size = new System.Drawing.Size(156, 21);
            this.txtDBPass.TabIndex = 6;
            // 
            // txtDBUser
            // 
            this.txtDBUser.Location = new System.Drawing.Point(106, 84);
            this.txtDBUser.MaxLength = 20;
            this.txtDBUser.Name = "txtDBUser";
            this.txtDBUser.Size = new System.Drawing.Size(156, 21);
            this.txtDBUser.TabIndex = 5;
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(106, 57);
            this.txtDBName.MaxLength = 20;
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(156, 21);
            this.txtDBName.TabIndex = 4;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(106, 138);
            this.txtPort.MaxLength = 9;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(156, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "1433";
            this.txtPort.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 30);
            this.txtAddress.MaxLength = 20;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(156, 21);
            this.txtAddress.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(35, 61);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 12);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "数据库名称";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(35, 115);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(65, 12);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "数据库密码";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(35, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 12);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "数据库用户";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(35, 142);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(65, 12);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "数据库端口";
            this.Label6.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(35, 34);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 12);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "数据库地址";
            // 
            // GBA
            // 
            this.GBA.Controls.Add(this.BtnTestAccess);
            this.GBA.Controls.Add(this.BtnSaveAccess);
            this.GBA.Controls.Add(this.BtnAccess);
            this.GBA.Controls.Add(this.txtAccess);
            this.GBA.Location = new System.Drawing.Point(16, 67);
            this.GBA.Name = "GBA";
            this.GBA.Size = new System.Drawing.Size(292, 235);
            this.GBA.TabIndex = 3;
            this.GBA.TabStop = false;
            this.GBA.Text = "Access";
            this.GBA.Visible = false;
            // 
            // BtnTestAccess
            // 
            this.BtnTestAccess.Location = new System.Drawing.Point(58, 136);
            this.BtnTestAccess.Name = "BtnTestAccess";
            this.BtnTestAccess.Size = new System.Drawing.Size(75, 23);
            this.BtnTestAccess.TabIndex = 2;
            this.BtnTestAccess.Text = "测试连接";
            this.BtnTestAccess.UseVisualStyleBackColor = true;
            this.BtnTestAccess.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // BtnSaveAccess
            // 
            this.BtnSaveAccess.Enabled = false;
            this.BtnSaveAccess.Location = new System.Drawing.Point(160, 136);
            this.BtnSaveAccess.Name = "BtnSaveAccess";
            this.BtnSaveAccess.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveAccess.TabIndex = 2;
            this.BtnSaveAccess.Text = "保存";
            this.BtnSaveAccess.UseVisualStyleBackColor = true;
            this.BtnSaveAccess.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // BtnAccess
            // 
            this.BtnAccess.Location = new System.Drawing.Point(233, 69);
            this.BtnAccess.Name = "BtnAccess";
            this.BtnAccess.Size = new System.Drawing.Size(41, 23);
            this.BtnAccess.TabIndex = 1;
            this.BtnAccess.Text = "...";
            this.BtnAccess.UseVisualStyleBackColor = true;
            this.BtnAccess.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtAccess
            // 
            this.txtAccess.Enabled = false;
            this.txtAccess.Location = new System.Drawing.Point(16, 70);
            this.txtAccess.Name = "txtAccess";
            this.txtAccess.Size = new System.Drawing.Size(211, 21);
            this.txtAccess.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmDbSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 344);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDbSet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库设置";
            this.Load += new System.EventHandler(this.SetDbForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GBS.ResumeLayout(false);
            this.GBS.PerformLayout();
            this.GBA.ResumeLayout(false);
            this.GBA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox CBoxDbType;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GBS;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnTest;
        internal System.Windows.Forms.TextBox txtDBPass;
        internal System.Windows.Forms.TextBox txtDBUser;
        internal System.Windows.Forms.TextBox txtDBName;
        internal System.Windows.Forms.TextBox txtPort;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GBA;
        internal System.Windows.Forms.Button BtnTestAccess;
        internal System.Windows.Forms.Button BtnSaveAccess;
        internal System.Windows.Forms.Button BtnAccess;
        internal System.Windows.Forms.TextBox txtAccess;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}