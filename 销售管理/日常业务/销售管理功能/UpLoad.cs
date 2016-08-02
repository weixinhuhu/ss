using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetT_UpdateTableAdapters;
using System.IO;

namespace 销售管理.日常业务
{
    public partial class UpLoad : Form
    {
        public UpLoad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_UpdateTableAdapter adapter = new T_UpdateTableAdapter();
            OpenFileDialog mDlg = new OpenFileDialog();
            mDlg.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (mDlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(mDlg.FileName,FileMode.Open);
                byte[] bFile = new byte[fs.Length];
                fs.Read(bFile, 0, (int)fs.Length);
                adapter.Insert("销售管理", "1.1", "", DateTime.Now, bFile, "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            T_UpdateTableAdapter adapter = new T_UpdateTableAdapter();
            byte[] bFile;
            string mPath;
            mPath = AppDomain.CurrentDomain.BaseDirectory + "\\temp\\" ;
            bFile = ((销售管理.DAL.DataSetT_Update.T_UpdateRow)adapter.GetData().Rows[0]).Content;
            using (FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\temp\\" + ((销售管理.DAL.DataSetT_Update.T_UpdateRow)adapter.GetData().Rows[0]).Dir, FileMode.Create))
            {

                fs.Write(bFile, 0, bFile.Length);
                fs.Close();
            }
        }
    }
}
