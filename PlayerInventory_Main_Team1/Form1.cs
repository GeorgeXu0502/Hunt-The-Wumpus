namespace PlayerInventory_Main_Team1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Player_HighScore PlayerHighScore;
        private void buttonConstructor_Click(object sender, EventArgs e)
        {


            PlayerHighScore = new Player_HighScore();
        }
    }
}
