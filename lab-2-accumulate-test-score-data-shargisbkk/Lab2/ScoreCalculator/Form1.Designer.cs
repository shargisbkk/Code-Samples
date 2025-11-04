namespace ScoreCalculator
{
    partial class Form1
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
            lblScore = new Label();
            lblScoreTotal = new Label();
            lblScoreCount = new Label();
            lblScoreAverage = new Label();
            txtScore = new TextBox();
            txtScoreTotal = new TextBox();
            txtScoreCount = new TextBox();
            txtScoreAverage = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(30, 29);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(49, 20);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score:";
            // 
            // lblScoreTotal
            // 
            lblScoreTotal.AutoSize = true;
            lblScoreTotal.Location = new Point(30, 65);
            lblScoreTotal.Name = "lblScoreTotal";
            lblScoreTotal.Size = new Size(86, 20);
            lblScoreTotal.TabIndex = 1;
            lblScoreTotal.Text = "Score Total:";
            // 
            // lblScoreCount
            // 
            lblScoreCount.AutoSize = true;
            lblScoreCount.Location = new Point(30, 102);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(90, 20);
            lblScoreCount.TabIndex = 2;
            lblScoreCount.Text = "Score count:";
            // 
            // lblScoreAverage
            // 
            lblScoreAverage.AutoSize = true;
            lblScoreAverage.Location = new Point(30, 136);
            lblScoreAverage.Name = "lblScoreAverage";
            lblScoreAverage.Size = new Size(67, 20);
            lblScoreAverage.TabIndex = 3;
            lblScoreAverage.Text = "Average:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(130, 26);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(51, 27);
            txtScore.TabIndex = 4;
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.Location = new Point(130, 62);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.Size = new Size(51, 27);
            txtScoreTotal.TabIndex = 5;
            txtScoreTotal.TabStop = false;
            // 
            // txtScoreCount
            // 
            txtScoreCount.Location = new Point(130, 99);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.Size = new Size(51, 27);
            txtScoreCount.TabIndex = 6;
            txtScoreCount.TabStop = false;
            // 
            // txtScoreAverage
            // 
            txtScoreAverage.Location = new Point(130, 133);
            txtScoreAverage.Name = "txtScoreAverage";
            txtScoreAverage.Size = new Size(51, 27);
            txtScoreAverage.TabIndex = 7;
            txtScoreAverage.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(196, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(87, 175);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(196, 175);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(326, 226);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtScoreAverage);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScoreTotal);
            Controls.Add(txtScore);
            Controls.Add(lblScoreAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(lblScoreTotal);
            Controls.Add(lblScore);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private Label lblScoreTotal;
        private Label lblScoreCount;
        private Label lblScoreAverage;
        private TextBox txtScore;
        private TextBox txtScoreTotal;
        private TextBox txtScoreCount;
        private TextBox txtScoreAverage;
        private Button btnAdd;
        private Button btnClear;
        private Button btnExit;
    }
}
