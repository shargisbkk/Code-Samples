namespace StudentScoresApp
{
    partial class StudentScoresForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScoresForm));
            lblStudents = new Label();
            lblScoreTotal = new Label();
            lblScoreCount = new Label();
            lblScoreAverage = new Label();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            txtScoreTotal = new TextBox();
            txtScoreCount = new TextBox();
            txtScoreAverage = new TextBox();
            lstStudents = new ListBox();
            SuspendLayout();
            // 
            // lblStudents
            // 
            resources.ApplyResources(lblStudents, "lblStudents");
            lblStudents.Name = "lblStudents";
            // 
            // lblScoreTotal
            // 
            resources.ApplyResources(lblScoreTotal, "lblScoreTotal");
            lblScoreTotal.Name = "lblScoreTotal";
            // 
            // lblScoreCount
            // 
            resources.ApplyResources(lblScoreCount, "lblScoreCount");
            lblScoreCount.Name = "lblScoreCount";
            // 
            // lblScoreAverage
            // 
            resources.ApplyResources(lblScoreAverage, "lblScoreAverage");
            lblScoreAverage.Name = "lblScoreAverage";
            // 
            // btnAddNew
            // 
            resources.ApplyResources(btnAddNew, "btnAddNew");
            btnAddNew.Name = "btnAddNew";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            resources.ApplyResources(btnUpdate, "btnUpdate");
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtScoreTotal
            // 
            resources.ApplyResources(txtScoreTotal, "txtScoreTotal");
            txtScoreTotal.BackColor = SystemColors.ActiveBorder;
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            // 
            // txtScoreCount
            // 
            resources.ApplyResources(txtScoreCount, "txtScoreCount");
            txtScoreCount.BackColor = SystemColors.ActiveBorder;
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.ReadOnly = true;
            // 
            // txtScoreAverage
            // 
            resources.ApplyResources(txtScoreAverage, "txtScoreAverage");
            txtScoreAverage.BackColor = SystemColors.ActiveBorder;
            txtScoreAverage.Name = "txtScoreAverage";
            txtScoreAverage.ReadOnly = true;
            // 
            // lstStudents
            // 
            resources.ApplyResources(lstStudents, "lstStudents");
            lstStudents.FormattingEnabled = true;
            lstStudents.Name = "lstStudents";
            lstStudents.SelectedIndexChanged += selectStudent;
            // 
            // StudentScoresForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            Controls.Add(lstStudents);
            Controls.Add(txtScoreAverage);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScoreTotal);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(lblScoreAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(lblScoreTotal);
            Controls.Add(lblStudents);
            Name = "StudentScoresForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudents;
        private Label lblScoreTotal;
        private Label lblScoreCount;
        private Label lblScoreAverage;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private TextBox txtScoreTotal;
        private TextBox txtScoreCount;
        private TextBox txtScoreAverage;
        private ListBox lstStudents;
    }
}
