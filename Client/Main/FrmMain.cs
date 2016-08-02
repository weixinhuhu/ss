using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Xml;
using System.IO;
using BSE.Windows.Forms;
using Client.Class;
using Common;
using Soft.Common;
//using PubClasses;

namespace Client.Main
{
    partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (System.Environment.OSVersion.Version.Major > 5)
                    cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        public FrmMain(FrmLogin mLogin)
            : this()
        {
            myLogin = mLogin;
        }

        FrmLogin myLogin;

        private string labelTemp;
        //private bool toolstripMBool;//是否点击过菜单下的工具栏按钮，为true时才可以点击按钮隐藏左侧工具栏
        List<ModuleList> myModuleList = new List<ModuleList>();

        public void LoadModuleListFromDb(int ryzbh)
        {
            int CardType = -1;
            string mySQL;
            DataTable mTable;
            //XmlDocument mXml = new XmlDocument();
            //if (File.Exists("System.xml") == true)
            //{
            //    mXml.Load("System.xml");
            //    XmlNode mCardTypeNode = mXml.SelectSingleNode("/Config/CardType");
            //    if (mCardTypeNode != null)
            //    {
            //        CardType = Convert.ToInt32(mCardTypeNode.Attributes["Type"].Value);
            //    }
            //}
            if (CommonClass.SttUser.blSuperUser)
            {
                mySQL = string.Format("select A.MKBH,A.MKMC,A.MKJB,A.MKFCD,A.MKTP,A.MKWJM,A.MKHSM,A.BBH,a.FastStart from PTcd A where cardtype in(-3) or (MKFCD='9800' or A.MKBH='9800') order by A.MKFCD,A.MKBH");
            }
            else
            {
                //获取当前卡片类型            
                mySQL = "select CardMeterTypeId from szIcSysParam";
                mTable = SqlHelper.GetData(mySQL);
                if (mTable.Rows.Count > 0)
                {
                    CardType = Utils.StrToIntDef(mTable.Rows[0][0].ToString(), -1);
                    CommonClass.SttIC.iCardType = CardType;
                }
                if (CardType == -1)
                {//无卡片类型设置则只加载具有权限中的“系统设置”一级菜单下子菜单
                    mySQL = string.Format("select A.MKBH,A.MKMC,A.MKJB,A.MKFCD,A.MKTP,A.MKWJM,A.MKHSM,A.BBH,a.FastStart from PTcd A,PTzqx B where A.MKBH=B.MKBH and B.RYZBH={0} and (MKFCD='9800' or A.MKBH='9800') order by A.MKFCD,A.MKBH", ryzbh);
                }
                else
                {
                    mySQL = string.Format("select A.MKBH,A.MKMC,A.MKJB,A.MKFCD,A.MKTP,A.MKWJM,A.MKHSM,A.BBH,a.FastStart from PTcd A,PTzqx B where A.MKBH=B.MKBH and B.RYZBH={0} and cardtype in({1},-1) order by A.MKFCD,A.MKBH", ryzbh, CardType.ToString());
                }
            }
            mTable = SqlHelper.GetData(mySQL);

            if (mTable != null)
            {
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
                    ml.BBH = mRow["BBH"].ToString().Trim();
                    ml.FastStart = mRow["FastStart"].ToString();

                    Image tempImage = null;
                    if (File.Exists(ml.MKTP) == true)
                    {
                        tempImage = Image.FromFile(ml.MKTP);
                    }

                    if (Convert.ToBoolean(ml.FastStart) == true && ml.MKJB != 1)
                    {
                        //toolStripFast添加快捷按钮
                        ToolStripButton tsbFastTemp = new ToolStripButton(ml.MKMC, tempImage, new EventHandler(t2toolStripButton1_Click));
                        tsbFastTemp.Tag = ml;
                        tsbFastTemp.DisplayStyle = ToolStripItemDisplayStyle.Image;
                        tsbFastTemp.ToolTipText = ml.MKMC;

                        toolStripFast.Items.Add(tsbFastTemp);
                    }

                    if (ml.MKFCD == "0000")
                    {
                        XPanderPanel mxppTemp = new XPanderPanel();
                        mxppTemp.Text = ml.MKMC;

                        ToolStrip tsTemp = new ToolStrip(); // 新建侧边栏
                        tsTemp.Name = "ts" + ml.MKMC;
                        tsTemp.ImageScalingSize = new Size(36, 36);
                        tsTemp.BackColor = System.Drawing.Color.FromArgb(192, 220, 255);
                        tsTemp.Dock = DockStyle.Fill;
                        tsTemp.GripStyle = ToolStripGripStyle.Hidden;
                        tsTemp.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                        tsTemp.Parent = mxppTemp;
                        tsTemp.Tag = ml;

                        ToolStripMenuItem tsmiTemp = new ToolStripMenuItem(ml.MKMC);
                        tsmiTemp.Name = "tsmi" + ml.MKMC;
                        tsmiTemp.Tag = ml;

                        xPanderPanelList1.XPanderPanels.Add(mxppTemp);
                        MenuMain.Items.Insert(MenuMain.Items.Count - 2, tsmiTemp);
                    }
                    else if (ml.MKFCD != "0000" || ml.MKFCD != "9999")
                    {
                        foreach (ToolStripMenuItem mMenuItem in MenuMain.Items)
                        {
                            if (mMenuItem.Tag == null) continue;
                            if (((ModuleList)mMenuItem.Tag).MKBH == ml.MKFCD)
                            {
                                ToolStripMenuItem tsmiSubTemp = new ToolStripMenuItem(ml.MKMC, tempImage, new EventHandler(t2toolStripButton1_Click));
                                tsmiSubTemp.Tag = ml;

                                mMenuItem.DropDownItems.Add(tsmiSubTemp);

                                foreach (Control mCtrl in splitContainer1.Panel1.Controls.Find("ts" + ((ModuleList)mMenuItem.Tag).MKMC, true))
                                {
                                    ToolStripButton tsbTemp = new ToolStripButton(ml.MKMC, tempImage, new EventHandler(t2toolStripButton1_Click), "tsb" + ml.MKMC);//新建业务按钮
                                    tsbTemp.ImageScaling = ToolStripItemImageScaling.SizeToFit;
                                    tsbTemp.Name = "tsb" + ml.MKMC;
                                    tsbTemp.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                                    tsbTemp.TextImageRelation = TextImageRelation.ImageAboveText;
                                    tsbTemp.Tag = ml;
                                    ((ToolStrip)mCtrl).Items.Add(tsbTemp); //业务按钮添加到控件上
                                }
                            }
                        }
                    }
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Rectangle Rect = Screen.GetWorkingArea(this);
            if (Rect.Width > 1366)
            {
                //this.WindowState = FormWindowState.Maximized;
            }
            string sIconFileName = string.Format(@"{0}\Images\app.ico", Application.StartupPath);
            string sBackgroudFileName = string.Format(@"{0}\Images\backgroud.jpg", Application.StartupPath);
            if (File.Exists(sIconFileName))
            {
                this.Icon = new Icon(sIconFileName);
            }
            if (File.Exists(sBackgroudFileName))
            {
                PnlClient.BackgroundImage = new Bitmap(sBackgroudFileName);
            }
            if (CommonClass.SttDb.iDBType == 1)
            {
                TimingFromDbServer();
                timer.Enabled = true;
            }
            TSSLblUser.Text = string.Format("工号:{0}姓名:{1}", CommonClass.SttUser.sUserID, CommonClass.SttUser.sUserName);
            TSSLblDatetime.Text = string.Format("登录时间:{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            TSSLblDbInfo.Text = string.Format("数据库:{0}", CommonClass.SttDb.sDbInfo);
            TSSLblDbInfo.ToolTipText = TSSLblDbInfo.Text;
            //Dlg.ShowErrorInfo(Rect.Width.ToString ()+":"+Rect.Height.ToString());
            SetDoubleBuffered(PnlClient);
            if (xPanderPanelList1.XPanderPanels.Count > 0)
                xPanderPanelList1.XPanderPanels[0].Expand = true;
            //折叠panel1
            //splitContainer1.Panel1Collapsed = true;
            //LoadModuleList();
            //initOper();
            string mSql = "Select IntCode,VcDesc from ZDparams where IntType = 1 and IntCode<>-1  order by intcode";
            DataTable mTable = SqlHelper.GetData(mSql);
            foreach (DataRow mRow in mTable.Rows)
            {
                ToolStripMenuItem mTSI = new ToolStripMenuItem();
                mTSI.Tag = mRow["IntCode"];
                mTSI.Text = mRow["VcDesc"].ToString();
                mTSI.Click += 其它卡片ToolStripMenuItem_Click;
                选择卡片类型ToolStripMenuItem.DropDownItems.Add(mTSI);
            }
        }

        private void TimingFromDbServer()
        {
            string sSql = "select GetDate()";
            try
            {
                DataTable MyTable = SqlHelper.GetData(sSql);
                if (MyTable != null)
                {
                    MD5.Timing(DateTime.Parse(MyTable.Rows[0][0].ToString()));
                }
            }
            catch
            { }
        }

        private void LoadModuleListFromXml()
        {
            XmlDocument mXml = new XmlDocument();
            if (System.IO.File.Exists("System.xml") == false)
            {
                Dlg.ShowErrorInfoAndHelp("没有发现配置文档");
                return;
            }
            mXml.Load("System.xml");
            XmlNode mConfigNode = mXml.SelectSingleNode("/Config/ConfigFile");
            if (mConfigNode == null)
            {
                Dlg.ShowErrorInfoAndHelp("配置文件有误");
                return;
            }

            if (System.IO.File.Exists(mConfigNode.Attributes["FileName"].Value) == false)
            {
                Dlg.ShowErrorInfoAndHelp("没有发现配置文档");
                return;
            }
            mXml.Load(mConfigNode.Attributes["FileName"].Value);

            XmlNodeList mNodeList = mXml.SelectNodes("/Config/menus");
            for (int i = 0; i < mNodeList.Count; i++)
            {
                XmlNode mNode = mNodeList[i];
                Image imageTemp = null;
                string strText = "缺省值";
                string strName;
                if (mNode.Attributes["imagePath"].Value != null)
                {
                    imageTemp = Image.FromFile(mNode.Attributes["imagePath"].Value);
                }
                else
                {
                    imageTemp = Image.FromFile(@"Images\1.png");
                }
                if (mNode.Attributes["text"].Value != null)
                {
                    strText = mNode.Attributes["text"].Value;
                }
                if (mNode.Attributes["name"].Value != null)
                {
                    strName = mNode.Attributes["name"].Value;
                }
                else
                {
                    strName = new Guid().ToString();
                }

                ToolStripButton tsbMain = new ToolStripButton(strText, imageTemp, new EventHandler(mtoolStripButton1_Click), strName); //新建菜单主项按钮
                tsbMain.DisplayStyle = ToolStripItemDisplayStyle.Image;
                tsbMain.TextImageRelation = TextImageRelation.ImageAboveText;

                ToolStrip tsTemp = new ToolStrip(); // 新建侧边栏
                tsTemp.Name = "ts" + mNode.Attributes["text"].Value;
                tsTemp.Visible = false;
                tsTemp.ImageScalingSize = new Size(32, 32);
                tsTemp.BackColor = System.Drawing.Color.FromArgb(192, 220, 255);
                tsTemp.Dock = DockStyle.Fill;
                tsTemp.GripStyle = ToolStripGripStyle.Hidden;
                tsTemp.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                tsTemp.Parent = splitContainer1.Panel1;

                //新建菜单栏
                ToolStripMenuItem tsmiTemp = new ToolStripMenuItem(mNode.Attributes["text"].Value);
                tsmiTemp.Name = "tsmi" + mNode.Attributes["text"].Value;
                MenuMain.Items.Insert(0, tsmiTemp);


                //menuStrip1.Items.Add(mItem);
                //toolStripM.Items.Add(tsbMain); //菜单主项按钮添加到主toolstrip
                XmlNodeList mChildNodes = mNode.ChildNodes;
                for (int j = 0; j < mChildNodes.Count; j++)
                {
                    XmlNode mChildNode = mChildNodes[j];
                    Image imageChildTemp = null;
                    string strChildText = "缺省值";
                    string strChildName;

                    if (mChildNode.Attributes["imagePath"].Value != null)
                    {
                        imageChildTemp = Image.FromFile(mChildNode.Attributes["imagePath"].Value);
                    }
                    else
                    {
                        imageChildTemp = Image.FromFile(@"Images\1.png");
                    }
                    if (mChildNode.Attributes["text"].Value != null)
                    {
                        strChildText = mChildNode.Attributes["text"].Value;
                    }
                    if (mChildNode.Attributes["name"].Value != null)
                    {
                        strChildName = mChildNode.Attributes["name"].Value;
                    }
                    else
                    {
                        strChildName = new Guid().ToString();
                    }

                    ToolStripButton tsbTemp = new ToolStripButton(strChildText, imageChildTemp, new EventHandler(t2toolStripButton1_Click), strChildName);//新建业务按钮
                    ModuleList myModule = new ModuleList();
                    tsbTemp.ImageScaling = ToolStripItemImageScaling.SizeToFit;
                    tsbTemp.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    tsbTemp.TextImageRelation = TextImageRelation.ImageAboveText;
                    myModule.MKHSM = mChildNode.Attributes["class"].Value;//获取类名
                    myModule.MKWJM = mChildNode.Attributes["dllName"].Value;//获取程序集名称
                    tsbTemp.Tag = myModule;
                    myModuleList.Add(myModule);

                    tsTemp.Items.Add(tsbTemp); //业务按钮添加到控件上

                    //添加菜单子项
                    ToolStripMenuItem tsmiSubTemp = new ToolStripMenuItem(strChildText, imageChildTemp, new EventHandler(t2toolStripButton1_Click));
                    tsmiSubTemp.Tag = myModule;

                    tsmiTemp.DropDownItems.Add(tsmiSubTemp);
                }
            }
        }

        private void initOper()
        {
            Assembly myAs;
            myAs = Assembly.LoadFrom("一卡通.dll");

            Type mType = myAs.GetType("一卡通.Classes.InitRight");

            if (mType != null)
            {
                object[] args = new object[1];
                args[0] = this;

                mType.InvokeMember("InitUserRight", BindingFlags.InvokeMethod, null, mType, args);
            }
        }

        private object addControl(string senderName, ModuleList mModule)
        {
            try
            {
                Control mCT = null;

                string sCtrlName = mModule.MKHSM;
                if (PnlClient.Controls.Find(sCtrlName, false).Length > 0) //该页面已存在
                {
                    mCT = PnlClient.Controls.Find(sCtrlName, false)[0];
                }
                else
                {
                    Assembly myAs;

                    string sDllFile = mModule.MKWJM;
                    if (File.Exists(sDllFile))
                    {
                        myAs = Assembly.LoadFrom(sDllFile);
                    }
                    else
                    {
                        myAs = Assembly.GetExecutingAssembly();
                    }
                    if (myAs == null)
                    {
                        Dlg.ShowErrorInfoAndHelp(string.Format("未找到程序集({0})", mModule.MKWJM));
                        return null;
                    }

                    Type mType = myAs.GetType(sCtrlName);
                    if (mType == null)
                    {
                        Dlg.ShowErrorInfoAndHelp(string.Format("没有找到窗体({0})！", sCtrlName));
                        return 1;
                    }
                    mCT = (Control)Activator.CreateInstance(mType);
                    mCT.Name = sCtrlName;
                    //if (mType.BaseType.Name != "Form" )
                    //{
                    //    mCT.BackColor = System.Drawing.Color.Transparent;
                    //}
                    SetDoubleBuffered(mCT);
                    //SetBackColorTransParent(mCT);
                    mCT.Dock = System.Windows.Forms.DockStyle.Fill;

                    if (mCT is Form)
                    {
                        mCT.Show();
                    }
                    else
                    {
                        mCT.Tag = mModule;
                        //PnlClient.Controls.Clear();
                        foreach (Control ctrl in PnlClient.Controls)
                        {
                            ctrl.Dispose();
                        }
                        PnlClient.Controls.Add(mCT);
                    }
                    // mCT.Parent = panel1;
                }

                if (mCT != null)
                {
                    //for (int i = 0; i < panel1.Controls.Count; i++)
                    //{
                    //    panel1.Controls[i].Dispose();
                    //}
                    mCT.BringToFront();
                    mCT.Select();
                }
                LblTip.Text = senderName;
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(string.Format("异常：\n{0}", ex.Message));
                return 1;
            }
            return 0;  //0成功
        }

        private object addControl(string senderName, string _sTitle = "")
        {
            try
            {
                Control mCT = null;

                if (PnlClient.Controls.Find(senderName, false).Length > 0) //该页面已存在
                {
                    mCT = PnlClient.Controls.Find(senderName, false)[0];
                }
                else
                {
                    Assembly myAs = Assembly.GetExecutingAssembly();

                    Type mType = myAs.GetType(senderName);
                    if (mType == null)
                    {
                        Dlg.ShowErrorInfoAndHelp("没有找到窗体");
                        return 1;
                    }
                    if (mType.BaseType.Name == "UserControl" || mType.BaseType.Name == "UserControlBase")
                    {
                        mCT = (Control)Activator.CreateInstance(mType);
                        mCT.Name = senderName;
                    }

                    SetDoubleBuffered(mCT);
                    PnlClient.Controls.Add(mCT);
                    // mCT.Parent = panel1;
                    //将控件加载到标签页上

                }

                if (mCT != null)
                {
                    mCT.Dock = System.Windows.Forms.DockStyle.Fill;
                    mCT.BringToFront();
                    mCT.Select();
                }
                if (string.IsNullOrEmpty(_sTitle))
                {
                    LblTip.Text = senderName;
                }
                else
                {
                    LblTip.Text = _sTitle;
                }
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(string.Format("异常：\n{0}", ex.Message));
                return 1;
            }

            return 0;
            //0成功
        }

        private void SetDoubleBuffered(Control mc)
        {
            mc.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(mc, true, null);
            foreach (Control mSubCtrl in mc.Controls)
            {
                SetDoubleBuffered(mSubCtrl);
            }

        }

        private void SetBackColorTransParent(Control mc)
        {
            mc.BackColor = System.Drawing.Color.Transparent;
            foreach (Control mSubCtrl in mc.Controls)
            {
                SetDoubleBuffered(mSubCtrl);
            }

        }

        private void mtoolStripButton1_Click(object sender, EventArgs e)
        {
            ToolStripButton senderTemp = (ToolStripButton)sender;
            //ToolStripButton senderItem;
            //labelTemp = label1.Text + senderTemp.Text;
            labelTemp = senderTemp.Text;
            //展开panel1
            splitContainer1.Panel1Collapsed = false;
            //控制左侧工具栏显示
            //foreach (var tsb in toolStripM.Items)
            //{
            //    if (tsb.GetType().ToString().Contains("ToolStripButton"))
            //    {
            //        ((ToolStripButton)tsb).Checked = false;
            //    }
            //}

            //foreach (var ts in this.Controls.Find("ts" + senderTemp.Text, true))
            //{
            //    if (ts.GetType().Name == "ToolStrip")
            //    {
            //        ts.BringToFront();
            //        ts.Select();
            //        ts.Visible = true;
            //        toolStripButton1.Enabled = true;
            //    }
            //}
            #region 原方法
            //switch (senderTemp.Text)
            //{
            //    case "设置":
            //        ts设置.Visible = true;
            //        ts设置.Dock = DockStyle.Fill;

            //        mtoolStripButton1.Checked = true;
            //        ts日常业务.Visible = false;
            //        ts查询统计.Visible = false;
            //        ts审核.Visible = false;
            //        break;
            //    case "日常业务":
            //        ts日常业务.Visible = true;
            //        ts日常业务.Dock = DockStyle.Fill;

            //        mtoolStripButton2.Checked = true;
            //        ts设置.Visible = false;
            //        ts查询统计.Visible = false;
            //        ts审核.Visible = false;
            //        break;
            //    case "审核":
            //        ts审核.Visible = true;
            //        ts审核.Dock = DockStyle.Fill;

            //        mtoolStripButton3.Checked = true;
            //        ts设置.Visible = false;
            //        ts日常业务.Visible = false;
            //        ts查询统计.Visible = false;

            //        break;
            //    case "查询统计":
            //        ts查询统计.Visible = true;
            //        ts查询统计.Dock = DockStyle.Fill;

            //        mtoolStripButton4.Checked = true;
            //        ts设置.Visible = false;
            //        ts日常业务.Visible = false;
            //        ts审核.Visible = false;
            //        break;
            //    case "功能卡管理":

            //        ts设置.Visible = false;
            //        ts日常业务.Visible = false;
            //        ts查询统计.Visible = false;
            //        break;
            //    default:
            //        //隐藏panel1
            //        splitContainer1.Panel1Collapsed = true;
            //        break;
            //} 
            #endregion

            senderTemp.CheckOnClick = true;
            senderTemp.Checked = true;
            //foreach (ToolStripItem senderItem in toolStripM.Items)
            //{
            //    if (senderItem.GetType().Name == "ToolStripButton" && senderItem != senderTemp)
            //    {
            //        (senderItem as ToolStripButton).Checked = false;
            //    }
            //}
        }

        //todo:标示窗体名的标签
        private void t2toolStripButton1_Click(object sender, EventArgs e)
        {
            ToolStripItem senderTemp = (ToolStripItem)sender;
            addControl(senderTemp.Text, (ModuleList)senderTemp.Tag);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
            //if (splitContainer1.Panel1Collapsed == true)
            //{
            //    toolStripButton1.Image = global::Client.Properties.Resources.Forward;
            //}
            //else
            //{
            //    toolStripButton1.Image = global::Client.Properties.Resources.Back;
            //}
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout aboutboxM = new FrmAbout();
            aboutboxM.ShowDialog();

        }

        private bool blZhuxiao = false;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Dlg.ShowConfirmInfo("是否确定要注销？") == DialogResult.Yes)
            {
                Logout();
            }
        }

        public void Logout()
        {
            myLogin.TBUserPass.Clear();
            myLogin.Show();
            blZhuxiao = true;
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (blZhuxiao == false)
                {
                    if (Dlg.ShowConfirmInfo("确定退出系统？") == System.Windows.Forms.DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        e.Cancel = false;
                        //return;

                        #region 取数据库备份参数
                        int backupMode;
                        string backupPath;

                        string lsql = string.Format("SELECT IntCode,VcParam1 from SysParam where IntType=1");
                        using (DataTable dt = SqlHelper.GetData(lsql))
                        {
                            if (dt.Rows.Count == 0)
                            {
                                Dlg.ShowErrorInfoAndHelp("第一次使用，请设置数据库备份参数！");
                                e.Cancel = true;
                                return;
                            }
                            else
                            {
                                backupMode = Utils.StrToIntDef(dt.Rows[0]["IntCode"].ToString(), -1);
                                backupPath = Convert.ToString(dt.Rows[0]["VcParam1"]).Trim();
                            }

                            if ((backupMode < 0) || (backupMode > 2))
                            {
                                Dlg.ShowErrorInfo("数据库“备份选项”不正确，请设置！");
                                e.Cancel = true;
                                return;
                            }

                            if (backupMode != 2)
                            {
                                if (string.IsNullOrEmpty(backupPath) == true)
                                {
                                    if (Dlg.ShowConfirmInfo("数据库备份路径为空，请设置！") == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        e.Cancel = true;
                                        return;
                                    }
                                }
                                if ((!Directory.Exists(backupPath)) && CommonClass.SttDb.iDBType == 0)
                                {
                                    if (Dlg.ShowConfirmInfo("数据库备份路径在本机不存在，请设置！") == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        e.Cancel = true;
                                        return;
                                    }
                                }
                            }
                        }
                        #endregion

                        #region 备份
                        if (CommonClass.SttDb.iDBType == 0)
                        {
                            string dbFullName = Application.StartupPath + @"\DbMeter.mdb";
                            Cursor.Current = Cursors.WaitCursor;
                            CopyFileClass.Backup(backupMode, dbFullName, backupPath);
                            Cursor.Current = Cursors.Default;
                        }
                        else
                        {
                            if (backupMode == 0)
                            {
                                if (Dlg.ShowConfirmInfo("是否备份数据库") == System.Windows.Forms.DialogResult.Yes)
                                {
                                    Cursor.Current = Cursors.WaitCursor;
                                    string dbFullName = backupPath + "\\dbmeter" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak";
                                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\(.*?\)");
                                    string dbName = regex.Match(CommonClass.SttDb.sDbInfo).ToString().Trim('(', ')');
                                    string mSql = string.Empty;
                                    mSql = string.Format(@"BACKUP DATABASE {0} TO  DISK = N'{1}' WITH  INIT ,  NOUNLOAD , NAME = N'{0}备份',NOSKIP , STATS = 10, NOFORMAT", dbName, dbFullName);
                                    SqlHelper.ExecuteNonQuery(mSql);
                                    Cursor.Current = Cursors.Default;
                                }
                            }
                            else if (backupMode == 1)
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                string dbFullName = backupPath + "\\dbmeter" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak";
                                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\(.*?\)");
                                string dbName = regex.Match(CommonClass.SttDb.sDbInfo).ToString().Trim('(', ')');
                                string mSql = string.Empty;
                                mSql = string.Format(@"BACKUP DATABASE {0} TO  DISK = N'{1}' WITH  INIT ,  NOUNLOAD , NAME = N'{0}备份',NOSKIP , STATS = 10, NOFORMAT", dbName, dbFullName);
                                SqlHelper.ExecuteNonQuery(mSql);
                                Cursor.Current = Cursors.Default;
                            }

                        }
                        #endregion

                        //关闭启动窗体
                        myLogin.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message);
                e.Cancel = true;
                return;
            }
        }

        private int ChangeCardType(string xmlPath, string cardType)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                if (File.Exists(xmlPath) == false)
                {
                    xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "gb2312", null));
                    xmlDoc.AppendChild(xmlDoc.CreateElement("", "Config", ""));
                    xmlDoc.Save(xmlPath);
                }

                xmlDoc.Load(xmlPath);

                XmlNode mConfigNode = xmlDoc.SelectSingleNode("Config");
                if (mConfigNode == null)
                {
                    mConfigNode = xmlDoc.CreateElement("", "Config", "");
                    xmlDoc.AppendChild(mConfigNode);
                }
                XmlNode mCardTypeNode = xmlDoc.SelectSingleNode("Config/CardType");
                if (mCardTypeNode == null)
                {
                    mCardTypeNode = xmlDoc.CreateElement("CardType");
                    mConfigNode.AppendChild(mCardTypeNode);
                }
                XmlAttribute xaType = mCardTypeNode.Attributes["Type"];
                if (xaType == null)
                {
                    xaType = xmlDoc.CreateAttribute("Type");
                    mCardTypeNode.Attributes.Append(xaType);
                }
                xaType.Value = cardType;

                xmlDoc.Save(xmlPath);
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message);
                return 1;
            }
            return 0;
        }

        private int ChangeCardType(int CardType)
        {
            string mSql = string.Format("update SZICSysParam set cardmetertypeid = {0} ", CardType);
            int ret = SqlHelper.ExecuteNonQuery(mSql);
            if (ret > 0)
                return 0;
            else
                return 1;
        }
        private void cPU卡带EsamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ret = ChangeCardType("System.xml", "1");
            if (ret == 0)
            {
                //修改成功,注销系统
                Logout();
            }

        }

        private void cPU卡不带EsamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ret = ChangeCardType("System.xml", "2");
            if (ret == 0)
            {
                //修改成功,注销系统
                Logout();
            }
        }

        private void t5704M1卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ret = ChangeCardType("System.xml", "3");
            if (ret == 0)
            {
                //修改成功,注销系统
                Logout();
            }
        }

        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addControl("Client.Main.ManageUserRight");
        }

        private void 菜单配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addControl("Client.Main.ManageMenu");
        }

        private void 所有卡片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int ret = ChangeCardType("System.xml", "0");
            int ret = ChangeCardType(0);
            if (ret == 0)
            {
                //修改成功,注销系统
                Logout();
            }
        }

        private void 其它卡片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int ret = ChangeCardType("System.xml", "0");
            int ret = ChangeCardType(Convert.ToInt32((sender as ToolStripMenuItem).Tag));
            if (ret == 0)
            {
                //修改成功,注销系统
                Logout();
            }
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dlg.ShowConfirmInfo("是否确定要注销？") == DialogResult.Yes)
            {
                Logout();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dlg.ShowConfirmInfo("是否确定要退出系统？") == DialogResult.Yes)
            {
                Close();
            }
        }

        private void TSMenuItemHelp_Click(object sender, EventArgs e)
        {
            string sHelpFileName = string.Format(@"{0}\一卡多表管理系统使用手册.chm", Application.StartupPath);
            string sHelpFileName_PDF = string.Format(@"{0}\一卡多表管理系统使用手册.pdf", Application.StartupPath);
            if (File.Exists(sHelpFileName))
            {
                System.Diagnostics.Process.Start(sHelpFileName);
            }
            else
            {
                if (File.Exists(sHelpFileName_PDF))
                {
                    System.Diagnostics.Process.Start(sHelpFileName_PDF);
                }
                else
                {
                    Dlg.ShowErrorInfoAndHelp(string.Format("帮助文件“{0}”不存在！", sHelpFileName));
                }
            }
        }

        private void PnlClient_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (PnlClient.Controls.Count == 0)
            {
                LblTip.Text = "欢迎使用一卡多表管理系统";
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addControl("Client.Main.FrmModifyPass", "修改当前用户密码");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            TimingFromDbServer();
            timer.Enabled = true;
        }
    }
}
