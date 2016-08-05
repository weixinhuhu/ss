using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using 销售管理.DAL.DataSetPromaryTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 客户资料维护 : Form
    {
        public 客户资料维护()
        {
            InitializeComponent();
        }
        public long mId = -1;

        private void 客户资料维护_Load(object sender, EventArgs e)
        {
            //添加省市cmb
            var mTable1 = new T_PromaryTableAdapter().GetData();
            cmbPromary.DisplayMember = "proName";
            cmbPromary.ValueMember = "proID";
            cmbPromary.DataSource = mTable1;
            cmbPromary.SelectedIndex = -1;
            if (mId == -1)
            {
                btnSave.Text = "增加";
            }
            else
            {
                var mTable = new T_CustomersTableAdapter().GetDataById(mId);
                if (mTable.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetCustomers.T_CustomersRow)mTable.Rows[0];
                    txtComName.Text = mRow.CompanyName;
                    txtComAddr.Text = mRow.CompanyAddress;
                    txtBusinessName.Text = mRow.BusinessContactName;
                    if (mRow.IsDeliverAddressNull() == false)
                    {
                        txtDeliverAddr.Text = mRow.DeliverAddress;
                    }
                    if (mRow.IsDeliverNameNull() == false)
                    {
                        txtDeliverName.Text = mRow.DeliverName;
                    }
                    if (mRow.IsDeliverPhoneNull() == false)
                    {
                        txtDeliverPhone.Text = mRow.DeliverPhone;
                    }
                    if (mRow.IsCityIDNull() == false)
                    {
                        var mTable2 = new T_CityTableAdapter().GetDataByID(mRow.CityID);
                        if (mTable2.Rows.Count > 0)
                        {
                            cmbPromary.SelectedValue = mTable2[0].proID;
                            cmbCity.SelectedValue = mRow.CityID;
                        }
                    }
                    txtBusinessTel.Text = mRow.BusinessContactTel;
                    txtBusinessPhone.Text = mRow.BusinessContactPhone;
                    txtBusinessEmail.Text = mRow.BusinessContactEmail;
                    txtTechName.Text = mRow.TechContactName;
                    txtTechTel.Text = mRow.TechContactTel;
                    txtTechPhone.Text = mRow.TechContactPhone;
                    txtTechEmail.Text = mRow.TechContactEmail;
                }
                else
                {
                    MessageBox.Show("获取客户资料错误");
                    this.Close();
                    return;

                }

                btnSave.Text = "保存";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPromary.SelectedIndex < 0)
            {
                toolTip1.Show("请选择公司所在区域！", cmbPromary, 0, cmbPromary.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtComName.Text.Trim()) == true)
            {
                toolTip1.Show("请输入公司名称！", txtComName, 0, txtComName.Height, 2000);
                return;
            }
            if (cmbCity.SelectedIndex == -1)
            {
                toolTip1.Show("请选择公司所在区域", cmbCity, 0, cmbCity.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtComAddr.Text.Trim()) == true)
            {
                toolTip1.Show("请输入公司地址！", txtComAddr, 0, txtComAddr.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtBusinessName.Text.Trim()) == true)
            {
                toolTip1.Show("请输入商务负责人！", txtBusinessName, 0, txtBusinessName.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtBusinessTel.Text.Trim()) == true)
            {
                toolTip1.Show("请输入商务负责人座机！", txtBusinessTel, 0, txtBusinessTel.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtBusinessPhone.Text.Trim()) == true)
            {
                toolTip1.Show("请输入商务负责人手机！", txtBusinessPhone, 0, txtBusinessPhone.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtBusinessEmail.Text.Trim()) == true)
            {
                toolTip1.Show("请输入商务负责人邮箱！", txtBusinessEmail, 0, txtBusinessEmail.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtDeliverName.Text.Trim()) == true)
            {
                toolTip1.Show("请输入收件人！", txtDeliverName, 0, txtDeliverName.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtDeliverPhone.Text.Trim()) == true)
            {
                toolTip1.Show("请输入收件人手机！", txtDeliverPhone, 0, txtDeliverPhone.Height, 2000);
                return;
            }
            if (string.IsNullOrEmpty(txtDeliverAddr.Text.Trim()) == true)
            {
                toolTip1.Show("请输入收件人地址！", txtDeliverAddr, 0, txtDeliverAddr.Height, 2000);
                return;
            }

            if (mId > -1)
            {
                T_CustomersTableAdapter adapter = new T_CustomersTableAdapter();
                var mTable = adapter.GetDataByComName(txtComName.Text.Trim());
                if (mTable.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetCustomers.T_CustomersRow)mTable.Rows[0];
                    if (mId != mRow.id)
                    {
                        toolTip1.Show("该公司名称已存在！", txtComName, 0, txtComName.Height, 2000);
                        return;
                    }
                }

                int ret = adapter.UpdateById(txtComName.Text.Trim(), txtComAddr.Text.Trim(), txtBusinessName.Text.Trim(), txtBusinessTel.Text.Trim(), txtBusinessPhone.Text.Trim(), txtBusinessEmail.Text.Trim(), txtTechName.Text.Trim(), txtTechTel.Text.Trim(), txtTechPhone.Text.Trim(), txtTechEmail.Text.Trim(), txtDeliverName.Text.Trim(), txtDeliverAddr.Text.Trim(), txtDeliverPhone.Text.Trim(), (long)cmbCity.SelectedValue, mId);
                if (ret > 0)
                {
                    MessageBox.Show("修改成功");
                    btnSave.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("修改失败");
                    return;
                }

            }
            else
            {
                T_CustomersTableAdapter adapter = new T_CustomersTableAdapter();
                var mTable = adapter.GetDataByComName(txtComName.Text.Trim());
                if (mTable.Rows.Count > 0)
                {
                    toolTip1.Show("该公司名称已存在！", txtComName, 0, txtComName.Height, 2000);
                    return;
                }
                else
                {
                    int ret = adapter.Insert(txtComName.Text.Trim(), txtComAddr.Text.Trim(), txtBusinessName.Text.Trim(), txtBusinessTel.Text.Trim(), txtBusinessPhone.Text.Trim(), txtBusinessEmail.Text.Trim(), txtTechName.Text.Trim(), txtTechTel.Text.Trim(), txtTechPhone.Text.Trim(), txtTechEmail.Text.Trim(), txtDeliverName.Text.Trim(), txtDeliverAddr.Text.Trim(), txtDeliverPhone.Text.Trim(), (long)cmbCity.SelectedValue, Classes.PubClass.UserId, "正常");
                    if (ret > 0)
                    {
                        MessageBox.Show("添加成功");
                        btnSave.Enabled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                        return;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPromary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPromary.SelectedIndex != -1)
            {
                var mTable = new T_CityTableAdapter().GetDataByProID((long)cmbPromary.SelectedValue);
                cmbCity.DisplayMember = "cityName";
                cmbCity.ValueMember = "ID";
                cmbCity.DataSource = mTable;
            }
            else
            {
                cmbCity.DataSource = null;
            }
        }
    }
}
