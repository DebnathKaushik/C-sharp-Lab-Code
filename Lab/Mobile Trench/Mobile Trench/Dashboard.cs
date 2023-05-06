using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Trench
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            enableDisable(false, false, false);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uC_AddNewPhone1_Load(object sender, EventArgs e)
        {
            uC_AddNewPhone1.Visible = false;
        }

        private void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            uC_AddNewPhone1.Visible = true;
            uC_AddNewPhone1.BringToFront();
        }

        private void customer1_Load(object sender, EventArgs e)
        {
            customer1.Visible = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customer1.Visible = true;
            customer1.BringToFront();
        }

        private void btnCustomerRecords_Click(object sender, EventArgs e)
        {
            uC_CustomerRecords1.Visible = true;
            uC_CustomerRecords1.BringToFront();
        }

        private void btnDeletePhoneRecords_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            enableDisable(true, true, true);
        }


        private void uC_Stock1_Load(object sender, EventArgs e)
        {
            uC_Stock1.Visible = false;
        }


        private void btnStock_Click_1(object sender, EventArgs e)
        {
            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();
        }

        private void uC_CustomerRecords1_Load(object sender, EventArgs e)
        {
            uC_CustomerRecords1.Visible = false;
        }
        // ===
        public void enableDisable(Boolean txtbox, Boolean btn1, Boolean btn2)
        {
            txtPassword.Visible = txtbox;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
        }
        // ===
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //btnAddNewPhone.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            enableDisable(false, false, false);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "text")
            {
                panel2.Enabled = true;
                uC_DeletePhoneRecord1.Visible = true;
                uC_DeletePhoneRecord1.BringToFront();
                enableDisable(false, false, false);
                txtPassword.Clear();
            }
            else
            {
                txtPassword.Clear();
            }
        }

        private void uC_DeletePhoneRecord1_Load(object sender, EventArgs e)
        {
            uC_DeletePhoneRecord1.Visible = false;
        }
    }


}
