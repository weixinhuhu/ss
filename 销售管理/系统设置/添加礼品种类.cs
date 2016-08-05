using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetGiftsTableAdapters;

namespace 销售管理.系统设置
{
    public partial class 添加礼品种类 : Form
    {
        public 添加礼品种类()
        {
            InitializeComponent();
        }

        public long mId = -1;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtGiftName.Text.Trim() == string.Empty)
            {
                toolTip1.Show("礼品名称不能为空!", txtGiftName, 0, txtGiftName.Height, 2000);
                return;
            }
            if (txtPrice.Text.Trim() == string.Empty)
            {
                toolTip1.Show("单价不能为空!", txtPrice, 0, txtPrice.Height, 2000);
                return;
            } if (txtStockNum.Text.Trim() == string.Empty)
            {
                toolTip1.Show("库存数量不能为空!", txtStockNum, 0, txtStockNum.Height, 2000);
                return;
            }
            try
            {
                var adapter = new T_GiftsTableAdapter();
                if (mId < 0)
                {
                    var mTable = adapter.GetDataByGiftName(txtGiftName.Text.Trim());
                    if (mTable.Rows.Count > 0)
                    {
                        toolTip1.Show("礼品名称已存在!", txtGiftName, 0, txtGiftName.Height, 2000);
                        return;
                    }
                    int ret = 0;
                    ret = adapter.Insert(txtGiftName.Text.Trim(), Convert.ToDecimal(txtPrice.Text), Convert.ToDecimal(txtStockNum.Text));
                    if (ret > 0)
                    {
                        MessageBox.Show("插入成功!");
                        btnAdd.Enabled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("插入失败!");
                        return;
                    }
                }
                else
                {
                    int ret = 0;
                    ret = adapter.UpdateById(txtGiftName.Text.Trim(), Convert.ToDecimal(txtPrice.Text), Convert.ToDecimal(txtStockNum.Text),mId);
                    if (ret > 0)
                    {
                        MessageBox.Show("修改成功!");
                        btnAdd.Enabled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 添加礼品种类_Load(object sender, EventArgs e)
        {
            if (mId > -1)
            {
                var mTable = new T_GiftsTableAdapter().GetDataById(mId);
                if (mTable.Rows.Count > 0)
                {
                    销售管理.DAL.DataSetGifts.T_GiftsRow mRow = (销售管理.DAL.DataSetGifts.T_GiftsRow)mTable.Rows[0];
                    txtGiftName.Text = mRow.GiftName;
                    txtPrice.Text = mRow.Price.ToString();
                    txtStockNum.Text = mRow.StockNum.ToString();
                    this.Text = "修改礼品信息";
                    btnAdd.Text = "保存";
                }
            }
        }
    }
}
