//lisi 2012.09.19
//此文件只定义类型，没有class。定义5个结构体：4个用户卡内文件，和一个购买信息文件

//用户卡内共4个文件，对应4个结构体，和读卡时的4个函数( 在ClassRead4File)
//bcd码即是十进制，hex码即是十六进制
//起始码68，结束码16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 销售管理.Classes.Structs
{
    //4个文件开始=========================================================================================
    //购买信息文件
    public struct GouMaiFile
    {
        //校验码校验如下部分
        //长度45=2DH，单位字节。总字符数要再加前面3字节和后面2字节，共50字节，100个字符
        public const string comAndLenth = "012D";
        //6 6 1 1 1 1 1 
        //BCD码,表号
        public string meterNo;
        //用户号，BCD码
        public string userNo;
        //子表号，BCD码
        public string subNo;
        //用户类型（计费类型），hex
        public string userType;
        //卡类型：01开户，02用户，03补卡，hex
        public string cardType;
        ///表类型
        public string meterType;
        //参数更新标志，hex
        public string updateFlag;
        //4 2 4 4 4 4 2 4
        //购买量、金额
        public string buyAmount;
        //购买次数，hex
        public string buyTimes;
        //报警金额1，hex
        public string alarm1;
        //报警金额2，hex
        public string alarm2;
        //囤积金额，hex
        public string tunJi;
        //透支金额,hex
        public string touZhi;
        //脉冲常数，
        public string maiChong;
        //保留
        public string RFU;
        //校验码
        //结束码16
    }

    //返写信息文件
    public struct FanXieFile
    {
        //校验码校验如下部分 17+24+22+56=
        //长度119=77H。总字符数=(119+5)*2=248
        private const string comAndLenth = "0177";
        //6 6 1 1 1 1 1 
        //BCD码,表号
        public string meterNo;
        //用户号，BCD码
        public string userNo;
        //子表号，BCD码
        public string subNo;
        //计费类型，hex
        public string userType;
        //卡类型：01开户，02用户，03补卡，hex
        public string cardType;
        ///表类型
        public string meterType;
        //参数更新标志，hex
        public string updateFlag;
        //2 4 2 4 4 4 4 
        //保留
        public string RFU;
        //购买量、金额
        public string buyAmount;
        //购买次数，hex
        public string buyTimes;
        //报警金额1，hex
        public string alarm1;
        //报警金额2，hex
        public string alarm2;
        //囤积金额，hex
        public string tunJi;
        //透支金额,hex
        public string touZhi;
        //2 4 4 4 4 2 2
        //表状态字，
        public string meterState;
        //剩余
        public string surplus;
        //累计购买，
        public string leiJIGouMai;
        //累计使用
        public string leiJIShiYong;
        //累计脉冲数
        public string leiJiMaiChong;
        //本月用量
        public string mouthAmount;
        //脉冲常数
        public string maiChongConst;
        //48 8
        //历史用量，两年的每月用量
        public string twoYearAmount;
        //返写时间
        public string returnTime;
    }

    //阶梯信息文件，含两套阶梯价格和切换时间
    public struct JieTiFileNew
    {
        //长度101=65H。总字符数=(101+5)*2=216
        public const string comAndLenth = "0165";
        //1+4*23+8
        //第一套阶梯数长度为1字节，其他均为4字节
        public JieTi JieTi1;

        public JieTi JieTi2;
        //第二套阶梯启用时间
        public string SecondStartTime;
    }

    //阶梯价格，有两套
    public struct JieTi
    {
        //第一套阶梯数长度为1字节，其他均为4字节
        //阶梯套数，有两套
        public string JieTiShu;
        //第二阶梯起始量，hex。第一套起始量为0
        public string JieTiAmount2;
        //第三阶梯起始量,hex
        public string JieTiAmount3;
        //第四阶梯起始量,hex
        public string JieTiAmount4;
        //第五阶梯起始量,hex
        public string JieTiAmount5;
        //第六阶梯起始量,hex
        public string JieTiAmount6;
        //第一阶梯价,hex
        public string JieTiPrice1;
        //第二阶梯价,hex
        public string JieTiPrice2;
        //第三阶梯价,hex
        public string JieTiPrice3;
        //第四阶梯价,hex
        public string JieTiPrice4;
        //第五阶梯价.hex
        public string JieTiPrice5;
        //第六阶梯价，hex
        public string JieTiPrice6;
    }

    //钱包文件
    public struct QianBaoFile
    {
        //购买量、金额
        public string buyAmount;
        //购买次数，hex
        public string buyTimes;
    }
    //4个文件结束=========================================================================================

    /// <summary>
    /// 写卡写数据库用到的购买信息
    /// </summary>
    public struct SBuyData
    {
        public int Alarm1;
        public int Alarm2;
        public int Limit;
        public int Presell;
        public int BuyTimes;
        public decimal Price;
        public int Power;
        public int Power1;
        public decimal Money;
        public bool Balance;
        public int SumPower;
        public int SumUser;
        public int Surplus;
        public int OverPower;
        public int State;
        public int BaseValue;
        public string mMoney;


        public decimal txtMoney;
        //新销售管理增加
        public int UserTypeID;
        //？阶梯下怎么取
        public int PricetypeID;
        public int MeterTypeID;
        //表号，累加，有最大值表
        public int MeterID;
        //流水号
        public int OrderID;
    }







}
