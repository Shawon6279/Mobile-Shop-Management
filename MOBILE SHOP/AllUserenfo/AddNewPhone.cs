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
    public partial class AddNewPhone : UserControl
    {
        new_mobile nb = new new_mobile();  //object of new_mobile class
        string query;
        public AddNewPhone()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddNewPhone_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void svbtn_Click(object sender, EventArgs e)
        {
            if (companyname.Text != "" && modelname.Text != "" && ramsize.Text != "" && romsize.Text != "" && expndblmemorysize.Text != "" && dsplysize.Text != "" && camera.Text != "" && frontcamera.Text != "" && fngrprinttxt.Text != "" && simtp.Text != "" && ntwktxt.Text != "" && pricetg.Text != "")
            {
                string company = companyname.Text;
                string model = modelname.Text;
                string ram = ramsize.Text;
                string rom = romsize.Text;
                string expndbl = expndblmemorysize.Text;
                string display = dsplysize.Text;
                string cam = camera.Text;
                string frontcam = frontcamera.Text;
                string fngrprnt = fngrprinttxt.Text;
                string sim = simtp.Text;
                string network = ntwktxt.Text;
                Int64 price = Int64.Parse(pricetg.Text);

                query = "insert into add_mobile( c_name,m_name,ram_size,rom,expandable,display,rear_camera,front_camera,fngr_print,sim,network,price) values('" + company + "','" + model + "','" + ram + "','" + rom + "','" + expndbl + "','" + display + "','" + cam + "','" + frontcam + "','" + fngrprnt + "','" + sim + "','" + network + "'," + price + ")";
                nb.setdata(query);
            }
            else
            {
                MessageBox.Show("Fill All The Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rstbtn_Click(object sender, EventArgs e)  //reset button
        {
            companyname.Clear();
            modelname.Clear();
            ramsize.StartIndex = -1;
            romsize.StartIndex = -1;
            expndblmemorysize.StartIndex = -1;
            dsplysize.StartIndex = -1;
            camera.StartIndex = -1;
            frontcamera.StartIndex = -1;
            fngrprinttxt.StartIndex = -1;
            simtp.StartIndex = -1;
            ntwktxt.StartIndex = -1;
            pricetg.Clear();
        }
    }
}
