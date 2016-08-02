using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using WordApplication = Microsoft.Office.Interop.Word.Application;
using Document = Microsoft.Office.Interop.Word.Document;
using Bookmark = Microsoft.Office.Interop.Word.Bookmark;

namespace 销售管理.日常业务
{
    public partial class 打印收货单 : Form
    {
        public 打印收货单()
        {
            InitializeComponent();
        }
        public DataTable mDataTable;

        private void 打印收货单_Load(object sender, EventArgs e)
        {
            txtCompanyName.Text = mDataTable.Rows[0]["公司名称"].ToString();

            DataTable mTable = new T_CustomersTableAdapter().GetDataByComName(txtCompanyName.Text);
            if (mTable.Rows.Count > 0)
            {
                var mDataRow = (销售管理.DAL.DataSetCustomers.T_CustomersRow)mTable.Rows[0];
                if (mDataRow.IsDeliverNameNull() == false) txtContactName.Text = mDataRow.DeliverName;
                if (mDataRow.IsDeliverPhoneNull() == false) txtContactPhone.Text = mDataRow.DeliverPhone;
                if (mDataRow.IsDeliverAddressNull() == false) txtContactAddress.Text = mDataRow.DeliverAddress;
            }
            //txtProductName.Text = mTable.Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();
            //txtAmount.Text = mTable.Cells["amountDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        WordApplication word = null;
        Document doc = null;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (word != null)
                {
                    //word.Quit();
                    word = null;
                }
                word = new WordApplication();
                object oMissing = Type.Missing;

                object path1 = AppDomain.CurrentDomain.BaseDirectory + @"office\收货确认单(空白).doc";
                doc = word.Documents.Open(ref path1,ReadOnly:true);//, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing

                object markName = "客户名称";
                Bookmark bm = doc.Bookmarks.get_Item(ref markName);
                bm.Range.Text = txtCompanyName.Text;

                markName = "联系人";
                bm = doc.Bookmarks.get_Item(ref markName);
                bm.Range.Text = txtContactName.Text;

                markName = "电话";
                bm = doc.Bookmarks.get_Item(ref markName);
                bm.Range.Text = txtContactPhone.Text;

                markName = "送货地址";
                bm = doc.Bookmarks.get_Item(ref markName);
                bm.Range.Text = txtContactAddress.Text;
                for (int i = 0; i < mDataTable.Rows.Count; i++)
                {
                    DataRow mDR = mDataTable.Rows[i];
                    markName = "产品名称" + (i+1).ToString();
                    bm = doc.Bookmarks.get_Item(ref markName);
                    bm.Range.Text = mDR["产品名称"].ToString();

                    markName = "规格型号" + (i + 1).ToString();
                    bm = doc.Bookmarks.get_Item(ref markName);
                    bm.Range.Text = mDR["规格型号"].ToString();

                    markName = "数量" + (i + 1).ToString();
                    bm = doc.Bookmarks.get_Item(ref markName);
                    bm.Range.Text = mDR["数量"].ToString();

                    markName = "发货日期" + (i + 1).ToString();
                    bm = doc.Bookmarks.get_Item(ref markName);
                    bm.Range.Text = dtpSend.Value.Date.ToString("d");
                }

                markName = "备注";
                bm = doc.Bookmarks.get_Item(ref markName);
                bm.Range.Text = txtRemark.Text;

                word.Visible = true;
                doc.Protect(Microsoft.Office.Interop.Word.WdProtectionType.wdAllowOnlyReading);
                doc.PrintPreview();
                doc.Saved = true;
                if (word != null)
                {
                    word = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
