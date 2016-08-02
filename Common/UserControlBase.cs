using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using Soft.Common;

namespace Common
{
    public partial class UserControlBase : UserControl
    {
        public UserControlBase()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UserControlBase_DoubleClick(object sender, EventArgs e)
        {
            if ((ModifierKeys & Keys.Control) == Keys.Control)
            {
                FileVersionInfo FileVerInfo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                string sInfo = string.Format("程序集版本：{0}\n   产品版本：{1}\n   文件版本：{2}", Assembly.GetExecutingAssembly().GetName().Version
                                                                                               , FileVerInfo.ProductVersion, FileVerInfo.FileVersion);
                Dlg.ShowOKInfo(sInfo);
            }
        }
    }
}
