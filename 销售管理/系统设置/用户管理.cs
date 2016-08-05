using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;


namespace 销售管理.日常业务
{
    public partial class 用户管理 : 销售管理.UserControlBase
    {
        public 用户管理()
        {
            InitializeComponent();
        }

        long mId = -1;

        private void 用户管理_Load(object sender, EventArgs e)
        {
            tvShow();
            cmbRight.SelectedIndex = 0;
            cmbUserStatus.SelectedIndex = 0;
        }

        private void tvShow()
        {
            tvUsers.Nodes[0].Nodes.Clear();
            try
            {
                var mTable = new T_UsersTableAdapter().GetData();
                if (mTable.Rows.Count > 0)
                {
                    foreach (销售管理.DAL.DataSetUsers.T_UsersRow mRow in mTable.Rows)
                    {
                        if (mRow.LoginName.ToString() != "admin")
                        {
                            tvUsers.Nodes[0].Nodes.Add(mRow.LoginName.ToString());
                        }
                    }
                }
                tvUsers.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void tvUsers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnAdd.Enabled = true;
            try
            {
                DAL.DataSetUsers.T_UsersDataTable mTable = new T_UsersTableAdapter().GetDataByLoginName(tvUsers.SelectedNode.Text);
                if (mTable.Rows.Count > 0)
                {
                    DAL.DataSetUsers.T_UsersRow mRow = (DAL.DataSetUsers.T_UsersRow)mTable.Rows[0];
                    mId = mRow.id;
                    txtId.Text = mRow.id.ToString();
                    txtLoginName.Text = mRow.LoginName;
                    txtUserName.Text = mRow.UserName;
                    //txtPass.Text = mRow.PassWord;
                    //txtRePass.Text = mRow.PassWord;
                    cmbRight.SelectedItem = mRow.OperRight;
                    cmbUserStatus.SelectedItem = mRow.UserStatus;
                    txtUserChar.Text = mRow.UserChar;
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("没有找到该用户的信息");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mId = -1;
            txtId.Text = "";//new T_UsersTableAdapter().GetNextId().ToString();
            //mId = Convert.ToInt64(txtId.Text);
            txtLoginName.Text = "";
            txtUserName.Text = "";
            
            cmbRight.SelectedIndex = 0;
            txtUserChar.Text = "";
            btnAdd.Enabled = false;
            tvUsers.SelectedNode = null;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ret = 0;
            btnAdd.Enabled = true;

            if (txtLoginName.Text.Trim() == "")
            {
                toolTip1.Show("登录名不能为空", txtLoginName,0,txtLoginName.Height,2000);
                return;
            }
            if (txtUserName.Text.Trim() == "")
            {
                toolTip1.Show("用户名不能为空", txtUserName, 0, txtUserName.Height, 2000);
                return;
            }
            //if (txtPass.Text.Trim() == "")
            //{
            //    toolTip1.Show("密码不能为空", txtPass, 0, txtPass.Height, 2000);
            //    return;
            //}
            //if (txtRePass.Text.Trim() == "")
            //{
            //    toolTip1.Show("确认密码不能为空", txtRePass, 0, txtRePass.Height, 2000);
            //    return;
            //}
            //if (txtPass.Text.Trim() != txtRePass.Text.Trim())
            //{
            //    toolTip1.Show("两次密码不一致", txtRePass, 0, txtRePass.Height, 2000);
            //    return;
            //}
            
            try
            {
                if (mId >= 0)
                {
                    T_UsersTableAdapter adapter = new T_UsersTableAdapter();
                    var mTable = adapter.GetDataByLoginName(txtLoginName.Text.Trim());
                    if (mTable.Rows.Count > 0)
                    {
                        var mRow = (销售管理.DAL.DataSetUsers.T_UsersRow)mTable.Rows[0];
                        if (mRow.id != mId)
                        {
                            MessageBox.Show("此登录名已存在！");
                            txtLoginName.Focus();
                            txtLoginName.SelectionStart = 0;
                            txtLoginName.SelectionLength = txtLoginName.Text.Length;
                            return;
                        }

                    }

                    ret = adapter.UpdateById(txtLoginName.Text.Trim(), txtUserName.Text.Trim(), cmbRight.Text,txtUserChar.Text.Trim(),cmbUserStatus.Text, mId);
                    if (ret > 0)
                    {
                        MessageBox.Show("修改成功");
                        tvShow();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
                else
                {
                    T_UsersTableAdapter adapter = new T_UsersTableAdapter();
                    var mTable = adapter.GetDataByLoginName(txtLoginName.Text.Trim());
                    if (mTable.Rows.Count > 0)
                    {
                        MessageBox.Show("此登录名已存在！");
                        txtLoginName.Focus();
                        txtLoginName.SelectionStart = 0;
                        txtLoginName.SelectionLength = txtLoginName.Text.Length;
                        return;
                    }
                    ret = adapter.Insert(txtLoginName.Text.Trim(), Classes.MD5.Md5Encrypt("1"), txtUserName.Text.Trim(), cmbRight.Text, cmbRight.Text,txtUserChar.Text.Trim(),cmbUserStatus.Text,0,0);
                    if (ret > 0)
                    {
                        MessageBox.Show("添加成功");
                        tvShow();
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = new T_UsersTableAdapter().DeleteById(mId);
                if (ret > 0)
                {
                    MessageBox.Show("删除成功");
                    tvShow();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void txtUserChar_TextChanged(object sender, EventArgs e)
        {
            txtUserChar.Text = txtUserChar.Text.ToUpper();
        }

        private void txtUserChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = new T_UsersTableAdapter().ResetPass(Classes.MD5.Md5Encrypt("1"), mId);
                if (ret > 0)
                {
                    MessageBox.Show("重置成功,密码'1'");
                    tvShow();
                }
                else
                {
                    MessageBox.Show("重置失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
