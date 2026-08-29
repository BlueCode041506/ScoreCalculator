using System;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class scoreCalc : Form
    {
        private int scoreTotal = 0;
        private int scoreCount = 0;

        public scoreCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = int.Parse(scoretxt.Text);

            scoreTotal += score;
            scoreCount++;

            double average = (double)scoreTotal / scoreCount;

            scoreTotalTxt.Text = scoreTotal.ToString();
            scoreCountTxt.Text = scoreCount.ToString();
            averageTxt.Text = average.ToString("F1");

            scoretxt.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            scoreCount = 0;

            scoretxt.Clear();
            scoreTotalTxt.Clear();
            scoreCountTxt.Clear();
            averageTxt.Clear();

            scoretxt.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}