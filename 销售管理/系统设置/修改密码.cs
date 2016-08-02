using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;

namespace 销售管理.系统设置
{
    public partial class 修改密码 : 销售管理.UserControlBase
    {
        public 修改密码()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text.Trim() == "")
            {
                toolTip1.Show("原密码不能为空！", txtOldPass, 0, txtOldPass.Height, 2000);
                return;
            }
            if (txtNewPass.Text.Trim() == "")
            {
                toolTip1.Show("新密码不能为空！", txtNewPass, 0, txtNewPass.Height, 2000);
                return;
            }
            if (txtRePass.Text.Trim() == "")
            {
                toolTip1.Show("新密码不能为空！", txtRePass, 0, txtRePass.Height, 2000);
                return;
            }
            if (txtNewPass.Text.Trim() != txtRePass.Text.Trim())
            {
                toolTip1.Show("两次密码输入不一致！", txtRePass, 0, txtRePass.Height, 2000);
                return;
            }
            try
            {
                string oldPass = txtOldPass.Text.Trim();
                oldPass = Classes.MD5.Md5Encrypt(oldPass);
                T_UsersTableAdapter adapter = new T_UsersTableAdapter();
                var mTable = adapter.GetDataByLoginName(txtLoginName.Text.Trim());
                if (mTable.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetUsers.T_UsersRow)mTable.Rows[0];
                    if (oldPass != mRow.PassWord)
                    {
                        MessageBox.Show("原密码输入错误");
                        return;
                    }
                    int ret = adapter.UpdatePass(Classes.MD5.Md5Encrypt(txtNewPass.Text.Trim()), txtLoginName.Text.Trim(), oldPass);
                    if (ret > 0)
                    {
                        MessageBox.Show("修改成功");
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
                    MessageBox.Show("没有找到此用户信息");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void txtRePass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Trim() != txtRePass.Text.Trim())
            {
                toolTip1.Show("两次密码输入不一致！", txtRePass, 0, txtRePass.Height, 2000);
            }
        }

        private void 修改密码_Load(object sender, EventArgs e)
        {
            txtLoginName.Text = Classes.PubClass.LoginName;
        }
    }
}
