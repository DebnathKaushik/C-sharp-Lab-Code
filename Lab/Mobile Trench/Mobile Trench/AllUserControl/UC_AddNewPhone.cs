using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Trench.AllUserControl
{
    public partial class UC_AddNewPhone : UserControl
    {
        function fn = new function();
        String query;
        private object txtIntenal;
        private object txtExpendable;

        public UC_AddNewPhone()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddNewPhone_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIndex = txtFront.Text;


            if (selectedIndex == "8 MP")
            {
                CalculatePrice(10);
            }
            else if (selectedIndex == "18 MP")
            {

                CalculatePrice(20);
            }
            else if (selectedIndex == "32 MP")
            {
                CalculatePrice(30);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompany.Clear();
            txtModel.Clear();
            txtRam.StartIndex = -1;
            txtInternal.StartIndex = -1;
            txtExpandable.StartIndex = -1;
            txtDisplay.StartIndex = -1;
            txtFingerprint.StartIndex = -1;
            txtRear.StartIndex = -1;
            txtFront.StartIndex = -1;
            txtSim.StartIndex = -1;
            txtNetwork.StartIndex = -1;
            txtPrice2.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text != "" && txtModel.Text != "" && txtRam.Text != "" && txtInternal.Text != "" && txtExpandable.Text != "" && txtDisplay.Text != "" && txtRear.Text != "" && txtFront.Text != "" && txtFingerprint.Text != "" && txtSim.Text != "" && txtNetwork.Text != "" && txtPrice2.Text != "")
            {
                String company = txtCompany.Text;
                String model = txtModel.Text;
                String ram = txtRam.Text;
                String intel = txtInternal.Text;
                String display = txtDisplay.Text;
                String expandable = txtExpandable.Text;
                String rear = txtRear.Text;
                String front = txtFront.Text;
                String sim = txtSim.Text;
                String network = txtNetwork.Text;
                Int64 price = Int64.Parse(txtPrice2.Text);
                String fingerprint = txtFingerprint.Text;





                query = "insert into newMobile (cname,mname,ram,internal,expandable,display,rear,front,finger,sim,network,price) values('" + company + "','" + model + "','" + ram + "','" + intel + "','" + expandable + "','" + display + "','" + rear + "','" + front + "','" + fingerprint + "','" + sim + "','" + network + "'," + price + ")";
                fn.setdata(query);
                txtCompany.Clear();
                txtModel.Clear();
                txtRam.SelectedIndex = -1;
                txtInternal.SelectedIndex = -1;
                txtDisplay.SelectedIndex = -1;
                txtExpandable.SelectedIndex = -1;
                txtRear.SelectedIndex = -1;
                txtFront.SelectedIndex = -1;
                txtSim.SelectedIndex = -1;
                txtNetwork.SelectedIndex = -1;
                txtFingerprint.SelectedIndex = -1;
                txtPrice2.Clear();
            }
            else
            {
                MessageBox.Show("Fill All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
        }






        private void txtRam_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedIndex = txtRam.Text;

            if (selectedIndex == "4 GB")
            {
                CalculatePrice(4);
            }
            else if (selectedIndex == "8 GB")
            {
                CalculatePrice(8);
            }
            else if (selectedIndex == "16 GB")
            {
                CalculatePrice(16);
            }
            else if (selectedIndex == "32 GB")
            {
                CalculatePrice(32);
            }
        }

        private void txtInternal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIndex = txtInternal.Text;

            if (selectedIndex == "8 GB")
            {
                CalculatePrice(8);
            }
            else if (selectedIndex == "16 GB")
            {
                CalculatePrice(16);
            }
            else if (selectedIndex == "32 GB")
            {
                CalculatePrice(32);
            }
            else if (selectedIndex == "64 GB")
            {
                CalculatePrice(64);
            }
            else if (selectedIndex == "128 GB")
            {
                CalculatePrice(128);
            }
            else if (selectedIndex == "512 GB")
            {
                CalculatePrice(512);
            }
        }

        private void txtExpandable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIndex = txtExpandable.Text;

            if (selectedIndex == "No Expendable Memory")
            {
                CalculatePrice(5);
            }
            else if (selectedIndex == "128 GB")
            {
                CalculatePrice(10);
            }
            else if (selectedIndex == "256 GB")
            {
                CalculatePrice(15);
            }
            else if (selectedIndex == "512 GB")
            {
                CalculatePrice(20);
            }
            else if (selectedIndex == "1 TB")
            {
                CalculatePrice(25);
            }

        }

        private void txtDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIndex = txtDisplay.Text;

            if (selectedIndex == "5.0 inch")
            {
                CalculatePrice(10);
            }
            else if (selectedIndex == "5.2 inch")
            {
                CalculatePrice(20);
            }
            else if (selectedIndex == "5.5 inch")
            {
                CalculatePrice(50);
            }
            else if (selectedIndex == "6.0 inch")
            {
                CalculatePrice(60);
            }
            else if (selectedIndex == "6.5 inch")
            {
                CalculatePrice(70);
            }
            else if (selectedIndex == "6.9 inch")
            {
                CalculatePrice(80);
            }
        }

        private void txtRear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIndex = txtRear.Text;

            if (selectedIndex == "8 MP")
            {
                CalculatePrice(10);
            }
            else if (selectedIndex == "16 MP")
            {
                CalculatePrice(20);
            }
            else if (selectedIndex == "32 MP")
            {
                CalculatePrice(30);
            }
            else if (selectedIndex == "64 MP")
            {
                CalculatePrice(40);
            }
            else if (selectedIndex == "108 MP")
            {
                CalculatePrice(50);
            }



        }

        private void txtFingerprint_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIndex = txtFingerprint.Text;

            if (selectedIndex == "Yes")
            {
                CalculatePrice(15);
            }
            else if (selectedIndex == "No")
            {
                CalculatePrice(1);
            }
        }



        private void txtSim_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtNetwork_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void CalculatePrice(int val)
        {
            int ramPrice, internalPrice, displayPrice, expandablePrice, rearPrice, frontPrice, fingerprintPrice;
            int basePrice = 10000;

            ramPrice = val * 3;
            internalPrice = val * 4;
            displayPrice = val * 5;
            expandablePrice = val * 6;
            rearPrice = val * 7;
            frontPrice = val * 8;
            fingerprintPrice = val * 9;
            

            int totalPrice = basePrice + ramPrice + internalPrice + displayPrice + expandablePrice + rearPrice + frontPrice + fingerprintPrice;
            txtPrice2.Text = totalPrice.ToString();
        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
