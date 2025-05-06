using Newtonsoft.Json;

namespace PlayerInventory_Main_Team1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Player_HighScore2> highscores = ReadFromFile("highscores.json");

        const string DATA_FILE = "highscores.json";
        private Player_HighScore2 PlayerHighScore;
        private static JsonSerializer serializer = new JsonSerializer();

        public static void WriteToFile(string dataFile, List<Player_HighScore2> highscores)
        {
            StreamWriter writer = new StreamWriter(dataFile, false);

            JsonSerializer jsonSerializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            jsonSerializer.Serialize(writer, highscores, typeof(List<Player_HighScore2>));
            writer.Flush();
            writer.Close();
        }


        public static List<Player_HighScore2> ReadFromFile(string dataFile)
        {
            StreamReader reader = new StreamReader(dataFile);

            JsonSerializer jsonSerializer = new JsonSerializer();
            var list = (List<Player_HighScore2>)jsonSerializer.Deserialize(reader, typeof(List<Player_HighScore2>));
            reader.Close();
            if (list == null)
            {
                return new List<Player_HighScore2>();
            }

            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonAddTurn_Click(object sender, EventArgs e)
        {

        }

        private void buttonPitEncounter_Click(object sender, EventArgs e)
        {
            bool isLessThanZero = PlayerHighScore.EncounterTriviaPitCoins(false);
            int remainingGold = PlayerHighScore.GoldCount;
            textBoxGoldCount.Text = remainingGold.ToString();
        }

        private void buttonWumpusEncounter_Click(object sender, EventArgs e)
        {
            bool isLessThanZero = PlayerHighScore.EncounterWumpusCoins(false);
            int remainingGold = PlayerHighScore.GoldCount;
            textBoxGoldCount.Text = remainingGold.ToString();
        }

        private void buttonBuyArrows_Click(object sender, EventArgs e)
        {
            int arrows = PlayerHighScore.NumberOfArrowsIndex(true);
            textBoxArrows.Text = arrows.ToString();
        }

        private void buttonShootArrows_Click(object sender, EventArgs e)
        {
            int arrows = PlayerHighScore.NumberOfArrowsIndex(false);
            textBoxArrows.Text = arrows.ToString();
        }

        private void buttonCalculateHighScore_Click(object sender, EventArgs e)
        {
            int score = PlayerHighScore.CalculateHighScore(int.Parse(textBoxTurns.Text), int.Parse(textBoxGoldCount.Text), int.Parse(textBoxArrows.Text), checkBoxWumpusDefeated.Checked);
            textBoxHighScore.Text = score.ToString();
        }

        private void buttonConstructor_Click(object sender, EventArgs e)
        {
            // PlayerHighScore = new Player_HighScore2(int.Parse(textBoxGoldCount.Text), int.Parse(textBoxTurns.Text), int.Parse(textBoxArrows.Text), checkBoxSelfWanted.Checked, int.Parse(textBoxHighScore.Text), textBoxUsername.Text);
            textBoxGoldCount.Text = "0";
            textBoxTurns.Text = "0";
            textBoxArrows.Text = "3";
            textBoxHighScore.Text = "0";
        }

        private void buttonMoveForward_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayerHighScore != null)
                {


                    PlayerHighScore.SelfWanted = checkBoxSelfWanted.Checked;
                    int gold = PlayerHighScore.GoldCoinIndex();
                    int turns = PlayerHighScore.NumberOfTurnsIndex();
                    textBoxGoldCount.Text = gold.ToString();
                    textBoxTurns.Text = turns.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Checkbox Self Wanted not checked");
                return;
            }
        }

        private void buttonSaveHighScore_Click(object sender, EventArgs e)
        {
            Player_HighScore2 player_highscore2;
            try
            {
                player_highscore2 = new Player_HighScore2(int.Parse(textBoxGoldCount.Text), int.Parse(textBoxTurns.Text), int.Parse(textBoxArrows.Text), checkBoxSelfWanted.Checked, int.Parse(textBoxHighScore.Text), textBoxUsername.Text);
            }
            catch
            {
                MessageBox.Show("Enter a valid username");
                return;
            }





                highscores.Add(player_highscore2);
                listBoxHighScores.Items.Add(player_highscore2.Username + " " + player_highscore2.Score);
            WriteToFile(DATA_FILE, highscores);
            

            /* if (player_highscore2 != null)
            {
                // Save the high score to a file or database
                // For example, you can use a simple text file to store the high scores
                string filePath = "highscores.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{player_highscore2.Username}: {player_highscore2.Score}");
                }
                MessageBox.Show("High score saved successfully!");
            }
            else
            {
                MessageBox.Show("Failed to save high score.");
            } */
        }
    }
}
