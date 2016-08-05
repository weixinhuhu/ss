using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 销售管理
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void m_SplashPictureBox_Click(object sender, EventArgs e)
        {
             
          //m_SplashPictureBox.Image = splashImage;
      ClientSize =  m_SplashPictureBox.Size;
     
  
   //Rest of the implementation 
        }
      
    }
}
