using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using 销售管理.Classes.Structs;

namespace 销售管理.Classes
{
    class DbSet : 销售管理.Classes.DbBase
    {
        //操作操作员信息表-------------------------------------------------------------
        public bool GetOperInfo(string PNum, string PPwd, ref string PName, ref int PClass, ref string PNetNo)
        {
            ArrayList alstData = new ArrayList();

            SQL = "SELECT xm,jb,sh FROM PTry WHERE gh='" + PNum + "' AND mm='" + PPwd + "'";
            if (GetRecord(ref alstData)) return true;

            if (alstData.Count == 0)
            {
                PName = null;
            }
            else
            {
                PName = Convert.ToString(alstData[0].ToString());
                PClass = Convert.ToInt32((alstData[1]));
                PNetNo = Convert.ToString(alstData[2].ToString());
            }
            return false;
        }
        //操作操作员信息表-------------------------------------------------------------

        //用户信息表------------------------------------------
        //查询所有用户信息
        //Public Function GetUserInfo(ByRef pds As DataSet) As Boolean
        //    SQL = "SELECT * from XTUserinfo "
        //    Return GetDataSet(pds)
        //End Function
        //按用户永久编号查询用户信息
        //Customerid：用户永久编号
        public bool GetUserInfo(int Customerid, ref DataSet pds)
        {
            //SQL = "SELECT * from XTUserinfo WHERE Customerid=" & "'" & Customerid.ToString & "'"
            SQL = "SELECT * from XTUserinfo WHERE Customerid=" + Customerid;
            return GetDataSet(ref pds);
        }
        //用户信息表------------------------------------------
        //表信息表
        //todo 表号还是用字符型好
        public object GetUserMeterInfo_Ds(int MeterID, ref DataSet pds)
        {
            SQL = "SELECT * FROM XTUserMeterInfo WHERE MeterID=" + MeterID;
            return GetDataSet(ref pds);
        }

        //价格======================================================================================
        //取为数组，用来在下拉框显示
        //价格主表，取出所有价格性质。阶梯
        public bool GetXZMS_Jieti_Arr(ref ArrayList XZMS, string meterType)
        {
            if (meterType == "shui")
            {
                SQL = "SELECT XZMS FROM Priceyhxz where JTBZ='2' and MeterTypeID=0 or MeterTypeID=1 or MeterTypeID=2 or MeterTypeID=3";
            }
            else if (meterType == "dian")
            {
                SQL = "SELECT XZMS FROM Priceyhxz where JTBZ='2' and MeterTypeID=4";
            }
            else if (meterType == "qi")
            {
                SQL = "SELECT XZMS FROM Priceyhxz where JTBZ='2' and MeterTypeID=5";
            }
            else if (meterType == "re")
            {
                SQL = "SELECT XZMS FROM Priceyhxz where JTBZ='2' and MeterTypeID=6";
            }
            return GetRecord(ref XZMS);
        }
        //价格主表，取出所有价格性质。非阶梯
        public bool GetXZMS_Arr(ref ArrayList XZMS, string meterType)
        {
            if (meterType == "shui")
            {
                SQL = "SELECT XZMS FROM Priceyhxz where JTBZ='1' and MeterTypeID=0 or MeterTypeID=1 or MeterTypeID=2 or MeterTypeID=3";
            }
            else if (meterType == "dian")
            {
                SQL = "SELECT XZMS FROM Priceyhxz where JTBZ='1' and MeterTypeID=4";
            }
            else if (meterType == "qi")
            {
                SQL = "SELECT XZMS FROM Priceyhxz where JTBZ='1' and MeterTypeID=5";
            }
            else if (meterType == "re")
            {
                SQL = "SELECT XZMS FROM Priceyhxz where JTBZ='1' and MeterTypeID=6";
            }
            return GetRecord(ref XZMS);
        }
        //按某字段查询其他信息
        public object GetXZMS_Ds(string XZMS, ref DataSet pds)
        {
            SQL = "SELECT * FROM Priceyhxz WHERE XZMS='" + XZMS + "'";
            return GetDataSet(ref pds);
        }

        //按价格性质，取出阶梯。有阶梯，有多条
        public object GetXZBM_Jieti_Ds(string XZBM, ref DataSet pds)
        {
            SQL = "SELECT * FROM Pricejsjg WHERE XZBM='" + XZBM + "' and JTS>=1 order by JTS";
            return GetDataSet(ref pds);
        }
        //按价格性质，取出单价。无阶梯，只有一条
        public object GetXZBM_Ds(string XZBM, ref DataSet pds)
        {
            SQL = "SELECT * FROM Pricejsjg WHERE XZBM='" + XZBM + "' and JTS=0";
            return GetDataSet(ref pds);
        }
        //价格==========================================================================================


        //用户类型表--------------------------------------------------
        //取为数组，用来在下拉框显示
        public bool GetUserType_Arr(ref ArrayList PUserType, string meterType)
        {
            if (meterType == "shui")
            {
                SQL = "SELECT UserType FROM SZusertype_info where MeterTypeID=0 or MeterTypeID=1 or MeterTypeID=2 or MeterTypeID=3";
            }
            else if (meterType == "dian")
            {
                SQL = "SELECT UserType FROM SZusertype_info where MeterTypeID=4";
            }
            else if (meterType == "qi")
            {
                SQL = "SELECT UserType FROM SZusertype_info where MeterTypeID=5";
            }
            else if (meterType == "re")
            {
                SQL = "SELECT UserType FROM SZusertype_info where MeterTypeID=6";
            }
            return GetRecord(ref PUserType);
        }

        //按某字段查询其他信息
        public object GetUserType_Ds(string PUserType, ref DataSet pds)
        {
            SQL = "SELECT * FROM SZusertype_info WHERE UserType='" + PUserType + "'";
            return GetDataSet(ref pds);
        }
        public object GetUserTypeID_Ds(string PUserTypeID, ref DataSet pds)
        {
            SQL = "SELECT * FROM SZusertype_info WHERE UserTypeID=" + PUserTypeID;
            return GetDataSet(ref pds);
        }
        //用户类型表--------------------------------------------------

        //取硬件参数。水表：采样参数
        //按某字段查询其他信息
        //CY：采样
        public bool GetYJCS_Arr(ref ArrayList CY, string meterType)
        {
            if (meterType == "shui")
            {
                SQL = "SELECT CY FROM SZMetertype_info where MeterTypeID=0 or MeterTypeID=1 or MeterTypeID=2 or MeterTypeID=3";
            }
            else if (meterType == "dian")
            {
                SQL = "SELECT CY FROM SZMetertype_info where MeterTypeID=4";
            }
            else if (meterType == "qi")
            {
                SQL = "SELECT CY FROM SZMetertype_info where MeterTypeID=5";
            }
            else if (meterType == "re")
            {
                SQL = "SELECT CY FROM SZMetertype_info where MeterTypeID=6";
            }
            return GetRecord(ref CY);
        }

        //取最大值表================================================================================
        //取用户号（最大值加1），用户信息表的主键
        public bool GetNewUserID(ref int newid)
        {
            int maxid;
            SQLs.Clear();

            //todo -1从何而来
            //取最大用户号
            SQL = "SELECT Max(UserID) FROM XTMaxValue";
            maxid = GetOneValue();
            newid = maxid == -1 ? 1 : maxid + 1;
           
            return ExecCommand();
        }
        //取表号（最大值加1）,表具信息表的主键
        public bool GetMaxMeterID(ref int newid)
        {
            int maxid;
            SQLs.Clear();

            //取最大用户号
            SQL = "SELECT Max(MeterID) FROM XTMaxValue";
            maxid = GetOneValue();
            newid = maxid == -1 ? 1 : maxid + 1;
            //添加用户信息 

            return ExecCommand();
        }
        //取流水号（最大值加1）,流水表的主键
        public bool GetMaxOrderID(ref int newid)
        {
            int maxid;
            SQLs.Clear();

            //取最大用户号
            SQL = "SELECT Max(OrderID) FROM XTMaxValue";
            maxid = GetOneValue();
            newid = (maxid == -1 ? 1 : maxid + 1);
            //添加用户信息 

            return ExecCommand();
        }
        //取最大值表================================================================================

        //按用户号和子表号得到用户仪表信息
        public bool GetUserMeterInfo(int PUserId, int PSubId, ref DataSet pds)
        {
            SQL = "SELECT * FROM XTUserMeterInfo WHERE CustomerId=" + PUserId + " AND SubId=" + PSubId;
            //0-编号,1-子表号,2-用户类型,3-购水次数,4-本次购水量,5-单价,6-金额,7-累计购水量,8-累计购水金额,9-操作员编号,10-操作日期
            return GetDataSet(ref pds);
        }

        //用户开户
        public bool UserOpen(int PUserID, byte PByte, ArrayList PData, SBuyData[] PBuyData)
        {
            //PData--0-用户号,1-姓名,2-地址,3-电话
            string s = null;
            string fs = null;
            int i = 0;
            SQLs.Clear();

            //PUserID 无值，未开户。用户号从最大值表取。取完最大值加1

            if (PUserID == 0)
            {
                //取最大用户号。5．	最大值表XTMaxValue，用户号最大值	MaxUserID
                //SQL = "SELECT max(CustomerId) FROM UserInfo"
                SQL = "SELECT MaxUserID FROM XTMaxValue";
                PUserID = GetOneValue();
                PUserID = (PUserID == -1 ? 1 : PUserID + 1);

                //添加用户信息
                SQLs.Clear();
                fs = "INSERT INTO XTUserInfo(Customerid,User_Name,Address,Phone,[Identity],Numbers,DistrictId,OperNum,OperDate)VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
                s = string.Format(fs, PUserID, PData[1], PData[2], PData[3], PData[4], PData[5], PData[6], PubClass.operatorID, DateTime.Now);
                SQLs.Add(s);

                //更新最大值表 用户号
                s = "UPDATE XTMaxValue SET MaxUserID=" + PUserID;
                SQLs.Add(s);

                //添加开户费。只有系统参数里有，待加？
                //fs = "INSERT INTO TradeList(CustomerId,SubId,TradeMod,UserType,BuyTimes,Power,Price,[Money],OperNum)VALUES("
                //fs &= "{0},{1},'{2}','{3}',{4},{5},{6},{7},'{8}')"
                //s = String.Format(fs, PUserID, 0, "开户费", "", 0, 0, 0, PData(5), OperatorID)
                //SQLs.Add(s)
            }

            //PUserID 有值，已开户。用户号从卡里读取，开完后子表号最大值加1
            for (i = 0; i <= 7; i++)
            {
                if ((PByte & (1 << i)) != 0)//vb.net中，0为假，其他为真
                {
                    //'添加用户仪表信息表
                    //fs = "INSERT INTO UserMeterInfo(CustomerId,SubId,UserType,BuyTimes,Power,Price,[Money],SumPower,SumMoney,OperNum,BaseValue,Surplus)VALUES("
                    //fs &= "{0},{1},'{2}',1,{3},{4},{5},{3},{5},'{6}',{7},{3})"
                    //s = String.Format(fs, PUserID, i + 1, PBuyData(i).UserType, PBuyData(i).Power, PBuyData(i).Price, PBuyData(i).Money, OperatorID, PBuyData(i).BaseValue)
                    //SQLs.Add(s)
                    //'添加交易流水表
                    //fs = "INSERT INTO TradeList(CustomerId,SubId,TradeMod,UserType,BuyTimes,Power,Price,[Money],OperNum)VALUES("
                    //fs &= "{0},{1},'{2}','{3}',{4},{5},{6},{7},'{8}')"
                    //s = String.Format(fs, PUserID, i + 1, "开户", PBuyData(i).UserType, 0, PBuyData(i).Power, PBuyData(i).Price, PBuyData(i).Money, OperatorID)
                    //SQLs.Add(s)

                    //添加用户仪表信息表,
                    fs = "INSERT INTO XTUserMeterInfo(Customerid,SubId,UserTypeID,PriceTypeID,BuyTimes,Power,SumPower,SumMoney,BaseNum,OperatorId,Fdate,MeterID,MeterTypeID)VALUES(";
                    fs += "{0},{1},'{2}',{3},{4},{5},'{6}',{7},{8},{9},'{10}',{11},{12})";
                    s = string.Format(fs, PUserID, i + 1, PBuyData[i].UserTypeID, PBuyData[i].PricetypeID, 1, PBuyData[i].Power, PBuyData[i].Power, PBuyData[i].Money, PBuyData[i].BaseValue,
                    PubClass.operatorID, DateTime.Now, PBuyData[i].MeterID, 10);
                    SQLs.Add(s);
                    //添加交易流水表
                    fs = "INSERT INTO XTTradeList(Customerid,SubId,UserTypeID,PriceTypeID,Purchase_Num,PurchaseVal,Income,MeterTypeID,OperaterId,Fdate,OrderID)VALUES(";
                    fs += "{0},{1},'{2}','{3}',{4},{5},{6},{7},'{8}','{9}',{10})";
                    s = string.Format(fs, PUserID, i + 1, PBuyData[i].UserTypeID, PBuyData[i].PricetypeID, PBuyData[i].BuyTimes, PBuyData[i].Power, PBuyData[i].Money, PBuyData[i].MeterTypeID, PubClass.operatorID,
                    DateTime.Now, PBuyData[i].OrderID);
                    SQLs.Add(s);

                    //更新最大值表 表号
                    s = "UPDATE XTMaxValue SET MaxMeterID=" + PBuyData[i].MeterID;
                    SQLs.Add(s);
                    //更新最大值表 流水号
                    s = "UPDATE XTMaxValue SET MaxOrderID=" + PBuyData[i].OrderID;
                    SQLs.Add(s);
                }
            }
            return ExecCommands();
        }

        //用户购买
        public bool UserPurchase(byte PByte, int mSurplus, ArrayList PData, SBuyData[] PBuyData)
        {
            //PData--0-用户号,1-名称,2-地址,3-电话,
            string s = null;
            string fs = null;
            int i = 0;
            int PUserID = 0;

            PUserID = Convert.ToInt32(PData[0]);
            SQLs.Clear();
            //修改用户信息
            fs = "UPDATE XTUserInfo SET User_Name='{1}',Address='{2}',Phone='{3}',[Identity]='{4}',Numbers='{5}',DistrictId='{6}',OperNum='{6}',OperDate='{7}' WHERE CustomerId={0}";
            s = string.Format(fs, PUserID, PData[1], PData[2], PData[3], PData[4], PData[5], PData[6], PubClass.operatorID, DateTime.Now);
            SQLs.Add(s);

            for (i = 0; i <= 7; i++)
            {
                if ((PByte & (1 << i)) != 0)
                {
                    //修改用户仪表信息表
                    fs = "UPDATE XTUserMeterInfo SET UserTypeID='{0}' ,BuyTimes={1},Power={2},PriceTypeID={3},SumPower=SumPower+{2},SumMoney=SumMoney+{4},OperNum='{5}',OperDate='{6}',Surplus={9} WHERE CustomerId={7} AND SubId={8}";
                    s = string.Format(fs, PBuyData[i].UserTypeID, PBuyData[i].BuyTimes, PBuyData[i].Power, PBuyData[i].PricetypeID, PubClass.operatorID, DateTime.Now, PUserID, i + 1, mSurplus);
                    SQLs.Add(s);
                    //添加交易流水表
                    fs = "INSERT INTO TradeList(CustomerId,SubId,MeterId,UserTypeID,BuyTimes,PurchaseVal,PriceTypeID,[Income],OperNum)VALUES(";
                    fs += "{0},{1},'{2}','{3}',{4},{5},{6},{7},'{8}')";
                    s = string.Format(fs, PUserID, i + 1, PBuyData[i].MeterID, PBuyData[i].UserTypeID, PBuyData[i].BuyTimes, PBuyData[i].Power, PBuyData[i].PricetypeID, PBuyData[i].Money, PubClass.operatorID);
                    SQLs.Add(s);
                }
            }

            return ExecCommands();
        }

        //网点表
        public bool GetPTNetData(string PTNetId, ArrayList PNetData)
        {
            SQL = "SELECT * from PTNet Where BMBM=\'" + PTNetId + "\'";
            return GetRecord(ref PNetData);
        }
        public bool OperPTNet_InfoTable(int PType, ArrayList PData)
        {
            switch (PType)
            {
                case 0:
                    SQL = "SELECT count(*) FROM PTNet WHERE BMBM=\'" + PData[0] + "\' or BMMC= \'" + PData[1] + "\'";
                    if (GetOneValue() > 0)
                    {
                        mError = "数据库中有相同的网点设置信息，请重新输入！";
                        return true;
                    }
                    SQL = "INSERT INTO PTNet(BMBM,BMMC)VALUES(\'";
                    SQL += PData[0] + "\',";
                    SQL += "\'" + PData[1] + "\')";
                    break;
                case 1:
                    SQL = "SELECT count(*) FROM PTNet WHERE  BMMC= \'" + PData[1] + "\'";
                    if (GetOneValue() > 0)
                    {
                        mError = "数据库中有相同的网点设置信息，请重新输入！";
                        return true;
                    }
                    SQL = "UPDATE PTNet SET BMBM=\'" + PData[0] + "\'";
                    SQL += ",BMMC=\'" + PData[1] + "\'";
                    SQL += " WHERE BMBM=\'" + PData[0] + "\'";
                    break;
                case 2:
                    SQL = "DELETE FROM PTNet WHERE BMBM=\'" + PData[0] + "\'";
                    break;
            }
            return ExecCommand();
        }
        public bool GetPtNet(ArrayList aryList)
        {
            SQL = "SELECT BMBM FROM PTNet";
            return GetRecord(ref aryList);
        }
        public bool GetPtNetName(ArrayList aryList)
        {
            SQL = "SELECT BMBM FROM PTNet";
            return GetRecord(ref aryList);
        }
    }
}
