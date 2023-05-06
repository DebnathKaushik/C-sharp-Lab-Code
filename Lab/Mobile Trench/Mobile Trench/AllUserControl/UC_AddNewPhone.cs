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
        }

        private void txtInternal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtExpandable_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtRear_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtFingerprint_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtSim_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtNetwork_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
