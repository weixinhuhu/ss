using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 采购物品编辑 : Form
    {
        public 采购物品编辑()
        {
            InitializeComponent();
        }

        public MYDBEntities2 myEntity;

        public int mDaGoodsTypeID { get; set; }

        public int mDaGoodsID { get; set; }

        //public string mDaGoodsTypeName { get; set; }

        private DaGoods mDaGoods;
        private string oldNum=string.Empty;//原物品编号
        private void 采购物品编辑_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            if (myEntity == null)
                myEntity = new MYDBEntities2();

            ZDUnitBindingSource.DataSource = myEntity.ZdGoodsUnits.ToList();
            cmbUnit.DataSource = ZDUnitBindingSource;
            cmbUnit.DisplayMember = "VcDesc";
            cmbUnit.ValueMember = "ID";

            if (mDaGoodsID > 0)
            {
                //修改
                mDaGoods = myEntity.DaGoods1.SingleOrDefault(d => d.IntID == mDaGoodsID);
                oldNum = mDaGoods.VcNum;
                //mDaGoodsTypeID = mda
                //cmbUnit.SelectedValue = mDaGoods.IntUnit;
            }
            else
            {
                //新增
                string maxNum;
                GetMaxNum("1",out maxNum);
                mDaGoods = new DaGoods() { IntTypeID = mDaGoodsTypeID, VcNum = maxNum, IntStatus  = 0};
            }
            
            txtNum.DataBindings.Add("Text", mDaGoods, "VcNum");
            txtName.DataBindings.Add("Text", mDaGoods, "VcName");
            txtNorms.DataBindings.Add("Text", mDaGoods, "VcNorms");
            txtRemark.DataBindings.Add("Text", mDaGoods, "VcRemark");
            txtTypeName.Text = myEntity.DaGoodsTypes.SingleOrDefault(d => d.IntID == mDaGoods.IntTypeID).VcType;// mDaGoodsTypeName;
            txtPrice.DataBindings.Add("Text", mDaGoods, "MonPrice",true);
            
            cmbUnit.DataBindings.Add("SelectedValue", mDaGoods, "IntUnit");
            
        }

        private void GetMaxNum(string type, out string maxNum)
        {
            maxNum = myEntity.DaGoods1.Where(a=>a.VcNum.Substring(0,1)==type).Select(a => a.VcNum).Max();

            maxNum = !string.IsNullOrEmpty(maxNum) ? (Convert.ToInt64(maxNum) + 1).ToString() : type+"0000001";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //mDaGoods.IntUnit = ((ZdGoodsUnit)cmbUnit.SelectedItem).ID;

            if (mDaGoodsID > 0)
            {
                //修改
                
            }
            else
            {
                mDaGoods.IntEmpNum = Classes.PubClass.UserId;
                //增加
                myEntity.DaGoods1.Add(mDaGoods);
            }
            try
            {
                rbCaiGou_CheckedChanged(sender, e);
                int ret = myEntity.SaveChanges();
                {
                    if (ret > 0)
                    {
                        MessageBox.Show("保存成功");
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("保存失败");
                    }
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var item in ex.EntityValidationErrors)
                {
                    foreach (var item2 in item.ValidationErrors)
                    {
                        //MessageBox.Show(string.Format("{0}:{1}\r\n", item2.PropertyName, item2.ErrorMessage));
                        MessageBox.Show(string.Format("{0}\r\n", item2.ErrorMessage));
                    }
                }
            }
        }

        private void rbCaiGou_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCaiGou.Checked == true)
            {
                if (oldNum != string.Empty)
                {
                    if (oldNum.Substring(0, 1) == "1")
                    {
                        //没有改变
                        txtNum.Text = oldNum;
                        mDaGoods.VcNum = oldNum;
                    }
                    else
                    {
                        string maxNum;
                        GetMaxNum("1",out maxNum);
                        txtNum.Text = maxNum;
                        mDaGoods.VcNum = maxNum;
                    }
                }
                else
                {
                    string maxNum;
                    GetMaxNum("1", out maxNum);
                    txtNum.Text = maxNum;
                    mDaGoods.VcNum = maxNum;
                }
            }
            else
            {
                if (oldNum != string.Empty)
                {
                    if (oldNum.Substring(0, 1) == "2")
                    {
                        //没有改变
                        txtNum.Text = oldNum;
                        mDaGoods.VcNum = oldNum;
                    }
                    else
                    {
                        string maxNum;
                        GetMaxNum("2", out maxNum);
                        txtNum.Text = maxNum;
                        mDaGoods.VcNum = maxNum;
                    }
                }
                else
                {
                    string maxNum;
                    GetMaxNum("2", out maxNum);
                    txtNum.Text = maxNum;
                    mDaGoods.VcNum = maxNum;
                }
            }
        }
    }
}
