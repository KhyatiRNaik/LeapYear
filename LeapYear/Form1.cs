namespace LeapYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int years;

            LeapYear ly = new LeapYear();

            years = Convert.ToInt32(textBox1.Text);

            if (ly.getLeapYear(years) == 1)
                MessageBox.Show("It is a leap year!!!", "Leap Year");
            else
                MessageBox.Show("It is a not leap year!!!", "Not Leap Year");

            textBox1.Clear();
            textBox1.Focus();

        }
    }
}