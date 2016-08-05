using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace PubClasses
{
    public class MD5
    {
        /// <summary>
        /// 对传入的字符串进行MD5加密
        /// </summary>
        /// <param name="Pass">需要加密的字符串</param>
        /// <returns>加密后的数据</returns>
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
    }
}
