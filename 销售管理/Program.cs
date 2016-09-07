using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using 销售管理.Classes;
using 销售管理.DAL.DataSetT_UpdateTableAdapters;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Configuration;



namespace 销售管理
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
            
            
            //获取连接字符串
            Common.SqlConnectionSet.SetConnStr();
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(Assembly.GetExecutingAssembly().GetName().Name);
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
            
           // 检查是否有更新
            Version sVer = new Version(Convert.ToString(new T_UpdateTableAdapter().GetMaxVer()));
            Version mVer = Assembly.GetExecutingAssembly().GetName().Version;
            if (sVer > mVer)
            {
                //MessageBox.Show("开始升级");
                System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "升级.exe");
                //MessageBox.Show("升级完成");
                //Application.Exit();
                //System.Environment.Exit(0);
                return;
            }

            //更新本程序以外的其它文件
            //var mFilesTable = new T_UpdateTableAdapter().GetOtherProgramMaxVer();
            //foreach (DAL.DataSetT_Update.T_UpdateRow mFile in mFilesTable.Rows)
            //{
            //    byte[] bFile;
            //    string mPath;
            //    //if (mFile.ProgramName.ToLower().EndsWith(".dll"))
            //    //    continue;
            //    bFile = mFile.Content;
            //    if (string.IsNullOrEmpty(mFile.Dir) == false)
            //    {
            //        mPath = AppDomain.CurrentDomain.BaseDirectory + mFile.Dir + "\\" + mFile.ProgramName;
            //    }
            //    else
            //    {
            //        mPath = AppDomain.CurrentDomain.BaseDirectory + mFile.ProgramName;
            //    }
            //    if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + mFile.Dir) == false)
            //    {
            //        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + mFile.Dir);
            //    }
            //    try
            //    {
            //        using (FileStream fs = new FileStream(mPath, FileMode.Create))
            //        {

            //            fs.Write(bFile, 0, bFile.Length);
            //            fs.Close();
            //        }
            //    }
            //    catch (Exception)
            //    {
            //    }
            //}

            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ////ConfigurationManager.RefreshSection("MYDBEntities2");
            //if (config.ConnectionStrings.ConnectionStrings["MYDBEntities2"] != null)
            //{
            //    MessageBox.Show(config.ConnectionStrings.ConnectionStrings["MYDBEntities2"].ConnectionString);
            //}
            //else
            //{
            //    MessageBox.Show("空");
            //}
            //if (config.ConnectionStrings.ConnectionStrings["MYDBEntities2"] == null)
            //{
            //    MessageBox.Show("重启");
            //    Application.Restart();
            //}
            //try
            //{
                

            //    string xmlPath = "DBInfo.xml";
            //    XmlDocument xmlDoc = new XmlDocument();
            //    if (File.Exists(xmlPath) == false)
            //    {
            //        //文件不存在则新建文件
            //        xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", null, null));

            //        //根节点
            //        xmlDoc.AppendChild(xmlDoc.CreateElement("DBInfo"));
            //        xmlDoc.Save(xmlPath);

            //        //应用程序所在目录下级目录用“/”，上级目录用“../”
            //        Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBType", "", "0");
            //        //XmlHelper.Insert(xmlPath, "/DBInfo", "DBConnStr", "", "Provider=SQLOLEDB;Data Source=192.168.111.115,1433;Persist Security Info=True;Password=sa;User ID=sa;Initial Catalog=DBMeter");
            //        Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBConnStr", "", "");
            //    }

            //    string sConnStr = Common.XmlHelper.Read(xmlPath, "/DBInfo/DBConnStr", "");
            //    //解密数据库连接参数
            //    sConnStr = Soft.Common.Utils.DecryptRc2(sConnStr);
            //    //公共类的连接字符串赋值，包括类属性 和 项目属性两处
            //    //Common.Properties.Settings.Default.ConnectionString = Common.ConnStr;
            //    Common.CommonClass.SetConnStr(sConnStr);

            //    if (Common.SqlHelper.TestDB() == 0)
            //    {
            //        //PubClasses.SqlHelper.mConnStr = mConnStr;
            //    }
            //    else
            //    {
            //        MessageBox.Show("连接数据库失败,请运行“数据库连接参数配置工具.exe”进行配置！");
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //   MessageBox.Show(string.Format("异常：\n{0}", ex.Message));
            //    return;
            //}

            

            Application.Run(new LoginForm1());

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
