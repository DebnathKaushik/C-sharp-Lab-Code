using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TheArtOfDevHtmlRenderer.Adapters;


namespace Mobile_Trench.AllUserControl
{
    public partial class Customer : UserControl
    {
        function fn = new function();
        String query;
        public Customer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ==========

        public void setComboBox(String query, System.Windows.Forms.ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query); // select model from newMobile
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Enter(object sender, EventArgs e)
        {
            txtCompany.Items.Clear();
            query = "select distinct cname from newMobile";
            setComboBox(query, txtCompany);
        }

        private void txtCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModel.Items.Clear();
            String cname = txtCompany.Text;
            query = " select mname from newMobile where cname = '" + cname + "' ";
            setComboBox(query, txtModel);
        }

        private void txtModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = " select * from newMobile where mname = '" + txtModel.Text + "'  ";
            DataSet ds = fn.getData(query);

            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
            rearlabel.Text = ds.Tables[0].Rows[0][6].ToString();
            frontlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            fingerprintlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][12].ToString();




        }

        private void btnPurchase_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtCompany.Text != "" && txtModel.Text != "" && txtImei.Text != "")
            {
                String name = txtName.Text;
                String gender = txtGender.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;
                String address = txtAddress.Text;
                String company = txtCompany.Text;
                String model = txtModel.Text;
                String imei = txtImei.Text;


                query = "insert into customerPurchase (cname, gender, contact, email, caddress, company, model, imei) values('" + name + "','" + gender + "','" + contact + "','" + email + "','" + address + "','" + company + "','" + model + "','" + imei + "')";
                fn.setdata(query);
                txtName.Clear();
                txtGender.SelectedIndex = -1;
                txtContact.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtImei.Clear();
            }
            else
            {
                MessageBox.Show("Fill all the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
