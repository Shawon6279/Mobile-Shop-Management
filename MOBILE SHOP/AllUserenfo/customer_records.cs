using MOBILE_SHOP.Properties;
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
    public partial class customer_records : UserControl
    {
        new_mobile nb = new new_mobile();
        string query;
        public customer_records()
        {
            InitializeComponent();
        }

        private void customer_records_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Boolean flag;
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(searchby.SelectedIndex==0)
            {
                flag = false;
                labeltoset.Text = "Enter Customer Name";
            }
            else
            {
                flag = true;
                labeltoset.Text = "Enter IMEI";
            }
        }

        private void customer_records_Enter(object sender, EventArgs e)
        {
            query = "select * from purchasephone";
            DataSet ds = nb.getinformation(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                query = "select * from purchasephone where c_name like '" + searchtype.Text + "%'";
                DataSet ds = nb.getinformation(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from purchasephone where imei like '" + searchtype.Text + "%'";
                DataSet ds = nb.getinformation(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void customer_records_Enter_1(object sender, EventArgs e)
        {
            query = "select * from purchasephone";
            DataSet ds = nb.getinformation(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
