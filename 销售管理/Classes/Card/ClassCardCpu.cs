using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace 销售管理.Classes.Card
{
    class ClassCardcpu
    {
        //  [MarshalAs(UnmanagedType.LPStr)]
        //要带出值的不能用string要用stringbuilder
        //读用户卡用户号
        [DllImport("Ykt_Card.dll")]
        static extern int Read_Userid_YktCard_sm1(StringBuilder userid);

        //读用户卡，未开户返回31
        [DllImport("Ykt_Card.dll")]
        public static extern int Read_User_YktCard_sm1_A(
            int meterType, int subid,
            StringBuilder goumai,
            StringBuilder fanxie,
            StringBuilder qianbao,
            StringBuilder jieti);

        //写卡
        [DllImport("Ykt_Card.dll")]
        public static extern int Write_User_YktCard_sm1(string goumai, string qianbao, string jieti);

        /// <summary>
        /// 清卡
        /// </summary>
        /// <param name="meterType">水表1</param>
        /// <param name="subid"></param>
        /// <returns></returns>
        [DllImport("Ykt_Card.dll")]
        public static extern int Clear_User_YktCard(int  meterType, int subid);
        //===================================================================================================


        public static int GetBaseInfo(ref StringBuilder baseInfo)
        {
            return Read_Userid_YktCard_sm1(baseInfo);
        }



    }
}
