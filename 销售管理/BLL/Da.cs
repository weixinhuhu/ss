
using System.Data;
using System;

namespace 销售管理.BLL
{
    public class Da
    {
        public static DataTable GetContractGoodsTable(int contractId)
        {
            string mSql = string.Format(@"select a.IntID,a.MonPrice,a.NumCount,a.MonSum,f.VcNum,f.VcName,isnull(c.sumcount,0) StockInSum,isnull(e.sumcount,0) InvoiceSum,isnull(h.sumcount,0) ExpenseSum from daContractGoods a
left join 
(select b.IntContractGoodsID,sum(b.NumCount) sumcount from daStockIn b,daContractGoods a where a.IntID = b.IntContractGoodsID group by b.IntContractGoodsID) c on a.IntId = c.IntContractGoodsID
left join 
(select d.IntContractGoodsID,sum(d.NumCount) sumcount from daInvoice d,daContractGoods a where a.IntID = d.IntContractGoodsID group by d.IntContractGoodsID) e on a.IntID = e.IntContractGoodsID 
left join
(select g.IntContractGoodsID,sum(g.NumCount) sumcount from daExpense g,daContractGoods a where a.IntID =
 g.IntContractGoodsID  group by g.IntContractGoodsID) h on a.IntID = h.IntContractGoodsID
left join DaGoods  f on a.IntGoodsID = f.IntID 
where a.IntContractID={0}", contractId);

            return Common.SqlHelper.GetData(mSql);
        }

        public static void GetUserRight(int roleId)
        {
            
                string mSql = string.Format("select mkbh from ptzqx where ryzbh ={0}", roleId);

                var mTable = Common.SqlHelper.GetData(mSql);

                foreach (DataRow mRow in mTable.Rows)
                {
                    Common.CommonClass.UserRightList.Add(Convert.ToInt32(mRow["mkbh"]));
                }
            
        }

        //public static List<ZdAllStatu> GetZdAllStatusByType(MYDBEntities2 mydb, string typeName, bool addAllString)
        //{
        //    List<ZdAllStatu> zdAllStatus= mydb.ZdAllStatus.Where(a => a.VcType == typeName).ToList();

        //    if (addAllString == true)
        //    {
        //        zdAllStatus.Insert(0,new ZdAllStatu(){IntID = 0,VcDesc = "全部",VcType = typeName});
        //    }
        //    return zdAllStatus;
        //}

       
    }
}
