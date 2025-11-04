using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace StudentScoresApp
{
    public partial class AddStudentForm : Form
    {
        public string StudentName { get; private set; } // Property to hold the student's name
        public List<double> scoresList = new List<double>(); // List to hold the student's scores

        private StringBuilder sbScores = new StringBuilder();

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtScore.Text))
                {
                    MessageBox.Show("Please enter a score.");
                    txtScore.Focus();
                    return;
                }
                else if (double.TryParse(txtScore.Text, out double score))
                {
                    if (score < 0 || score > 100)
                    {
                        MessageBox.Show("Score must be between 0 and 100.");
                        txtScore.SelectAll();
                        txtScore.Focus();
                        return;
                    }
                    // check the length of the string builder before appending a space
                    if (sbScores.Length > 0)
                    {
                        sbScores.Append(" ");
                    }
                    // append the score to the StringBuilder and add to the scores list
                    sbScores.Append(score);
                    scoresList.Add(score);

                    txtScoresDisplay.Text = sbScores.ToString();

                    txtScore.Clear();
                    txtScore.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a numeric score.");
                    txtScore.SelectAll();
                    txtScore.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid format. Please enter a valid number.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number entered is too large or too small.", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                txtScore.Clear();
                txtScore.Focus();
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            // clear the scores list, the StringBuilder, and the display TextBox
            scoresList.Clear();
            sbScores.Clear();
            txtScoresDisplay.Clear();

            txtScore.Clear();
            txtScore.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // set the StudentName property
            StudentName = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(StudentName))
            {
                MessageBox.Show("Please enter the student's name.");
                txtName.Focus();
                return;
            }

            foreach (char c in StudentName)
            {
                if (char.IsDigit(c) || char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    MessageBox.Show("Name cannot contain numbers, punctuation, or symbols.");
                    txtName.Focus();
                    return;
                }
            }

            
            // set the DialogResult to OK and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // set the DialogResult to Cancel and close the form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
