namespace grade_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int score = Convert.ToInt32(textBox1.Text);
                string grade = "";

                if (score >= 76 && score <= 79)
                    grade = "B";
                else if (score >= 80 && score <= 84)
                    grade = "B+";
                else if (score >= 85 && score <= 89)
                    grade = "A";
                else if (score >= 90 && score <= 100)
                    grade = "A+";

                MessageBox.Show("Your grade is: " + grade);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid test score.");
            }
        }
    }
}