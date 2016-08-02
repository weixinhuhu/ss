using Client.Class;
using Common;
using Soft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client.Main
{
    public partial class FrmModifyPass : Common.UserControlBase
    {
        public FrmModifyPass()
        {
            InitializeComponent();
        }

        private void FrmModifyPass_Load(object sender, EventArgs e)
        {
            txtGH.Text = CommonClass.SttUser.sUserID;
            txtCZY.Text = CommonClass.SttUser.sUserName;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text.Trim()== string.Empty)
            {
                Dlg.ShowErrorInfo("新密码不能为空");
                return;
            }
            if (txtRePass.Text.Trim() == string.Empty)
            {
                Dlg.ShowErrorInfo("确认密码不能为空");
                return;
            }
            if (txtNewPass.Text.Trim().Equals(txtRePass.Text.Trim()) == false )
            {
                Dlg.ShowErrorInfo("新密码与确认密码不符");
                return;
            }

            try
            {
                //检查旧密码是否正确
                string _sPass = txtOldPass.Text.Trim();
                string mSql;
                //加密
                _sPass = MD5.Md5Encrypt(_sPass);
                mSql = string.Format("SELECT mm FROM PTry WHERE gh='{0}' ", txtGH.Text.Trim());

                DataTable mTable = SqlHelper.GetData(mSql);
                if (mTable == null)
                {
                    Dlg.ShowErrorInfo("获取操作员信息失败！");
                    return;
                }
                if (mTable.Rows.Count < 1)
                {
                    Dlg.ShowErrorInfo("工号输入错误！");
                    return;
                }
                if (_sPass != mTable.Rows[0]["mm"].ToString())
                {
                    Dlg.ShowErrorInfo("原密码输入错误");
                    return;
                }

                //修改用户密码
                string _NewPass = txtNewPass.Text.Trim();
                _NewPass = MD5.Md5Encrypt(_NewPass);

                mSql = string.Format("update ptry set mm ='{0}' where gh='{1}'", _NewPass, txtGH.Text.Trim());

                int ret = SqlHelper.ExecuteNonQuery(mSql);

                if(ret>0)
                {
                    Dlg.ShowOKInfo("修改成功！");
                    txtOldPass.Text = "";
                    txtNewPass.Text = "";
                    txtRePass.Text = "";
                    return;
                }
                else
                {
                    Dlg.ShowOKInfo("修改失败！");
                    return;
                }
            }
            catch(Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message);
                return;
            }
        }
    }
}
