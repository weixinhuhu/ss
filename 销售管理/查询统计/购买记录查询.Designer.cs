namespace 销售管理.查询统计
{
    partial class 购买记录查询
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
            this.CheckDate = new System.Windows.Forms.CheckBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.reportView = new System.Windows.Forms.DataGridView();
            this.XTTradeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.DTStart = new System.Windows.Forms.DateTimePicker();
            this.DTEnd = new System.Windows.Forms.DateTimePicker();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmbChoice = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XTTradeListBindingSource)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckDate
            // 
            this.CheckDate.AutoSize = true;
            this.CheckDate.Location = new System.Drawing.Point(469, 19);
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.Size = new System.Drawing.Size(84, 16);
            this.CheckDate.TabIndex = 17;
            this.CheckDate.Text = "按时间区间";
            this.CheckDate.UseVisualStyleBackColor = true;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(795, 19);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(105, 30);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Enabled = false;
            this.btnExcel.Location = new System.Drawing.Point(795, 57);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(105, 27);
            this.btnExcel.TabIndex = 15;
            this.btnExcel.Text = "导出到EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // reportView
            // 
            this.reportView.AllowUserToAddRows = false;
            this.reportView.AllowUserToDeleteRows = false;
            this.reportView.AutoGenerateColumns = false;
            this.reportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportView.DataSource = this.XTTradeListBindingSource;
            this.reportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportView.Location = new System.Drawing.Point(3, 17);
            this.reportView.Name = "reportView";
            this.reportView.ReadOnly = true;
            this.reportView.RowTemplate.Height = 23;
            this.reportView.Size = new System.Drawing.Size(932, 495);
            this.reportView.TabIndex = 0;
            // 
            // XTTradeListBindingSource
            // 
            this.XTTradeListBindingSource.DataMember = "XTTradeList";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(467, 45);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 12);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "起始时间";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(467, 72);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 12);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "结束时间";
            // 
            // DTStart
            // 
            this.DTStart.Location = new System.Drawing.Point(544, 41);
            this.DTStart.Name = "DTStart";
            this.DTStart.Size = new System.Drawing.Size(173, 21);
            this.DTStart.TabIndex = 14;
            // 
            // DTEnd
            // 
            this.DTEnd.Location = new System.Drawing.Point(544, 68);
            this.DTEnd.Name = "DTEnd";
            this.DTEnd.Size = new System.Drawing.Size(173, 21);
            this.DTEnd.TabIndex = 13;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CheckDate);
            this.GroupBox1.Controls.Add(this.btnQuery);
            this.GroupBox1.Controls.Add(this.btnExcel);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.DTStart);
            this.GroupBox1.Controls.Add(this.DTEnd);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cmbChoice);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtCondition);
            this.GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(938, 94);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "查询条件";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(26, 26);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 12);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "选择查询条件";
            // 
            // cmbChoice
            // 
            this.cmbChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Items.AddRange(new object[] {
            "查询所有",
            "按用户号",
            "按操作员"});
            this.cmbChoice.Location = new System.Drawing.Point(161, 22);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(273, 20);
            this.cmbChoice.TabIndex = 8;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(26, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 12);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "输入查询条件";
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(161, 57);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(273, 21);
            this.txtCondition.TabIndex = 9;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.reportView);
            this.GroupBox2.Location = new System.Drawing.Point(3, 103);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(938, 515);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "购买记录";
            // 
            // 购买记录查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Name = "购买记录查询";
            this.Controls.SetChildIndex(this.GroupBox2, 0);
            this.Controls.SetChildIndex(this.GroupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XTTradeListBindingSource)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.CheckBox CheckDate;
        internal System.Windows.Forms.Button btnQuery;
        internal System.Windows.Forms.Button btnExcel;
        internal System.Windows.Forms.DataGridView reportView;
        internal System.Windows.Forms.BindingSource XTTradeListBindingSource;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker DTStart;
        internal System.Windows.Forms.DateTimePicker DTEnd;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cmbChoice;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCondition;
        internal System.Windows.Forms.GroupBox GroupBox2;
    }
}
