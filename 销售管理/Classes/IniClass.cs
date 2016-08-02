using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;//[DllImport("kernel32")]

//格式
//  INI文件由节、键、值组成。
//节
//  [section]
//参数（键=值）
//  name=value
//注解
//  注解使用分号表示（;）

namespace 销售管理.Classes
{
    static class IniClass
    {
        //配置文件路径
        //private static string iniPath =Environment.CurrentDirectory  + @"\param.ini";//可设置
        private static string iniPath = System.Windows.Forms.Application.StartupPath + @"\ipSet.ini";//路径最后带\

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        /// <summary>
        /// 读ini文件
        /// </summary>
        /// <param name="lpAppName">节名称</param>
        /// <param name="lpKeyName">键名称</param>
        /// <param name="lpDefault">键没有找到时返回的默认值，可设为空字符串</param>
        /// <param name="lpReturnedString">键的值，指定一个字串缓冲区，长度至少为nSize</param>
        /// <param name="nSize">指定装载到lpReturnedString缓冲区的最大字符数量</param>
        /// <param name="lpFileName">ini文件全名</param>
        /// <returns>复制到lpReturnedString缓冲区的字节数量</returns> 
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern long GetPrivateProfileString(string section, string key, string defaultVal,
                                                         StringBuilder retVal, int iSize, string filePath);
        //==============================================================================================================
        //简单封装读写ini函数
        public static void WriteIni(string section, string key, string value)
        {
            try
            {
                WritePrivateProfileString(section, key, value,iniPath);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public static string ReadIni(string section, string key, string defaultVal)
        {
            try
            {
                StringBuilder retValue = new StringBuilder(200);
                GetPrivateProfileString(section, key, defaultVal, retValue, 200, iniPath);
                return retValue.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string AddDbInfo(string[] PInfo)
        {
            string id;
            id = ReadIni("Count", "ID", "0") + 1;
            WriteIni("Count", "ID", id);

            string sID = "ID=" + id;
            WriteIni(sID, "服务器的IP地址", PInfo[0]);
            WriteIni(sID, "服务器的数据库名称", PInfo[1]);
            WriteIni(sID, "数据库用户名称", PInfo[2]);
            WriteIni(sID, "数据库用户密码", PInfo[3]);
            WriteIni(sID, "数据库类型", PInfo[4]);
            return id;
        }

        public static string[] ReadDbInfo()
        {
            string id;
            string[] arytemp = new string[5];
            id = ReadIni("Count", "ID", "");
            arytemp[0] = ReadIni("ID=" + id, "服务器的IP地址", "0");
            arytemp[1] = ReadIni("ID=" + id, "服务器的数据库名称", "0");
            arytemp[2] = ReadIni("ID=" + id, "数据库用户名称", "0");
            arytemp[3] = ReadIni("ID=" + id, "数据库用户密码", "0");
            arytemp[4] = ReadIni("ID=" + id, "数据库类型", "0");
            return arytemp;
        }

    }
}
