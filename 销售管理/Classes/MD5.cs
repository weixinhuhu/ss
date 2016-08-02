using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace 销售管理.Classes
{
    class MD5
    {
        public static string Md5Encrypt(string Pass)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            Byte[] md5Data;
            string md5Pass;
            md5Data = md5.ComputeHash(UTF8Encoding.Default.GetBytes(Pass));
            md5Pass = BitConverter.ToString(md5Data, 0, md5Data.Length);
            md5Pass = md5Pass.Replace("-","");
            md5Data = md5.ComputeHash(UTF8Encoding.Default.GetBytes(md5Pass));
            md5Pass = BitConverter.ToString(md5Data, 0, md5Data.Length);
            md5Pass = md5Pass.Replace("-","");

            return md5Pass;
        }

        [DllImport("Kernel32.dll")]
        public static extern void SetLocalTime(SystemTime st);

        [StructLayout(LayoutKind.Sequential)]
        public class SystemTime
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort Whour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;

        }

        public static void Timing(DateTime _DT)
        {
            try
            {
                SystemTime st = new SystemTime();
                st.wYear = (ushort)_DT.Year;
                st.wMonth = (ushort)_DT.Month;
                st.wDay = (ushort)_DT.Day;
                st.Whour = (ushort)_DT.Hour;
                st.wMinute = (ushort)_DT.Minute;
                st.wSecond = (ushort)_DT.Second;
                SetLocalTime(st);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(string.Format("系统时间设置失败:\n{0}", Ex.Message));
            }
        }
    }
}
