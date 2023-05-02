namespace Lab_Exam
{
    public partial class Form1 : Form
    {
        int ammount;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ammount = Int32.Parse(textBox1.Text);
                label2_Click(sender, e);
                label3_Click(sender, e);
                label4_Click(sender, e);
                label5_Click(sender, e);
                label6_Click(sender, e);
                label7_Click(sender, e);
                label8_Click(sender, e);
                label9_Click(sender, e);
                label10_Click(sender, e);
                label11_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a numerical number ");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            int amm = ammount * 103;
            label2.Text = amm.ToString() + " $ USD";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            double amm = ammount * 1.25;
            label3.Text = amm.ToString() + " INR";

        }

        private void label4_Click(object sender, EventArgs e)
        {
            double amm = ammount * 76.8;
            label4.Text = amm.ToString() + " POUND";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            double amm = ammount * 17.30;
            label5.Text = amm.ToString() + " YEN";

        }

        private void label6_Click(object sender, EventArgs e)
        {
            double amm = ammount * 86.7;
            label6.Text = amm.ToString() + " EUR";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            double amm = ammount * 22.6;
            label7.Text = amm.ToString() + " RIAL";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            double amm = ammount * 122.6;
            label8.Text = amm.ToString() + " DINER";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = ammount.ToString() + " CFC";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            double amm = ammount * 64.6;
            label10.Text = amm.ToString() + " CAD";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            double amm = ammount * 30.6;
            label11.Text = amm.ToString() + " HKD";
        }
    }
}