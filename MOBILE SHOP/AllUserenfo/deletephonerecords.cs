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
    public partial class deletephonerecords : UserControl
    {
        new_mobile nb = new new_mobile();
        string query;
        public deletephonerecords()
        {
            InitializeComponent();
        }

        private void deletephonerecords_Enter(object sender, EventArgs e)
        {
            query = "select * from add_mobile";
            DataSet ds = nb.getinformation(query);
            deleteDataGridView1.DataSource = ds.Tables[0];
        }

        private void txtsearchdlt_TextChanged(object sender, EventArgs e)
        {
            query = "select * from add_mobile where c_name like '" + txtsearchdlt.Text + "%' or m_name like '" + txtsearchdlt.Text + "%'";
            DataSet ds = nb.getinformation(query);
            deleteDataGridView1.DataSource = ds.Tables[0];
        
        }

        int bid;
        private void deleteDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if(deleteDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bid = int.Parse(deleteDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "delete from add_mobile where m_id =" + bid + "";
            if(MessageBox.Show("Deleting Record of "+bid+"","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                nb.setdata(query);
            }
            else
            {
                MessageBox.Show("You Cancelled the Operation.", "Back <-", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
