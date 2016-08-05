using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Configuration;
using System.Xml;
using Common;
using Client.Class;
using Client.Main;
using Soft.Common;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("Client");
            if (processes.Length > 1)
            {
                IntPtr hwnd = processes[0].MainWindowHandle;
                // NOTE: ensure the first intance handle selected
                if (System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle == hwnd)
                {
                    hwnd = processes[1].MainWindowHandle;
                }

                long style = GetWindowLong(hwnd, GWL_STYLE);

                if ((style & WS_MINIMIZE) == WS_MINIMIZE)
                {
                    ShowWindow(hwnd, SW_SHOWNOACTIVATE);
                }
                SetForegroundWindow(hwnd);
                return;
            }

            try
            {
                string dataDir = AppDomain.CurrentDomain.BaseDirectory;
                if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
                {
                    dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                    AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
                }

                string xmlPath = "DBInfo.xml";
                XmlDocument xmlDoc = new XmlDocument();
                if (File.Exists(xmlPath) == false)
                {
                    //文件不存在则新建文件
                    xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", null, null));

                    //根节点
                    xmlDoc.AppendChild(xmlDoc.CreateElement("DBInfo"));
                    xmlDoc.Save(xmlPath);

                    //应用程序所在目录下级目录用“/”，上级目录用“../”
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBType", "", "0");
                    //XmlHelper.Insert(xmlPath, "/DBInfo", "DBConnStr", "", "Provider=SQLOLEDB;Data Source=192.168.111.115,1433;Persist Security Info=True;Password=sa;User ID=sa;Initial Catalog=DBMeter");
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBConnStr", "", "");
                }

                string sConnStr = Common.XmlHelper.Read(xmlPath, "/DBInfo/DBConnStr", "");
                //解密数据库连接参数
                sConnStr = Soft.Common.Utils.DecryptRc2(sConnStr);
                //公共类的连接字符串赋值，包括类属性 和 项目属性两处
                //Common.Properties.Settings.Default.ConnectionString = Common.ConnStr;
                CommonClass.SetConnStr(sConnStr);

                if (SqlHelper.TestDB() == 0)
                {
                    //PubClasses.SqlHelper.mConnStr = mConnStr;
                }
                else
                {
                    Dlg.ShowErrorInfo("连接数据库失败,请运行“数据库连接参数配置工具.exe”进行配置！");
                    return;                    
                }
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(string.Format("异常：\n{0}", ex.Message));
                return;
            }

            Application.Run(new FrmLogin());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hwnd);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern long GetWindowLong(IntPtr hwnd, int nIndex);

        private const int SW_SHOWNOACTIVATE = 4;
        const int GWL_STYLE = -16;
        const long WS_MINIMIZE = 0x20000000L;

    }
}
