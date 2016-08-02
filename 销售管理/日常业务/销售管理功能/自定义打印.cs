using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomControls.IO;
using System.Data.OleDb;

namespace 销售管理.日常业务
{
    public partial class 自定义打印 : Form
    {
        public 自定义打印()
        {
            InitializeComponent();
        }

        private DataTable mInportTable;


        private void 自定义打印_Load(object sender, EventArgs e)
        {
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

                InOutPut.OpenFile(designer1, Application.StartupPath + "\\Craxy\\" + cmbExpress.Text);
                designer1.LoadPrintSetting();
                designer1.Refresh();
                DataTable dt = new DataTable();

                dt.Columns.Add("UserName");
                dt.Columns.Add("DeliverName");
                dt.Columns.Add("companyName");
                dt.Columns.Add("DeliverAddress");
                dt.Columns.Add("DeliverPhone");
                dt.Columns.Add("SendCompany");
                dt.Columns.Add("SendAddress");
                dt.Columns.Add("SendMobile");
                //mRow = (mViewRow.DataBoundItem as DataRowView).Row;
                DataRow mRow = dt.NewRow();
                mRow["UserName"] = txtSendName.Text;
                mRow["DeliverName"] = txtRecName.Text;
                mRow["companyName"] = txtRecCompany.Text;
                mRow["DeliverAddress"] = txtRecAddress.Text;
                mRow["DeliverPhone"] = txtRecMobile.Text;
                mRow["SendCompany"] = txtSendCompany.Text;
                mRow["SendAddress"] = txtSendAddress.Text;
                mRow["SendMobile"] = txtSendMobile.Text;
                //dt.ImportRow(mRow);
                //dt.Rows.Add(((mRow.DataBoundItem as DataRowView).Row).Clone());
                dt.Rows.Add(mRow);
                designer1.DataSource = dt;
                designer1.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mInportTable = LoadExcelToDataTable(openFile.FileName, "Sheet1");

                bindingSource1.DataSource = mInportTable;
                dgvImport.DataSource = bindingSource1;
            }
        }

        //加载excel文件
        public static System.Data.DataTable LoadExcelToDataTable(string filename, string worksheetname)
        {
            System.Data.DataTable table;
            try
            {
                String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filename + ";" + "Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
                OleDbConnection myConn = new OleDbConnection(sConnectionString);
                // string strCom = " SELECT 电表资产号,通讯地址,'数据回抄' as 操作类型,'" + DateTime.Now.ToString("yy-MM-dd") + "' as 添加任务时间 FROM [" + worksheetname + "$] where 通讯地址 is not null and len(rtrim(通讯地址)) =12 ";
                //myConn.Open();

                string strCom = " SELECT RecCompany,RecName,RecMobile,RecAddress FROM [" + worksheetname + "$]"; //序号,
                myConn.Open();

                OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
                table = new System.Data.DataTable();
                myCommand.Fill(table);
                myConn.Close();
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            if (dgvImport.SelectedRows.Count < 1)
                return;
            InOutPut.OpenFile(designer1, Application.StartupPath + "\\Craxy\\" + cmbExpress.Text);
            designer1.LoadPrintSetting();
            designer1.Refresh();
            DataRow mDataRow = ((DataRowView)bindingSource1[dgvImport.SelectedRows[0].Index]).Row;

            DataTable dt = new DataTable();

            dt.Columns.Add("UserName");
            dt.Columns.Add("DeliverName");
            dt.Columns.Add("companyName");
            dt.Columns.Add("DeliverAddress");
            dt.Columns.Add("DeliverPhone");
            dt.Columns.Add("SendCompany");
            dt.Columns.Add("SendAddress");
            dt.Columns.Add("SendMobile");
            //mRow = (mViewRow.DataBoundItem as DataRowView).Row;
            DataRow mRow = dt.NewRow();

            mRow["DeliverName"] = mDataRow["RecName"];
            mRow["companyName"] = mDataRow["RecCompany"];
            mRow["DeliverAddress"] = mDataRow["RecAddress"];
            mRow["DeliverPhone"] = mDataRow["RecMobile"];
            mRow["UserName"] = txtSendName.Text;
            mRow["SendCompany"] = txtSendCompany.Text;
            mRow["SendAddress"] = txtSendAddress.Text;
            mRow["SendMobile"] = txtSendMobile.Text;
            //dt.ImportRow(mRow);
            //dt.Rows.Add(((mRow.DataBoundItem as DataRowView).Row).Clone());
            dt.Rows.Add(mRow);
            designer1.DataSource = dt;
            designer1.Print();



        }
    }
}
