using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOBILE_SHOP.AllUserenfo
{
    public partial class login_page : UserControl
    {
        public login_page()
        {
            InitializeComponent();
            showlabel.Visible = false;
        }

        int abc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            abc++;
            if(abc==10)
            {
                abc = 0;
                if(txtusername.Text=="novice pair"&& txtpassword.Text =="novice pair")
                {
                    this.Hide();
                    timer1.Stop();
                        }
                else
                {
                    panel1.Visible = true;
                    showlabel.Visible = true;
                    timer1.Stop();
                }
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            panel1.Visible = false;
            this.guna2WinProgressIndicator1.Start();
        }
    }
}
