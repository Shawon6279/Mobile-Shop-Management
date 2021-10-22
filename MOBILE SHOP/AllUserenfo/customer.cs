using MOBILE_SHOP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOBILE_SHOP.AllUserenfo
{
    public partial class customer : UserControl
    {
        new_mobile nb = new new_mobile();
        string query;
        public customer()
        {
            InitializeComponent();
        }
        public void setcombobox(string query,ComboBox combo) //to fill up the combobox with distinct modelname automatically
        {
            SqlDataReader sdr = nb.getforcombo(query);
            while(sdr.Read())
            {
                for (int i= 0; i< sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }

            }
        }
        private void customer_Enter(object sender, EventArgs e) //to fill up the combobox of company_name automatically
        {
            companyname.Items.Clear();
            query = "select distinct c_name from add_mobile";
            setcombobox(query, companyname);
           
        }
        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Enter(object sender, EventArgs e)
        {

        }

        private void setcombobox(string query, string companyName)
        {
            throw new NotImplementedException();
        }

        private void customer_Load(object sender, EventArgs e)
        {
             
        }

        private void companyname_SelectedIndexChanged(object sender, EventArgs e) //to select the model of that company name which has been selected already 
        {
            modelname.Items.Clear();
            string c_name = companyname.Text;
            query= "select m_name from add_mobile where c_name='"+c_name+"'";
            setcombobox(query, modelname);
        }

        private void modelname_SelectedIndexChanged(object sender, EventArgs e)  //to fill up the rectangular shape 
        {
            query = "select * from add_mobile where m_name='" + modelname.Text + "'";
            DataSet ds = nb.getinformation(query);

            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
            rearlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            frontlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            fingerprintlabel.Text = ds.Tables[0].Rows[0][9].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][12].ToString(); 
        }

        private void purchaseitem_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && gender.Text != "" && contactnumber.Text != "" && emailid.Text != "" && address.Text != "" && companyname.Text != "" && modelname.Text != "" && imei.Text != "")
            {
                string nam = name.Text;
                string gend = gender.Text;
                Int64 cntct = Int64.Parse(contactnumber.Text);
                string eml = emailid.Text;
                string addr = address.Text;
                string comp = companyname.Text;
                string mdl = modelname.Text;
                string ime = imei.Text;

                query = " insert into purchasephone (c_name,gender,contact,email,c_address,company,model,imei) values ('" + nam + "','" + gend + "'," + cntct + ",'" + eml + "','" + addr + "','" + comp + "','" + mdl + "','" + ime + "')";
                nb.setdata(query);
                
                name.Clear();
                gender.SelectedIndex = -1;
                contactnumber.Clear();
                emailid.Clear();
                address.Clear();
                imei.Clear();
            }
            else
            {
                MessageBox.Show("Fill All the Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }
    }
}
