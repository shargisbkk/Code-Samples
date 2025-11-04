namespace WinFormsApp1
{
    partial class frmCalculator
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnChangeSign = new Button();
            btnDecimal = new Button();
            btnAdd = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnSquareRoot = new Button();
            btnReciprical = new Button();
            btnEquals = new Button();
            btnBack = new Button();
            btnClear = new Button();
            rtxtDisplay = new RichTextBox();
            btnMemClear = new Button();
            btnMemRecall = new Button();
            btnMemSave = new Button();
            btnMemAdd = new Button();
            rtxtMemDisplay = new RichTextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btn1.ForeColor = Color.RoyalBlue;
            btn1.Location = new Point(95, 237);
            btn1.Name = "btn1";
            btn1.Size = new Size(64, 53);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += numb_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btn2.ForeColor = Color.RoyalBlue;
            btn2.Location = new Point(165, 237);
            btn2.Name = "btn2";
            btn2.Size = new Size(64, 53);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += numb_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btn3.ForeColor = Color.RoyalBlue;
            btn3.Location = new Point(235, 237);
            btn3.Name = "btn3";
            btn3.Size = new Size(64, 53);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += numb_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btn4.ForeColor = Color.RoyalBlue;
            btn4.Location = new Point(95, 178);
            btn4.Name = "btn4";
            btn4.Size = new Size(64, 53);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += numb_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btn5.ForeColor = Color.RoyalBlue;
            btn5.Location = new Point(165, 178);
            btn5.Name = "btn5";
            btn5.Size = new Size(64, 53);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += numb_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btn6.ForeColor = Color.RoyalBlue;
            btn6.Location = new Point(235, 178);
            btn6.Name = "btn6";
            btn6.Size = new Size(64, 53);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += numb_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btn7.ForeColor = Color.RoyalBlue;
            btn7.Location = new Point(95, 119);
            btn7.Name = "btn7";
            btn7.Size = new Size(64, 53);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += numb_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btn8.ForeColor = Color.RoyalBlue;
            btn8.Location = new Point(165, 119);
            btn8.Name = "btn8";
            btn8.Size = new Size(64, 53);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += numb_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btn9.ForeColor = Color.RoyalBlue;
            btn9.Location = new Point(235, 119);
            btn9.Name = "btn9";
            btn9.Size = new Size(64, 53);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += numb_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btn0.ForeColor = Color.RoyalBlue;
            btn0.Location = new Point(95, 296);
            btn0.Name = "btn0";
            btn0.Size = new Size(64, 53);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += numb_Click;
            // 
            // btnChangeSign
            // 
            btnChangeSign.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnChangeSign.ForeColor = Color.RoyalBlue;
            btnChangeSign.Location = new Point(165, 296);
            btnChangeSign.Name = "btnChangeSign";
            btnChangeSign.Size = new Size(64, 53);
            btnChangeSign.TabIndex = 10;
            btnChangeSign.Text = "+/-";
            btnChangeSign.UseVisualStyleBackColor = true;
            btnChangeSign.Click += btnChangeSign_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnDecimal.ForeColor = Color.RoyalBlue;
            btnDecimal.Location = new Point(235, 296);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(64, 53);
            btnDecimal.TabIndex = 11;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Crimson;
            btnAdd.Location = new Point(305, 296);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(64, 53);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += set_Operand;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnMinus.ForeColor = Color.Crimson;
            btnMinus.Location = new Point(305, 237);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(64, 53);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += set_Operand;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnMultiply.ForeColor = Color.Crimson;
            btnMultiply.Location = new Point(305, 178);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(64, 53);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += set_Operand;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnDivide.ForeColor = Color.Crimson;
            btnDivide.Location = new Point(305, 119);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(64, 53);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += set_Operand;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSquareRoot.ForeColor = Color.RoyalBlue;
            btnSquareRoot.Location = new Point(375, 119);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(64, 53);
            btnSquareRoot.TabIndex = 16;
            btnSquareRoot.Text = "sqrt";
            btnSquareRoot.UseVisualStyleBackColor = true;
            btnSquareRoot.Click += btnSquareRoot_Click;
            // 
            // btnReciprical
            // 
            btnReciprical.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnReciprical.ForeColor = Color.RoyalBlue;
            btnReciprical.Location = new Point(375, 178);
            btnReciprical.Name = "btnReciprical";
            btnReciprical.Size = new Size(64, 53);
            btnReciprical.TabIndex = 17;
            btnReciprical.Text = "1/x";
            btnReciprical.UseVisualStyleBackColor = true;
            btnReciprical.Click += btnReciprical_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnEquals.ForeColor = Color.RoyalBlue;
            btnEquals.Location = new Point(375, 237);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(64, 112);
            btnEquals.TabIndex = 18;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += calculate;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnBack.ForeColor = Color.Crimson;
            btnBack.Location = new Point(95, 59);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 54);
            btnBack.TabIndex = 19;
            btnBack.Text = "&Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnClear.ForeColor = Color.Crimson;
            btnClear.Location = new Point(235, 59);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(204, 54);
            btnClear.TabIndex = 20;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // rtxtDisplay
            // 
            rtxtDisplay.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtxtDisplay.Location = new Point(23, 12);
            rtxtDisplay.Name = "rtxtDisplay";
            rtxtDisplay.ReadOnly = true;
            rtxtDisplay.RightToLeft = RightToLeft.Yes;
            rtxtDisplay.ScrollBars = RichTextBoxScrollBars.None;
            rtxtDisplay.Size = new Size(416, 41);
            rtxtDisplay.TabIndex = 21;
            rtxtDisplay.TabStop = false;
            rtxtDisplay.Text = "";
            rtxtDisplay.WordWrap = false;
            // 
            // btnMemClear
            // 
            btnMemClear.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMemClear.ForeColor = Color.Crimson;
            btnMemClear.Location = new Point(23, 119);
            btnMemClear.Name = "btnMemClear";
            btnMemClear.Size = new Size(64, 53);
            btnMemClear.TabIndex = 22;
            btnMemClear.Text = "MC";
            btnMemClear.UseVisualStyleBackColor = true;
            btnMemClear.Click += btnMemClear_Click;
            // 
            // btnMemRecall
            // 
            btnMemRecall.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnMemRecall.ForeColor = Color.Crimson;
            btnMemRecall.Location = new Point(23, 178);
            btnMemRecall.Name = "btnMemRecall";
            btnMemRecall.Size = new Size(64, 53);
            btnMemRecall.TabIndex = 23;
            btnMemRecall.Text = "MR";
            btnMemRecall.UseVisualStyleBackColor = true;
            btnMemRecall.Click += btnMemRecall_Click;
            // 
            // btnMemSave
            // 
            btnMemSave.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnMemSave.ForeColor = Color.Crimson;
            btnMemSave.Location = new Point(23, 237);
            btnMemSave.Name = "btnMemSave";
            btnMemSave.Size = new Size(64, 53);
            btnMemSave.TabIndex = 24;
            btnMemSave.Text = "MS";
            btnMemSave.UseVisualStyleBackColor = true;
            btnMemSave.Click += btnMemSave_Click;
            // 
            // btnMemAdd
            // 
            btnMemAdd.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            btnMemAdd.ForeColor = Color.Crimson;
            btnMemAdd.Location = new Point(23, 296);
            btnMemAdd.Name = "btnMemAdd";
            btnMemAdd.Size = new Size(64, 53);
            btnMemAdd.TabIndex = 25;
            btnMemAdd.Text = "M+";
            btnMemAdd.UseVisualStyleBackColor = true;
            btnMemAdd.Click += btnMemAdd_Click;
            // 
            // rtxtMemDisplay
            // 
            rtxtMemDisplay.Font = new Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtxtMemDisplay.Location = new Point(23, 59);
            rtxtMemDisplay.Name = "rtxtMemDisplay";
            rtxtMemDisplay.RightToLeft = RightToLeft.Yes;
            rtxtMemDisplay.ScrollBars = RichTextBoxScrollBars.None;
            rtxtMemDisplay.Size = new Size(66, 54);
            rtxtMemDisplay.TabIndex = 26;
            rtxtMemDisplay.Text = "";
            // 
            // frmCalculator
            // 
            AcceptButton = btnEquals;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 366);
            Controls.Add(rtxtMemDisplay);
            Controls.Add(btnMemAdd);
            Controls.Add(btnMemSave);
            Controls.Add(btnMemRecall);
            Controls.Add(btnMemClear);
            Controls.Add(rtxtDisplay);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(btnEquals);
            Controls.Add(btnReciprical);
            Controls.Add(btnSquareRoot);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnAdd);
            Controls.Add(btnDecimal);
            Controls.Add(btnChangeSign);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            ForeColor = Color.Black;
            Name = "frmCalculator";
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnChangeSign;
        private Button btnDecimal;
        private Button btnAdd;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnSquareRoot;
        private Button btnReciprical;
        private Button btnEquals;
        private Button btnBack;
        private Button btnClear;
        private RichTextBox rtxtDisplay;
        private Button btnMemClear;
        private Button btnMemRecall;
        private Button btnMemSave;
        private Button btnMemAdd;
        private RichTextBox rtxtMemDisplay;
    }
}
