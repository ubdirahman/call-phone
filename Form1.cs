using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace call_phone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetPhoneData(CellPhone phone)
        {
            // Temporary variable to hold the price.
            decimal price;

            // Get the phone's brand.
            phone.Brand = brandtxt.Text;

            // Get the phone's model.
            phone.Model = modeltxt.Text;

            // Get the phone's price.
            if (decimal.TryParse(pricetxt.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid price");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // Create a CellPhone object.
            CellPhone myPhone = new CellPhone();

            // Get the phone data.
            GetPhoneData(myPhone);

            // Display the phone data.
            brandlbl.Text = myPhone.Brand;
            modellbl.Text = myPhone.Model;
            pricelbl.Text = myPhone.Price.ToString("c");

           
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();

            // Get the phone data.
            GetPhoneData(myPhone);

            // Display the phone data.
            brandlbl.Text = myPhone.Brand;
            modellbl.Text = myPhone.Model;
            pricelbl.Text = myPhone.Price.ToString("c");

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modellbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void brandlbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pricelbl_TextChanged(object sender, EventArgs e)
        {

        }
    } }
