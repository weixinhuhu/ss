using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using PubClasses;
using System.IO;
using System.Linq;
using Client.Class;
using Common;
using Soft.Common;

namespace Client.Main
{
    public partial class ManageUserRight : UserControlBase
    {
        public ManageUserRight()
        {
            InitializeComponent();
        }

        private void ManageUserRight_Load(object sender, EventArgs e)
        {
            InitRYZ();//初始化人员组
            InitRight();//初始化权限
            InitRY();//初始化人员
            InitSH();//初始化所属网点
        }

        private void InitRight()
        {
            tvRight.Nodes.Clear();
            string mSql = string.Format("select * from PTcd  where mkbh not in('0000') and ((cardtype in(-1,-2)) or(cardtype={0})) order by mkjb,PTcd.MKBH", CommonClass.SttIC.iCardType);
            DataTable mTable = SqlHelper.GetData(mSql);

            foreach (DataRow mRow in mTable.Rows)
            {
                ModuleList ml;
                ml.MKBH = mRow["MKBH"].ToString().Trim();
                ml.MKMC = mRow["MKMC"].ToString().Trim();
                ml.MKJB = Convert.ToInt32(mRow["MKJB"]);
                ml.MKFCD = mRow["MKFCD"].ToString().Trim();
                ml.MKTP = mRow.IsNull("MKTP") ? "" : mRow["MKTP"].ToString().Trim();
                Image tmpImage = null;
                if (File.Exists(ml.MKTP))
                {
                    tmpImage = Image.FromFile(ml.MKTP);
                    imageList1.Images.Add(ml.MKTP, tmpImage);
                }



                if (ml.MKFCD != "0000")
                {
                    TreeNode[] mNodes = tvRight.Nodes.Find(ml.MKFCD, true);
                    if (mNodes.Length > 0)
                    {
                        TreeNode mFCDNode = tvRight.Nodes.Find(ml.MKFCD, true)[0];

                        TreeNode mNode = mFCDNode.Nodes.Add(ml.MKBH, ml.MKMC);
                        mNode.Tag = ml.MKBH;
                        if (tmpImage != null)
                        {
                            mNode.ImageKey = ml.MKTP;
                            mNode.SelectedImageKey = ml.MKTP;
                        }
                    }
                }
                else
                {
                    TreeNode mNode = tvRight.Nodes.Add(ml.MKBH, ml.MKMC);
                    mNode.Tag = ml.MKBH;
                    if (tmpImage != null)
                    {
                        mNode.ImageKey = ml.MKTP;
                        mNode.SelectedImageKey = ml.MKTP;
                    }
                }
            }

            tvRight.ExpandAll();
        }

        private void InitRYZ()
        {
            tvRYZ.Nodes.Clear();
            string mSql = "select zbh,zmc from ptryz";
            DataTable mTable = SqlHelper.GetData(mSql);
            foreach (DataRow mRow in mTable.Rows)
            {
                tvRYZ.Nodes.Add(mRow["zmc"].ToString()).Tag = mRow["zbh"];
            }
            CBoxRole.DataSource = mTable;
        }

        private void InitSH()
        {
            CBoxSH.DataSource = SqlHelper.GetData("select * from ptnet");
        }

        private void InitRY()
        {
            string mSql = "SELECT [GH] ,[XM] ,[XB]  ,[DH] ,[JB] ,ptryz.ZMC as [ZMC]  ,[SH]  ,PTNet.BMMC as [SHMC] ,  [ZT] FROM [PTry] , PTNet,PTryz  where PTNet.BMBM = PTry.SH and PTry.JB = PTryz.ZBH";

            dgvRY.DataSource = SqlHelper.GetData(mSql);
            foreach (DataGridViewRow mRow in dgvRY.Rows)
            {
                mRow.Selected = false;
            }
            ClearForm();
        }

        private bool m_SetClick = true;

        private void SetSubNodeCheck(TreeNode p_TreeNode, bool p_SelectCheck)
        {
            m_SetClick = false;
            foreach (TreeNode _SubNode in p_TreeNode.Nodes)
            {
                _SubNode.Checked = p_SelectCheck;
                SetSubNodeCheck(_SubNode, p_SelectCheck);
            }

        }
        private void SetParentCheck(TreeNode p_TreeNode)
        {
            if (p_TreeNode.Checked && p_TreeNode.Parent != null)
            {
                p_TreeNode.Parent.Checked = true;
                SetParentCheck(p_TreeNode.Parent);
            }
        }
        private void SetParentNotCheck(TreeNode p_TreeNode)
        {
            if (!p_TreeNode.Checked && p_TreeNode.Parent != null)
            {
                foreach (TreeNode _Node in p_TreeNode.Parent.Nodes)
                {
                    if (_Node.Checked) return;
                }
                p_TreeNode.Parent.Checked = false;
                SetParentNotCheck(p_TreeNode.Parent);
            }
        }

        private void tvRight_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // 禁用TreeView视图重绘的功能。
            tvRight.BeginUpdate();
            if (m_SetClick)
            {
                SetSubNodeCheck(e.Node, e.Node.Checked);
                SetParentCheck(e.Node);
                SetParentNotCheck(e.Node);
                m_SetClick = true;
            }
            // 启用TreeView视图重绘的功能。
            tvRight.EndUpdate();
        }

        private DataTable mRightTable;

        /// <summary>
        /// 递归遍历TreeView，然后对比已有的数据和TreeView上面的节点数据，
        /// 如果匹配成功，则选中TreeView上面的相应节点。
        /// </summary>
        /// <param name="tn"></param>
        private void FindTreeView(TreeNode tn)
        {
            tn.Checked = false;

            string FunctionID_dt = string.Empty;
            string FunctionID_tv = string.Empty;
            for (int i = 0; i < mRightTable.Rows.Count; i++)
            {
                FunctionID_dt = mRightTable.Rows[i][0].ToString().Trim();
                FunctionID_tv = tn.Tag.ToString();
                if (FunctionID_dt == FunctionID_tv)
                {
                    tn.Checked = true;
                }
            }
            foreach (TreeNode tnSub in tn.Nodes)
            {
                FindTreeView(tnSub);
            }
        }

        private void tsbAddRole_Click(object sender, EventArgs e)
        {
            using (FrmInput mForm = new FrmInput())
            {
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    int iRet = Convert.ToInt32(SqlHelper.ExecuteScalar(string.Format("select count(*) from ptryz where ZMC='{0}'", mForm.txtInput.Text.Trim())));
                    if (iRet > 0)
                    {
                        Dlg.ShowErrorInfoAndHelp("该角色已存在,请重新创建！");
                        return;
                    }
                    iRet = SqlHelper.ExecuteNonQuery(string.Format("insert into ptryz(zmc)values('{0}')", mForm.txtInput.Text.Trim()));                    
                    InitRYZ();
                    if (iRet!=0)
                    {
                        Dlg.ShowOKInfo("创建成功！");
                    }
                }
            }
        }

        private void tvRYZ_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string mSql = string.Format("select mkbh from ptzqx where ryzbh={0}", e.Node.Tag);
            mRightTable = SqlHelper.GetData(mSql);

            foreach (TreeNode tn in tvRight.Nodes)
            {
                FindTreeView(tn);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (tvRYZ.SelectedNode == null)
            {
                Dlg.ShowErrorInfoAndHelp("请选择用户的角色以分配权限！");
                return;
            } 
            if (tvRYZ.SelectedNode.Text == "管理员")
            {
                Dlg.ShowErrorInfoAndHelp("管理员角色不允许修改权限！");
                return;
            } 
            int ryzbh = Convert.ToInt32(tvRYZ.SelectedNode.Tag);
            List<string> mSqls = new List<string>();
            mSqls.Add(string.Format("delete from ptzqx where ryzbh={0} and MKBH in (select MKBH from PTcd where MKBH <> '0000' and (cardtype in (-1,-2) or cardtype ={1}))", ryzbh, CommonClass.SttIC.iCardType));
            foreach (TreeNode tn in tvRight.Nodes)
            {
                AddSqlStr(ref mSqls, tn, ryzbh);
            }
            int ret = SqlHelper.ExecuteSqls(mSqls.ToArray());
            if (ret == 0)
            {
                Dlg.ShowOKInfo("保存成功");
                return;
            }
            else
            {
                Dlg.ShowErrorInfo("保存失败");
                return;
            }
        }

        private void AddSqlStr(ref List<string> mSqls, TreeNode tn, int ryzbh)
        {
            if (tn.Checked == true)
            {
                mSqls.Add(string.Format("insert into ptzqx(ryzbh,mkbh) values({0},'{1}')", ryzbh, Convert.ToInt32(tn.Tag)));
                var msql = from m in mSqls select m;
            }
            foreach (TreeNode subNs in tn.Nodes)
            {
                AddSqlStr(ref mSqls, subNs, ryzbh);
            }
        }

        private void tsbModify_Click(object sender, EventArgs e)
        {
            if (tvRYZ.SelectedNode==null)
            {
                Dlg.ShowErrorInfo("未选择要修改的角色！");
                return;
            }
            if (tvRYZ.SelectedNode.Text=="管理员")
            {
                Dlg.ShowErrorInfo("管理员角色不允许修改！");
                return;
            }
            using (FrmInput mForm = new FrmInput())
            {
                mForm.txtInput.Text = tvRYZ.SelectedNode.Text;
                int zbh = Convert.ToInt32(tvRYZ.SelectedNode.Tag);
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    string sSql = string.Format("select count(*) from ptryz where zmc='{0}'", mForm.txtInput.Text.Trim());
                    int iRet = (int)SqlHelper.ExecuteScalar(sSql);
                    if (iRet == -1)
                    {
                        return;
                    }
                    if (iRet != 0)
                    {
                        Dlg.ShowErrorInfoAndHelp(string.Format("输入的新角色名称“{0}”已存在，不能修改！", mForm.txtInput.Text.Trim()));
                        return;
                    }
                    sSql = string.Format("update ptryz set zmc='{0}' where zbh={1}", mForm.txtInput.Text.Trim(), zbh);
                    int ret = SqlHelper.ExecuteNonQuery(sSql);
                    InitRYZ();
                }
            }
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            if (tvRYZ.SelectedNode == null)
            {
                Dlg.ShowErrorInfo("未选择要删除的角色！");
                return;
            }
            if (tvRYZ.SelectedNode.Text == "管理员")
            {
                Dlg.ShowErrorInfo("管理员角色不允许删除！");
                return;
            }
            //Check
            DbAccess DbAcs = new DbAccess(CommonClass.ConnStr);
            DbAcs.m_sSQL = string.Format("SELECT count(*) FROM [PTry] where JB={0}", tvRYZ.SelectedNode.Tag.ToString());
            DataSet DS = DbAcs.GetDataSet();
            if (DS.ExtendedProperties["ReturnFlag"].ToString() != "0")
            {
                Dlg.ShowErrorInfo(DS.ExtendedProperties["ReturnFlag"].ToString());
                return;
            }
            if (DS.Tables[0].Rows[0][0].ToString() != "0")
            {
                Dlg.ShowErrorInfo("该系统角色已经做过分配，不能删除！");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (Dlg.ShowConfirmInfo("确认要删除该角色吗?") == DialogResult.Yes)
            {
                string mSql = string.Format("delete from ptryz where zbh={0}", Convert.ToInt32(tvRYZ.SelectedNode.Tag));
                int ret = SqlHelper.ExecuteNonQuery(mSql);
                InitRYZ();
                InitRight();
            }
        }

        private void dgvRY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            CBoxSH.SelectedValue = dgvRY["ColSH", e.RowIndex].Value;
            TBGH.Text = dgvRY["ColGH", e.RowIndex].Value.ToString();
            TBXM.Text = dgvRY["ColXM", e.RowIndex].Value.ToString();
            if (dgvRY["ColXB", e.RowIndex].Value.ToString().Trim() == "男")
            {
                rbMale.Checked = true;
            }
            else if (dgvRY["ColXB", e.RowIndex].Value.ToString().Trim() == "女")
            {
                rbFemale.Checked = true;
            }
            TBDH.Text = dgvRY["ColDH", e.RowIndex].Value.ToString();
            CBoxRole.SelectedValue = dgvRY["ColJB", e.RowIndex].Value;
            if (dgvRY["ColZT", e.RowIndex].Value.ToString() == "0")
            {
                tsbLock.Enabled = true;
                tsbUnlock.Enabled = false;
            }
            else
            {
                tsbUnlock.Enabled = true;
                tsbLock.Enabled = false;
            }
        }

        private void tsbLock_Click(object sender, EventArgs e)
        {
            if (dgvRY.SelectedRows.Count < 1)
            {
                Dlg.ShowErrorInfoAndHelp(string.Format("请选择要锁定的员工！"));
                return;
            }
            int gh = Convert.ToInt32(dgvRY.SelectedRows[0].Cells["ColGH"].Value);
            if (gh == 1001)
            {
                Dlg.ShowErrorInfoAndHelp("工号1001不能进行锁定！");
                return;
            }
            string mSql = string.Format("update ptry set zt ='1' where gh='{0}'", gh);
            int ret = SqlHelper.ExecuteNonQuery(mSql);
            InitRY();
            tsbUnlock.Enabled = true;
            tsbLock.Enabled = false;
            SelectRow(gh);
        }

        private void SelectRow(int gh)
        {
            foreach (DataGridViewRow mRow in dgvRY.Rows)
            {
                if (gh == Convert.ToInt32(mRow.Cells["ColGH"].Value))
                {
                    mRow.Selected = true;
                    break;
                }
            }
        }

        private void tsbUnlock_Click(object sender, EventArgs e)
        {
            if (dgvRY.SelectedRows.Count < 1) return;
            int gh = Convert.ToInt32(dgvRY.SelectedRows[0].Cells["ColGH"].Value);
            string mSql = string.Format("update ptry set zt ='0' where gh='{0}'", gh);
            int ret = SqlHelper.ExecuteNonQuery(mSql);
            InitRY();
            tsbLock.Enabled = true;
            tsbUnlock.Enabled = false;
            SelectRow(gh);
        }

        void TrimTextBox()
        {
            TBGH.Text = TBGH.Text.Trim();
            TBXM.Text = TBXM.Text.Trim();
            TBDH.Text = TBDH.Text.Trim();
        }
        private void tsbRYAdd_Click(object sender, EventArgs e)
        {
            TrimTextBox();
            if (TBGH.Text.Trim() == string.Empty)
            {
                toolTip1.Show("工号不能为空", TBGH, 0, TBGH.Height, 2000);
                return;
            }
            if (TBXM.Text.Trim() == string.Empty)
            {
                toolTip1.Show("姓名不能为空", TBXM, 0, TBXM.Height, 2000);
                return;
            }
            if (Utils.StrToIntDef(TBGH.Text, -1) == -1)
            {
                Dlg.ShowErrorInfoAndHelp("请输入四位数字工号，且不能与已有工号重复！");
                TBGH.SelectAll();
                TBGH.Focus();
                return;
            }
            if (TBDH.Text!="")
            {
                if (Utils.StrToIntDef(TBDH.Text, -1) == -1)
                {
                    Dlg.ShowErrorInfoAndHelp("请输入正确的电话号码数字！");
                    TBDH.SelectAll();
                    TBDH.Focus();
                    return;
                }
            }

            ry ry = new ry();

            ry.GH = Convert.ToInt32(TBGH.Text);
            ry.XM = TBXM.Text.Trim();
            ry.XB = "男";
            ry.DH = TBDH.Text.Trim();
            ry.SH = Convert.ToInt32(CBoxSH.SelectedValue);
            ry.RYZ = Convert.ToInt32(CBoxRole.SelectedValue);
            if (rbFemale.Checked == true)
            {
                ry.XB = "女";
            }
            int ret = Convert.ToInt32(SqlHelper.ExecuteScalar(string.Format("select count(1) from ptry where gh='{0}'", ry.GH)));
            if (ret > 0)
            {
                toolTip1.Show("该工号已存在,请重新输入", TBGH, 0, TBGH.Height, 2000);
                TBGH.Focus();
                return;
            }

            string mSql = string.Format("insert into ptry(gh,xm,xb,dh,sh,jb,zt,mm) values ({0},'{1}','{2}','{3}',{4},{5},'0','{6}')", ry.GH, ry.XM, ry.XB, ry.DH, ry.SH, ry.RYZ, MD5.Md5Encrypt("1001"));
            ret = SqlHelper.ExecuteNonQuery(mSql);
            if (ret > 0)
            {
                InitRY();
                SelectRow(ry.GH);
                Dlg.ShowOKInfo("添加成功,初始密码1001!");
            }
        }

        private struct ry
        {
            public int GH;
            public string XM;
            public string XB;
            public string DH;
            public int SH;
            public int RYZ;
        }

        private void tsbRYDel_Click(object sender, EventArgs e)
        {
            if (dgvRY.SelectedRows.Count == 0) 
            { 
                return;
            }
            int gh = Convert.ToInt32(dgvRY.SelectedRows[0].Cells["ColGH"].Value);
            if (gh==1001)
            {
                Dlg.ShowErrorInfoAndHelp("工号1001不能进行删除！");
                return;
            }
            //检查用户是否过做业务
            DbAccess DbAcs = new DbAccess(CommonClass.ConnStr);
            DbAcs.m_sSQL = string.Format("select count(*) from XTtradelist where operaterid='{0}'", gh);
            DataSet DS = DbAcs.GetDataSet();
            if (DS.ExtendedProperties["ReturnFlag"].ToString() != "0")
            {
                Dlg.ShowErrorInfo(DS.ExtendedProperties["ReturnFlag"].ToString());
                return;
            }
            if (DS.Tables[0].Rows[0][0].ToString() != "0")
            {
                Dlg.ShowErrorInfo("该用户已经做过业务，不能删除！");
                return;
            }
            //Confirm
            if (Dlg.ShowConfirmInfo("确认要删除该用户吗？")==DialogResult.No)
            {
                return;
            }
            string mSql = string.Format("delete from ptry where gh='{0}'", gh);
            int ret = SqlHelper.ExecuteNonQuery(mSql);
            if (ret > 0) InitRY();
        }

        private void ClearForm()
        {
            TBGH.Text = "";
            TBXM.Text = "";
            TBDH.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }

        private void tsbRYSave_Click(object sender, EventArgs e)
        {
            if (dgvRY.SelectedRows.Count < 1)
            {
                Dlg.ShowErrorInfoAndHelp("请先选择要保存的用户");
                return;
            }
            if (TBGH.Text.Trim() == string.Empty)
            {
                toolTip1.Show("工号不能为空", TBGH, 0, TBGH.Height, 2000);
                return;
            }
            if (TBXM.Text.Trim() == string.Empty)
            {
                toolTip1.Show("姓名不能为空", TBXM, 0, TBXM.Height, 2000);
                return;
            }
            ry ry = new ry();

            ry.GH = Convert.ToInt32(TBGH.Text);
            ry.XM = TBXM.Text.Trim();
            ry.XB = "男";
            ry.DH = TBDH.Text.Trim();
            ry.SH = Convert.ToInt32(CBoxSH.SelectedValue);
            ry.RYZ = Convert.ToInt32(CBoxRole.SelectedValue);
            if (rbFemale.Checked == true)
            {
                ry.XB = "女";
            }
            int gh = Convert.ToInt32(dgvRY.SelectedRows[0].Cells["ColGH"].Value);
            int ret;
            if (gh != ry.GH)
            {
                Dlg.ShowErrorInfoAndHelp("已经创建的员工不允许修改其工号！");
                return;
                //if (gh == 1001)
                //{
                //    Dlg.ShowErrorInfoAndHelp("员工1001不允许修改工号！");
                //    return;
                //}
                //ret = Convert.ToInt32(SqlHelper.ExecuteScalar(string.Format("select count(1) from ptry where gh={0}", ry.GH)));
                //if (ret > 0)
                //{
                //    toolTip1.Show("该工号已存在,请重新输入", TBGH, 0, TBGH.Height, 2000);
                //    TBGH.Focus();
                //    return;
                //}
            }
            if ((gh == 1001) && (ry.RYZ != (int)dgvRY.SelectedRows[0].Cells["ColJB"].Value))
            {
                Dlg.ShowErrorInfoAndHelp("员工1001不允许修改权限！");
                return;
            }
            string mSql = string.Format("update ptry set gh='{0}',xm='{1}',xb='{2}',dh='{3}',sh={4},jb={5} where gh='{6}'", ry.GH, ry.XM, ry.XB, ry.DH, ry.SH, ry.RYZ, gh);
            ret = SqlHelper.ExecuteNonQuery(mSql);
            if (ret > 0)
            {
                InitRY();
                SelectRow(ry.GH);
                Dlg.ShowOKInfo("修改成功！");
            }
        }

        private void tsbResetPass_Click(object sender, EventArgs e)
        {
            //Confirm
            if (Dlg.ShowConfirmInfo("确认要重置密码吗？") == DialogResult.No)
            {
                return;
            }
            if (dgvRY.SelectedRows.Count < 1)
            {
                Dlg.ShowErrorInfoAndHelp("请先选择要重置的用户");
                return;
            }
            int gh = Convert.ToInt32(dgvRY.SelectedRows[0].Cells["ColGH"].Value);
            using (FrmInput mForm = new FrmInput())
            {
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    string strPass = mForm.txtInput.Text.Trim();
                    strPass = MD5.Md5Encrypt(strPass);

                    string mSql = string.Format("update ptry set mm='{0}' where gh='{1}'", strPass, gh);
                    int ret = SqlHelper.ExecuteNonQuery(mSql);
                    if (ret > 0)
                    {
                        Dlg.ShowOKInfo("重置成功!");
                    }
                    else
                    {
                        Dlg.ShowErrorInfo("重置失败!");
                    }
                }
            }
        }

        private void cmbSH_Resize(object sender, EventArgs e)
        {
            GBoxSex.Width = CBoxSH.Width;
        }

        private void TabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
