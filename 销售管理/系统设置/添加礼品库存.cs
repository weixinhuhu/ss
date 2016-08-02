using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetGiftStockInTableAdapters;
using 销售管理.DAL.DataSetGiftsTableAdapters;

namespace 销售管理.系统设置
{
    public partial class 添加礼品库存 : Form
    {
        public 添加礼品库存()
        {
            InitializeComponent();
        }

        private void 添加礼品库存_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSetGifts.T_Gifts”中。您可以根据需要移动或删除它。
            this.t_GiftsTableAdapter.Fill(this.dataSetGifts.T_Gifts);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNum.Text.Trim() == "")
                {
                    toolTip1.Show("请输入入库数量!", txtNum, 0, txtNum.Height, 2000);
                    return;
                }
                if (dgvGifts.SelectedRows.Count < 1)
                {
                    MessageBox.Show("请选择要入库的礼品!");
                    return;
                }
                long giftId;
                Decimal giftPrice, giftOldNum, giftCurrentNum;
                string giftName;

                giftId = Convert.ToInt64(dgvGifts.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
                giftPrice = Convert.ToDecimal(dgvGifts.SelectedRows[0].Cells["priceDataGridViewTextBoxColumn"].Value);
                giftOldNum = Convert.ToDecimal(dgvGifts.SelectedRows[0].Cells["stockNumDataGridViewTextBoxColumn"].Value);
                giftName = dgvGifts.SelectedRows[0].Cells["giftNameDataGridViewTextBoxColumn"].Value.ToString();

                giftCurrentNum = Convert.ToDecimal(txtNum.Text); 

                using (SqlConnection mConn = new SqlConnection(Common.CommonClass.SqlConnStr))
                {
                    mConn.Open();
                    int ret =0;
                    using (SqlTransaction mTrans = mConn.BeginTransaction())
                    {
                        try
                        {
                            var adapter = new T_GiftStockInTableAdapter();
                            adapter.Connection = mConn;
                            adapter.Transaction = mTrans;

                            ret = adapter.Insert(giftId, giftName, giftPrice, giftOldNum, giftCurrentNum, giftOldNum + giftCurrentNum, Classes.PubClass.UserId);
                            if (ret > 0)
                            {
                                var adapter1 = new T_GiftsTableAdapter();
                                adapter1.Connection = mConn;
                                adapter1.Transaction = mTrans;

                                ret = adapter1.AddStockNum(giftCurrentNum, giftId);
                                if (ret > 0)
                                {
                                    mTrans.Commit();
                                    MessageBox.Show("添加库存成功");
                                    btnAdd.Enabled = false;
                                    dgvGifts.DataSource = adapter1.GetData();
                                }
                            }
                            else
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
