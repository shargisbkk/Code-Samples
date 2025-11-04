namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        private int scoreTotal = 0;
        private int scoreCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);
            scoreTotal += score;
            scoreCount++;
            double scoreAverage = scoreTotal / scoreCount;

            txtScoreTotal.Text = scoreTotal.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtScoreAverage.Text = scoreAverage.ToString();

            txtScore.Clear();
            txtScore.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            scoreCount = 0;

            txtScore.Clear();
            txtScoreTotal.Clear();
            txtScoreCount.Clear();
            txtScoreAverage.Clear();
            txtScore.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
