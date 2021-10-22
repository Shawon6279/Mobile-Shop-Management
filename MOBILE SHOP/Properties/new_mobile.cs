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
        protected SqlConnection getconnection()   //sqlconnection object retun conn
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = DESKTOP-DOCT0BV\\SQLEXPRESS; database = mobile_shop_management;integrated security= True ";
            return conn;
        }

        public DataSet getinformation(string query) //to  get the data from database
        {
            SqlConnection conn = getconnection();
            SqlCommand cmd= new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter d1 = new SqlDataAdapter(cmd); //to store the data in the sqldata
            DataSet ds1 = new DataSet();
            d1.Fill(ds1);
            return ds1;


        }

        public void setdata(string query)  //to insert the data
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

        public SqlDataReader getforcombo(string query)   //to automatically extract the data for combobox for new model
        {
            SqlConnection conn = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr; 
        }

    }
}
