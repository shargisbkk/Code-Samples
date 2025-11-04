namespace SimpleRobot
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
            btnNorth = new Button();
            btnEast = new Button();
            btnSouth = new Button();
            btnWest = new Button();
            btnMove1 = new Button();
            btnMove10 = new Button();
            btnExit = new Button();
            lblPosition = new Label();
            pnlWorld = new Panel();
            lblRobot = new Label();
            pnlWorld.SuspendLayout();
            SuspendLayout();
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(136, 278);
            btnNorth.Margin = new Padding(3, 2, 3, 2);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(37, 27);
            btnNorth.TabIndex = 0;
            btnNorth.Text = "N";
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.Click += btnNorth_Click;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(170, 304);
            btnEast.Margin = new Padding(3, 2, 3, 2);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(37, 27);
            btnEast.TabIndex = 1;
            btnEast.Text = "E";
            btnEast.UseVisualStyleBackColor = true;
            btnEast.Click += btnEast_Click;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(136, 329);
            btnSouth.Margin = new Padding(3, 2, 3, 2);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(37, 27);
            btnSouth.TabIndex = 2;
            btnSouth.Text = "S";
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.Click += btnSouth_Click;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(102, 304);
            btnWest.Margin = new Padding(3, 2, 3, 2);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(37, 27);
            btnWest.TabIndex = 3;
            btnWest.Text = "W";
            btnWest.UseVisualStyleBackColor = true;
            btnWest.Click += btnWest_Click;
            // 
            // btnMove1
            // 
            btnMove1.Location = new Point(46, 304);
            btnMove1.Margin = new Padding(3, 2, 3, 2);
            btnMove1.Name = "btnMove1";
            btnMove1.Size = new Size(51, 27);
            btnMove1.TabIndex = 4;
            btnMove1.Text = "Go 1";
            btnMove1.UseVisualStyleBackColor = true;
            btnMove1.Click += btnMove1_Click;
            // 
            // btnMove10
            // 
            btnMove10.Location = new Point(212, 304);
            btnMove10.Margin = new Padding(3, 2, 3, 2);
            btnMove10.Name = "btnMove10";
            btnMove10.Size = new Size(51, 27);
            btnMove10.TabIndex = 5;
            btnMove10.Text = "Go 10";
            btnMove10.UseVisualStyleBackColor = true;
            btnMove10.Click += btnMove10_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(181, 357);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(28, 7);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(38, 15);
            lblPosition.TabIndex = 7;
            lblPosition.Text = "label1";
            // 
            // pnlWorld
            // 
            pnlWorld.BorderStyle = BorderStyle.FixedSingle;
            pnlWorld.Controls.Add(lblRobot);
            pnlWorld.Location = new Point(29, 24);
            pnlWorld.Margin = new Padding(3, 2, 3, 2);
            pnlWorld.MaximumSize = new Size(250, 250);
            pnlWorld.MinimumSize = new Size(250, 250);
            pnlWorld.Name = "pnlWorld";
            pnlWorld.Size = new Size(250, 250);
            pnlWorld.TabIndex = 9;
            // 
            // lblRobot
            // 
            lblRobot.AutoSize = true;
            lblRobot.Font = new Font("Wingdings", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lblRobot.Location = new Point(116, 111);
            lblRobot.Name = "lblRobot";
            lblRobot.Size = new Size(20, 16);
            lblRobot.TabIndex = 10;
            lblRobot.Text = "p";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 399);
            Controls.Add(pnlWorld);
            Controls.Add(btnNorth);
            Controls.Add(btnExit);
            Controls.Add(lblPosition);
            Controls.Add(btnEast);
            Controls.Add(btnWest);
            Controls.Add(btnMove10);
            Controls.Add(btnMove1);
            Controls.Add(btnSouth);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Simple Robot";
            pnlWorld.ResumeLayout(false);
            pnlWorld.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNorth;
        private Button btnEast;
        private Button btnSouth;
        private Button btnWest;
        private Button btnMove1;
        private Button btnMove10;
        private Button btnExit;
        private Label lblPosition;
        private Panel pnlWorld;
        private Label lblRobot;
    }
}
