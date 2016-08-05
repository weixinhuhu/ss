using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using Client.Class;
using Common;
using Soft.Common;

namespace Client.Main
{
    public partial class FrmDbSet : Form
    {
        public FrmDbSet()
        {
            InitializeComponent();
        }

        private void SetDbForm_Load(object sender, EventArgs e)
        {
            CBoxDbType.SelectedIndex = 0;
            //cmbDB.Enabled = False
        }

        private void cmbDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBoxDbType.Text)
            {
                case "SQL Server":
                    GBS.Visible = true;
                    GBA.Visible = false;
                    break;
                case "Access":
                    GBS.Visible = false;
                    GBA.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string ConnStr = null;

            //Provider=SQLOLEDB;Data Source=.;Integrated Security=SSPI;Initial Catalog=DBMeter
            ConnStr = string.Format("Provider=SQLOLEDB;Data Source={0},{1};Password={2};User ID={3};Initial Catalog={4}", txtAddress.Text, txtPort.Text, txtDBPass.Text, txtDBUser.Text, txtDBName.Text);

            OleDbConnection mConn = new OleDbConnection(ConnStr);
            try
            {
                mConn.Open();
                mConn.Close();
                Dlg.ShowOKInfo("连接成功");
                BtnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message.ToString());
                BtnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ConnStr = null;
            ConnStr = string.Format("provider=SQLOLEDB;Data Source={0},{1};Password={2};User ID={3};Initial Catalog={4}", txtAddress.Text, txtPort.Text, txtDBPass.Text, txtDBUser.Text, txtDBName.Text);
            //  //获取appSettings节点   
            try
            {
                SqlHelper.RefreshSection(ConnStr);
                // My.Settings.ConnectionString = config.ConnectionStrings.ConnectionStrings("一卡通.Properties.Settings.Default.ConnectionString").ToString
                //MsgBox(My.Settings.ConnectionString)
                //Dlg.ShowOKInfo("保存成功,程序将重新启动");
                //Application.Restart();
                //Application.Exit()
                //Process.Start(Application.ExecutablePath.ToString)
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message.ToString());
            }
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            string ConnStr = null;
            ConnStr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Persist Security Info=True;Jet OLEDB:Database Password=meiyoumima2011", txtAccess.Text);
            //;Persist Security Info=True;Jet OLEDB:Database Password=
            OleDbConnection mConn = new OleDbConnection(ConnStr);
            try
            {
                mConn.Open();
                mConn.Close();
                Dlg.ShowOKInfo("连接成功");
                BtnSaveAccess.Enabled = true;
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message.ToString());
                BtnSaveAccess.Enabled = false;
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            string ConnStr = null;
            //ConnStr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", txtAccess.Text);
            ConnStr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Persist Security Info=True;Jet OLEDB:Database Password=meiyoumima2011", txtAccess.Text);

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration("PubClasses.dll");

                config.ConnectionStrings.ConnectionStrings.Remove("PubClasses.Properties.Settings.Setting_ConnStr");
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("PubClasses.Properties.Settings.Setting_ConnStr", ConnStr, "System.Data.OleDb"));
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("ConnectionStrings");
                // My.Settings.ConnectionString = config.ConnectionStrings.ConnectionStrings("一卡通.Properties.Settings.Default.ConnectionString").ToString
                //MsgBox(My.Settings.ConnectionString)
                Dlg.ShowOKInfo("保存成功,程序将重新启动");
                Application.Exit();
                System.Diagnostics.Process.Start(Application.ExecutablePath.ToString());
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Access数据库(*.mdb;*.accdb)|*.mdb;*.accdb|所有文件(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAccess.Text = openFileDialog1.FileName;
            }
        }
    }
}
