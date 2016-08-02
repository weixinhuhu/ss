namespace 销售管理.日常业务
{
    partial class 费用分配详细
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
            this.dgvExAllocation = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExAllocation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExAllocation
            // 
            this.dgvExAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExAllocation.Location = new System.Drawing.Point(58, 139);
            this.dgvExAllocation.Name = "dgvExAllocation";
            this.dgvExAllocation.RowTemplate.Height = 23;
            this.dgvExAllocation.Size = new System.Drawing.Size(483, 303);
            this.dgvExAllocation.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 费用分配详细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvExAllocation);
            this.Name = "费用分配详细";
            this.Text = "费用分配详细";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExAllocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExAllocation;
        private System.Windows.Forms.Button button1;
    }
}