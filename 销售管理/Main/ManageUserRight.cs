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
using Common;
using Soft.Common;
using 销售管理.Classes;


namespace 销售管理.Main
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

        /// <summary>
        /// 初始化菜单下的操作权限
        /// </summary>
        private void InitOperation()
        {
            string mSql = "select * from PTOperation ";
            DataTable mTable = SqlHelper.GetData(mSql);

            foreach (DataRow mRow in mTable.Rows)
            {
                Operation op;
                op.IntID = Convert.ToInt32(mRow["IntID"]);
                op.IntMenuID = Convert.ToInt32(mRow["IntMenuID"]);
                op.VcDesc = mRow["VcDesc"].ToString().Trim();
                op.VcImagePath = mRow["VcImagePath"].ToString().Trim();


                Image tmpImage = null;
                if (File.Exists(op.VcImagePath))
                {
                    tmpImage = Image.FromFile(op.VcImagePath);
                    imageList1.Images.Add(op.VcImagePath, tmpImage);
                }

                TreeNode[] mNodes = tvRight.Nodes.Find(op.IntMenuID.ToString(), true);
                if (mNodes.Length > 0)
                {
                    TreeNode mFCDNode = tvRight.Nodes.Find(op.IntMenuID.ToString(), true)[0];

                    TreeNode mNode = mFCDNode.Nodes.Add(op.IntID.ToString(), op.VcDesc);
                    mNode.Tag = op.IntID;

                    if (tmpImage != null)
                    {
                        mNode.ImageKey = op.VcImagePath;
                        mNode.SelectedImageKey = op.VcImagePath;
                    }
                }

            }

        }

        private void InitRight()
        {
            tvRight.Nodes.Clear();
            string mSql ="select * from PTMenu  where mkbh not in('0000') order by mkjb,PTMenu.MKBH";
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
            InitOperation();//附加操作权限
            tvRight.ExpandAll();
        }

        private void InitRYZ()
        {
            tvRYZ.Nodes.Clear();
            string mSql = "select zbh,zmc from PTRole";
            DataTable mTable = SqlHelper.GetData(mSql);
            foreach (DataRow mRow in mTable.Rows)
            {
                tvRYZ.Nodes.Add(mRow["zmc"].ToString()).Tag = mRow["zbh"];
            }
            cmbRole.DataSource = mTable;
        }

        private void InitSH()
        {
            cmbDepart.DataSource = SqlHelper.GetData("select * from ptDepartment");
        }

        private void InitRY()
        {
            string mSql = @"select a.*,b.VcName as 部门名称,c.Zmc as 角色名 from T_Users a left join ptdepartment b on a.IntDepartmentID = b.INtid left join  PTRole c on  a.IntRoleID = c.zbh";

            dgvRY.AutoGenerateColumns = false;
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
                if(_SubNode.Level>1 && p_SelectCheck)
                    continue;
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
            if (p_TreeNode.Level > 1)
                return;
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
            //if (e.Node.Level > 1)
            //    return;
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
                    int iRet = Convert.ToInt32(SqlHelper.ExecuteScalar(string.Format("select count(*) from PTRole where ZMC='{0}'", mForm.txtInput.Text.Trim())));
                    if (iRet > 0)
                    {
                        Dlg.ShowErrorInfoAndHelp("该角色已存在,请重新创建！");
                        return;
                    }
                    iRet = SqlHelper.ExecuteNonQuery(string.Format("insert into PTRole(zmc)values('{0}')", mForm.txtInput.Text.Trim()));                    
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
            mSqls.Add(string.Format("delete from ptzqx where ryzbh={0} ", ryzbh)); //and MKBH in (select MKBH from PTMenu where MKBH <> '0000' )
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
                mSqls.Add(string.Format("insert into ptzqx(ryzbh,mkbh,IntLevel) values({0},'{1}','{2}')", ryzbh, Convert.ToInt32(tn.Tag),tn.Level));
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
                    string sSql = string.Format("select count(*) from PTRole where zmc='{0}'", mForm.txtInput.Text.Trim());
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
                    sSql = string.Format("update PTRole set zmc='{0}' where zbh={1}", mForm.txtInput.Text.Trim(), zbh);
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
            DbAcs.m_sSQL = string.Format("SELECT count(*) FROM [t_users] where introleid={0}", tvRYZ.SelectedNode.Tag.ToString());
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
                string mSql = string.Format("delete from PTRole where zbh={0}", Convert.ToInt32(tvRYZ.SelectedNode.Tag));
                int ret = SqlHelper.ExecuteNonQuery(mSql);
                InitRYZ();
                InitRight();
            }
        }

        private void dgvRY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtID.Text = dgvRY[ColID.Index, e.RowIndex].Value.ToString();
            cmbDepart.SelectedValue = dgvRY[ColDepartmentID.Index, e.RowIndex].Value;
            txtLoginName.Text = dgvRY[ColLoginName.Index, e.RowIndex].Value.ToString();
            txtUserName.Text = dgvRY[ColUserName.Index, e.RowIndex].Value.ToString();
            txtAreaCode.Text = dgvRY[ColAreaCode.Index, e.RowIndex].Value.ToString();
            cmbRole.SelectedValue = dgvRY[ColIntRoleID.Index, e.RowIndex].Value;
            if (dgvRY[ColUserStatus.Index, e.RowIndex].Value.ToString() == "0")
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
            string loginName = dgvRY.SelectedRows[0].Cells[ColLoginName.Index].Value.ToString();
            if (loginName.ToLower() == "admin")
            {
                Dlg.ShowErrorInfoAndHelp("admin不能进行锁定！");
                return;
            }
            long Id = Convert.ToInt64(dgvRY.SelectedRows[0].Cells[ColLoginName.Index].Value);
            string mSql = string.Format("update t_users set userstatus ='停用' where id='{0}'", Id);
            int ret = SqlHelper.ExecuteNonQuery(mSql);
            InitRY();
            tsbUnlock.Enabled = true;
            tsbLock.Enabled = false;
            SelectRow(Id);
        }

        private void SelectRow(long gh)
        {
            foreach (DataGridViewRow mRow in dgvRY.Rows)
            {
                if (gh == Convert.ToInt64(mRow.Cells[ColID.Index].Value))
                {
                    mRow.Selected = true;
                    break;
                }
            }
        }

        private void tsbUnlock_Click(object sender, EventArgs e)
        {
            if (dgvRY.SelectedRows.Count < 1) return;
            long gh = Convert.ToInt64(dgvRY.SelectedRows[0].Cells[ColID.Index].Value);
            string mSql = string.Format("update t_users set userstatues ='正常' where id='{0}'", gh);
            int ret = SqlHelper.ExecuteNonQuery(mSql);
            InitRY();
            tsbLock.Enabled = true;
            tsbUnlock.Enabled = false;
            SelectRow(gh);
        }

        void TrimTextBox()
        {
            txtLoginName.Text = txtLoginName.Text.Trim();
            txtUserName.Text = txtUserName.Text.Trim();
            txtAreaCode.Text = txtAreaCode.Text.Trim();
        }
        private void tsbRYAdd_Click(object sender, EventArgs e)
        {
            TrimTextBox();
            if (txtLoginName.Text.Trim() == string.Empty)
            {
                toolTip1.Show("登录名不能为空", txtLoginName, 0, txtLoginName.Height, 2000);
                return;
            }
            if (txtUserName.Text.Trim() == string.Empty)
            {
                toolTip1.Show("姓名不能为空", txtUserName, 0, txtUserName.Height, 2000);
                return;
            }
           
            

            ry ry = new ry();

            ry.LoginName = txtLoginName.Text.Trim();
            ry.UserName = txtUserName.Text.Trim();
            ry.AreaCode = txtAreaCode.Text.Trim();
            ry.IntDepartmentID = Convert.ToInt32(cmbDepart.SelectedValue);
            ry.IntRoleID = Convert.ToInt32(cmbRole.SelectedValue);
            
            int ret = Convert.ToInt32(SqlHelper.ExecuteScalar(string.Format("select count(1) from t_users where loginName='{0}'", ry.LoginName)));
            if (ret > 0)
            {
                toolTip1.Show("该登陆名已存在,请重新输入", txtLoginName, 0, txtLoginName.Height, 2000);
                txtLoginName.Focus();
                return;
            }

            string mSql = string.Format("insert into t_users(loginname,UserName,userChar,IntDepartmentID,IntRoleID,userstatus,PassWord) values ('{0}','{1}','{2}',{3},{4},'正常','{5}')", ry.LoginName, ry.UserName, ry.AreaCode, ry.IntDepartmentID, ry.IntRoleID, MD5.Md5Encrypt("1"));
            ret = SqlHelper.ExecuteNonQuery(mSql);
            if (ret > 0)
            {
                InitRY();
                mSql = string.Format("select id from t_users where loginname='{0}'",ry.LoginName);
                ry.ID=Convert.ToInt64( SqlHelper.ExecuteScalar(mSql));
                txtID.Text = ry.ID.ToString();
                SelectRow(ry.ID);
                Dlg.ShowOKInfo("添加成功,初始密码1!");
            }
        }

        private struct ry
        {
            public string LoginName;
            public string UserName;
            public string AreaCode;
            public int IntDepartmentID;
            public long ID;
            public int IntRoleID;
        }

        private void tsbRYDel_Click(object sender, EventArgs e)
        {
            if (dgvRY.SelectedRows.Count == 0) 
            { 
                return;
            }
            string loginName = dgvRY.SelectedRows[0].Cells[ColLoginName.Index].Value.ToString();
            if (loginName == "admin")
            {
                Dlg.ShowErrorInfoAndHelp("admin不能进行删除！");
                return;
            }
            
            //Confirm
            if (Dlg.ShowConfirmInfo("确认要删除该用户吗？")==DialogResult.No)
            {
                return;
            }
            long id = Convert.ToInt64(dgvRY.SelectedRows[0].Cells[ColID.Index].Value);
            string mSql = string.Format("delete from t_users where id='{0}'", id);
            int ret = SqlHelper.ExecuteNonQuery(mSql);
            if (ret > 0) InitRY();
        }

        private void ClearForm()
        {
            txtLoginName.Text = "";
            txtUserName.Text = "";
            txtAreaCode.Text = "";
            
        }

        private void tsbRYSave_Click(object sender, EventArgs e)
        {
            if ((dgvRY.SelectedRows.Count < 1) || (txtID.Text == ""))
            {
                Dlg.ShowErrorInfoAndHelp("请先选择要保存的用户");
                return;
            }
            if (txtLoginName.Text.Trim() == string.Empty)
            {
                toolTip1.Show("登录名不能为空", txtLoginName, 0, txtLoginName.Height, 2000);
                return;
            }
            if (txtUserName.Text.Trim() == string.Empty)
            {
                toolTip1.Show("姓名不能为空", txtUserName, 0, txtUserName.Height, 2000);
                return;
            }
            ry ry = new ry();

            ry.ID = Convert.ToInt64(txtID.Text);
            ry.LoginName = txtLoginName.Text;
            ry.UserName = txtUserName.Text.Trim();
            
            ry.AreaCode = txtAreaCode.Text.Trim();
            ry.IntDepartmentID = Convert.ToInt32(cmbDepart.SelectedValue);
            ry.IntRoleID = Convert.ToInt32(cmbRole.SelectedValue);

            int ret = Convert.ToInt32(SqlHelper.ExecuteScalar(string.Format("select count(1) from t_users where loginName='{0}' and id <> {1}", ry.LoginName,ry.ID)));
            if (ret > 0)
            {
                toolTip1.Show("该登陆名已存在,请重新输入", txtLoginName, 0, txtLoginName.Height, 2000);
                txtLoginName.Focus();
                return;
            }


            if ((ry.LoginName.ToLower() == "admin"))
            {
                Dlg.ShowErrorInfoAndHelp("员工admin不允许修改！");
                return;
            }
            string mSql = string.Format("update t_users set loginName='{0}',UserName='{1}',userChar='{2}',intdepartmentID='{3}',IntRoleID={4} where id='{5}'", ry.LoginName, ry.UserName, ry.AreaCode,ry.IntDepartmentID,ry.IntRoleID,ry.ID);
            ret = SqlHelper.ExecuteNonQuery(mSql);
            if (ret > 0)
            {
                InitRY();
                SelectRow(ry.ID);
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
            long id = Convert.ToInt64(dgvRY.SelectedRows[0].Cells[ColID.Index].Value);
            using (FrmInput mForm = new FrmInput())
            {
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    string strPass = mForm.txtInput.Text.Trim();
                    strPass = MD5.Md5Encrypt(strPass);

                    string mSql = string.Format("update t_users set password='{0}' where id={1}", strPass, id);
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
        }

        private void TabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvRY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
