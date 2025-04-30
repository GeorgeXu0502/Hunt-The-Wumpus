using System.Net.Http.Headers;
using CaveMain_Offical;
using GameControl_Offical;
using Microsoft.VisualBasic.ApplicationServices;
using TrivaMachine_Offical;


namespace HuntTheWumpus_Team1
{
    public partial class Form1 : Form
    {
        Player_GameControl GameControlObject = new GameControl_Offical.Player_GameControl();
        int RoomNumber = 1;
        bool SelfInitated = true;


        // System Specific Image Location:
        List<string> ListofImageLocation = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // Add the Locations
            ListofImageLocation = MakeListofImageLocation();
        }

        private void Form1_Activated(object sender, EventArgs e) // THE MAIN FUNCTION HERE!
        {
            // Open the inital Menu. Give the User the oppertunity to login.
            OpeningMenu OpentheMenuObject = new OpeningMenu();
            OpentheMenuObject.ShowDialog();

            bool [] DangerInRoom = DrawTheRoom();

            if (DangerInRoom[0] == true)
            {
                WampusInRoom();
            }
            else if (DangerInRoom[1] == true)
            {
                BatsInRoom();
            }
            else if (DangerInRoom[2] == true)
            {
                PitInRoom();
            }
        }

        private void EndTheGame() // This Function is most important as it will end the game when needed.
        {

        }

        private List<String> MakeListofImageLocation()
        {
            List<string> ListtoReturn = new List<string>();
            ListtoReturn.Add("Hi"); //  Change this. 
            ListtoReturn.Add("Hi");
            ListtoReturn.Add("Hi");

            return ListtoReturn;
        }
        
        private bool[] DrawTheRoom()
        {
            // This Room List should be of this form: [RoomUser, RoomtotheTopLeft, .... (Coutnerclockwise), ....]
            List <Room> listofadjacentrooms = GameControlObject.AdjacentRoomInformation();

            int RoomIndex = listofadjacentrooms[0].RoomNumber;
            pictureBoxGeneralRoomBackground.Image = Image.FromFile(ListofImageLocation[RoomIndex]);

            // Change the Button Labels and disable the Buttons in order to stop User from touching them. 

            buttonNextRoom1.Text = "Room: " + listofadjacentrooms[1].RoomNumber.ToString();
            buttonNextRoom2.Text = "Room: " + listofadjacentrooms[2].RoomNumber.ToString();
            buttonNextRoom3.Text = "Room: " + listofadjacentrooms[3].RoomNumber.ToString();
            buttonNextRoom4.Text = "Room: " + listofadjacentrooms[4].RoomNumber.ToString();
            buttonNextRoom5.Text = "Room: " + listofadjacentrooms[5].RoomNumber.ToString();
            buttonNextRoom6.Text = "Room: " + listofadjacentrooms[6].RoomNumber.ToString();

            buttonNextRoom1.Enabled = false;
            buttonNextRoom2.Enabled = false;
            buttonNextRoom3.Enabled = false;
            buttonNextRoom4.Enabled = false;
            buttonNextRoom5.Enabled = false;
            buttonNextRoom6.Enabled = false;

            // Redraw Inventory

            textBoxGoldCoinAmount.Text = GameControlObject.PlayerGoldCoinAmount().ToString();
            textBoxArrowAmount.Text = GameControlObject.PlayerArrowAmount().ToString();

            // Do the Warnings
            bool hasBat = false;
            bool hasPit = false;
            bool hasWumpus = false;

            for (int i = 1; i < 7; i++)
            {
                Room newroomtoconsider = listofadjacentrooms[i];

                if (newroomtoconsider.HasBats == true)
                {
                    hasBat = true;
                }

                if (newroomtoconsider.HasWumpus == true)
                {
                    hasWumpus = true;
                }

                if (newroomtoconsider.HasPit == true)
                {

                    hasPit = true;
                }

             
            }

            // Change the Actual Checkboxes
            if (hasBat == true)
            {
                checkBoxbatsnearby.Checked = true;
            }

            if (hasPit == true)
            {
                checkBoxpitnearby.Checked = true;
            }

            if (hasWumpus == true)
            {
                checkBoxwumpusneabry.Checked = true;
            }

            bool[] BoolListToReturn = { listofadjacentrooms[0].HasWumpus, listofadjacentrooms[0].HasBats, listofadjacentrooms[0].HasPit };
            return BoolListToReturn;
        }
        


        /*
        public void UserMovesForward()
        {
            Room RoomUserIn = GameControlObject.GetRoomUserMovingTo(RoomNumber, SelfInitated);
            TriviaAnswer TriviatoShow = GameControlObject.SendTriviaAnswer();
        }
        */

        public void WampusInRoom()
        {
            TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
            triviaDlg.AmountofQuestions = 5;
            triviaDlg.ShowDialog();

            bool DidWeMakeIt = triviaDlg.GotOffSaftley;

            if (DidWeMakeIt == false)
            {
                EndTheGame();
            }
            else
            {
                GameControlObject.MoveWumpus(GameControlObject.WhereIsUser());
            }
        }

        public void BatsInRoom()
        {

        }

        public void PitInRoom()
        {
            TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
            triviaDlg.AmountofQuestions = 3;
            triviaDlg.ShowDialog();

            bool DidWeMakeIt = triviaDlg.GotOffSaftley;


            if (DidWeMakeIt == false)
            {
                EndTheGame();
            }
        }
    }
}
