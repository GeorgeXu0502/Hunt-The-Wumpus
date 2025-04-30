using System.Data.SqlTypes;
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

        // Button Clicking Bool Variables.

        bool ButtonMoveToNextRoomClicked = false;
        bool ButtonBuyanArrowClicked = false;
        bool ButtonShootanArrowClicked = false;
        bool ButtonBuyaSecretClicked = false;
        bool ButtonEndGameNowClicked = false;

        bool ButtomRoom1Clicked = false;
        bool ButtomRoom2Clicked = false;
        bool ButtomRoom3Clicked = false;
        bool ButtomRoom4Clicked = false;
        bool ButtomRoom5Clicked = false;
        bool ButtomRoom6Clicked = false;
        public Form1()
        {
            InitializeComponent();

            // Add the Locations
            ListofImageLocation = MakeListofImageLocation();
            Main();
        }
        private void Main() // THE MAIN FUNCTION HERE!
        {
            StartTheGame();
            UserMoving();


            /* Exmaple Code For Later
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
            */


        }

        private void StartTheGame()
        {
            // Open the inital Menu. Give the User the oppertunity to login.
            OpeningMenu OpentheMenuObject = new OpeningMenu();
            OpentheMenuObject.ShowDialog();

            bool[] DangerInRoom = DrawTheRoom();
        }

        private void UserMoving()
        {
            int ChoiceIndex = GetInput();

            while (ChoiceIndex != 0) // Let User Do WhatEver Till They Choose To Move Rooms
            {
                if (ChoiceIndex == 1)
                {
                    UserBuysAnArrow();
                }
                else if (ChoiceIndex == 2)
                {
                    UserShootAnArrow();
                }
                else if (ChoiceIndex == 3)
                {
                    UserBuyASecret();
                }
                else
                {
                    EndTheGame();
                }

                ChoiceIndex = GetInput();

            }

            buttonNextRoom1.Enabled = true;
            buttonNextRoom2.Enabled = true;
            buttonNextRoom3.Enabled = true;
            buttonNextRoom4.Enabled = true;
            buttonNextRoom5.Enabled = true;
            buttonNextRoom6.Enabled = true;

            bool StatmentofRooms = (ButtomRoom1Clicked == false && ButtomRoom2Clicked == false && ButtomRoom3Clicked == false && ButtomRoom4Clicked == false && ButtomRoom5Clicked == false && ButtomRoom6Clicked == false);

            while (StatmentofRooms == true)
            {
                StatmentofRooms = (ButtomRoom1Clicked == false && ButtomRoom2Clicked == false && ButtomRoom3Clicked == false && ButtomRoom4Clicked == false && ButtomRoom5Clicked == false && ButtomRoom6Clicked == false);
            }

            // Get the Room We Are Moving to!! This is NEXT!
        }

        private int GetInput() // This Function get the input from the original list of options. 
        {
            // 0 - Move to Next Room, 1 - Buy an Arrow, 2 - Shoot an Arrow, 3 - Buy a Secret, 4 - End Game Now. 
            bool Statment = (ButtonMoveToNextRoomClicked == false && ButtonBuyanArrowClicked == false && ButtonShootanArrowClicked == false && ButtonBuyaSecretClicked == false && ButtonEndGameNowClicked == false);

            int toreturn;
            while (Statment == true)
            {
                Statment = (ButtonMoveToNextRoomClicked == false && ButtonBuyanArrowClicked == false && ButtonShootanArrowClicked == false && ButtonBuyaSecretClicked == false && ButtonEndGameNowClicked == false);
            }

            if (ButtonMoveToNextRoomClicked == true)
            {

                toreturn = 0;
            }
            else if (ButtonBuyanArrowClicked == true)
            {
                toreturn = 1;
            }
            else if (ButtonShootanArrowClicked == true)
            {
                toreturn = 2;
            }
            else if (ButtonBuyaSecretClicked == true)
            {
                toreturn = 3;
            }
            else
            {
                toreturn = 4;
            }

            ButtonMoveToNextRoomClicked = false;
            ButtonMoveToNextRoomClicked = false;
            ButtonShootanArrowClicked = false;
            ButtonMoveToNextRoomClicked = false;
            ButtonEndGameNowClicked = false;
            return toreturn;

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Auxilerly Function.
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
            List<Room> listofadjacentrooms = GameControlObject.AdjacentRoomInformation();

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
            string StringToDisplay = "You encountered a Wumpus! You now have to answer 3 out of 5 Trivia Questions Correctly!";

            MessageBoxCustom MessageBoxDlg = new MessageBoxCustom();
            MessageBoxDlg.StringToDispaly = StringToDisplay;
            MessageBoxDlg.ShowDialog();

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
            string StringToDisplay = "You encountered a Pit! You now have to answer 2 out of 3 Trivia Questions Correctly!";

            MessageBoxCustom MessageBoxDlg = new MessageBoxCustom();
            MessageBoxDlg.StringToDispaly = StringToDisplay;
            MessageBoxDlg.ShowDialog();

            TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
            triviaDlg.AmountofQuestions = 3;
            triviaDlg.ShowDialog();

            bool DidWeMakeIt = triviaDlg.GotOffSaftley;


            if (DidWeMakeIt == false)
            {
                EndTheGame();
            }
        }

        private void buttonMovetoNextRoom_Click(object sender, EventArgs e)
        {
            ButtonMoveToNextRoomClicked = true;
        }

        private void buttonShootanArrow_Click(object sender, EventArgs e)
        {
            ButtonShootanArrowClicked = true;
        }

        private void buttonPurchaseArrow_Click(object sender, EventArgs e)
        {
            ButtonBuyanArrowClicked = true;
        }

        private void buttonPurchaseSecret_Click(object sender, EventArgs e)
        {
            ButtonBuyaSecretClicked = true;
        }

        private void buttonEndGameNow_Click(object sender, EventArgs e)
        {
            ButtonEndGameNowClicked = true;
        }

        private void buttonNextRoom6_Click(object sender, EventArgs e)
        {
            ButtomRoom6Clicked = true;
        }

        private void buttonNextRoom5_Click(object sender, EventArgs e)
        {
            ButtomRoom5Clicked = true;
        }

        private void buttonNextRoom4_Click(object sender, EventArgs e)
        {
            ButtomRoom4Clicked = true;
        }

        private void buttonNextRoom3_Click(object sender, EventArgs e)
        {
            ButtomRoom3Clicked = true;
        }

        private void buttonNextRoom2_Click(object sender, EventArgs e)
        {
            ButtomRoom2Clicked = true;
        }

        private void buttonNextRoom1_Click(object sender, EventArgs e)
        {
            ButtomRoom1Clicked = true;
        }
    }
}
