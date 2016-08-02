//此文件专用于定义全局变量，全局变量均在类PubClass中

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 销售管理.Classes
{
    static class PubClass//命名空间内的类，默认访问级别为 internal（内部）。类下面的类，默认访问级别为 private（私有）。
    {
        //连接数据库用的全局变量--------------------------------------------------
        //public DatabaseSetClassNew mDatabaseClass = new DatabaseSetClassNew();

        private static string mDatabaseType;//数据库类型，1-sqlserver，2-access

        public static string MDatabaseType
        {
            get { return PubClass.mDatabaseType; }
            set { PubClass.mDatabaseType = value; }
        }

        //access
         private static string accessDbName;//access数据库名称

         public static string AccessDbName
        {
            get { return accessDbName; }
            set { accessDbName = value; }
        }

        //sqlserver
         private static string sqlDbAddress; //sqlserver数据库IP地址 "127.0.0.1","(local)"

         public static string SqlDbAddress
        {
            get { return sqlDbAddress; }
            set { sqlDbAddress = value; }
        }

         private static string sqlDbName; //sqlserver数据库名称 DBMeter

         public static string SqlDbName
        {
            get { return sqlDbName; }
            set { sqlDbName = value; }
        }

         private static string sqlDbUserName;   //用户名 sa

         public static string SqlDbUserName
        {
            get { return sqlDbUserName; }
            set { sqlDbUserName = value; }
        }

         private static string sqlDbPwd;   //用户密码 sa

         public static string SqlDbPwd
        {
            get { return sqlDbPwd; }
            set { sqlDbPwd = value; }
        }

         private static bool dbConnection;//数据库连接成功标志，成功为true

         public static bool DbConnection
        {
            get { return dbConnection; }
            set { dbConnection = value; }
        }
        //连接数据库--------------------------------------------------

        //配置文件路径
        //private static string filePath = Aplication.CurrentDirectory + @"\param.ini";//窗体里才可以用，路径最后不带\
         private static string iniPath = AppDomain.CurrentDomain + "param.ini";//路径最后带\

         public static string IniPath
         {
             get { return PubClass.iniPath; }
             set { PubClass.iniPath = value; }
         }

        public static string operatorID;

        public static string LoginName;
        public static long UserId;
        public static string UserName;
        public static string UserRight;
        public static string UserStatus;
        public static int UserRoleId;
        public static string ConnStr;
        //public static string EFConnStr;

        public const string StockInStatus = "StockInStatus";

        public  class MyCmbList
        {
            private Int64 mId;
            private string mName;
            public MyCmbList() { }
            public  MyCmbList(Int64 id, string name)
            {
                mId = id;
                mName = name;
            }

            public Int64 Id
            {
                set
                {
                    mId = value;
                }
                get
                {
                    return mId;
                }
            }

            public string Name
            {
                set
                {
                    mName = value;
                }
                get
                {
                    return mName;
                }

            }
            public override string ToString()
            {
                return Name;
            }
        }

        public static DbSet mDatabaseClass = new DbSet();


        
    }
}
