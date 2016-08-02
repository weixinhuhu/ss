using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 销售管理.Print
{
    public partial class PrintTemp : Form
    {
        public PrintTemp()
        {
            InitializeComponent();
        }

        #region 字段

        public DataTable dtDataSource = new DataTable();

        #endregion

        private void Print_Load(object sender, EventArgs e)
        {
            string[] Files = null;
            string mPath = null;

            Files = System.IO.Directory.GetFiles(Application.StartupPath + @"\Craxy\");

            for (int i = 0; i <= Files.Count() - 1; i++)
            {
                mPath = System.IO.Path.GetFileName((Files[i]));
                if (mPath.EndsWith(".CraxyMouse"))
                {
                    ComboBox1.Items.Add(mPath);
                }
            }

            Designer1.DataSource = dtDataSource;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CustomControls.IO.InOutPut.OpenFile(Designer1, Application.StartupPath + "\\Craxy\\" + ComboBox1.Text);

                //大小随模板变化
                //Panel1.Top = Designer1.Height + Designer1.Top + 5
                //Me.Height = Panel1.Top + Panel1.Height + 50

                this.Width = Designer1.Width + 30;
                Panel1.Height = Designer1.Height + 30;
                this.Height = Panel1.Height + 80;

                Designer1.LoadPrintSetting();
                Designer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDesign_Click(object sender, EventArgs e)
        {
            PrintModelSet mForm = new PrintModelSet();
            mForm.ShowDialog();
        }

        private void ButtonPreview_Click(object sender, EventArgs e)
        {
            Designer1.PrintView();
        }

        private void TxtCustomerId_TextChanged(object sender, EventArgs e)
        {
            TextBox senderTemp = (TextBox)sender;
            dtDataSource.Rows[0]["colCustomerId"] = senderTemp.Text.Trim();
            dtDataSource.Rows[0].AcceptChanges();

            Designer1.Refresh();
        }
    }
}
