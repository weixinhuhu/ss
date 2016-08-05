using System;
using System.Linq;

namespace 销售管理.Controls
{
    public partial class DgvPager 
    {
        public int PageSize { set; get; }

        private int CurrentPage
        {
            get
            {
                return Convert.ToInt32(navCurrentPage.Text);
            }
            set { navCurrentPage.Text = value.ToString(); }
        }

        private int PageCount
        {
            get { return Convert.ToInt32(navSumPage.Text); }
            set
            {
                navSumPage.Text = value.ToString();
            }
        }

        public int TotalCount { set; get; }

        private IQueryable<object> _dataSource;
        public IQueryable<object> DataSource
        {
            set
            {
                if (value == null)
                    return;
                if (PageSize == 0)
                    PageSize = 1;
                
                TotalCount = value.Count();//获取总数
                PageCount = TotalCount / PageSize;//获取页数
                if ((TotalCount%PageSize) > 0)
                    PageCount++;
                CurrentPage = 1;
                
                _dataSource = value;
                SetPageData();
            }
            get
            {
                return _dataSource;
            }
        }

        public DgvPager()
        {
            InitializeComponent();

        }

        private void SetPageData()
        {
            if (CurrentPage > PageCount)
            {
                CurrentPage = PageCount;
            }
            if (CurrentPage < 1)
                CurrentPage = 1;
            
            bs.DataSource = DataSource.OrderBy(a=>"").Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
            dgv.DataSource = bs;
            SetRoleNavigatorState();
        }

        private void SetRoleNavigatorState()
        {
            if (PageCount > 0)
            {
                if (CurrentPage == 1)
                {
                    this.navFirstPage.Enabled = false;
                    this.navPrePage.Enabled = false;
                    this.navNextPage.Enabled = true;
                    this.navLastPage.Enabled = true;
                }
                else if (CurrentPage == PageCount)
                {
                    this.navFirstPage.Enabled = true;
                    this.navPrePage.Enabled = true;
                    this.navNextPage.Enabled = false;
                    this.navLastPage.Enabled = false;
                }
                else
                {
                    this.navFirstPage.Enabled = true;
                    this.navPrePage.Enabled = true;
                    this.navNextPage.Enabled = true;
                    this.navLastPage.Enabled = true;
                }
            }
            else if (PageCount <= 1)
            {

                this.navFirstPage.Enabled = false;
                this.navPrePage.Enabled = false;
                this.navNextPage.Enabled = false;
                this.navLastPage.Enabled = false;
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            SetPageData();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            SetPageData();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            SetPageData();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            CurrentPage = PageCount;
            SetPageData();
        }

        private void navCurrentPage_Leave(object sender, EventArgs e)
        {
            SetPageData();
        }

    }
}
