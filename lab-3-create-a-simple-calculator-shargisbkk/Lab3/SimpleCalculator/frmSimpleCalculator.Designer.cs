namespace SimpleCalculator
{
    partial class frmSimpleCalculator
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
            lblOperand1 = new Label();
            lblOperator = new Label();
            lblOperand2 = new Label();
            lblResult = new Label();
            txtOperand1 = new TextBox();
            txtOperator = new TextBox();
            txtOperand2 = new TextBox();
            txtResult = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblOperand1
            // 
            lblOperand1.AutoSize = true;
            lblOperand1.Location = new Point(32, 26);
            lblOperand1.Name = "lblOperand1";
            lblOperand1.Size = new Size(82, 20);
            lblOperand1.TabIndex = 0;
            lblOperand1.Text = "Operand 1:";
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Location = new Point(32, 56);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(72, 20);
            lblOperator.TabIndex = 1;
            lblOperator.Text = "Operator:";
            // 
            // lblOperand2
            // 
            lblOperand2.AutoSize = true;
            lblOperand2.Location = new Point(32, 86);
            lblOperand2.Name = "lblOperand2";
            lblOperand2.Size = new Size(82, 20);
            lblOperand2.TabIndex = 2;
            lblOperand2.Text = "Operand 2:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(32, 115);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result:";
            // 
            // txtOperand1
            // 
            txtOperand1.Location = new Point(154, 23);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(125, 27);
            txtOperand1.TabIndex = 4;
            txtOperand1.TextChanged += textChanged;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(154, 53);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(36, 27);
            txtOperator.TabIndex = 5;
            txtOperator.TextChanged += textChanged;
            // 
            // txtOperand2
            // 
            txtOperand2.Location = new Point(154, 83);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(125, 27);
            txtOperand2.TabIndex = 6;
            txtOperand2.TextChanged += textChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(154, 112);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(125, 27);
            txtResult.TabIndex = 7;
            txtResult.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(32, 153);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(185, 153);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmSimpleCalculator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(318, 203);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(txtOperand2);
            Controls.Add(txtOperator);
            Controls.Add(txtOperand1);
            Controls.Add(lblResult);
            Controls.Add(lblOperand2);
            Controls.Add(lblOperator);
            Controls.Add(lblOperand1);
            Name = "frmSimpleCalculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOperand1;
        private Label lblOperator;
        private Label lblOperand2;
        private Label lblResult;
        private TextBox txtOperand1;
        private TextBox txtOperator;
        private TextBox txtOperand2;
        private TextBox txtResult;
        private Button btnCalculate;
        private Button btnExit;
    }
}
