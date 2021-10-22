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
    public partial class stock : UserControl
    {
        new_mobile nb = new new_mobile();
        string query;
        public stock()
        {
            InitializeComponent();
        }

        private void stock_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void stock_Enter(object sender, EventArgs e)  //to show the data into datagridview of all mobiles information
        {
            query = " select * from add_mobile";
            DataSet ds= nb.getinformation(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void searchbutton_CheckedChanged(object sender, EventArgs e)  //for search button
        {
            query = "Select * from add_mobile where c_name like '" + txtcompanysearch.Text + "%'";
            DataSet ds = nb.getinformation(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            //txtcompanysearch.Clear();
        }

        int bid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)  //to show the the in a rectangular shape of that clicked row
        {
            if(guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select * from add_mobile where m_id=" + bid + "";
            DataSet ds = nb.getinformation(query);
            companylabel.Text = ds.Tables[0].Rows[0][1].ToString();
            modellabel.Text = ds.Tables[0].Rows[0][2].ToString();
            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
           displaylabel.Text = ds.Tables[0].Rows[0][6].ToString();
            rearlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            frontlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            fingerlabel.Text = ds.Tables[0].Rows[0][9].ToString();
            simlabel.Text = ds.Tables[0].Rows[0][10].ToString();
            networklabel.Text = ds.Tables[0].Rows[0][11].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][12].ToString();

        }

       
    }
}
