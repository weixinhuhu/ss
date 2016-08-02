//lisi 2012.09.19
//用户卡内共4个文件，对应4个结构体，和读卡时的4个函数

//bcd码即是十进制，hex码即是十六进制
//起始码68，结束码16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 销售管理.Classes.Structs;

namespace 销售管理.Classes
{ 
  public   class ClassRead4File
    {
        //读卡时从4个文件中取值，共4个方法=============================================================================
        //方法1，取购买文件
        public bool GetGouMaiFile(ref GouMaiFile sGouMai, StringBuilder  dataGouMaiSB)
        {
            string dataGouMai = dataGouMaiSB.ToString();

            sGouMai.meterNo = dataGouMai.Substring(6, 12);
            sGouMai.userNo = dataGouMai.Substring(18, 12);
            sGouMai.subNo = dataGouMai.Substring(30, 2);
            //用户类型()
            //用户类型：用一字节HEX码表示，用于表示用户的使用类型。

            //1:      代表按量计量的预付费方式()
            //2:      代表按金额计算的预付费方式()
            //3:      代表按金额计算的预付费方式(按阶梯计算)
            //4:      代表按量计量的后付费方式()
            //5:      代表按金额计算的后付费方式()
            //6:      代表按金额计算的后付费方式(按阶梯计算)
            //        卡类型()
            //卡类型:    用一字节HEX码表示(, 系统运营状态下识别不同卡片种类的标志)
            //编号规定为：01---开户卡；02用户卡；03补卡
            //        表类型()
            //表类型：用一字节HEX码表示，区分系统运行的不同表具.
            sGouMai.userType = dataGouMai.Substring(32, 2);
            sGouMai.cardType = dataGouMai.Substring(34, 2);
            sGouMai.meterType = dataGouMai.Substring(36, 2);
            sGouMai.updateFlag = dataGouMai.Substring(38, 2);

            sGouMai.buyAmount = dataGouMai.Substring(40, 8);
            sGouMai.buyTimes = dataGouMai.Substring(48, 4);
            sGouMai.alarm1 = dataGouMai.Substring(52, 8);
            sGouMai.alarm2 = dataGouMai.Substring(60, 8);
            sGouMai.tunJi = dataGouMai.Substring(68, 8);
            sGouMai.touZhi = dataGouMai.Substring(76, 8);
            sGouMai.maiChong = dataGouMai.Substring(84, 4);
            sGouMai.RFU = dataGouMai.Substring(88, 8);

            string checkEnd = null;
            //核对用，校验码和结束码
            checkEnd = dataGouMai.Substring(96);
            //校验码读卡时没用，仅验证下结束码
            if (checkEnd.Substring(2, 2) == "16")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //方法2，取返写文件
        public bool GetFanXieFile(ref FanXieFile sFanXie, StringBuilder dataFanXieSB)
        {
            string dataFanXie = dataFanXieSB.ToString();
            //6
            sFanXie.meterNo = dataFanXie.Substring(6, 12);
            sFanXie.userNo = dataFanXie.Substring(18, 12);
            //1
            sFanXie.subNo = dataFanXie.Substring(30, 2);
            sFanXie.userType = dataFanXie.Substring(32, 2);
            sFanXie.cardType = dataFanXie.Substring(34, 2);
            sFanXie.meterType = dataFanXie.Substring(36, 2);
            sFanXie.updateFlag = dataFanXie.Substring(38, 2);
            //2 4 2 4 4 4 4 
            sFanXie.RFU = dataFanXie.Substring(40, 4);
            sFanXie.buyAmount = dataFanXie.Substring(44, 8);
            sFanXie.buyTimes = dataFanXie.Substring(52, 4);
            sFanXie.alarm1 = dataFanXie.Substring(56, 8);
            sFanXie.alarm2 = dataFanXie.Substring(64, 8);
            sFanXie.tunJi = dataFanXie.Substring(72, 8);
            sFanXie.touZhi = dataFanXie.Substring(80, 8);
            //2
            sFanXie.meterState = dataFanXie.Substring(88, 4);
            //4
            sFanXie.surplus = dataFanXie.Substring(92, 8);
            sFanXie.leiJIGouMai = dataFanXie.Substring(100, 8);
            sFanXie.leiJIShiYong = dataFanXie.Substring(108, 8);
            sFanXie.leiJiMaiChong = dataFanXie.Substring(116, 8);
            //2 2 48 8
            sFanXie.mouthAmount = dataFanXie.Substring(124, 4);
            sFanXie.maiChongConst = dataFanXie.Substring(128, 4);
            sFanXie.twoYearAmount = dataFanXie.Substring(132, 96);
            sFanXie.returnTime = dataFanXie.Substring(228, 16);

            string checkEnd = null;
            //核对用，校验码和结束码
            checkEnd = dataFanXie.Substring(244);
            if (checkEnd.Substring(2, 2) == "16")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //方法3，取钱包文件
        public bool GetQianBaoFile(ref QianBaoFile sQianBao, StringBuilder dataQianBaoSB)
        {
            string dataQianBao = dataQianBaoSB.ToString();

            sQianBao.buyAmount = dataQianBao.Substring(0, 8);
            sQianBao.buyTimes = dataQianBao.Substring(8, 8);
            return true;
        }

        //方法4，取阶梯文件
        public bool GetJieTiFile(ref JieTiFileNew sJieTifile, StringBuilder dataJieTiSB)
        {
            string dataJieTi = dataJieTiSB.ToString();

            sJieTifile.JieTi1.JieTiShu = dataJieTi.Substring(6, 2);
            sJieTifile.JieTi1.JieTiAmount2 = dataJieTi.Substring(8, 8);
            sJieTifile.JieTi1.JieTiAmount3 = dataJieTi.Substring(16, 8);
            sJieTifile.JieTi1.JieTiAmount4 = dataJieTi.Substring(24, 8);
            sJieTifile.JieTi1.JieTiAmount5 = dataJieTi.Substring(32, 8);
            sJieTifile.JieTi1.JieTiAmount6 = dataJieTi.Substring(40, 8);
            sJieTifile.JieTi1.JieTiPrice1 = dataJieTi.Substring(48, 8);
            sJieTifile.JieTi1.JieTiPrice2 = dataJieTi.Substring(56, 8);
            sJieTifile.JieTi1.JieTiPrice3 = dataJieTi.Substring(64, 8);
            sJieTifile.JieTi1.JieTiPrice4 = dataJieTi.Substring(72, 8);
            sJieTifile.JieTi1.JieTiPrice5 = dataJieTi.Substring(80, 8);
            sJieTifile.JieTi1.JieTiPrice6 = dataJieTi.Substring(88, 8);

            sJieTifile.JieTi2.JieTiShu = dataJieTi.Substring(8 * 12, 8);
            sJieTifile.JieTi2.JieTiAmount2 = dataJieTi.Substring(8 * 13, 8);
            sJieTifile.JieTi2.JieTiAmount3 = dataJieTi.Substring(8 * 14, 8);
            sJieTifile.JieTi2.JieTiAmount4 = dataJieTi.Substring(8 * 15, 8);
            sJieTifile.JieTi2.JieTiAmount5 = dataJieTi.Substring(8 * 16, 8);
            sJieTifile.JieTi2.JieTiAmount6 = dataJieTi.Substring(8 * 17, 8);
            sJieTifile.JieTi2.JieTiPrice1 = dataJieTi.Substring(8 * 18, 8);
            sJieTifile.JieTi2.JieTiPrice2 = dataJieTi.Substring(8 * 19, 8);
            sJieTifile.JieTi2.JieTiPrice3 = dataJieTi.Substring(8 * 20, 8);
            sJieTifile.JieTi2.JieTiPrice4 = dataJieTi.Substring(8 * 21, 8);
            sJieTifile.JieTi2.JieTiPrice5 = dataJieTi.Substring(8 * 22, 8);
            sJieTifile.JieTi2.JieTiPrice6 = dataJieTi.Substring(8 * 23, 8);

            sJieTifile.SecondStartTime = dataJieTi.Substring(192, 16);

            string checkEnd = null;
            //核对用，校验码和结束码，4位
            checkEnd = dataJieTi.Substring(208);
            if (checkEnd.Substring(2, 2) == "16")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //结束 读卡时从4个文件中取值，共4个方法=========================================================

    }
}
