using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 销售管理.DAL.DataSetGiftStockOutTableAdapters;
using 销售管理.DAL.DataSetMealsTableAdapters;

namespace 销售管理.BLL
{
    public  class Sa
    {
        public static int GetGiftLeaderUnAuditCount()
        {
            using (T_GiftStockOutTableAdapter ad = new T_GiftStockOutTableAdapter())
            {
                return Convert.ToInt32(ad.GetLeaderUnAuditCount());
            }

            
        }

        public static int GetMealLeaderUnAuditCount()
        {
            using (T_MealsTableAdapter ad = new T_MealsTableAdapter())
            {
                return Convert.ToInt32(ad.GetLeaderUnAuditCount());
            }
            
        }
    }
}
