using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using 销售管理.Classes.Structs;

namespace 销售管理.Classes
{
    class ClassAboutPrice
    {
        /// <summary>
        /// 根据价格计算表 Pricejsjg 取阶梯组成
        /// </summary>
        /// <param name="mJieTiPrice">传出结构体</param>
        /// <param name="PricejsjgTable">传入表</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static int GetJietiFromDT(ref JieTi mJieTiPrice, DataTable PricejsjgTable)
        {
            try
            {
                int caseSwitch = PricejsjgTable.Rows.Count;
                mJieTiPrice.JieTiShu = caseSwitch.ToString();
                switch (caseSwitch)
                {
                    case 1:
                        //1阶
                        //1阶起始量为0
                        mJieTiPrice.JieTiPrice1 = PricejsjgTable.Rows[0]["JG"].ToString();
                        break;
                    case 2: 
                        //1阶
                        //0
                        mJieTiPrice.JieTiPrice1 = PricejsjgTable.Rows[0]["JG"].ToString();
                        //2阶
                        mJieTiPrice.JieTiAmount2 = PricejsjgTable.Rows[1]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice2 = PricejsjgTable.Rows[1]["JG"].ToString();
                        break;
                    case 3:
                        //1阶
                        //0
                        mJieTiPrice.JieTiPrice1 = PricejsjgTable.Rows[0]["JG"].ToString();
                        //2阶
                        mJieTiPrice.JieTiAmount2 = PricejsjgTable.Rows[1]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice2 = PricejsjgTable.Rows[1]["JG"].ToString();
                        //3阶
                        mJieTiPrice.JieTiAmount3 = PricejsjgTable.Rows[2]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice3 = PricejsjgTable.Rows[2]["JG"].ToString();
                        break;
                    case 4:
                        //1阶
                        //0
                        mJieTiPrice.JieTiPrice1 = PricejsjgTable.Rows[0]["JG"].ToString();
                        //2阶
                        mJieTiPrice.JieTiAmount2 = PricejsjgTable.Rows[1]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice2 = PricejsjgTable.Rows[1]["JG"].ToString();
                        //3阶
                        mJieTiPrice.JieTiAmount3 = PricejsjgTable.Rows[2]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice3 = PricejsjgTable.Rows[2]["JG"].ToString();
                        //4阶
                        mJieTiPrice.JieTiAmount4 = PricejsjgTable.Rows[3]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice4 = PricejsjgTable.Rows[3]["JG"].ToString();
                        break;
                    case 5:
                        //1阶
                        //0
                        mJieTiPrice.JieTiPrice1 = PricejsjgTable.Rows[0]["JG"].ToString();
                        //2阶
                        mJieTiPrice.JieTiAmount2 = PricejsjgTable.Rows[1]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice2 = PricejsjgTable.Rows[1]["JG"].ToString();
                        //3阶
                        mJieTiPrice.JieTiAmount3 = PricejsjgTable.Rows[2]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice3 = PricejsjgTable.Rows[2]["JG"].ToString();
                        //4阶
                        mJieTiPrice.JieTiAmount4 = PricejsjgTable.Rows[3]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice4 = PricejsjgTable.Rows[3]["JG"].ToString();
                        //5阶
                        mJieTiPrice.JieTiAmount5 = PricejsjgTable.Rows[4]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice5 = PricejsjgTable.Rows[4]["JG"].ToString();
                        break;
                    case 6:
                        //1阶
                        //0
                        mJieTiPrice.JieTiPrice1 = PricejsjgTable.Rows[0]["JG"].ToString();
                        //2阶
                        mJieTiPrice.JieTiAmount2 = PricejsjgTable.Rows[1]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice2 = PricejsjgTable.Rows[1]["JG"].ToString();
                        //3阶
                        mJieTiPrice.JieTiAmount3 = PricejsjgTable.Rows[2]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice3 = PricejsjgTable.Rows[2]["JG"].ToString();
                        //4阶
                        mJieTiPrice.JieTiAmount4 = PricejsjgTable.Rows[3]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice4 = PricejsjgTable.Rows[3]["JG"].ToString();
                        //5阶
                        mJieTiPrice.JieTiAmount5 = PricejsjgTable.Rows[4]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice5 = PricejsjgTable.Rows[4]["JG"].ToString();
                        //6阶
                        mJieTiPrice.JieTiAmount6 = PricejsjgTable.Rows[5]["JTQSS"].ToString();
                        mJieTiPrice.JieTiPrice6 = PricejsjgTable.Rows[5]["JG"].ToString();
                        break;
                }
                return 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return 1;
                throw new Exception("",ex);
            }
        }

        //补零函数
        public object jieti_PadLeft8(object Obj)
        {
            if ((Obj == null))
            {
                return "".PadLeft(8, '0');
            }
            else
            {
                return Obj.ToString().PadLeft(8, '0');
            }
        }
        public object jieti_PadLeft16(object Obj)
        {
            if ((Obj == null))
            {
                return "".PadLeft(16, '0');
            }
            else
            {
                return Obj.ToString().PadLeft(16, '0');
            }
        }



    }
}
