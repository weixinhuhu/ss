using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public static class CommonClass
    {
        //public  PubClass(string connStr)
        //{
        //    Common.Properties.Settings.Default.ConnectionString = connStr;
        //}

        //全局变量登录时赋值，修改时重新赋值。采样点不是全局变量，要在开户时可选。

        public static string ConnStr;
        public static string SqlConnStr;
        public static string EFConnStr;
        
        //public static string gCardType = "CPU 卡(3DES)";        

        //登录
        public static string OperatorID = "0";
        public static int OperatorType;

        public static List<int> UserRightList = new List<int>();

        public struct SttUser
        {
            public static string sUserID = "";
            public static string sUserName = "";
            public static Int32 iLevel = 0;
            public static bool blSuperUser = false;
        }
        public struct SttDb
        {
            /// <summary>
            /// -2:不支持; -1:未知; 0:Access; 1:SQLServer;
            /// </summary>
            public static Int32 iDBType = -1; //
            public static string sDbInfo = "";//用于显示在状态栏；
            public static string sDataSource = "";
            public static string sUserID = "";
            public static string sUserPass = "";
        }

        public struct SttIC
        {
            public static Int32 iCardType = -1;
        }

        public static void SetConnStr(string connStr,string sqlConnStr,string efConnStr)
        {
            ConnStr = connStr;
            SqlConnStr = sqlConnStr;
            EFConnStr = efConnStr;
            Common.Properties.Settings.Default.ConnectionString = connStr;
            
        }

        //public static string OperatorName;
        //public static string NetNo;

        ////04规范--------------------------------------------------------------
        ////区域号，t57取前2位。要防止区域号不足2位时截取前2位出错
        //public static string gSysId;
        //public static int gPortInt;     //读卡器端口号，已截取数字部分
        //public static int gCode1, gCode2, gCode3;

        ////public static string gCardType; //卡类型
        //public static Int16 gT57_flag;
        //public static decimal gOpenFee, gBukaFee, gExchangeFee;//开户费，补卡费，换表费


        ////cpu卡表--------------------------------------------------------------
        ////金额与费率乘以 10000 写卡
        //public const int Money_point = 10000;
        ////返写区加密补充算法
        //public static string JMA;


    }
}
