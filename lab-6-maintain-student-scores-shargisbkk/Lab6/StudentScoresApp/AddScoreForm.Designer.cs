namespace StudentScoresApp
{
    partial class AddScoreForm
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
            lblScore = new Label();
            txtScore = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(21, 25);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(49, 20);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(76, 22);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(139, 27);
            txtScore.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(121, 55);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddScoreForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(238, 103);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtScore);
            Controls.Add(lblScore);
            Name = "AddScoreForm";
            Text = "Add Score";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private TextBox txtScore;
        private Button btnAdd;
        private Button btnCancel;
    }
}