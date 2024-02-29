namespace Ass2
{
    partial class GameBoard
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
            btnEnter = new Button();
            btnOpen = new Button();
            btnSummary = new Button();
            lblInstructions = new Label();
            label1 = new Label();
            txtUserGuess = new TextBox();
            lblBankersNumber = new Label();
            lblYourBalance = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(484, 112);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(154, 69);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(484, 216);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(147, 76);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(484, 318);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(137, 59);
            btnSummary.TabIndex = 2;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.ForeColor = Color.FromArgb(0, 0, 192);
            lblInstructions.Location = new Point(46, 30);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(319, 20);
            lblInstructions.TabIndex = 3;
            lblInstructions.Text = "Each guess costs $1 if it doesn't match banker's";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(46, 50);
            label1.Name = "label1";
            label1.Size = new Size(297, 20);
            label1.TabIndex = 4;
            label1.Text = " If your guess matches banker's, you win $5\"";
            // 
            // txtUserGuess
            // 
            txtUserGuess.BackColor = Color.Cyan;
            txtUserGuess.Location = new Point(286, 133);
            txtUserGuess.MaxLength = 1;
            txtUserGuess.Name = "txtUserGuess";
            txtUserGuess.Size = new Size(142, 27);
            txtUserGuess.TabIndex = 5;
            txtUserGuess.TextChanged += txtUserGuess_TextChanged;
            // 
            // lblBankersNumber
            // 
            lblBankersNumber.AutoSize = true;
            lblBankersNumber.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBankersNumber.ForeColor = Color.Fuchsia;
            lblBankersNumber.Location = new Point(317, 216);
            lblBankersNumber.Name = "lblBankersNumber";
            lblBankersNumber.Size = new Size(48, 62);
            lblBankersNumber.TabIndex = 6;
            lblBankersNumber.Text = "?";
            // 
            // lblYourBalance
            // 
            lblYourBalance.AutoSize = true;
            lblYourBalance.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYourBalance.Location = new Point(286, 315);
            lblYourBalance.Name = "lblYourBalance";
            lblYourBalance.Size = new Size(108, 62);
            lblYourBalance.TabIndex = 7;
            lblYourBalance.Text = "$10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 133);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 8;
            label2.Text = "Enter your guess:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 153);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 9;
            label3.Text = "(1 ~ 5)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 250);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 10;
            label4.Text = "Banker's Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 337);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 11;
            label5.Text = "Your balance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblYourBalance);
            Controls.Add(lblBankersNumber);
            Controls.Add(txtUserGuess);
            Controls.Add(label1);
            Controls.Add(lblInstructions);
            Controls.Add(btnSummary);
            Controls.Add(btnOpen);
            Controls.Add(btnEnter);
            Name = "Form1";
            Text = "Game Board";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Button btnOpen;
        private Button btnSummary;
        private Label lblInstructions;
        private Label label1;
        private TextBox txtUserGuess;
        private Label lblBankersNumber;
        private Label lblYourBalance;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
