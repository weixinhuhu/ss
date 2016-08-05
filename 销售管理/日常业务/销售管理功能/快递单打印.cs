using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using CustomControls.IO;

namespace 销售管理.日常业务
{
    public partial class 快递单打印 : 销售管理.UserControlBase
    {
        public 快递单打印()
        {
            InitializeComponent();
        }

        private static DataTable dt = new DataTable();
        //private DataRow dr = dt.NewRow();

        private void 快递单打印cs_Load(object sender, EventArgs e)
        {
            dgvResult.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(dgvResult, true, null);
            if (Classes.PubClass.UserRight != "商务助理" && Classes.PubClass.UserRight != "商务经理" && Classes.PubClass.UserRight != "超级管理员" && Classes.PubClass.UserRight != "领导" && Classes.PubClass.UserRight != "发货")
            {
                cmbComName.DataSource = t_CustomersTableAdapter.GetDataByUserId(Classes.PubClass.UserId);
            }
            else
            {
                cmbComName.DataSource = t_CustomersTableAdapter.GetData();
            }
            cmbComName.SelectedIndex = -1;
            initCmbExpress();
        }

        private void initCmbExpress()
        {
            string[] Files = null;
            Files = System.IO.Directory.GetFiles(Application.StartupPath + "\\Craxy\\");
            string mPath = null;
            for (int i = 0; i <= Files.Length - 1; i++)
            {
                mPath = System.IO.Path.GetFileName((Files[i]));
                if (mPath.EndsWith(".CraxyMouse"))
                {
                    cmbExpress.Items.Add(mPath);
                }

            }
            if (cmbExpress.Items.Count > 0) cmbExpress.SelectedIndex = 0;

            //dt.Rows.Add(dr);
            //designer1.DataSource = dt;
        }

        private void cmbComName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvResult.DataSource = new T_CustomersTableAdapter().GetDataByComNameUserName(cmbComName.Text, Classes.PubClass.UserName);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Classes.PubClass.UserRight != "商务助理" && Classes.PubClass.UserRight != "商务经理" && Classes.PubClass.UserRight != "超级管理员" && Classes.PubClass.UserRight != "领导" && Classes.PubClass.UserRight != "发货")
            {
                dgvResult.DataSource = new T_CustomersTableAdapter().GetDataByFuzzyComNameUserName(cmbComName.Text, Classes.PubClass.UserName);
            }
            else
            {
                dgvResult.DataSource = t_CustomersTableAdapter.GetDataByFuzzyComName(cmbComName.Text);
            }
        }

        private void cmbExpress_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                InOutPut.OpenFile(designer1, Application.StartupPath + "\\Craxy\\" + cmbExpress.Text);
                designer1.LoadPrintSetting();
                designer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnPrePrintView_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResult.SelectedRows.Count > 0)
                {
                    InOutPut.OpenFile(designer1, Application.StartupPath + "\\Craxy\\" + cmbExpress.Text);
                    designer1.LoadPrintSetting();
                    designer1.Refresh();

                    DataGridViewRow mViewRow = dgvResult.SelectedRows[0];
                    DataRow mRow;
                    mRow = (mViewRow.DataBoundItem as DataRowView).Row;
                    dt = mRow.Table.Clone();
                    dt.ImportRow(mRow);
                    //dt.Rows.Add(((mRow.DataBoundItem as DataRowView).Row).Clone());
                    designer1.DataSource = dt;
                    designer1.PrintView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UpLoad mForm = new UpLoad();
            //mForm.ShowDialog();
            模板设计 mform = new 模板设计();
            mform.ShowDialog();
            //cmbExpress_SelectedIndexChanged(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (自定义打印 mForm = new 自定义打印())
            {
                mForm.ShowDialog();
            }
        }
    }
}
