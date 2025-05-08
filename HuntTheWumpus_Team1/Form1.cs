using System.Data.SqlTypes;
using System.Net.Http.Headers;
using Microsoft.VisualBasic.ApplicationServices;
using GameControl_Offical;
using CaveMain_Official2;
using TrivaMachine_Offical;


namespace HuntTheWumpus_Team1
{
    public partial class Form1 : Form
    {
        Player_GameControl GameControlObject = new GameControl_Offical.Player_GameControl();
        // int RoomNumber = 1;
        // bool SelfInitated = true;

        string UserUsername;
        // System Specific Image Location:
        List<string> ListofImageLocation = new List<string>();
        List<Room> listofadjacentrooms = new List<Room>();
        // Button Clicking Bool Variables.

        int WhatAreWeChoosingMove0orWampus1;
        public Form1()
        {
            InitializeComponent();

            // Add the Locations
            ListofImageLocation = MakeListofImageLocation();
            // GameControlObject.AddOriginalTriviaFile(); // Only Active This if you need to write Trivia to File. Please talk to Sergei before doing this! YOU WILL MESS UP YOUR LOCAL FILE!
            // GameControlObject.AddOriginalHighScores(); // Only Active This if you need to write High Scores to File. Please talk to Sergei before doing this! YOU WILL MESS UP YOUR LOCAL FILE!
            Main();
        }
        private void Main() // THE MAIN FUNCTION HERE!
        {
            StartTheGame();
            // UserMoving();

            // The Question that might come up is: Why so few? This is because after the User Selects to Move, We Move to the Function Below. This repeats on Innite till the Game Ends. 
        }

        private void MoveToNewRoomOrshootWampus(int RoomNumber, int MovingForWhat)
        {
            if (MovingForWhat == 0) // This means that we are moving for actual moving. 
            {
                GameControlObject.UpdateWhereUserIs(RoomNumber);
                ShowTriviaAnswer();
                GameControlObject.AddGoldCoin();
                bool[] BoolArrayOfWarnings = DrawTheRoom(RoomNumber);

                if (BoolArrayOfWarnings[0] == true) // No more than 1 hazard in room. 
                {
                    WampusInRoom();
                }
                else if (BoolArrayOfWarnings[1] == true)
                {
                    BatsInRoom();
                }
                else if (BoolArrayOfWarnings[2] == true)
                {
                    PitInRoom();
                }
            }
            else
            {
                UserShootAnArrow(RoomNumber);
            }

            EnableAllButtonsForRoomInput();
            buttonNextRoom1.Enabled = false;
            buttonNextRoom2.Enabled = false;
            buttonNextRoom3.Enabled = false;
            buttonNextRoom4.Enabled = false;
            buttonNextRoom5.Enabled = false;
            buttonNextRoom6.Enabled = false;
        }

        private void ShowTriviaAnswer()
        {
            TriviaAnswerUI TriviaAnswerUIDlg = new TriviaAnswerUI();
            TriviaAnswerUIDlg.TriviaAnswerToUse = GameControlObject.SendTriviaQuestion();
            TriviaAnswerUIDlg.ShowDialog();
        }
        private void StartTheGame()
        {
            // Open the inital Menu. Give the User the oppertunity to login.
            
            OpeningMenu OpentheMenuObject = new OpeningMenu();
            OpentheMenuObject.ShowDialog();
            UserUsername = OpentheMenuObject.UsernameToReturn;
            

            bool[] DangerInRoom = DrawTheRoom(GameControlObject.WhereIsUser());
        }

        private void UserMoving(int ChoiceIndex)
        {
            GameControlObject.AddUserTurn();
            if (ChoiceIndex == 1)
            {
                UserBuysAnArrow();
            }
            else if (ChoiceIndex == 2)
            {
                WhatAreWeChoosingMove0orWampus1 = 1;
                DisplayaMessage("Please choose a room into which to shoot the arrow");
                buttonNextRoom1.Enabled = true;
                buttonNextRoom2.Enabled = true;
                buttonNextRoom3.Enabled = true;
                buttonNextRoom4.Enabled = true;
                buttonNextRoom5.Enabled = true;
                buttonNextRoom6.Enabled = true;

                // Just Diables all the other buttons the other can press. 
                DisableAllButtonsForRoomInput();
            }
            else if (ChoiceIndex == 3)
            {
                UserBuysASecret();
            }
            else if (ChoiceIndex == 4)
            {
                UserViewaSecret();
            }
            else if (ChoiceIndex == 5)
            {
                buttonNextRoom1.Enabled = true;
                buttonNextRoom2.Enabled = true;
                buttonNextRoom3.Enabled = true;
                buttonNextRoom4.Enabled = true;
                buttonNextRoom5.Enabled = true;
                buttonNextRoom6.Enabled = true;

                // Just Diables all the other buttons the other can press. 
                DisableAllButtonsForRoomInput();

                WhatAreWeChoosingMove0orWampus1 = 0;
            }
            else
            {
                EndTheGame();
            }
           textBoxGoldCoinAmount.Text = GameControlObject.PlayerGoldCoinAmount().ToString();
           textBoxArrowAmount.Text = GameControlObject.PlayerArrowAmount().ToString();
        }

        public void DisableAllButtonsForRoomInput()
        {
            buttonMovetoNextRoom.Enabled = false;
            buttonShootanArrow.Enabled = false;
            buttonPurchaseArrow.Enabled = false;
            buttonPurchaseSecret.Enabled = false;
            buttonViewSecret.Enabled = false;
            buttonEndGameNow.Enabled = false;
        }

        public void EnableAllButtonsForRoomInput()
        {
            buttonMovetoNextRoom.Enabled = true;
            buttonShootanArrow.Enabled = true;
            buttonPurchaseArrow.Enabled = true;
            buttonPurchaseSecret.Enabled = true;
            buttonViewSecret.Enabled = true;
            buttonEndGameNow.Enabled = true;
        }


        private void EndTheGame() // This Function is most important as it will end the game when needed.
        {
            HighScoreUI HighScoreDlg = new HighScoreUI();
            HighScoreDlg.PlayedGameOrNot = true;
            HighScoreDlg.ShowDialog();
        }

        private List<String> MakeListofImageLocation()
        {
            List<string> ListtoReturn = new List<string>();
            // List<string> ListtoReturn2 = new List<string>();
            // Change the Location of the Pictures to the Image System - Specific Location. 
            ListtoReturn.Add("Blank String"); // Room Index starts at 1, not the reuglar 0.

            string stringAddress = "\"C:\\Users\\1117057\\source\\repos\\SergeiMakarevich_HuntTheWumpusLocal\\HuntTheWumpus_Team1\\PictureforRoomBackground\\";
            // string stringAddress = "\"C:\\Users\\Sergei\\source\\repos\\HuntTheWumpus-Team1\\HuntTheWumpus_Team1\\PictureforRoomBackground\\HuntheWumpusRoom1.png\"";

            for (int i = 1; i < 31; i++)
            {
                string newString = stringAddress + "HuntheWumpusRoom" + i.ToString() + ".png\\"; // Notice the one t, in the string. 
                ListtoReturn.Add(newString);
            }

            /*
            for (int i = 1; i < 31; i++)
            {
                string newString = stringAddress + "HuntheWumpusRoom" + i.ToString(); // Notice the one t, in the string. 
                ListtoReturn2.Add(newString);
            }
            */
            return ListtoReturn;
        }

        private bool[] DrawTheRoom(int RoomNumberToDraw)
        {
            // This Room List should be of this form: [RoomUser, RoomtotheTopLeft, .... (Coutnerclockwise), ....]
            listofadjacentrooms = GameControlObject.AdjacentRoomInformation(RoomNumberToDraw);

            int RoomIndex = listofadjacentrooms[0].RoomNumber;
            // The Following are some other ways to get the Background Image to be correct. 
            // pictureBoxGeneralRoomBackground.Image = Properties.Resources.ListofImageLocations[] 
            // pictureBoxGeneralRoomBackground.Image = Image.FromFile(ListofImageLocation[RoomIndex]);
            // "\"C:\\Users\\1117057\\source\\repos\\SergeiMakarevich_HuntTheWumpusLocal\\HuntTheWumpus_Team1\\PictureforRoomBackground\\HuntheWumpusRoom1.png\""
            GetCorrectRoomBackground(RoomIndex);
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

            EnableAllButtonsForRoomInput();

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
            else
            {
                checkBoxbatsnearby.Checked = false;
            }

            if (hasPit == true)
            {
                checkBoxpitnearby.Checked = true;
            }
            else
            {
                checkBoxpitnearby.Checked = false;
            }

            if (hasWumpus == true)
            {
                checkBoxwumpusneabry.Checked = true;
            }
            else
            {
                checkBoxwumpusneabry.Checked = false;
            }

            bool[] BoolListToReturn = { listofadjacentrooms[0].HasWumpus, listofadjacentrooms[0].HasBats, listofadjacentrooms[0].HasPit };
            return BoolListToReturn;
        }

        public void WampusInRoom()
        {
            DisplayaMessage("You encountered a Wumpus! You now have to answer 3 out of 5 Trivia Questions Correctly!");

            TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
            triviaDlg.AmountofQuestions = 5;
            triviaDlg.ShowDialog();

            bool DidWeMakeItWithCoins = triviaDlg.GotOffWithCoins;
            bool DidWeMakeItWithQuestions = triviaDlg.GotOffWithQuestions;

            bool DidWeMakeIt = (DidWeMakeItWithCoins == true && DidWeMakeItWithQuestions == true);
            if (DidWeMakeIt == false)
            {
                // Change this to pass into the Wampus deafeted. YOU DID THIS WRONG!
                EndTheGame();
            }
            else
            {
                DisplayaMessage("We narowly avoided the Wampus! It will now move to a different room!");
                GameControlObject.MoveWumpus(GameControlObject.WhereIsUser());
            }
        }

        public void BatsInRoom()
        {
            DisplayaMessage("You encountered a Bat! You will now be moved to a new room at random!");

            int RoomToUseTo = GameControlObject.GetNewUserRoom();
            GameControlObject.MoveBatsFromRoom(RoomToUseTo);
            MoveToNewRoomOrshootWampus(RoomToUseTo, 0);
        }

        public void PitInRoom()
        {
            DisplayaMessage("You encountered a Pit! You now have to answer 2 out of 3 Trivia Questions Correctly!");

            TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
            triviaDlg.AmountofQuestions = 3;
            triviaDlg.ShowDialog();

            bool DidWeMakeItWithCoins = triviaDlg.GotOffWithCoins;
            bool DidWeMakeItWithQuestions = triviaDlg.GotOffWithQuestions;

            bool DidWeMakeIt = (DidWeMakeItWithCoins == true && DidWeMakeItWithQuestions == true);
            if (DidWeMakeIt == false)
            {
                EndTheGame();
            }
            else
            {
                MoveToNewRoomOrshootWampus(1, 0); // Moving back to Room 1.
            }
        }


        private void UserBuysAnArrow()
        {
            if (GameControlObject.CanWeBuyAnArrow())
            {
                string StringtoShow = "This operations costs 3 Coins. You have: " + GameControlObject.PlayerGoldCoinAmount().ToString() + " Coins. Do You want to contiue?";
                bool DoWeContiueWithAction = DisplayAYesNoMessage(StringtoShow);

                if (DoWeContiueWithAction)
                {
                    DisplayaMessage("We Will Contiue. Please Get 2 Questions out of 3 Correct!");

                    TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
                    triviaDlg.AmountofQuestions = 3;
                    triviaDlg.ShowDialog();

                    bool DidWeMakeItWithCoins = triviaDlg.GotOffWithCoins;
                    bool DidWeMakeItWithQuestions = triviaDlg.GotOffWithQuestions;

                    if (DidWeMakeItWithCoins == false)
                    {
                        EndTheGame();
                    }
                    else
                    {
                        if (DidWeMakeItWithQuestions)
                        {
                            DisplayaMessage("We have an Extra Arrow!");
                            GameControlObject.AddArrow();
                            textBoxArrowAmount.Text = GameControlObject.PlayerArrowAmount().ToString();
                        }
                        else
                        {
                            DisplayaMessage("We did not get an extra Extra Arrow!");
                        }
                    }
                }
                else
                {
                    DisplayaMessage("We will not continue.");
                }
            }
            else
            {
                DisplayaMessage("You can no longer buy an arrows! Only 2 per Game.");
            }
        }

        private void UserShootAnArrow(int RoomToWhichWeShoot)
        {
            int PlayerArrowAmount = GameControlObject.PlayerArrowAmount();

            if (PlayerArrowAmount > 0)
            {
                GameControlObject.RemoveArrowPlayerInventory();
                // DisplayaMessage("Please select the Room into which you want to shoot an arrow.");

                // int RoomToWhichWeShoot = GetRoomInput();

                // Check if Wampus Was in that Room.

                bool GotWampus = GameControlObject.CheckIfWampusInRoom(RoomToWhichWeShoot);

                if (GotWampus)
                {
                    DisplayaMessage("You got the Wampus! Ending the Game");
                    GameControlObject.ChangeWumpusDefetedStatus();
                    EndTheGame();
                }
                else
                {
                    DisplayaMessage("You did not get the Wampus. We will now move the Wumpus.");
                    Random randomvariable = new Random();

                    if (randomvariable.Next(1, 2) == 1) // Randomly move Wampus.
                    {
                        GameControlObject.MoveWumpus(GameControlObject.WhereIsUser());
                    }
                }

                textBoxArrowAmount.Text = GameControlObject.PlayerArrowAmount().ToString();

            }
            else
            {
                DisplayaMessage("Sorry. You do not have arrows to shoot. Please buy them if possible, otherwise end the game.");
            }
        }


        private void UserBuysASecret()
        {
            string StringtoShow = "This operations costs 3 Coins. You have: " + GameControlObject.PlayerGoldCoinAmount().ToString() + " Coins. Do You want to contiue?";
            bool DoWeContiueWithAction = DisplayAYesNoMessage(StringtoShow);

            if (DoWeContiueWithAction)
            {
                DisplayaMessage("We Will Contiue. Please Get 2 Questions out of 3 Correct!");

                TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
                triviaDlg.AmountofQuestions = 3;
                triviaDlg.ShowDialog();

                bool DidWeMakeItWithCoins = triviaDlg.GotOffWithCoins;
                bool DidWeMakeItWithQuestions = triviaDlg.GotOffWithQuestions;

                if (DidWeMakeItWithCoins == false)
                {
                    EndTheGame();
                }
                else
                {
                    if (DidWeMakeItWithQuestions)
                    {
                        DisplayaMessage("We have an Extra Secret!");
                        string SecretToShow = GameControlObject.AddASecretToList();
                        DisplayaMessage("Secret is: " + SecretToShow);
                        List<string> ListofSecrets = GameControlObject.ReturnSecretList();

                        for (int i = 0; i < ListofSecrets.Count; i++)
                        {
                            listBoxSecretsList.Items.Add("Secret " + i.ToString());
                        }
                    }
                    else
                    {
                        DisplayaMessage("We do not have an Extra Secret");
                    }
                    
                }
            }
            else
            {
                DisplayaMessage("We will not continue.");
            }
        }

        private void UserViewaSecret()
        {
            DisplayaMessage("Please select a Secret From Down Below");

            while (listBoxSecretsList.SelectedIndex == -1)
            {
                // Do Nothing. Wait for User to select a Index.
            }

            int index = listBoxSecretsList.SelectedIndex;
            string SecretToShow = GameControlObject.ReturnSecretList()[index];
            string StringToShow = "Secret " + index.ToString() + ": " + SecretToShow;
            DisplayaMessage(StringToShow);
        }

        private bool DisplayAYesNoMessage(string StringToDisplay)
        {
            MessageBoxYesorNoCustom MessageBoxShowDlg = new MessageBoxYesorNoCustom();
            MessageBoxShowDlg.QuestionToDisplay = StringToDisplay;
            MessageBoxShowDlg.ShowDialog();

            bool ResultOfMessageBox = MessageBoxShowDlg.ResultOfQuestion;
            return ResultOfMessageBox;
        } // This Function is fine. 
        private void DisplayaMessage(string StringToDisplay)
        {
            MessageBoxCustom MessageBoxDlg = new MessageBoxCustom();
            MessageBoxDlg.StringToDispaly = StringToDisplay;
            MessageBoxDlg.ShowDialog();
        } // This Function is fine.
        private void buttonMovetoNextRoom_Click(object sender, EventArgs e)
        {
            UserMoving(5);
        }

        private void buttonShootanArrow_Click(object sender, EventArgs e)
        {
            UserMoving(2);
        }

        private void buttonPurchaseArrow_Click(object sender, EventArgs e)
        {
            UserMoving(1);
        }

        private void buttonPurchaseSecret_Click(object sender, EventArgs e)
        {
            UserMoving(3);
        }

        private void buttonEndGameNow_Click(object sender, EventArgs e)
        {
            UserMoving(6);
        }

        private void buttonNextRoom6_Click(object sender, EventArgs e)
        {
            MoveToNewRoomOrshootWampus(listofadjacentrooms[6].RoomNumber, WhatAreWeChoosingMove0orWampus1);
        }

        private void buttonNextRoom5_Click(object sender, EventArgs e)
        {
            MoveToNewRoomOrshootWampus(listofadjacentrooms[5].RoomNumber, WhatAreWeChoosingMove0orWampus1);
        }

        private void buttonNextRoom4_Click(object sender, EventArgs e)
        {
            MoveToNewRoomOrshootWampus(listofadjacentrooms[4].RoomNumber, WhatAreWeChoosingMove0orWampus1);
        }

        private void buttonNextRoom3_Click(object sender, EventArgs e)
        {
            MoveToNewRoomOrshootWampus(listofadjacentrooms[3].RoomNumber, WhatAreWeChoosingMove0orWampus1);
        }

        private void buttonNextRoom2_Click(object sender, EventArgs e)
        {
            MoveToNewRoomOrshootWampus(listofadjacentrooms[2].RoomNumber, WhatAreWeChoosingMove0orWampus1);
        }

        private void buttonNextRoom1_Click(object sender, EventArgs e)
        {
            MoveToNewRoomOrshootWampus(listofadjacentrooms[1].RoomNumber, WhatAreWeChoosingMove0orWampus1);
        }

        private void buttonViewSecret_Click(object sender, EventArgs e)
        {
            UserMoving(4);
        }

        private void GetCorrectRoomBackground(int RoomNumberToGetBackgroundFor)
        {
            if (RoomNumberToGetBackgroundFor == 1)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom1;
            }
            else if (RoomNumberToGetBackgroundFor == 2)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom2;
            }
            else if (RoomNumberToGetBackgroundFor == 3)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom3;
            }
            else if (RoomNumberToGetBackgroundFor == 4)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom4;
            }
            else if (RoomNumberToGetBackgroundFor == 5)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom5;
            }
            else if (RoomNumberToGetBackgroundFor == 6)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom6;
            }
            else if (RoomNumberToGetBackgroundFor == 7)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom7;
            }
            else if (RoomNumberToGetBackgroundFor == 8)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom8;
            }
            else if (RoomNumberToGetBackgroundFor == 9)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom9;
            }
            else if (RoomNumberToGetBackgroundFor == 10)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom10;
            }
            else if (RoomNumberToGetBackgroundFor == 11)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom11;
            }
            else if (RoomNumberToGetBackgroundFor == 12)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom12;
            }
            else if (RoomNumberToGetBackgroundFor == 13)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom13;
            }
            else if (RoomNumberToGetBackgroundFor == 14)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom14;
            }
            else if (RoomNumberToGetBackgroundFor == 15)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom15;
            }
            else if (RoomNumberToGetBackgroundFor == 16)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom16;
            }
            else if (RoomNumberToGetBackgroundFor == 17)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom17;
            }
            else if (RoomNumberToGetBackgroundFor == 18)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom18;
            }
            else if (RoomNumberToGetBackgroundFor == 19)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom19;
            }
            else if (RoomNumberToGetBackgroundFor == 20)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom20;
            }
            else if (RoomNumberToGetBackgroundFor == 21)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom21;
            }
            else if (RoomNumberToGetBackgroundFor == 22)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom22;
            }
            else if (RoomNumberToGetBackgroundFor == 23)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom23;
            }
            else if (RoomNumberToGetBackgroundFor == 24)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom24;
            }
            else if (RoomNumberToGetBackgroundFor == 25)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom25;
            }
            else if (RoomNumberToGetBackgroundFor == 26)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom26;
            }
            else if (RoomNumberToGetBackgroundFor == 27)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom27;
            }
            else if (RoomNumberToGetBackgroundFor == 28)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom28;
            }
            else if (RoomNumberToGetBackgroundFor == 29)
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom29;
            }
            else
            {
                pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom30;
            }
        }
    }
}
