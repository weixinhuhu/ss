using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using 升级.DAL.DataSetUpdateTableAdapters;


namespace 升级
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //获取连接字符串
            Common.SqlConnectionSet.SetConnStr();

            FileVersionInfo FileInfo = FileVersionInfo.GetVersionInfo(Application.StartupPath + "\\销售管理.exe"); //获取文件版本信息
            Version mVer = new Version(FileInfo.FileVersion);
            Version sVer = new Version(new T_UpdateTableAdapter().GetMaxVer());
            if (mVer>=sVer)
            {
                Process.Start(AppDomain.CurrentDomain.BaseDirectory + "销售管理.exe");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 升级());
        }
    }
}
