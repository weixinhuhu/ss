using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormPager
{
    public partial class DgvNav : BindingNavigator
    {
        
        public int PageSize {
            set
            {
                if (value < 1)
                    return;
                if (PageSizeItem == null)
                    return;
                if (Convert.ToInt32(PageSizeItem.Text) == value)
                    return;

                PageSizeItem.Text = value.ToString();
                //InitPage();
            }
            get
            {
                if (PageSizeItem==null)
                {
                    return 100;
                }
                if (string.IsNullOrEmpty(PageSizeItem.Text))
                    return 100;
                if (Convert.ToInt32(PageSizeItem.Text) == 0)
                    return 100;
                
                return  Convert.ToInt32(PageSizeItem.Text);
            }
        }

        public BindingSource MyBs { set; get; }


        private int CurrentPage
        {
            get
            {
                return Convert.ToInt32(PositionItem.Text);
            }
            set { PositionItem.Text = value.ToString(); }
        }

        private int PageCount
        {
            get { return Convert.ToInt32(CountItem.Text.Replace("/", "")); }
            set
            {
                CountItem.Text = string.Format("/ {0}", value);
            }
        }

        private string _originSql;
        public string OriginSql
        {
            set
            {
                if (value == string.Empty)
                    return;
                if (Conn == null)
                    return;
                if (string.IsNullOrEmpty(OrderField))
                    OrderField = "Id";

                _originSql = value;
                InitPage();
                SetPageData();
                InitEvents();
            }
            get { return _originSql; }
        }
        public string OrderField { set; get; }
        public string OrderDirection { set; get; }
        public string PrimaryKey { set; get; }

        public string ComparyChar { set; get; }
        public SqlConnection Conn { set; get; }

        public int TotalCount { set; get; }

        private ToolStripItem pageSizeItem;

        public ToolStripItem PageSizeItem {
            set { pageSizeItem = value; }
            get { return pageSizeItem; }
        }

        private IQueryable<object> _dataSource;
        public IQueryable<object> DataSource
        {
            set
            {
                if (value == null)
                    return;
                
                _dataSource = value;
                InitPage();
                SetPageData();
                InitEvents();
            }
            get
            {
                return _dataSource;
            }
        }

        private void InitPage()
        {
            
            if (DataSource != null)
            {
                TotalCount = DataSource.Count();//获取总数
            }
            else
            {
                TotalCount = GetRecordCount();//获取总行数
            }
            if (PageSize == 0)
                PageSize = 100;
            PageCount = TotalCount / PageSize;//获取页数
            if ((TotalCount % PageSize) > 0)
                PageCount++;
            CurrentPage = 1;
            
        }

        public DgvNav()
        {
            InitializeComponent();
        }

        

        public DgvNav(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }


        public override void AddStandardItems()
        {

            //
            // Create items
            //

            MoveFirstItem = new System.Windows.Forms.ToolStripButton();

            MovePreviousItem = new System.Windows.Forms.ToolStripButton();

            MoveNextItem = new System.Windows.Forms.ToolStripButton();

            MoveLastItem = new System.Windows.Forms.ToolStripButton();

            PositionItem = new System.Windows.Forms.ToolStripTextBox();
            CountItem = new System.Windows.Forms.ToolStripLabel();
            AddNewItem = new System.Windows.Forms.ToolStripButton();
            DeleteItem = new System.Windows.Forms.ToolStripButton();
            PageSizeItem = new System.Windows.Forms.ToolStripTextBox();
            
            ToolStripSeparator separator1 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripSeparator separator2 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripSeparator separator3 = new System.Windows.Forms.ToolStripSeparator();

            //
            // Set up strings
            //

            // Hacky workaround for VSWhidbey 407243
            // Default to lowercase for null name, because C# dev is more likely to create controls programmatically than
            // vb dev.
            GripStyle = ToolStripGripStyle.Hidden;

            char ch = string.IsNullOrEmpty(Name) || char.IsLower(Name[0]) ? 'b' : 'B';

            MoveFirstItem.Name = ch + "indingNavigatorMoveFirstItem";
            MovePreviousItem.Name = ch + "indingNavigatorMovePreviousItem";
            MoveNextItem.Name = ch + "indingNavigatorMoveNextItem";
            MoveLastItem.Name = ch + "indingNavigatorMoveLastItem";
            PositionItem.Name = ch + "indingNavigatorPositionItem";
            CountItem.Name = ch + "indingNavigatorCountItem";
            PageSizeItem.Name = ch + "indingNavigatorPageSizeItem";
            AddNewItem.Name = ch + "indingNavigatorAddNewItem";
            DeleteItem.Name = ch + "indingNavigatorDeleteItem";
            separator1.Name = ch + "indingNavigatorSeparator";
            separator2.Name = ch + "indingNavigatorSeparator";
            separator3.Name = ch + "indingNavigatorSeparator";
            

            MoveFirstItem.Text = "第一页";
            MovePreviousItem.Text = "上一页";
            MoveNextItem.Text = "下一页";
            MoveLastItem.Text = "最后一页";

            AddNewItem.Text = "添加";


            CountItem.ToolTipText = "总页数";
            PositionItem.ToolTipText = "当前页";
            PageSizeItem.ToolTipText = "每页显示数量";
            CountItem.AutoToolTip = false;
            PositionItem.AutoToolTip = false;
            PageSizeItem.AutoToolTip = false;
            PageSizeItem.Text = "100";
            PositionItem.AccessibleName = "BindingNavigatorPositionAccessibleName";
            //
            // Set up images
            //

            Bitmap moveFirstImage = new Bitmap(typeof(BindingNavigator), "BindingNavigator.MoveFirst.bmp");
            Bitmap movePreviousImage = new Bitmap(typeof(BindingNavigator), "BindingNavigator.MovePrevious.bmp");
            Bitmap moveNextImage = new Bitmap(typeof(BindingNavigator), "BindingNavigator.MoveNext.bmp");
            Bitmap moveLastImage = new Bitmap(typeof(BindingNavigator), "BindingNavigator.MoveLast.bmp");
            Bitmap addNewImage = new Bitmap(typeof(BindingNavigator), "BindingNavigator.AddNew.bmp");
            Bitmap deleteImage = new Bitmap(typeof(BindingNavigator), "BindingNavigator.Delete.bmp");

            moveFirstImage.MakeTransparent(System.Drawing.Color.Magenta);
            movePreviousImage.MakeTransparent(System.Drawing.Color.Magenta);
            moveNextImage.MakeTransparent(System.Drawing.Color.Magenta);
            moveLastImage.MakeTransparent(System.Drawing.Color.Magenta);
            addNewImage.MakeTransparent(System.Drawing.Color.Magenta);
            deleteImage.MakeTransparent(System.Drawing.Color.Magenta);

            MoveFirstItem.Image = moveFirstImage;
            MovePreviousItem.Image = movePreviousImage;
            MoveNextItem.Image = moveNextImage;
            MoveLastItem.Image = moveLastImage;
            AddNewItem.Image = addNewImage;
            DeleteItem.Image = deleteImage;

            MoveFirstItem.RightToLeftAutoMirrorImage = true;
            MovePreviousItem.RightToLeftAutoMirrorImage = true;
            MoveNextItem.RightToLeftAutoMirrorImage = true;
            MoveLastItem.RightToLeftAutoMirrorImage = true;
            AddNewItem.RightToLeftAutoMirrorImage = true;
            DeleteItem.RightToLeftAutoMirrorImage = true;

            MoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            MovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            MoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            MoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;

            //
            // Set other random properties
            //
            PositionItem.AutoSize = false;
            PositionItem.Width = 50;

            PageSizeItem.AutoSize = false;
            PageSizeItem.Width = 50;
            //
            // Add items to strip
            //

            Items.AddRange(new[] {
                                MoveFirstItem,
                                MovePreviousItem,
                                separator1,
                                PositionItem,
                                CountItem,
                                PageSizeItem,
                                separator2,
                                MoveNextItem,
                                MoveLastItem,
                                separator3,
                                AddNewItem
                                });
        }

        private void MoveFirstItem_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            SetPageData();
        }

        private void InitEvents()
        {
            if (MoveFirstItem != null) MoveFirstItem.Click -= MoveFirstItem_Click;
            if (MovePreviousItem != null) MovePreviousItem.Click -= MovePreviousItem_Click;
            if (MoveNextItem != null) MoveNextItem.Click -= MoveNextItem_Click;
            if (MoveLastItem != null) MoveLastItem.Click -= MoveLastItem_Click;

            if (MoveFirstItem != null) MoveFirstItem.Click += MoveFirstItem_Click;
            if (MovePreviousItem != null) MovePreviousItem.Click += MovePreviousItem_Click;
            if (MoveNextItem != null) MoveNextItem.Click += MoveNextItem_Click;
            if (MoveLastItem != null) MoveLastItem.Click += MoveLastItem_Click;

            if (PositionItem != null)
            {
                ToolStripControlHost mCtrl = PositionItem as ToolStripControlHost;
                var keyUpHandler = new KeyEventHandler(OnPositionKey);
                var lostFocusHandler = new EventHandler(OnPositionLostFocus);

                mCtrl.KeyUp -= keyUpHandler;
                mCtrl.LostFocus -= lostFocusHandler;

                mCtrl.KeyUp += keyUpHandler;
                mCtrl.LostFocus += lostFocusHandler;
            }

            if (PageSizeItem != null)
            {
                ToolStripControlHost mCtrl = PageSizeItem as ToolStripControlHost;
                var keyUpHandler = new KeyEventHandler(OnPageSizeKey);
                //var lostFocusHandler = new EventHandler(OnPageSizeLostFocus);

                mCtrl.KeyUp -= keyUpHandler;
               // mCtrl.LostFocus -= lostFocusHandler;

                mCtrl.KeyUp += keyUpHandler;
                //mCtrl.LostFocus += lostFocusHandler;
            }
        }

        private void MovePreviousItem_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            SetPageData();
        }

        private void MoveNextItem_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            SetPageData();
        }

        private void MoveLastItem_Click(object sender, EventArgs e)
        {
            CurrentPage = PageCount;
            SetPageData();
        }

        private void SetPageData()
        {
            if (CurrentPage > PageCount)
            {
                CurrentPage = PageCount;
            }
            if (CurrentPage < 1)
                CurrentPage = 1;
            if (DataSource != null) //ef 方式
            {
                if (MyBs != null)
                {
                    MyBs.DataSource =
                        DataSource.OrderBy(a => "").Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
                    //dgv.DataSource = bs;
                    
                }
            }
            else if (OriginSql != string.Empty) //sql查询方式
            {
                if (MyBs != null)
                {
                    string resultSql = ManageSql();
                    MyBs.DataSource = GetRecord(resultSql);
                }
            }
            SetRoleNavigatorState();
        }

        private string ManageSql()
        {
            CompareInfo compare = CultureInfo.InvariantCulture.CompareInfo;
            int selectIndex = compare.IndexOf(OriginSql, "select ", CompareOptions.IgnoreCase);
            //判断是否有select,有：+7
            if (selectIndex > -1)
                selectIndex += 7;
            else
                return "";
            

            //select top x orderFiled from table
            string startSql = OriginSql.Insert(selectIndex, string.Format(@" row_Number() over (order by {0} {1}) rowNum, ", OrderField, OrderDirection));

            startSql = string.Format("select * from ({0})result where rowNum >{1} and rowNum <={2}", startSql,
                (CurrentPage - 1)*PageSize, CurrentPage*PageSize);

            return startSql;
        }

        //private string ManageSqlPrimaryKey()
        //{
        //    CompareInfo compare = CultureInfo.InvariantCulture.CompareInfo;
        //    int selectIndex = compare.IndexOf(OriginSql, "select ", CompareOptions.IgnoreCase);
        //    //判断是否有select,有：+7
        //    if (selectIndex > -1)
        //        selectIndex += 7;
        //    else
        //        return "";
        //    //判断是否有from,无：退出
        //    int fromIndex = compare.IndexOf(OriginSql, "from ", CompareOptions.IgnoreCase);
        //    if (selectIndex == -1)
        //        return "";

        //    string startSql = OriginSql.Remove(selectIndex, fromIndex - selectIndex);

        //    //select top x orderFiled from table
        //    startSql = startSql.Insert(selectIndex, string.Format(@" top {0} {1} ", (CurrentPage - 1) * PageSize, PrimaryKey));
        //    //判读如果没有order by 就添加order by
        //    if (compare.IndexOf(OriginSql, " order ") == -1 || compare.IndexOf(OriginSql, " by ") == -1)
        //    {
        //        startSql += string.Format(" order by {0} {1}", OrderField, OrderDirection);
        //    }

        //    startSql = string.Format(" {0} {2} (select isnull(max({0}),0) from ({1}) ConditionTable) ", PrimaryKey, startSql, ComparyChar);
        //    string resultSql = OriginSql.Insert(selectIndex, string.Format(" top {0} ", PageSize));
        //    //获取最后一个where
        //    int whereIndex = compare.LastIndexOf(OriginSql, "where ", CompareOptions.IgnoreCase);
        //    if (whereIndex == -1)
        //    {
        //        resultSql += string.Format(" where {0} order by {1} {2} ", startSql, OrderField, OrderDirection);
        //    }
        //    else
        //    {
        //        resultSql += string.Format(" and {0} order by {1} {2} ", startSql, OrderField, OrderDirection);
        //    }
        //    return resultSql;
        //}

        private void SetRoleNavigatorState()
        {
            if (MoveFirstItem != null) MoveFirstItem.Enabled = (CurrentPage > 1);
            if (MovePreviousItem != null) MovePreviousItem.Enabled = (CurrentPage > 1);
            if (MoveNextItem != null) MoveNextItem.Enabled = (CurrentPage < PageCount);
            if (MoveLastItem != null) MoveLastItem.Enabled = (CurrentPage < PageCount);
            if (PositionItem != null) PositionItem.Enabled = (CurrentPage > 0 && PageCount > 0);
            if (CountItem != null) CountItem.Enabled = (PageCount > 0);
            //if (PageCount > 0)
            //{
            //    if (CurrentPage == 1)
            //    {
            //        MoveFirstItem.Enabled = false;
            //        MovePreviousItem.Enabled = false;
            //        MoveNextItem.Enabled = true;
            //        MoveLastItem.Enabled = true;
            //    }
            //    else if (CurrentPage == PageCount)
            //    {
            //        MoveFirstItem.Enabled = true;
            //        MovePreviousItem.Enabled = true;
            //        MoveNextItem.Enabled = false;
            //        MoveLastItem.Enabled = false;
            //    }
            //    else
            //    {
            //        MoveFirstItem.Enabled = true;
            //        MovePreviousItem.Enabled = true;
            //        MoveNextItem.Enabled = true;
            //        MoveLastItem.Enabled = true;
            //    }
            //}
            //else if (PageCount <= 1)
            //{

            //    MoveFirstItem.Enabled = false;
            //    MovePreviousItem.Enabled = false;
            //    MoveNextItem.Enabled = false;
            //    MoveLastItem.Enabled = false;
            //}
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected override void RefreshItemsCore()
        {
            int count, position;


            // Get state info from the binding source (if any)
            if (DataSource == null)
            {
                count = 0;
                position = 0;

            }
            else
            {
                count = DataSource.Count();
                position = CurrentPage;

            }

            // Enable or disable items (except when in design mode)
            if (!DesignMode)
            {
                if (MoveFirstItem != null) MoveFirstItem.Enabled = (position > 1);
                if (MovePreviousItem != null) MovePreviousItem.Enabled = (position > 1);
                if (MoveNextItem != null) MoveNextItem.Enabled = (position < count);
                if (MoveLastItem != null) MoveLastItem.Enabled = (position < count);



                if (PositionItem != null) PositionItem.Enabled = (position > 0 && count > 0);
                if (CountItem != null) CountItem.Enabled = (count > 0);
            }

            // Update current position indicator
            if (PositionItem != null)
            {
                PositionItem.Text = position.ToString(CultureInfo.CurrentCulture);
            }

            // Update record count indicator
            if (CountItem != null)
            {
                CountItem.Text = DesignMode ? CountItemFormat : String.Format(CultureInfo.CurrentCulture, CountItemFormat, count);
            }
        }

        protected override void OnRefreshItems()
        {
            // Refresh all the standard items
            RefreshItemsCore();

        }

        private void OnPositionKey(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SetPageData();
                    break;

            }
        }
        private void OnPositionLostFocus(object sender, EventArgs e)
        {
            SetPageData();
        }

        private void OnPageSizeKey(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    InitPage();
                    SetPageData();
                    break;

            }
            if ("0123456789".IndexOf((char) e.KeyValue) < 0)
                e.Handled = true;
        }
        private void OnPageSizeLostFocus(object sender, EventArgs e)
        {
            InitPage();
            SetPageData();
        }

        private int GetRecordCount()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                using (var comm = new SqlCommand())
                {
                    comm.Connection = Conn;

                    comm.CommandText = string.Format("select count(1) from ({0}) a", OriginSql);

                    return Convert.ToInt32(comm.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }

        }

        private DataTable GetRecord(string resultSql)
        {
            DataTable mTable = new DataTable();
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(resultSql, Conn))
                {
                    adapter.Fill(mTable);

                }
                return mTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


    }


}
