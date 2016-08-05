namespace 销售管理
{
    partial class SetDbForm
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
            this.TxtDBName = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtDBIp = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.Cancel = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.OK = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDBName
            // 
            this.TxtDBName.Location = new System.Drawing.Point(192, 80);
            this.TxtDBName.MaxLength = 20;
            this.TxtDBName.Name = "TxtDBName";
            this.TxtDBName.Size = new System.Drawing.Size(144, 21);
            this.TxtDBName.TabIndex = 3;
            this.TxtDBName.Text = "DBMeter";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TxtDBName);
            this.GroupBox1.Controls.Add(this.TxtUserName);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.TxtPwd);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.TxtDBIp);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(12, 108);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(360, 208);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "SQL Server数据库";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(192, 120);
            this.TxtUserName.MaxLength = 20;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(144, 21);
            this.TxtUserName.TabIndex = 6;
            this.TxtUserName.Text = "sa";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 120);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(136, 23);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "用户名称：";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(16, 160);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(136, 23);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "用户密码：";
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(192, 160);
            this.TxtPwd.MaxLength = 10;
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(144, 21);
            this.TxtPwd.TabIndex = 6;
            this.TxtPwd.Text = "sa";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(144, 23);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "数据库服务器的IP地址：";
            // 
            // TxtDBIp
            // 
            this.TxtDBIp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtDBIp.Location = new System.Drawing.Point(192, 40);
            this.TxtDBIp.MaxLength = 15;
            this.TxtDBIp.Name = "TxtDBIp";
            this.TxtDBIp.Size = new System.Drawing.Size(144, 21);
            this.TxtDBIp.TabIndex = 1;
            this.TxtDBIp.Text = "127.0.0.1";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(136, 23);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "数据库的名称：";
            // 
            // RadioButton1
            // 
            this.RadioButton1.Location = new System.Drawing.Point(18, 36);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(144, 24);
            this.RadioButton1.TabIndex = 10;
            this.RadioButton1.Text = "Access数据库";
            // 
            // RadioButton2
            // 
            this.RadioButton2.Location = new System.Drawing.Point(192, 36);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(144, 24);
            this.RadioButton2.TabIndex = 11;
            this.RadioButton2.Text = "SQL Server数据库";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(297, 322);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "取消(&C)";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.RadioButton2);
            this.GroupBox2.Controls.Add(this.RadioButton1);
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(360, 90);
            this.GroupBox2.TabIndex = 17;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "数据库类型选择";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(204, 322);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 15;
            this.OK.Text = "确定(&O)";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // SetDbForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(382, 354);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetDbForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据库设置";
            this.Load += new System.EventHandler(this.SetDbForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtDBName;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TxtUserName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TxtPwd;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtDBIp;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button OK;
    }
}