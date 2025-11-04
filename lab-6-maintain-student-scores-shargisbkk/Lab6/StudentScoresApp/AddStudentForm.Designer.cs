namespace StudentScoresApp
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblScoreEnter = new Label();
            lblScoreDisplay = new Label();
            txtName = new TextBox();
            txtScore = new TextBox();
            txtScoresDisplay = new TextBox();
            btnAddScore = new Button();
            btnClearScores = new Button();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblScoreEnter
            // 
            lblScoreEnter.AutoSize = true;
            lblScoreEnter.Location = new Point(24, 58);
            lblScoreEnter.Name = "lblScoreEnter";
            lblScoreEnter.Size = new Size(49, 20);
            lblScoreEnter.TabIndex = 1;
            lblScoreEnter.Text = "Score:";
            // 
            // lblScoreDisplay
            // 
            lblScoreDisplay.AutoSize = true;
            lblScoreDisplay.Location = new Point(24, 92);
            lblScoreDisplay.Name = "lblScoreDisplay";
            lblScoreDisplay.Size = new Size(55, 20);
            lblScoreDisplay.TabIndex = 2;
            lblScoreDisplay.Text = "Scores:";
            // 
            // txtName
            // 
            txtName.Location = new Point(82, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 27);
            txtName.TabIndex = 3;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(82, 55);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 4;
            // 
            // txtScoresDisplay
            // 
            txtScoresDisplay.Location = new Point(82, 89);
            txtScoresDisplay.Name = "txtScoresDisplay";
            txtScoresDisplay.ReadOnly = true;
            txtScoresDisplay.Size = new Size(239, 27);
            txtScoresDisplay.TabIndex = 5;
            txtScoresDisplay.TabStop = false;
            // 
            // btnAddScore
            // 
            btnAddScore.Location = new Point(218, 54);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Size = new Size(103, 29);
            btnAddScore.TabIndex = 6;
            btnAddScore.Text = "&Add Score";
            btnAddScore.UseVisualStyleBackColor = true;
            btnAddScore.Click += btnAddScore_Click;
            // 
            // btnClearScores
            // 
            btnClearScores.Location = new Point(218, 132);
            btnClearScores.Name = "btnClearScores";
            btnClearScores.Size = new Size(103, 29);
            btnClearScores.TabIndex = 7;
            btnClearScores.Text = "Clear &Scores";
            btnClearScores.UseVisualStyleBackColor = true;
            btnClearScores.Click += btnClearScores_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(109, 167);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(103, 29);
            btnOK.TabIndex = 8;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(218, 167);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddStudentForm
            // 
            AcceptButton = btnAddScore;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(347, 215);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(btnClearScores);
            Controls.Add(btnAddScore);
            Controls.Add(txtScoresDisplay);
            Controls.Add(txtScore);
            Controls.Add(txtName);
            Controls.Add(lblScoreDisplay);
            Controls.Add(lblScoreEnter);
            Controls.Add(lblName);
            Name = "AddStudentForm";
            Text = "Add New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblScoreEnter;
        private Label lblScoreDisplay;
        private TextBox txtName;
        private TextBox txtScore;
        private TextBox txtScoresDisplay;
        private Button btnAddScore;
        private Button btnClearScores;
        private Button btnOK;
        private Button btnCancel;
    }
}