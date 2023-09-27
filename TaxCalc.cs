namespace IncomeCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTI.Text, out decimal income))
            {
                decimal tax;

                if (income <= 9875)
                {
                    tax = income * 0.10m;
                }
                else if (income <= 40125)
                {
                    tax = 9875 * 0.10m + (income - 9875) * 0.12m;
                }
                else
                {
                    tax = 9875 * 0.10m + (40125 - 9875) * 0.12m + (income - 40125) * 0.22m;
                }

                txtITO.Text = tax.ToString("F2"); 
            }
            else
            {
                MessageBox.Show("Please enter a valid decimal value for income.");
            }
        }
    }


}