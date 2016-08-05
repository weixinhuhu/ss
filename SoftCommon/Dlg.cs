using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Soft.Common
{
    public class Dlg
    {
        #region  Hint Dialog
        public static void ShowOKInfo(string sInfo)
        {
            MessageBox.Show(sInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowErrorInfo(string sInfo)
        {
            MessageBox.Show(sInfo, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowErrorInfoAndHelp(string sInfo)
        {
            MessageBox.Show(sInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult ShowConfirmInfo(string sInfo)
        {
            return MessageBox.Show(sInfo, "系统询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }        
        public static string InputBox(string _sPrompt,string _sTitle="",string _sDefaultRes="",int _iX=-1,int _iY=-1)
        {
            return Interaction.InputBox(_sPrompt, _sTitle, _sDefaultRes, _iX, _iY);
        }
        #endregion
    }
}
