using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.Classes;
using 销售管理.DAL;
using 销售管理.Model.ViewModel;
using 销售管理.日常业务;
using 销售管理.日常业务.供应商管理;

namespace 销售管理.查询统计
{
    public partial class 采购物品查询 : 销售管理.UserControlBase
    {

        public 采购物品查询()
        {
            InitializeComponent();
        }

        public MYDBEntities2 myEntity = new MYDBEntities2();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            IQueryable<DaGoods> daGoods = myEntity.DaGoods1;
            if (string.IsNullOrWhiteSpace(txtGoodsNum.Text) == false)//物品编码筛选
            {
                daGoods = daGoods.Where(a => a.VcNum.Contains(txtGoodsNum.Text.Trim()));
            }
            if (string.IsNullOrWhiteSpace(txtGoodsName.Text) == false)//物品名称筛选
            {
                daGoods = daGoods.Where(a => a.VcName.Contains(txtGoodsName.Text.Trim()));
            }
            if (cmbUsers.SelectedIndex < 0)//用户选择为空 则显示自己的物品
            {
                daGoods = daGoods.Where(a => a.IntEmpNum == Classes.PubClass.UserId);
            }
            else if ((long)cmbUsers.SelectedValue > 0)//用户选择不为空且不为全部
            {
                daGoods = daGoods.Where(a => a.IntEmpNum == (long) cmbUsers.SelectedValue);
            }
            //IQueryable<ViewCaiGouWuPin> query = daGoods.Select(a => new ViewCaiGouWuPin
            //{
            //    物品编号 = a.VcNum,
            //    物品名称=a.VcName,
            //    单位=a.ZdGoodsUnit.VcDesc,
            //    参考单价=a.MonPrice,
            //    规格型号=a.VcNorms,
            //    物品分类=a.DaGoodsType.VcType,
            //    备注 = a.VcRemark
            //});
            //bsDaGoods.DataSource = query.ToList();
            bsDaGoods.DataSource = daGoods.Select(a => new ViewCaiGouWuPin
            {
                物品编号 = a.VcNum,
                物品名称 = a.VcName,
                单位 = a.ZdGoodsUnit.VcDesc,
                参考单价 = a.MonPrice,
                规格型号 = a.VcNorms,
                物品分类 = a.DaGoodsType.VcType,
                备注 = a.VcRemark
            }).ToList();
        }

        private void 采购物品查询_Load(object sender, EventArgs e)
        {
            //初始化人员列表
            dgvDaGoods.AutoGenerateColumns = true;
            InitUsers();
            InitData();
            dgvDaGoods.DataSource = bsDaGoods;
        }

        private void InitUsers()
        {
            //获取采购角色List
            List<int> roles = myEntity.PTRoles.Where(a => a.ZMC.Contains("采购")).Select(a => a.ZBH).ToList();
            //获取所有采购用户
            IQueryable<T_Users> users = myEntity.T_Users.Where(a => roles.Contains(a.IntRoleID??0));
            cmbUsers.ValueMember = "Id";
            cmbUsers.DisplayMember = "Name";
            List<Classes.PubClass.MyCmbList> listUsers; //用户List
            listUsers = users.Select(a => new Classes.PubClass.MyCmbList { Id = a.id, Name = a.UserName }).ToList();
            //插入全部
            listUsers.Insert(0, new Classes.PubClass.MyCmbList(0, "全部" ));
            //绑定数据
            cmbUsers.DataSource = listUsers;
            if (!Common.CommonClass.SttUser.blSuperUser && !Common.AuthenticateRight.AuthOperation(140601))
            {
                if (listUsers.Any(a => a.Id == PubClass.UserId))
                {//如果登陆的用户是采购角色
                    cmbUsers.SelectedValue = Classes.PubClass.UserId;
                    cmbUsers.Enabled = false;
                }
                else
                {//不是采购角色
                    cmbUsers.SelectedIndex = -1;
                    cmbUsers.Enabled = false;
                }
            }
            else
            {
                //默认选中全部
                cmbUsers.SelectedIndex = 0;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Classes.ExcelDeport.Deport(dgvDaGoods, 1);
        }

        private void dgvDaGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == Col历史采购明细.Index)
            {
                //查看历史采购明细
                //获取物品编码
                string mGoodsNum= dgvDaGoods[Col物品编号.Index,e.RowIndex].Value.ToString();
                //根据物品显示历史采购明细
                using (采购物品历史采购明细 mForm = new 采购物品历史采购明细())
                {
                    mForm.GoodsNum = mGoodsNum;
                    mForm.ShowDialog();
                }

            }
        }
    }
}
