using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 销售管理.Classes
{
    static class PubFunc
    {
        /// <summary>
        /// 在字符串前面补零，使字符串长度为zeroNum
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="zeroNum">补齐之后的长度</param>
        /// <returns>新字符串，长度为zeroNum</returns>
        public static string StrAddZero(string str, int zeroNum)
        {
            if (zeroNum - str.Trim().Length > 0)
            {
                return str.PadLeft(zeroNum, '0');
            }
            else
            {
                return str.Trim().Substring(str.Length - zeroNum, zeroNum);//舍弃高位
            }
        }

        /// <summary>
        /// 把字符串的最后2位作为小数部分，其他作为整数部分，组成一个新的小数
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="sTemp">新字符串</param>
        /// <returns>新字符串</returns>
        public static string DotStr82(string str, string sTemp)
        {
            int i = 0;
            i = str.Length;

            if (str == "0")
            {
                sTemp = str;
            }
            else
            {
                sTemp = str.Substring(0, i - 2) + "." + str.Substring(i - 2, 2);
            }
            return sTemp;
        }

        /// <summary>
        /// 把字符串的最后4位作为小数部分，其他作为整数部分，组成一个新的小数
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="sTemp">新字符串</param>
        /// <returns>新字符串</returns>
        public static string DotStr84(string str, string sTemp)
        {
            int i = 0;
            i = str.Length;

            if (str == "0")
            {
                sTemp = str;
            }
            else
            {
                sTemp = str.Substring(0, i - 4) + "." + str.Substring(i - 4, 4);
            }
            return sTemp;
        }

        /// <summary>
        ///  十六进制抟换为十进制
        /// </summary>
        /// <param name="hex"></param>
        /// <returns>十进制长整形的字符串形式</returns>
        public static long HexToDec(string hex)
        {
            return Convert.ToInt64(hex, 16);
        }

        /// <summary>
        ///  十进制抟换为十六进制
        /// </summary>
        /// <param name="dec"></param>
        /// <returns>十六进制字符串形式</returns>
        public static string DecToHex(long dec)
        {
            return Convert.ToString(dec, 16);
        }

        /// <summary>
        /// 十进制抟换为十六进制，然后在前面补零
        /// </summary>
        /// <param name="dec">10进制字符串形式</param>
        /// <param name="zeroNum">补零后长度</param>
        /// <returns>16进制字符串</returns>
        public static string DecToHex1(string dec, int zeroNum)
        {
            int decTemp = Convert.ToInt32(dec);
            return Convert.ToString(decTemp, 16).PadLeft(zeroNum, '0');
        }
        //补零后长度为8，这种情形最多，所以单列
        public static string DecToHex8(string dec)
        {
            int decTemp = Convert.ToInt32(dec);
            return Convert.ToString(decTemp, 16).PadLeft(8, '0');
        }

        /// <summary>
        /// 累加校验和
        /// </summary>
        /// <param name="data1"></param>
        /// <returns>最后一个字节，2位16进制数</returns>
        public static string HexAddSum(string data1)
        {
            long m = 0;
            long sum = 0;
            string sum16;

            for (int i = 0; i < data1.Trim().Length; i += 2)
            {
                m = HexToDec(data1.Substring(i, 2));
                sum += m;
            }

            sum16 = DecToHex(sum);
            if (sum16.Length >= 2)
            {
                return sum16.Substring(sum16.Length - 1 - 2, 2);
            }
            else
            {
                return "0" + sum16;
            }
        }

        public static Int16 HexAddSum1(byte[] memorySpage)
        {
            int num = 0;
            for (int i = 0; i < memorySpage.Length; i++)
            {
                num = (num + memorySpage[i]) % 0xffff;
            }
            //实际上num 这里已经是结果了，如果只是取int 可以直接返回了 
            memorySpage = BitConverter.GetBytes(num);
            //返回累加校验和 
            return BitConverter.ToInt16(new byte[] { memorySpage[0], memorySpage[1] }, 0);
        }


        public static void AddTreeNode(string str, int cls, System.Windows.Forms.TreeNodeCollection nodes)
        {
            System.Windows.Forms.TreeNode nodeTemp = new System.Windows.Forms.TreeNode();
            nodeTemp.Text = str;
            nodeTemp.ImageIndex = cls;
            nodeTemp.SelectedImageIndex = cls;
            nodes.Add(nodeTemp);
        }

        /// <summary>
        /// 正整数
        /// </summary>
        public static bool IsIntPositive(string i1)
        {
            Regex rg;
            rg = new Regex("^[0-9]*[1-9][0-9]*$");//[0-9]等同于\d 
            return rg.IsMatch(i1);
        }

        public static bool IsMoneyPositive(string i1)
        {
            Regex rg;
            rg = new Regex(@"^\d*(\.(\d){0,4})?$");//[0-9]等同于\d 
            return rg.IsMatch(i1);
        }
        public static bool IsMoney(string i1)
        {
            Regex rg;
            rg = new Regex(@"^-?\d*(\.(\d){0,4})?$");//[0-9]等同于\d 
            return rg.IsMatch(i1);
        }

        public static byte HexToBina(string hex)
        {
            int iTemp;
            string sTemp;
            iTemp = Convert.ToInt32(hex, 16);
            sTemp = Convert.ToString(iTemp, 2);
            return Convert.ToByte(sTemp);

            //return Convert.ToString(0xa, 2);
        }

        public static bool IsNumber(string input)
        {
            try
            {
                double outDec=0;
                return double.TryParse(input, out outDec);
            }
            catch
            {
                return false;
            }
        }

        public static void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var mCol = ((DataGridView)sender).Columns["编号"];
            if (mCol != null)
                mCol.Visible = false;
        }


        public static void dgv_DataBindingComplete_RemoveID(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            var dgv = (DataGridView) sender;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Name.ToUpper().Contains("ID"))
                {
                    col.Visible = false;
                }
            }
        }
        
    }
}