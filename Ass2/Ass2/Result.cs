using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass2
{
    public partial class Result : Form
    {


        private int initialBalance;
        private int totalMissed;
        private int totalMatched;
        private int moneyLost;
        private int moneyGained;
        private int currentBalance;


        public Result(int initialBalance, int totalMissed, int totalMatched, int currentBalance)
        {
            InitializeComponent();

            // Set the initial values for labels
            this.initialBalance = initialBalance;
            this.totalMissed = totalMissed;
            this.totalMatched = totalMatched;
            this.currentBalance = currentBalance;

            // Assuming $1 is lost per miss and $5 is gained per match
            this.moneyLost = totalMissed * 1;
            this.moneyGained = totalMatched * 5;

            lblinitialBalanceValue.Text = $"${initialBalance}";
            lblTotalMissedValue.Text = totalMissed.ToString();
            lblMoneyLostValue.Text = $"-${moneyLost}";
            lblTotalMatchedValue.Text = totalMatched.ToString();
            lblMoneyGainedValue.Text = $"+${moneyGained}";
            lblCurrentBalanceValue.Text = $"${currentBalance}";
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
