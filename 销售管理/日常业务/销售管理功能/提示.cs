using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 销售管理.日常业务.销售管理功能
{
    public partial class 提示 : 销售管理.Main.FormBase
    {
        public 提示()
        {
            InitializeComponent();
        }

        private void 提示_Load(object sender, EventArgs e)
        {
            GetAllTips();
        }

        /// <summary>
        /// 获取所有代办事宜个数
        /// </summary>
        private void GetAllTips()
        {
            int giftUnAuditCount = BLL.Sa.GetGiftLeaderUnAuditCount();
            int mealUnAuditCount = BLL.Sa.GetMealLeaderUnAuditCount();

            labTips.Text = string.Format("礼品未审核数目:{0}\r\n餐费未审核数目:{1}",giftUnAuditCount,mealUnAuditCount);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
