namespace StudentScoresApp
{
    partial class UpdateStudentForm
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
            lblScores = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnClearScores = new Button();
            btnOK = new Button();
            btnCancel = new Button();
            lsScores = new ListBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.Location = new Point(17, 48);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(55, 20);
            lblScores.TabIndex = 1;
            lblScores.Text = "Scores:";
            // 
            // txtName
            // 
            txtName.Location = new Point(79, 15);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(248, 27);
            txtName.TabIndex = 2;
            txtName.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(233, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(233, 83);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(233, 118);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(108, 29);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "&Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearScores
            // 
            btnClearScores.Location = new Point(233, 153);
            btnClearScores.Name = "btnClearScores";
            btnClearScores.Size = new Size(108, 29);
            btnClearScores.TabIndex = 7;
            btnClearScores.Text = "Clear &Scores";
            btnClearScores.UseVisualStyleBackColor = true;
            btnClearScores.Click += btnClearScores_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(115, 199);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(102, 29);
            btnOK.TabIndex = 8;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(233, 199);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lsScores
            // 
            lsScores.FormattingEnabled = true;
            lsScores.Location = new Point(79, 48);
            lsScores.Name = "lsScores";
            lsScores.Size = new Size(150, 124);
            lsScores.TabIndex = 10;
            // 
            // UpdateStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(359, 240);
            Controls.Add(lsScores);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(btnClearScores);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(lblScores);
            Controls.Add(lblName);
            Name = "UpdateStudentForm";
            Text = "Update Student Scores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblScores;
        private TextBox txtName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnClearScores;
        private Button btnOK;
        private Button btnCancel;
        private ListBox lsScores;
    }
}