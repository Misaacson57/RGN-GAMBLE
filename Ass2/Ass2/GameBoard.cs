namespace Ass2
{
    public partial class GameBoard : Form
    {

        private int initialBalance = 10;
        private int balance = 10;
        private int totalMissed = 0;
        private int totalMatched = 0;
        private int bankerNumber; // To store the banker's drawn number


        public GameBoard()
        {
            InitializeComponent();
            lblYourBalance.Text = $"${balance}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bankerNumber = new Random().Next(1, 6); // Generate the banker's number between 1 and 5
            int userGuess = int.Parse(txtUserGuess.Text);

            // Update balance based on the guess
            if (userGuess == bankerNumber)
            {
                balance += 5; // User wins $5
                totalMatched++;
            }
            else
            {
                balance -= 1; // User loses $1
                totalMissed++;
            }

            lblYourBalance.Text = $"${balance}"; // Update the balance display
            btnEnter.Enabled = false; // Disable the Enter button after use
            btnOpen.Enabled = true; // Enable the Open button

            // Check if the game is over
            if (balance <= 0)
            {
                MessageBox.Show("Sorry, you have zero balance.", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the Gameboard form
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            lblBankersNumber.Text = bankerNumber.ToString(); // Reveal the banker's number
            btnOpen.Enabled = false; // Disable the Open button after revealing the number

        }

        private void txtUserGuess_TextChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = int.TryParse(txtUserGuess.Text, out int guess) && guess >= 1 && guess <= 5;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            Result resultForm = new Result(initialBalance, totalMissed, totalMatched, balance);
            resultForm.Show();
        }
    }
}
