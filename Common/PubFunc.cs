using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

namespace PubClasses
{
    public static class PubFunc
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
        public static string DecToHex(string dec, int zeroNum)
        {
            int decTemp = Convert.ToInt32(dec);
            return Convert.ToString(decTemp, 16).PadLeft(zeroNum, '0');
        }

        ////改为下面那个函数。补零后长度为8，这种情形最多，所以单列
        //public static string DecToHex8(string dec)
        //{
        //    int decTemp;
        //    if (dec != "")
        //    {
        //        decTemp = (int)(Convert.ToDecimal(dec));
        //        return Convert.ToString(decTemp, 16).PadLeft(8, '0');
        //    }
        //    else
        //    {
        //        return "".PadLeft(8, '0');
        //    }
        //}

        //补零后长度为8，这种情形最多，所以单列
        public static string DecToHex8(decimal? dec)
        {
            if (dec == null)
            {
                return "0".PadLeft(8, '0');
            }

            long tempDec = Convert.ToInt64(dec);
            return Convert.ToString(tempDec, 16).PadLeft(8, '0');
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
                return sum16.Substring(sum16.Length - 2, 2);
            }
            else
            {
                return "0" + sum16;
            }
        }

        //试验
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

        //验证数字类型，正则表达式==============================================================================
        /// <summary>
        /// 非负整数，@"^$"，这是必备的，[0-9]等同于\d
        /// </summary>
        public static bool IsIntFeiFu(string i1)
        {
            Regex rg;
            rg = new Regex(@"^\d+$");//\d+
            return rg.IsMatch(i1);
        }
        /// <summary>
        /// 正整数，*重复0次或更多次，+重复1次或更多次
        /// </summary>
        public static bool IsIntZheng(string i1)
        {
            Regex rg;
            rg = new Regex("^[0-9]*[1-9][0-9]*$");//[0-9]*[1-9][0-9]*
            return rg.IsMatch(i1);
        }
        /// <summary>
        /// 负整数
        /// </summary>
        public static bool IsIntFu(string i1)
        {
            Regex rg;
            rg = new Regex("^-[0-9]*[1-9][0-9]*$");//-[0-9]*[1-9][0-9]*
            return rg.IsMatch(i1);
        }
        /// <summary>
        /// 整数
        /// </summary>
        public static bool IsInt(string i1)
        {
            Regex rg;
            rg = new Regex(@"^-?\d+$");//-?\d+
            return rg.IsMatch(i1);
        }
        /// <summary>
        /// 小数
        /// </summary>
        public static bool IsDouble(string i1)
        {
            Regex rg;
            rg = new Regex(@"^(-?\d+)(\.\d+)?$");//(-?\d+)(\.\d+)?
            return rg.IsMatch(i1);
        }
        //=====================================================================================================

        public static byte HexToBina(string hex)
        {
            int iTemp;
            string sTemp;
            iTemp = Convert.ToInt32(hex, 16);
            sTemp = Convert.ToString(iTemp, 2);
            return Convert.ToByte(sTemp);

            //return Convert.ToString(0xa, 2);
        }

        public static int CY_ChangeInt(string cyData)
        {
            double cy = Convert.ToDouble(cyData);
            if (cy == 0.1)
            {
                return 1;
            }
            else if (cy == 1)
            {
                return 2;
            }
            else if (cy == 0.01)
            {
                return 3;
            }
            else if (cy == 10)
            {
                return 4;
            }
            else
            {
                return -1;
            }
        }
        public static double CY_Change(string cyData)
        {
            int cy = Convert.ToInt32(cyData);
            if (cy == 1)
            {
                return 0.1;
            }
            else if (cy == 2)
            {
                return 1;
            }
            else if (cy == 3)
            {
                return 0.01;
            }
            else if (cy == 4)
            {
                return 10;
            }
            else
            {
                return -1;
            }
        }
        /// <summary>
        /// 异或
        /// </summary>
        /// <param name="aHex"></param>
        /// <param name="bHex"></param>
        /// <returns></returns>
        public static string AXorB(string aHex, string bHex)
        {
            string ret;
            long retDec, aDec, bDec;

            //16转10
            aDec = Convert.ToInt64(aHex, 16);

            //16转10
            bDec = Convert.ToInt64(bHex, 16);

            retDec = aDec ^ bDec;
            ret = PubFunc.DecToHex(retDec);

            return ret;
        }

        //以下为对十进制与十六进制相互转换的函数
        public static string Dec2Hex(string hugenum)
        {
            //'UPGRADE_WARNING: Mod 有新行为。 单击以获得更多信息:“ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"”
            string dectohexTemp = string.Empty;
            string subRight4;
            while (hugenum.Length > 2)
            {
                if (hugenum.Length <= 4)
                {
                    subRight4 = hugenum;
                }
                else
                {
                    subRight4 = hugenum.Substring(hugenum.Length - 4, 4);
                }

                long tempDec1 = Convert.ToInt64(subRight4);

                dectohexTemp = Convert.ToString(tempDec1 % 16, 16) + dectohexTemp;
                for (int i = 1; i <= 4; i++) //devide hugenum by 16
                {
                    hugenum = half(hugenum);
                }
            }

            long tempDec2 = Convert.ToInt64(hugenum);
            dectohexTemp = Convert.ToString(tempDec2, 16) + dectohexTemp;

            return dectohexTemp;
        }

        //只能传可以转换为整形的数
        public static string half(string X)   //get half of x（取半）
        {
            string halfTemp;

            X = "0" + X;
            string[] result = new string[X.Length + 1];

            for (int i = 2; i <= X.Length; i++)
            {
                int a, b, modTemp;

                //vb mid函数下标从1算起
                a = Convert.ToInt32(X.Substring(i - 1, 1)) / 2;

                modTemp = Convert.ToInt32(X.Substring(i - 2, 1)) % 2;
                b = (modTemp == 1 ? 5 : 0);

                result[i] = (a + b).ToString();
            }

            halfTemp = string.Join("", result);
            if (halfTemp.Substring(0, 1) == "0")
            {
                // no zero ahead
                halfTemp = halfTemp.Substring(1, halfTemp.Length - 1);
            }

            return halfTemp;
        }

        public static bool IsNumber(string input)
        {
            try
            {
                double outDec = 0;
                return double.TryParse(input, out outDec);
            }
            catch
            {
                return false;
            }
        }




    }
}