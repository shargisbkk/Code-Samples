using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScoresApp
{
    public partial class UpdateScoreForm : Form
    {

        public UpdateScoreForm(double score)
        {
            InitializeComponent();

            // Initialize the textbox with the current score
            txtScore.Text = score.ToString("F2");
            // Select all text in the textbox for easy editing
            txtScore.SelectAll();
            txtScore.Focus();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtScore.Text))
                {
                    MessageBox.Show("Please enter a score.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtScore.Focus();
                    return;
                }
                if (double.TryParse(txtScore.Text, out double updatedScore))
                {
                    if (updatedScore < 0 || updatedScore > 100)
                    {
                        MessageBox.Show("Score must be between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtScore.SelectAll();
                        txtScore.Focus();
                        return;
                    }
                    this.Tag = updatedScore; // Store the updated score in the Tag property
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric score.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
