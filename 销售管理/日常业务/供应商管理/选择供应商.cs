using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using 销售管理.DAL;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 选择供应商 : Form
    {
        public 选择供应商()
        {
            InitializeComponent();
        }

        public MYDBEntities2 myEntity;
        public int mDaGoodsID { set; get; }
        List<int> mDaSupplier;
        public List<int> mDaSupplierID =new List<int>();//当前选中的供应商
        public bool MultiSelect=false;  //是否可以多选

        private void 选择供应商_Load(object sender, EventArgs e)
        {
            dgvDaSupplier.MultiSelect = MultiSelect;
            if (myEntity == null)
                myEntity = new MYDBEntities2();
            //获取现有的关系
            mDaSupplier = myEntity.DaGoodsSuppliers.Where(d => d.IntGoodsID == mDaGoodsID).Select(d => d.DaSupplier.IntID).ToList();
            InitData();
            SearchData();
        }

        private void InitData()
        {
            // if (myEntity == null)                myEntity = new MYDBEntities2();

            AutoCompleteStringCollection mAutoComplete = new AutoCompleteStringCollection();
            mAutoComplete.AddRange(myEntity.DaSuppliers.Where(d => mDaSupplier.Contains(d.IntID) == false).Select(d => d.VcName).ToArray());
            txtDaName.AutoCompleteCustomSource = mAutoComplete;
            txtDaName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDaName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            //选取不包含已选择
            IQueryable<DaSupplier> daSuppliers = myEntity.DaSuppliers.Where(d => mDaSupplier.Contains(d.IntID) == false);
            if (!Common.AuthenticateRight.AuthOperation(120101) && !CommonClass.SttUser.blSuperUser)
            {//判断是否有权限查看其它人
                daSuppliers = daSuppliers.Where(d => d.IntEmpNum == Classes.PubClass.UserId);
            }
            if (txtDaName.Text != string.Empty)
            {//输入了供应商名字
                daSuppliers=daSuppliers.Where(d => d.VcName.Contains(txtDaName.Text));
            }
           
            DaSupplierBindingSource.DataSource = daSuppliers.ToList();
        }

        private void txtDaName_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvDaSupplier.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择供应商");
                return;
            }
            
                //添加物品对应关系
            foreach (DataGridViewRow row in dgvDaSupplier.SelectedRows)
            {
                mDaSupplierID.Add(((DaSupplier)DaSupplierBindingSource[row.Index]).IntID);
            }
                //mDaSupplierID.Add(((DaSupplier)DaSupplierBindingSource[dgvDaSupplier.SelectedRows[0].Index]).IntID);
                
                DialogResult = DialogResult.OK;

            
            

        }

        private void dgvDaSupplier_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDaSupplier.SelectedRows.Count < 1)
                return;
            if (dgvDaSupplier.SelectedRows[0].Index < 0)
                return;
            btnOK.PerformClick();
        }
    }
}
