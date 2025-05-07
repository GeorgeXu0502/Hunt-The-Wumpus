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

            jsonSerializer.Serialize(writer, highscores);
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

            PlayerHighScore = new Player_HighScore2(0, 0, 3, false, 0, "Player");


            if (File.Exists(DATA_FILE))
            {
                highscores = ReadFromFile(DATA_FILE);
                listBoxHighScores.Items.Clear();
                foreach (var hs in highscores.OrderByDescending(h => h.Score).Take(5))
                {
                    listBoxHighScores.Items.Add($"{hs.Username}: {hs.Score}");
                }
            }
            else
            {
                highscores = new List<Player_HighScore2>();
            }
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
            highscores = highscores.OrderByDescending(h => h.Score).ToList();

            listBoxHighScores.Items.Clear();
            foreach (var hs in highscores.Take(5))
            {
                listBoxHighScores.Items.Add($"{hs.Username}: {hs.Score}");
            }

            
            WriteToFile(DATA_FILE, highscores);
            
            
            
        }
    }
}
