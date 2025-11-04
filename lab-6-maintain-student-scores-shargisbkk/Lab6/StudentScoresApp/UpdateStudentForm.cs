using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentScoresApp.StudentScoresForm;

namespace StudentScoresApp
{
    public partial class UpdateStudentForm : Form
    {
        public Student StudentToUpdate { get; set; }

        public UpdateStudentForm(Student originalStudent) // Constructor that takes the original student to be updated
        {
            InitializeComponent();
            // create a copy of the original student to work with
            StudentToUpdate = new Student(originalStudent);

            // populate the Name textbox with the student's current name
            txtName.Text = StudentToUpdate.Name;

            // clear the listbox and repopulate it with the scores from the student
            lsScores.Items.Clear();
            foreach (double score in StudentToUpdate.Scores)
            {
                lsScores.Items.Add(score);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddScoreForm addForm = new AddScoreForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                if (addForm.Tag is double score) // Retrieve the score from the Tag property
                {
                    lsScores.Items.Add(score);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lsScores.SelectedItem == null)
            {
                MessageBox.Show("Please select a score to update.", "No Score Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lsScores.SelectedItem is double selectedScore && lsScores.SelectedItem != null)
            {
                // Set the selected index before opening the update form
                int selectedIndex = lsScores.SelectedIndex;
                // Open the UpdateScoreForm with the selected score
                UpdateScoreForm updateScoreForm = new UpdateScoreForm(selectedScore);
                if (updateScoreForm.ShowDialog() == DialogResult.OK)
                {
                    if (updateScoreForm.Tag is double updatedScore) // Retrieve the updated score from the Tag property
                    {
                        // Replace the item at the selected index with the updated score
                        lsScores.Items[selectedIndex] = updatedScore;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a score to update.", "No Score Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsScores.SelectedItem != null)
            {
                lsScores.Items.Remove(lsScores.SelectedItem);
                MessageBox.Show("Score removed successfully.", "Score Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a score to remove.", "No Score Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            if (lsScores.Items.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to clear all scores?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lsScores.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("There are no scores to clear.", "No Scores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // update the StudentToUpdate properties with the values from the form
            StudentToUpdate.Name = txtName.Text.Trim();
            StudentToUpdate.Scores = lsScores.Items.Cast<double>().ToList();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
