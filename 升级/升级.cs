using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using 升级.DAL.DataSetUpdateTableAdapters;
using System.Diagnostics;
using System.IO;

namespace 升级
{
    public partial class 升级 : Form
    {
        public 升级()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                FileVersionInfo FileInfo = FileVersionInfo.GetVersionInfo(Application.StartupPath + "\\销售管理.exe"); //获取文件版本信息
                Version mVer = new Version(FileInfo.FileVersion);
                Version sVer = new Version(new T_UpdateTableAdapter().GetMaxVer());
                if (mVer >= sVer)
                {
                    Process.Start(AppDomain.CurrentDomain.BaseDirectory + "销售管理.exe");
                    return;
                }
                var mFilesTable = new T_UpdateTableAdapter().GetDataByVer(mVer.ToString());
                int count = mFilesTable.Rows.Count;
                pbStatus.Step = 100/count;
                foreach (DAL.DataSetUpdate.T_UpdateRow mFile in mFilesTable.Rows)
                {
                    byte[] bFile;
                    string mPath;
                    bFile = mFile.Content;
                    if (string.IsNullOrEmpty(mFile.Dir) == false)
                    {
                        mPath = AppDomain.CurrentDomain.BaseDirectory + mFile.Dir + "\\" + mFile.ProgramName;
                    }
                    else
                    {
                        mPath = AppDomain.CurrentDomain.BaseDirectory + mFile.ProgramName;
                    }
                    if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + mFile.Dir) == false)
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + mFile.Dir);
                    }
                   
                    using (FileStream fs = new FileStream(mPath, FileMode.Create))
                    {

                        fs.Write(bFile, 0, bFile.Length);
                        fs.Close();
                    }
                    pbStatus.PerformStep();
                }
                Process.Start(AppDomain.CurrentDomain.BaseDirectory + "销售管理.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Environment.Exit(0);
            }
        }

        private void 升级_Load(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(1000);
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
