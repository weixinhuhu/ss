using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Soft.Common
{
    public class Log
    {
        public static void WriteToTxt(string _sInfo)
        {
            FileStream fs;
            try
            {
                fs = new FileStream(string.Format(@"{0}\Debug.txt", Application.StartupPath), FileMode.Append, FileAccess.Write);
            }
            catch(Exception Ex)
            {
                Dlg.ShowErrorInfo(string.Format("创建日志文件失败：\n{0}", Ex.Message));
                return;
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(string.Format("【{0}】{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), _sInfo));
                    sw.Close();
                }
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
