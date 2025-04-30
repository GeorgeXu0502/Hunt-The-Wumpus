namespace PlayerInventory_Main_Team1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Player_HighScore2 PlayerHighScore;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonAddTurn_Click(object sender, EventArgs e)
        {

        }

        private void buttonPitEncounter_Click(object sender, EventArgs e)
        {
            bool isLessThanZero = PlayerHighScore.EncounterTriviaPitCoins(1, false);
            int remainingGold = PlayerHighScore.GoldCount;
            textBoxGoldCount.Text = remainingGold.ToString();
        }

        private void buttonWumpusEncounter_Click(object sender, EventArgs e)
        {
            bool isLessThanZero = PlayerHighScore.EncounterWumpusCoins(1, false);
            int remainingGold = PlayerHighScore.GoldCount;
            textBoxGoldCount.Text = remainingGold.ToString();
        }

        private void buttonBuyArrows_Click(object sender, EventArgs e)
        {
            int arrows = PlayerHighScore.NumberOfArrowsIndex(1, true);
            textBoxArrows.Text = arrows.ToString();
        }

        private void buttonShootArrows_Click(object sender, EventArgs e)
        {
            int arrows = PlayerHighScore.NumberOfArrowsIndex(1, false);
            textBoxArrows.Text = arrows.ToString();
        }

        private void buttonCalculateHighScore_Click(object sender, EventArgs e)
        {
            int score = PlayerHighScore.CalculateHighScore(int.Parse(textBoxTurns.Text), int.Parse(textBoxGoldCount.Text), int.Parse(textBoxArrows.Text), checkBoxWumpusDefeated.Checked);
            textBoxHighScore.Text = score.ToString();
        }

        private void buttonConstructor_Click(object sender, EventArgs e)
        {
            PlayerHighScore = new Player_HighScore2();
            textBoxGoldCount.Text = "0";
            textBoxTurns.Text = "0";
            textBoxArrows.Text = "3";
            textBoxHighScore.Text = "0";
        }

        private void buttonMoveForward_Click(object sender, EventArgs e)
        {
            PlayerHighScore.SelfWanted = checkBoxSelfWanted.Checked;

            int gold = PlayerHighScore.GoldCoinIndex(1);
            int turns = PlayerHighScore.NumberOfTurnsIndex(1);
            textBoxGoldCount.Text = gold.ToString();
            textBoxTurns.Text = turns.ToString();
        }
    }
}
