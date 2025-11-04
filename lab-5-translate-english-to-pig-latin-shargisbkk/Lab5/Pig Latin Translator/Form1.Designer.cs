namespace Pig_Latin_Translator
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
            lblEnglish = new Label();
            lblPigLatin = new Label();
            txtEnglish = new RichTextBox();
            txtPigLatin = new RichTextBox();
            btnTranslate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblEnglish
            // 
            lblEnglish.AutoSize = true;
            lblEnglish.Location = new Point(21, 8);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new Size(159, 20);
            lblEnglish.TabIndex = 0;
            lblEnglish.Text = "Enter English text here:";
            // 
            // lblPigLatin
            // 
            lblPigLatin.AutoSize = true;
            lblPigLatin.Location = new Point(21, 192);
            lblPigLatin.Name = "lblPigLatin";
            lblPigLatin.Size = new Size(143, 20);
            lblPigLatin.TabIndex = 0;
            lblPigLatin.Text = "Pig Latin translation:";
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(21, 31);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            txtEnglish.Size = new Size(440, 158);
            txtEnglish.TabIndex = 2;
            txtEnglish.Text = "";
            // 
            // txtPigLatin
            // 
            txtPigLatin.Location = new Point(21, 215);
            txtPigLatin.Name = "txtPigLatin";
            txtPigLatin.ReadOnly = true;
            txtPigLatin.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            txtPigLatin.Size = new Size(440, 155);
            txtPigLatin.TabIndex = 1;
            txtPigLatin.TabStop = false;
            txtPigLatin.Text = "";
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(21, 385);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(94, 29);
            btnTranslate.TabIndex = 3;
            btnTranslate.Text = "&Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(121, 385);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(367, 385);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnTranslate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(482, 424);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnTranslate);
            Controls.Add(txtPigLatin);
            Controls.Add(txtEnglish);
            Controls.Add(lblPigLatin);
            Controls.Add(lblEnglish);
            Name = "Form1";
            Text = "Pig Latin Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnglish;
        private Label lblPigLatin;
        private RichTextBox txtEnglish;
        private RichTextBox txtPigLatin;
        private Button btnTranslate;
        private Button btnClear;
        private Button btnExit;
    }
}
