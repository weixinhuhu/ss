using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client.Main
{
    public partial class UCBase : UserControl
    {
        public UCBase()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {            
            var mLable =this.Parent.Parent.Controls.Find("labTip", true)[0];
            mLable.Text = mLable.Text.Split(">>".ToCharArray())[0];
            this.Parent.Controls.Clear();
            this.Dispose();
        }

        private void UserControlBase_Load(object sender, EventArgs e)
        {
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer
            //           | ControlStyles.ResizeRedraw
            //           | ControlStyles.Selectable
            //           | ControlStyles.AllPaintingInWmPaint
            //           | ControlStyles.UserPaint
            //           | ControlStyles.SupportsTransparentBackColor,
            //         true);
        }
    }
}
