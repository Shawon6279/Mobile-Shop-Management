using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBILE_SHOP.Properties
{
    class new_mobile
    {
        protected SqlConnection getconnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = DESKTOP-DOCT0BV\\SQLEXPRESS; database = mobile_shop_management;integrated security= True ";
            return conn;
        }

        public DataSet getinformation(string query)
        {
            SqlConnection conn = getconnection();
            SqlCommand cmd= new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter d1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            d1.Fill(ds1);
            return ds1;


        }

        public void setdata(string query)
        {
            SqlConnection conn = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Executed successfully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
