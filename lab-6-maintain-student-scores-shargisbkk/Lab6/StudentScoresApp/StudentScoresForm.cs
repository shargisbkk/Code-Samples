namespace StudentScoresApp
{
    public partial class StudentScoresForm : Form
    {
        public class Student // Holds Student data and can be inherited in other forms
        {
            public string Name { get; set; } // Property to hold the student's name
            public List<double> Scores { get; set; } // List to hold multiple scores
            public Student(string name, List<double> scores) // Constructor to initialize properties
            {
                this.Name = name;
                this.Scores = scores;
            }
            public Student(Student student) // Copy constructor to create a new Student from an existing one
            {
                this.Name = student.Name;
                this.Scores = new List<double>(student.Scores);
            }
            public override string ToString() // Override ToString to display the student's name and scores in the ListBox
            {
                string scoresFormatted = string.Join("|", Scores);
                return $"{Name}| {scoresFormatted}";
            }
        }
        public StudentScoresForm()
        {
            InitializeComponent();
            // make 3 instances of students to add to the list box
            Student JohnMurach = new Student("John Murach", new List<double> { 97, 91, 83 });
            Student DougLowe = new Student("Doug Lowe", new List<double> { 99, 93, 97 });
            Student AnneBoehm = new Student("Anne Boehm", new List<double> { 100, 100, 100 });
            lstStudents.Items.Add(JohnMurach);
            lstStudents.Items.Add(DougLowe);
            lstStudents.Items.Add(AnneBoehm);
        }

        private void selectStudent(object sender, EventArgs e)
        {
            // check if a selected item is a Student and cast it to a Student object
            if (lstStudents.SelectedItem is Student selectedStudent)
            {
                double sum = selectedStudent.Scores.Sum();
                int count = selectedStudent.Scores.Count;
                double average = count > 0 ? sum / count : 0;

                txtScoreTotal.Text = sum.ToString("F2");
                txtScoreCount.Text = count.ToString();
                txtScoreAverage.Text = average.ToString("F2");
            }
            else
            {
                // Clear the text boxes if no student is selected
                txtScoreTotal.Clear();
                txtScoreCount.Clear();
                txtScoreAverage.Clear();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            // Open the AddStudentForm as a dialog
            AddStudentForm addForm = new AddStudentForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Create a new Student object using the data from the AddStudentForm
                Student student = new Student(addForm.StudentName, addForm.scoresList);
                // Add the new Student object to the ListBox
                lstStudents.Items.Add(student);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem is Student selectedStudent)
            {
                // Set the selected index before opening the update form
                int selectedIndex = lstStudents.SelectedIndex;
                UpdateStudentForm updateForm = new UpdateStudentForm(selectedStudent);
                {
                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        // Create a new Student object using the updated data from the UpdateStudentForm and replace the old one in the ListBox
                        lstStudents.Items[selectedIndex] = new Student(updateForm.StudentToUpdate);
                        // Reselect the updated item in the ListBox
                        lstStudents.SelectedIndex = selectedIndex;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete the selected student?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    {
                    lstStudents.Items.Remove(lstStudents.SelectedItem);
                    txtScoreTotal.Clear();
                    txtScoreCount.Clear();
                    txtScoreAverage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
