namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
       
        int ST = 0;
        int SC;
        int A;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Score = Convert.ToInt32(txtScore.Text);

            ST += Score;
            SC++;
            A = Score + ST + SC;
            A /= 3;

            txtScoreTotal.Text = ST.ToString();
            txtScoreCount.Text = SC.ToString();
            txtAverage.Text = A.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            ST = 0;
            SC = 0;
            A = 0;

            txtScoreTotal.Text = ST.ToString();
            txtScoreCount.Text = SC.ToString();
            txtAverage.Text = A.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}