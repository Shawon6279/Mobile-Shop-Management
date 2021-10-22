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

        private void Form1_Load(object sender, EventArgs e)  //to hide the user control at first
        {
            panel1.Visible = false;
            addNewPhone1.Visible = false;
            customer1.Visible = false;
            stock1.Visible = false;
            customer_records1.Visible = false;
            deletephonerecords1.Visible = false;
            //btndeletephone.Visible = false;
            
        }

        private void addNewPhone1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)     //for close button
        {
            Application.Exit();
        }

        private void MINIMIZE_Click(object sender, EventArgs e)  //for minimize button
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NewPhone_Click(object sender, EventArgs e) //here uscontrol addnewphone will be visible then it comes in front
        {
            addNewPhone1.Visible = true;
            addNewPhone1.BringToFront();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerbutton_Click(object sender, EventArgs e)  //here uscontrol purchase phone will be visible then it comes in front
        {
            customer1.Visible = true;
            customer1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e) //here uscontrol stock will be visible then it comes in front
        {
            stock1.Visible = true;
            stock1.BringToFront();
        }

        private void btncustomerrecords_Click(object sender, EventArgs e)
        {
            customer_records1.Visible = true;
            customer_records1.BringToFront();
        }

        private void customer_records1_Load(object sender, EventArgs e)
        {

        }

        private void btndeletephone_Click(object sender, EventArgs e)
        {
            deletephonerecords1.Visible = true;
            deletephonerecords1.BringToFront();
        }
        private void login_page1_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            NewPhone.PerformClick();
        }
    }
}
