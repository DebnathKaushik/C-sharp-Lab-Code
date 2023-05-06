namespace Mobile_Trench
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
        }

        private void dashboard2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}