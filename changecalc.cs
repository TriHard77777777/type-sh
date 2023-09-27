namespace ChangeCalc
{
    public partial class Form1 : Form
    {
        int Quarters = 0;
        int Dimes = 0;
        int Nickles = 0;
        int Pennies = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int ChangeDue = Convert.ToInt32(txtChangeDue.Text);

            Quarters = ChangeDue / 25;
            int remainder = ChangeDue % 25;
            Dimes = remainder / 10;
            remainder %= 10;
            Nickles = remainder / 5;
            remainder %= 5;
            Pennies = remainder / 1;

            txtQuarters.Text = Quarters.ToString();
            txtDimes.Text = Dimes.ToString();
            txtNickles.Text = Nickles.ToString();
            txtPennies.Text = Pennies.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}