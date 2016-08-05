using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using Client.Class;
using Common;
using Soft.Common;

namespace Client.Main
{
    public partial class ManageMenu : UserControlBase
    {
        public ManageMenu()
        {
            InitializeComponent();
        }

        //自定义组合框项 
        class MyItem
        {
            //项文本内容 
            private String Text;

            //项图片 
            public Image Img;

            //构造函数 
            public MyItem(String text, Image img)
            {
                Text = text;
                Img = img;
            }

            //重写ToString函数，返回项文本 
            public override string ToString()
            {
                return Text;
            }
        }

        private void ComboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //鼠标选中在这个项上 
            if ((e.State & DrawItemState.Selected) != 0)
            {
                //渐变画刷 
                LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, Color.FromArgb(255, 251, 237),
                                                 Color.FromArgb(255, 236, 181), LinearGradientMode.Vertical);
                //填充区域 
                Rectangle borderRect = new Rectangle(3, e.Bounds.Y, e.Bounds.Width - 5, e.Bounds.Height - 2);

                e.Graphics.FillRectangle(brush, borderRect);

                //画边框 
                Pen pen = new Pen(Color.FromArgb(229, 195, 101));
                e.Graphics.DrawRectangle(pen, borderRect);
            }
            else
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255));
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            if (e.Index == -1) return;
            //获得项图片,绘制图片 
            MyItem item = (MyItem)cmbTP.Items[e.Index];
            Image img = item.Img;

            //图片绘制的区域 
            Rectangle imgRect = new Rectangle(6, e.Bounds.Y + 3, 45, 45);
            e.Graphics.DrawImage(img, imgRect);

            //文本内容显示区域 
            Rectangle textRect =
                    new Rectangle(imgRect.Right + 2, imgRect.Y, e.Bounds.Width - imgRect.Width, e.Bounds.Height - 2);

            //获得项文本内容,绘制文本 
            String itemText = cmbTP.Items[e.Index].ToString();

            //文本格式垂直居中 
            StringFormat strFormat = new StringFormat();
            strFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(itemText, new Font("宋体", 9), Brushes.Black, textRect, strFormat);
        }

        private void ManageMenu_Load(object sender, EventArgs e)
        {
            InitRight();
            InitCardType();
            InitImages();
        }

        private void InitImages()
        {
            string[] Files;
            Files = System.IO.Directory.GetFiles(@"Images\");
            string mPath;

            foreach (string file in Files)
            {
                if (file.EndsWith(".png") == true)
                {
                    mPath = @"Images\" + System.IO.Path.GetFileName(file);
                    cmbTP.Items.Add(new MyItem(mPath, Image.FromFile(mPath)));
                }
            }


            cmbTP.SelectedIndex = -1;

            cmbTP.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTP.ItemHeight = 48;
            //cmbTP.Width = 200;

            //添加DrawItem事件处理函数 
            cmbTP.DrawItem += ComboBox1_DrawItem;
        }


        private void InitCardType()
        {
            string mSql = "Select IntCode,VcDesc from ZDparams where IntType = 1 order by intcode";
            DataTable mTable = SqlHelper.GetData(mSql);
            cmbCardType.DisplayMember = "VcDesc";
            cmbCardType.ValueMember = "IntCode";
            cmbCardType.DataSource = mTable;
        }

        private void InitFCD()
        {
            cmbFCD.DataSource = SqlHelper.GetData("select mkbh,mkmc,mkbh+':'+mkmc as mkbhmc from ptcd where mkjb=1");
            cmbFCD.SelectedIndex = -1;
        }

        private void InitRight()
        {
            tvRight.Nodes.Clear();
            Application.DoEvents();
            string mSql = string.Format("select * from PTcd where mkbh<>'0000' and ((cardtype in(-1,-2)) or(cardtype={0})) order by mkjb,PTcd.MKBH", CommonClass.SttIC.iCardType);
            DataTable mTable = SqlHelper.GetData(mSql);

            tvRight.BeginUpdate();
            foreach (DataRow mRow in mTable.Rows)
            {
                ModuleList ml = new ModuleList();
                ml.MKBH = mRow["MKBH"].ToString().Trim();
                ml.MKMC = mRow["MKMC"].ToString().Trim();
                ml.MKJB = Convert.ToInt32(mRow["MKJB"]);
                ml.MKFCD = mRow["MKFCD"].ToString().Trim();
                ml.MKTP = mRow.IsNull("MKTP") ? "" : mRow["MKTP"].ToString().Trim();
                ml.MKWJM = mRow.IsNull("MKWJM") ? "" : mRow["MKWJM"].ToString().Trim();
                ml.MKHSM = mRow.IsNull("MKHSM") ? "" : mRow["MKHSM"].ToString().Trim();
                ml.FastStart = mRow["FastStart"].ToString();
                ml.CardType = Convert.ToInt32(mRow["CardType"]);
                ml.BBH = mRow["BBH"].ToString();

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


                        TreeNode mNode = mFCDNode.Nodes.Add(ml.MKBH, ml.MKBH + "-" + ml.MKMC);
                        mNode.Tag = ml;
                        if (tmpImage != null)
                        {
                            mNode.ImageKey = ml.MKTP;
                            mNode.SelectedImageKey = ml.MKTP;
                        }
                    }
                }
                else
                {
                    TreeNode mNode = tvRight.Nodes.Add(ml.MKBH, ml.MKBH + "-" + ml.MKMC);
                    mNode.Tag = ml;
                    if (tmpImage != null)
                    {
                        mNode.ImageKey = ml.MKTP;
                        mNode.SelectedImageKey = ml.MKTP;
                    }
                }
            }

            tvRight.ExpandAll();            
            if (tvRight.Nodes.Count > 0) tvRight.Nodes[0].EnsureVisible();
            tvRight.EndUpdate();
            InitFCD();
        }

        private void ClearForm()
        {
            txtBBH.Text = "";
            txtMKBH.Text = "";
            txtMKHSM.Text = "";
            txtMKMC.Text = "";
            txtMKWJM.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZCD.Checked == true)
            {
                labFCD.Visible = false;
                cmbFCD.Visible = false;
                labMKWJM.Visible = false;
                txtMKWJM.Visible = false;
                labMKHSM.Visible = false;
                txtMKHSM.Visible = false;
                labFastStart.Visible = false;
                cbFastStart.Visible = false;
            }
            else
            {
                labFCD.Visible = true;
                cmbFCD.Visible = true;
                labMKWJM.Visible = true;
                txtMKWJM.Visible = true;
                labMKHSM.Visible = true;
                txtMKHSM.Visible = true;
                labFastStart.Visible = true;
                cbFastStart.Visible = true;
            }
        }

        private void tvRight_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ModuleList ml = (ModuleList)e.Node.Tag;

            if (ml.MKJB == 1)
            {
                rbZCD.Checked = true;

            }
            else
            {
                rbMK.Checked = true;
                cmbFCD.SelectedValue = ml.MKFCD;
                txtMKWJM.Text = ml.MKWJM;
                txtMKHSM.Text = ml.MKHSM;
                cbFastStart.Checked = Convert.ToBoolean(ml.FastStart);
            }
            if (ml.MKTP != "")
            {
                cmbTP.SelectedIndex = cmbTP.FindString(ml.MKTP);
            }
            txtMKMC.Text = ml.MKMC;
            txtMKBH.Text = ml.MKBH;
            txtBBH.Text = ml.BBH;
            cmbCardType.SelectedValue = Convert.ToInt32(ml.CardType);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModuleList ml = new ModuleList();
            ml.MKBH = txtMKBH.Text.Trim();
            ml.MKMC = txtMKMC.Text.Trim();
            ml.MKTP = cmbTP.Text;
            ml.BBH = txtBBH.Text.Trim();
            ml.CardType = Convert.ToInt32(cmbCardType.SelectedValue);

            if (ml.MKBH == "")
            {
                toolTip1.Show("模块编号不能为空!", txtMKBH, 0, txtMKBH.Height, 2000);
                return;
            }
            if (ml.MKMC == "")
            {
                toolTip1.Show("模块名称不能为空!", txtMKMC, 0, txtMKMC.Height, 2000);
                return;
            }
            if (ml.BBH == "")
            {
                toolTip1.Show("模块版本号不能为空!", txtBBH, 0, txtBBH.Height, 2000);
                return;
            }

            int ret;
            string mSql;
            ret = Convert.ToInt32(SqlHelper.ExecuteScalar(string.Format("select count(1) from ptcd where mkbh='{0}'", ml.MKBH)));
            if (ret > 0)
            {
                toolTip1.Show("该模块编号已存在!", txtMKBH, 0, txtMKBH.Height, 2000);
                return;
            }
            if (rbZCD.Checked == true)
            {
                ml.MKJB = 1;
                ml.MKFCD = "0000";
                ml.MKWJM = "";
                ml.MKHSM = "";
                ml.FastStart = "0";
                mSql = string.Format("insert into ptcd(mkbh,mkmc,mkjb,mkfcd,mktp,bbh,cardtype) values('{0}','{1}','{2}','{3}','{4}','{5}',{6})", ml.MKBH, ml.MKMC, ml.MKJB, ml.MKFCD, ml.MKTP, ml.BBH, ml.CardType);
            }
            else
            {
                if (ml.MKWJM == "")
                {
                    toolTip1.Show("模块文件名不能为空!", txtMKWJM, 0, txtMKWJM.Height, 2000);
                    return;
                }
                if (ml.MKHSM == "")
                {
                    toolTip1.Show("模块函数名不能为空!", txtMKWJM, 0, txtMKWJM.Height, 2000);
                    return;
                }
                if (cmbFCD.SelectedIndex == -1)
                {
                    toolTip1.Show("请选择父菜单!", cmbFCD, 0, cmbFCD.Height, 2000);
                    return;
                }
                ml.FastStart = Convert.ToInt32(cbFastStart.Checked).ToString();
                ml.MKJB = 2;
                ml.MKFCD = cmbFCD.SelectedValue.ToString();
                ml.MKWJM = txtMKWJM.Text.Trim();
                ml.MKHSM = txtMKHSM.Text.Trim();
                mSql = string.Format("insert into ptcd(mkbh,mkmc,mkjb,mkfcd,mktp,mkwjm,mkhsm,faststart,bbh,cardtype) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9})", ml.MKBH, ml.MKMC, ml.MKJB, ml.MKFCD, ml.MKTP, ml.MKWJM, ml.MKHSM, ml.FastStart, ml.BBH, ml.CardType);
            }
            ret = SqlHelper.ExecuteNonQuery(mSql);
            if (ret > 0)
            {
                InitRight();
                Dlg.ShowOKInfo("创建成功");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (Dlg.ShowConfirmInfo("确认要删除该模块吗?") == DialogResult.Yes)
            {
                string MKBH;
                if (tvRight.SelectedNode == null)
                {
                    Dlg.ShowErrorInfoAndHelp("请选择要删除的模块！");
                    return;
                }
                MKBH = ((ModuleList)tvRight.SelectedNode.Tag).MKBH;
                List<string> mSqls = new List<string>();
                string mSql = string.Format("delete from ptcd where mkbh='{0}'", MKBH);
                mSqls.Add(mSql);
                mSql = string.Format("delete from ptzqx where mkbh='{0}'", MKBH);
                mSqls.Add(mSql);
            
                int ret = SqlHelper.ExecuteSqls(mSqls.ToArray());
                if (ret == 0)
                {
                    Dlg.ShowOKInfo("删除成功!");
                    ClearForm();
                    InitRight();
                }
            }
        }

        private void tsbModify_Click(object sender, EventArgs e)
        {
            string MKBH;
            if (tvRight.SelectedNode == null)
            {
                Dlg.ShowErrorInfoAndHelp("请选择要修改的模块！");
                return;
            }
            MKBH = ((ModuleList)tvRight.SelectedNode.Tag).MKBH;
            ModuleList ml = new ModuleList();
            ml.MKBH = txtMKBH.Text.Trim();
            ml.MKMC = txtMKMC.Text.Trim();
            ml.MKTP = cmbTP.Text;
            ml.BBH = txtBBH.Text.Trim();

            ml.CardType = Convert.ToInt32(cmbCardType.SelectedValue);

            if (ml.MKBH == "")
            {
                toolTip1.Show("模块编号不能为空!", txtMKBH, 0, txtMKBH.Height, 2000);
                return;
            }
            if (ml.MKMC == "")
            {
                toolTip1.Show("模块名称不能为空!", txtMKMC, 0, txtMKMC.Height, 2000);
                return;
            }
            if (ml.BBH == "")
            {
                toolTip1.Show("模块版本号不能为空!", txtBBH, 0, txtBBH.Height, 2000);
                return;
            }

            int ret;
            string mSql;
            List<string> mSqls = new List<string>();
            if (MKBH != ml.MKBH)
            {
                ret = Convert.ToInt32(SqlHelper.ExecuteScalar(string.Format("select count(1) from ptcd where mkbh='{0}'", ml.MKBH)));
                if (ret > 0)
                {
                    toolTip1.Show("该模块编号已存在!", txtMKBH, 0, txtMKBH.Height, 2000);
                    return;
                }
            }
            if (rbZCD.Checked == true)
            {
                ml.MKWJM = "";
                ml.MKHSM = "";
                ml.MKJB = 1;
                ml.MKFCD = "0000";
                ml.FastStart = "0";
            }
            else
            {
                if (ml.MKWJM == "")
                {
                    toolTip1.Show("模块文件名不能为空!", txtMKWJM, 0, txtMKWJM.Height, 2000);
                    return;
                }
                if (ml.MKHSM == "")
                {
                    toolTip1.Show("模块函数名不能为空!", txtMKWJM, 0, txtMKWJM.Height, 2000);
                    return;
                }
                ml.FastStart = Convert.ToInt32(cbFastStart.Checked).ToString();
                ml.MKJB = 2;
                ml.MKFCD = cmbFCD.SelectedValue.ToString();
                ml.MKWJM = txtMKWJM.Text.Trim();
                ml.MKHSM = txtMKHSM.Text.Trim();
            }
            mSql = string.Format("update ptcd set mkbh='{0}',mkmc='{1}',mkjb='{2}',mkfcd='{3}',mktp='{4}',mkwjm='{5}',mkhsm='{6}',faststart='{7}',bbh='{8}',cardtype={9} where mkbh='{10}'", ml.MKBH, ml.MKMC, ml.MKJB, ml.MKFCD, ml.MKTP, ml.MKWJM, ml.MKHSM, ml.FastStart, ml.BBH, ml.CardType, MKBH);
            mSqls.Add(mSql);
            mSql = string.Format("update ptcd set mkfcd ='{0}' where mkfcd='{1}'", ml.MKBH, MKBH);
            mSqls.Add(mSql);
            ret = SqlHelper.ExecuteSqls(mSqls.ToArray());
            if (ret == 0)
            {
                InitRight();
                //tvRight.BeginUpdate();
                //try
                //{
                //    TreeNode[] mNodes = tvRight.Nodes.Find(ml.MKBH, true);
                //    if (mNodes.Length > 0)
                //        tvRight.SelectedNode = mNodes[0];
                //}
                //finally
                //{
                //    tvRight.EndUpdate();
                //}
                Dlg.ShowOKInfo("修改成功！");
            }
        }
    }
}
