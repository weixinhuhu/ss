using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.Classes;

namespace 销售管理
{
    public partial class SetDbForm : Form
    {
        //private DbSet mDatabaseClass = new DbSet();

        public SetDbForm()
        {
            InitializeComponent();
        }

        private void SetDbForm_Load(object sender, EventArgs e)
        {
            this.RadioButton1.Checked = true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.RadioButton1.Checked == true)
            {
                //连接Access数据库
                //成功则返回false
                if (PubClass.mDatabaseClass.mConn.State  != ConnectionState.Open )
                {
                    //MessageBox.Show(mDatabaseClass.ErrorInfo);
                    MessageBox.Show("Access数据库连接失败！");
                    return;
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                //access，将数据库信息写入到配置文件ipSet.ini中
                PubClass.MDatabaseType = "2";
                string[] arytemp = { "0", "0", "0", "0", "2" };
                IniClass.AddDbInfo(arytemp);
                //mDatabaseClass.Dispose();
                this.Close();
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(this.TxtDBIp.Text))
                {
                    MessageBox.Show("数据库的IP地址不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(this.TxtDBName.Text))
                {
                    MessageBox.Show("数据库的名称不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(this.TxtUserName.Text))
                {
                    MessageBox.Show("数据库的用户名称不能为空");
                    return;
                }
                //If Me.txtPwd.Text = "" Then
                //    MsgBox("数据库的用户密码不能为空", , gProjectName)
                //    Return
                //End If
                //5个公共变量前4
                PubClass.SqlDbAddress = this.TxtDBIp.Text.Trim();
                PubClass.SqlDbName = this.TxtDBName.Text.Trim();
                PubClass.SqlDbUserName = TxtUserName.Text.Trim();
                PubClass.SqlDbPwd = TxtPwd.Text.Trim();
                //成功则返回false
                if (PubClass. mDatabaseClass.ConnectSql(PubClass.SqlDbAddress, PubClass.SqlDbName, PubClass.SqlDbUserName, PubClass.SqlDbPwd) == true)
                {
                    MessageBox.Show("请重新确认系统的配置信息或检查网络连接是否畅通");
                    return;
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }

                //sqlserver，将数据库信息写入到配置文件ipSet.ini中
                //5个公共变量后1
                PubClass.MDatabaseType = "1";
                string[] arytemp = { PubClass.SqlDbAddress, PubClass.SqlDbName, PubClass.SqlDbUserName, PubClass.SqlDbPwd, "1" };

                IniClass.AddDbInfo(arytemp);
                //mDatabaseClass.Dispose();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //mDatabaseClass.Dispose();
            }
        }

        //private void Cancel_Click(object sender, EventArgs e)
        //{

        //}
    }
}
