using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 销售管理.Classes
{
    public class Valid
    {
        public static bool ValidMoneyPositive(string matchString, string strName)
        {
            if (PubFunc.IsMoneyPositive(matchString) == false)
            {
                MessageBox.Show(string.Format("{0}必须为正数", strName), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool ValidMoney(string matchString, string strName)
        {
            if (PubFunc.IsMoney(matchString) == false)
            {
                MessageBox.Show(string.Format("{0}必须为数字", strName), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool ValidIntPositive(string matchString, string strName)
        {
            if (PubFunc.IsIntPositive(matchString) == false)
            {
                MessageBox.Show(string.Format("{0}必须为正整数", strName), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
