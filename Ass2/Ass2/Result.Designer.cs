namespace Ass2
{
    partial class Result
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
            lblInitialBalanceTitle = new Label();
            lblinitialBalanceValue = new Label();
            lblTotalMissedTitle = new Label();
            lblTotalMissedValue = new Label();
            lblTotalMatchedTitle = new Label();
            lblTotalMatchedValue = new Label();
            lblCurrentBalanceTitle = new Label();
            lblCurrentBalanceValue = new Label();
            lblMoneyLostValue = new Label();
            lblMoneyGainedValue = new Label();
            SuspendLayout();
            // 
            // lblInitialBalanceTitle
            // 
            lblInitialBalanceTitle.AutoSize = true;
            lblInitialBalanceTitle.Location = new Point(64, 78);
            lblInitialBalanceTitle.Name = "lblInitialBalanceTitle";
            lblInitialBalanceTitle.Size = new Size(102, 20);
            lblInitialBalanceTitle.TabIndex = 0;
            lblInitialBalanceTitle.Text = "Initial balance";
            // 
            // lblinitialBalanceValue
            // 
            lblinitialBalanceValue.AutoSize = true;
            lblinitialBalanceValue.Location = new Point(291, 78);
            lblinitialBalanceValue.Name = "lblinitialBalanceValue";
            lblinitialBalanceValue.Size = new Size(33, 20);
            lblinitialBalanceValue.TabIndex = 1;
            lblinitialBalanceValue.Text = "$10";
            // 
            // lblTotalMissedTitle
            // 
            lblTotalMissedTitle.AutoSize = true;
            lblTotalMissedTitle.Location = new Point(64, 150);
            lblTotalMissedTitle.Name = "lblTotalMissedTitle";
            lblTotalMissedTitle.Size = new Size(92, 20);
            lblTotalMissedTitle.TabIndex = 2;
            lblTotalMissedTitle.Text = "Total Missed";
            // 
            // lblTotalMissedValue
            // 
            lblTotalMissedValue.AutoSize = true;
            lblTotalMissedValue.Location = new Point(246, 150);
            lblTotalMissedValue.Name = "lblTotalMissedValue";
            lblTotalMissedValue.Size = new Size(17, 20);
            lblTotalMissedValue.TabIndex = 3;
            lblTotalMissedValue.Text = "0";
            // 
            // lblTotalMatchedTitle
            // 
            lblTotalMatchedTitle.AutoSize = true;
            lblTotalMatchedTitle.Location = new Point(64, 214);
            lblTotalMatchedTitle.Name = "lblTotalMatchedTitle";
            lblTotalMatchedTitle.Size = new Size(104, 20);
            lblTotalMatchedTitle.TabIndex = 4;
            lblTotalMatchedTitle.Text = "Total matched";
            // 
            // lblTotalMatchedValue
            // 
            lblTotalMatchedValue.AutoSize = true;
            lblTotalMatchedValue.Location = new Point(246, 214);
            lblTotalMatchedValue.Name = "lblTotalMatchedValue";
            lblTotalMatchedValue.Size = new Size(17, 20);
            lblTotalMatchedValue.TabIndex = 5;
            lblTotalMatchedValue.Text = "0";
            // 
            // lblCurrentBalanceTitle
            // 
            lblCurrentBalanceTitle.AutoSize = true;
            lblCurrentBalanceTitle.Location = new Point(64, 284);
            lblCurrentBalanceTitle.Name = "lblCurrentBalanceTitle";
            lblCurrentBalanceTitle.Size = new Size(113, 20);
            lblCurrentBalanceTitle.TabIndex = 6;
            lblCurrentBalanceTitle.Text = "Current balance";
            // 
            // lblCurrentBalanceValue
            // 
            lblCurrentBalanceValue.AutoSize = true;
            lblCurrentBalanceValue.Location = new Point(291, 284);
            lblCurrentBalanceValue.Name = "lblCurrentBalanceValue";
            lblCurrentBalanceValue.Size = new Size(33, 20);
            lblCurrentBalanceValue.TabIndex = 7;
            lblCurrentBalanceValue.Text = "$10";
            // 
            // lblMoneyLostValue
            // 
            lblMoneyLostValue.AutoSize = true;
            lblMoneyLostValue.Location = new Point(291, 150);
            lblMoneyLostValue.Name = "lblMoneyLostValue";
            lblMoneyLostValue.Size = new Size(25, 20);
            lblMoneyLostValue.TabIndex = 8;
            lblMoneyLostValue.Text = "$0";
            // 
            // lblMoneyGainedValue
            // 
            lblMoneyGainedValue.AutoSize = true;
            lblMoneyGainedValue.Location = new Point(291, 214);
            lblMoneyGainedValue.Name = "lblMoneyGainedValue";
            lblMoneyGainedValue.Size = new Size(25, 20);
            lblMoneyGainedValue.TabIndex = 9;
            lblMoneyGainedValue.Text = "$0";
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 450);
            Controls.Add(lblMoneyGainedValue);
            Controls.Add(lblMoneyLostValue);
            Controls.Add(lblCurrentBalanceValue);
            Controls.Add(lblCurrentBalanceTitle);
            Controls.Add(lblTotalMatchedValue);
            Controls.Add(lblTotalMatchedTitle);
            Controls.Add(lblTotalMissedValue);
            Controls.Add(lblTotalMissedTitle);
            Controls.Add(lblinitialBalanceValue);
            Controls.Add(lblInitialBalanceTitle);
            Name = "Result";
            Text = "Result";
            Load += Result_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInitialBalanceTitle;
        private Label lblinitialBalanceValue;
        private Label lblTotalMissedTitle;
        private Label lblTotalMissedValue;
        private Label lblTotalMatchedTitle;
        private Label lblTotalMatchedValue;
        private Label lblCurrentBalanceTitle;
        private Label lblCurrentBalanceValue;
        private Label lblMoneyLostValue;
        private Label lblMoneyGainedValue;
    }
}