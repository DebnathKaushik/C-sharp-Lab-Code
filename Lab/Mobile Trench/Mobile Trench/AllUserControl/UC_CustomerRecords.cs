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
    public partial class UC_CustomerRecords : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRecords()
        {
            InitializeComponent();
        }

        private void UC_CustomerRecords_Enter(object sender, EventArgs e)
        {
            query = "select * from customerPurchase";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        Boolean flag;
        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                flag = false;
                labelTOSET.Text = "Enter Customer Name";
            }
            else if (txtSearchBy.SelectedIndex == 1)
            {
                flag = true;
                labelTOSET.Text = "Enter IMEI";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                query = "select * from customerPurchase where cname like '" + txtSearch.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from customerPurchase where imei like '" + txtSearch.Text + "%' ";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
