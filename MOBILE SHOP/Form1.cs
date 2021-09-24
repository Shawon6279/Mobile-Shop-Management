using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOBILE_SHOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addNewPhone1.Visible = false;
            customer1.Visible = false;
        }

        private void addNewPhone1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewPhone_Click(object sender, EventArgs e)
        {
            addNewPhone1.Visible = true;
            addNewPhone1.BringToFront();
        }

        private void MINIMIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerbutton_Click(object sender, EventArgs e)
        {
            customer1.Visible = true;
            customer1.BringToFront();
        }
    }
}
