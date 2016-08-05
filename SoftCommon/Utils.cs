using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Security.Cryptography;
using System.IO;

namespace Soft.Common
{
    public class Utils
    {
        /// <summary>
        /// 计算累加和
        /// </summary>
        /// <param name="sMsg"></param>
        /// <returns></returns>
        public static string CalcChecksum(string sMsg)
        {
            byte bSum = 0;
            try
            {
                for (int i = 0; i < (sMsg.Length / 2); i++)
                {
                    bSum += Convert.ToByte(sMsg.Substring(i * 2, 2), 16);
                }
            }
            catch
            {
                //ShowErrorInfo(string.Format("计算校验和异常：{0}", ex.Message));
            }
            return bSum.ToString("X2");
        }

        /// <summary>
        /// 逆序字符串
        /// </summary>
        /// <param name="sMsg"></param>
        /// <returns></returns>
        public static string ConvertOrder(string sMsg)
        {
            if ((sMsg.Length % 2) != 0)
            {
                return sMsg;
            }
            int iCount = sMsg.Length / 2;
            StringBuilder sbInfo = new StringBuilder(sMsg.Length);
            for (int i = 0; i < iCount; i++)
            {
                sbInfo.Append(sMsg.Substring((iCount - i - 1) * 2, 2));
            }
            return sbInfo.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sMsg"></param>
        /// <returns></returns>
        public static string GetASCII(string sMsg)
        {
            StringBuilder sb = new StringBuilder();
            byte[] bMsg = Encoding.ASCII.GetBytes(sMsg);
            for (int i = 0; i < sMsg.Length; i++)
            {
                sb.Append(bMsg[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static int StrToIntDef(string _sInt, int _iDef = -1)
        {
            int iOut;
            if (Int32.TryParse(_sInt, out iOut))
            {
                return iOut;
            }
            else
            {
                return _iDef;
            }
        }

        public static int StrToIntDef(string _sInt, int _iDef, NumberStyles style)
        {
            int iOut;
            if (Int32.TryParse(_sInt, style, CultureInfo.CurrentCulture, out iOut))
            {
                return iOut;
            }
            else
            {
                return _iDef;
            }
        }
        public static Int64 StrToInt64Def(string _sInt64, Int64 _i64Def = -1)
        {
            Int64 iOut;
            if (Int64.TryParse(_sInt64, out iOut))
            {
                return iOut;
            }
            else
            {
                return _i64Def;
            }
        }

        public static Int64 StrToInt64Def(string _sInt64, int _i64Def, NumberStyles style)
        {
            Int64 iOut;
            if (Int64.TryParse(_sInt64, style, CultureInfo.CurrentCulture, out iOut))
            {
                return iOut;
            }
            else
            {
                return _i64Def;
            }
        }

        public static float StrToFloatDef(string _sFloat, float _fDef = -1)
        {
            float iOut;
            if (float.TryParse(_sFloat, out iOut))
            {
                return iOut;
            }
            else
            {
                return _fDef;
            }
        }

        #region  //Encrypt
        public static string EncryptRc2(string srcStr, string sKey = "ABCDEF987654321")
        {
            if (string.IsNullOrEmpty(srcStr) || string.IsNullOrEmpty(sKey))
            {
                return null;
            }
            byte[] InByteArray = Encoding.UTF8.GetBytes(srcStr);
            byte[] key = Encoding.UTF8.GetBytes(sKey);
            byte[] IV = Encoding.UTF8.GetBytes(sKey.Substring(0, sKey.Length - 2));
            using (RC2CryptoServiceProvider rc2 = new RC2CryptoServiceProvider())
            {
                ICryptoTransform Encrytor = rc2.CreateEncryptor(key, IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, Encrytor, CryptoStreamMode.Write))
                    {
                        cs.Write(InByteArray, 0, InByteArray.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                    }
                    string DesStr = Convert.ToBase64String(ms.ToArray());
                    ms.Close();
                    return DesStr;
                }
            }
        }
        
        public static string DecryptRc2(string srcStr, string sKey = "ABCDEF987654321")
        {
            if (string.IsNullOrEmpty(srcStr) || string.IsNullOrEmpty(sKey))
            {
                return null;
            }
            byte[] InByteArray = Convert.FromBase64String(srcStr);
            byte[] key = Encoding.UTF8.GetBytes(sKey);
            byte[] IV = Encoding.UTF8.GetBytes(sKey.Substring(0, sKey.Length - 2));
            using (RC2CryptoServiceProvider rc2 = new RC2CryptoServiceProvider())
            {
                ICryptoTransform Decryptor = rc2.CreateDecryptor(key, IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, Decryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(InByteArray, 0, InByteArray.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                    }
                    string DesStr = Encoding.UTF8.GetString(ms.ToArray());
                    ms.Close();
                    return DesStr;
                }
            }
        }
        #endregion
    }
}
