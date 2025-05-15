using System.Data.SqlTypes;
using System.Net.Http.Headers;
using Microsoft.VisualBasic.ApplicationServices;
using GameControl_Offical;
using CaveMain_Official2;
using TrivaMachine_Offical;
using System.Net.Sockets;
using TriviaMachine_Offical3;


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
        List<TriviaQuestion> ListofPastTriviaQuestions = new List<TriviaQuestion>();

        // Button Clicking Bool Variables.
        int WhatAreWeChoosingMove0orWampus1;
        public Form1()
        {
            InitializeComponent();
            // GameControlObject.AddOriginalTriviaFile(); // Only Active This if you need to write Trivia to File. Please talk to Sergei before doing this! YOU WILL MESS UP YOUR LOCAL FILE!
            // GameControlObject.AddOriginalHighScores(); // Only Active This if you need to write High Scores to File. Please talk to Sergei before doing this! YOU WILL MESS UP YOUR LOCAL FILE!
            // GameControlObject.AddOriginalSecretFile(); // Only Active This if you need to write High Scores to File. Please talk to Sergei before doing this! YOU WILL MESS UP YOUR LOCAL FILE!
            StartTheGame();
        }

        /// <summary>
        /// Works with Moving the Location of the User or Having the User Shoot a Arrow. 
        /// </summary>
        /// <param name="RoomNumber"> The Room Number to Consider </param>
        /// <param name="MovingForWhat"> What are we moving for: 0 - User is Moving. 1 - User is Shooting. </param>
        private void MoveToNewRoomOrshootWampus(int RoomNumber, int MovingForWhat)
        {
            if (MovingForWhat == 0) // This means that we are moving for actual moving. 
            {
                GameControlObject.UpdateWhereUserIs(RoomNumber);
                TriviaQuestion TriviaQuestionToUse = GameControlObject.SendTriviaQuestion();
                ShowTriviaAnswer(TriviaQuestionToUse, true);
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

        /// <summary>
        /// Shows a Trivia Answer to the User. 
        /// </summary>
        /// <param name="TriviaQuestionToUse"> The Trivia Answer to Show </param>
        private void ShowTriviaAnswer(TriviaQuestion TriviaQuestionToUse, bool newQuestion)
        {
            TriviaAnswerUI TriviaAnswerUIDlg = new TriviaAnswerUI();
            this.Hide();
            TriviaAnswerUIDlg.TriviaAnswerToUse = TriviaQuestionToUse;
            TriviaAnswerUIDlg.ShowDialog();

            if (newQuestion)
            {
                ListofPastTriviaQuestions.Add(TriviaQuestionToUse);
                int i = ListofPastTriviaQuestions.Count;
                listBoxTriviaQuestion.Items.Add("Trivia Question Number: #" + (i).ToString());
            }
            this.Show();
        }

        /// <summary>
        /// Starts the Game. Shows the Opening Menu, and then draws the Initial Room. 
        /// </summary>
        private void StartTheGame()
        {
            // Open the inital Menu. Give the User the oppertunity to login.

            OpeningMenu OpentheMenuObject = new OpeningMenu();
            OpentheMenuObject.ShowDialog();
            UserUsername = OpentheMenuObject.UsernameToReturn;

            while (string.IsNullOrWhiteSpace(UserUsername) == true)
            {
                this.Close();
            }

            bool[] DangerInRoom = DrawTheRoom(GameControlObject.WhereIsUser());
        }

        /// <summary>
        /// Facilitates the Choice of the User. The Six Different Turns on the Right Side of the UI. 
        /// </summary>
        /// <param name="ChoiceIndex"> What is the User Chosing to Do. 1 - Buy Arrow. 2 - Shoot an Arrow. 3 - Buy a Secret. 4 - View a Secret. 5 - User Moving To New Room. 6 - User Wants to End Game Now. </param>
        private void UserMoving(int ChoiceIndex)
        {
            if (ChoiceIndex == 1)
            {
                UserBuysAnArrow();
            }
            else if (ChoiceIndex == 2)
            {
                int PlayerArrowAmount = GameControlObject.PlayerArrowAmount();

                if (PlayerArrowAmount > 0)
                {
                    GameControlObject.AddUserTurn();
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
                else
                {
                    DisplayaMessage("Sorry. You do not have arrows to shoot. Please buy them if possible, otherwise end the game.");
                }
            }
            else if (ChoiceIndex == 3)
            {
                UserBuysASecret();
            }
            else if (ChoiceIndex == 5)
            {
                GameControlObject.AddUserTurn();
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

        /// <summary>
        /// Disables Input for all Buttons except the Room Buttons. 
        /// </summary>
        public void DisableAllButtonsForRoomInput()
        {
            buttonMovetoNextRoom.Enabled = false;
            buttonShootanArrow.Enabled = false;
            buttonPurchaseArrow.Enabled = false;
            buttonPurchaseSecret.Enabled = false;
            buttonEndGameNow.Enabled = false;
        }

        /// <summary>
        /// Enables Room Input Buttons. 
        /// </summary>
        public void EnableAllButtonsForRoomInput()
        {
            buttonMovetoNextRoom.Enabled = true;
            buttonShootanArrow.Enabled = true;
            buttonPurchaseArrow.Enabled = true;
            buttonPurchaseSecret.Enabled = true;
            buttonEndGameNow.Enabled = true;
        }

        /// <summary>
        /// The End Game Function. Ends the Game and Shows the High Score UI.
        /// </summary>
        private void EndTheGame() // This Function is most important as it will end the game when needed.
        {
            HighScoreUI HighScoreDlg = new HighScoreUI();
            HighScoreDlg.PlayedGameOrNot = true;
            HighScoreDlg.GameControlObject = GameControlObject;
            this.Hide();
            HighScoreDlg.ShowDialog();
        }

        /* Function not needed. Will delete if I do not find a better usuage for this. 
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

            
            for (int i = 1; i < 31; i++)
            {
                string newString = stringAddress + "HuntheWumpusRoom" + i.ToString(); // Notice the one t, in the string. 
                ListtoReturn2.Add(newString);
            }
            
            return ListtoReturn;
        }
        */

        /// <summary>
        /// Draws the Room. Resets the UI to have just the User Choices Avaliable. Returns a bool[] of Dangers in the Room. 
        /// </summary>
        /// <param name="RoomNumberToDraw"> The Room Number of the Room to Draw. </param>
        /// <returns></returns>
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
            textBoxAmountofTurns.Text = GameControlObject.PlayerTurnAmount().ToString();

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

        /// <summary>
        /// Function that handels the event of a Wampus in the Room. If User fails ends the game, otherwise moves Wumpus. 
        /// </summary>
        public void WampusInRoom()
        {
            DisplayaMessage("You encountered a Wumpus! You now have to answer 3 out of 5 Trivia Questions Correctly!");

            TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
            triviaDlg.AmountofQuestions = 5;
            triviaDlg.GameControlObject = GameControlObject;
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

        /// <summary>
        /// Function that handels the event of Bats in the Room. Moves Bats and Room to a new location. 
        /// </summary>
        public void BatsInRoom()
        {
            DisplayaMessage("You encountered a Bat! You will now be moved to a new room at random!");

            int RoomToUseTo = GameControlObject.GetNewUserRoom();
            GameControlObject.MoveBatsFromRoom(RoomToUseTo);
            MoveToNewRoomOrshootWampus(RoomToUseTo, 0);
        }

        /// <summary>
        /// Function that handels the event of a Pit in the Room. If User fails ends the game. Otherwise, moves User back to Start. 
        /// </summary>
        public void PitInRoom()
        {
            DisplayaMessage("You encountered a Pit! You now have to answer 2 out of 3 Trivia Questions Correctly!");

            TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
            triviaDlg.AmountofQuestions = 3;
            triviaDlg.GameControlObject = GameControlObject;
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

        /// <summary>
        /// Function that handels the desire of the User to Buy An Arrow. Checks if we can actually buy an Arrow. Then if the User gets Trivia Correct, Adds the Arrow. 
        /// </summary>
        private void UserBuysAnArrow()
        {
            if (GameControlObject.CanWeBuyAnArrow())
            {
                string StringtoShow = "This operations costs 3 Coins. You have: " + GameControlObject.PlayerGoldCoinAmount().ToString() + " Coins. Do You want to contiue?";
                bool DoWeContiueWithAction = DisplayAYesNoMessage(StringtoShow);

                if (DoWeContiueWithAction)
                {
                    GameControlObject.AddUserTurn();
                    DisplayaMessage("We Will Contiue. Please Get 2 Questions out of 3 Correct!");

                    TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
                    triviaDlg.AmountofQuestions = 3;
                    triviaDlg.GameControlObject = GameControlObject;
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
        /// <summary>
        /// Function that handels the desire of the User to shoot an Arrow. First checks if we have an arrow, then if Wumpus is in the Room, the User shoot into. 
        /// </summary>
        /// <param name="RoomToWhichWeShoot"></param>
        private void UserShootAnArrow(int RoomToWhichWeShoot)
        {
            GameControlObject.RemoveArrowPlayerInventory();
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

        /// <summary>
        /// Function that handels the desire of the User to Buy a Secret. 
        /// </summary>
        private void UserBuysASecret()
        {
            string StringtoShow = "This operations costs 3 Coins. You have: " + GameControlObject.PlayerGoldCoinAmount().ToString() + " Coins. Do You want to contiue?";
            bool DoWeContiueWithAction = DisplayAYesNoMessage(StringtoShow);

            if (DoWeContiueWithAction)
            {
                GameControlObject.AddUserTurn();
                DisplayaMessage("We Will Contiue. Please Get 2 Questions out of 3 Correct!");

                TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
                triviaDlg.AmountofQuestions = 3;
                triviaDlg.GameControlObject = GameControlObject;
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
                        string SecretToShow = GameControlObject.GetSecretObject();
                        DisplayaMessage("Secret is: " + SecretToShow);
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
        /// <summary>
        /// Function that handels the desire of the User to View a Secret. 
        /// </summary>

        /// <summary>
        /// Function that Displays a Custom Yes or No Box, and then uses the input furthur. 
        /// </summary>
        /// <param name="StringToDisplay"> Question that the User is Asked. </param>
        /// <returns></returns>
        private bool DisplayAYesNoMessage(string StringToDisplay)
        {
            MessageBoxYesorNoCustom MessageBoxShowDlg = new MessageBoxYesorNoCustom();
            MessageBoxShowDlg.QuestionToDisplay = StringToDisplay;
            MessageBoxShowDlg.ShowDialog();

            bool ResultOfMessageBox = MessageBoxShowDlg.ResultOfQuestion;
            return ResultOfMessageBox;
        }

        /// <summary>
        /// Function that displays a Message in a Custom Message Box. 
        /// </summary>
        /// <param name="StringToDisplay"> String that the Message Box will Display. </param>
        private void DisplayaMessage(string StringToDisplay)
        {
            MessageBoxCustom MessageBoxDlg = new MessageBoxCustom();
            MessageBoxDlg.StringToDispaly = StringToDisplay;
            MessageBoxDlg.ShowDialog();
        }

        // All Functions from this one to Button_End Game Now, are called when the User clicks a Choice Button. The Name is indivicative of the choice. 
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

        /// <summary>
        /// Function that changes the background image of the Room. 
        /// </summary>
        /// <param name="RoomNumberToGetBackgroundFor"> Using the Room Number to change the background image of the Room to the correct value. </param>
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

        // These Function Make the Checkboxs take the correct state if the user decides to independently change the Checboxes. 
        private void checkBoxwumpusneabry_CheckedChanged(object sender, EventArgs e)
        {
            listofadjacentrooms = GameControlObject.AdjacentRoomInformation(GameControlObject.WhereIsUser());

            bool hasWampus = false;

            for (int i = 1; i < 7; i++)
            {
                Room newroomtoconsider = listofadjacentrooms[i];

                if (newroomtoconsider.HasWumpus == true)
                {
                    hasWampus = true;
                }
            }

            checkBoxwumpusneabry.Checked = hasWampus;
        }

        private void checkBoxpitnearby_CheckedChanged(object sender, EventArgs e)
        {
            listofadjacentrooms = GameControlObject.AdjacentRoomInformation(GameControlObject.WhereIsUser());

            bool hasPit = false;

            for (int i = 1; i < 7; i++)
            {
                Room newroomtoconsider = listofadjacentrooms[i];

                if (newroomtoconsider.HasPit == true)
                {
                    hasPit = true;
                }
            }

            checkBoxpitnearby.Checked = hasPit;
        }

        private void checkBoxbatsnearby_CheckedChanged(object sender, EventArgs e)
        {
            listofadjacentrooms = GameControlObject.AdjacentRoomInformation(GameControlObject.WhereIsUser());

            bool hasBat = false;

            for (int i = 1; i < 7; i++)
            {
                Room newroomtoconsider = listofadjacentrooms[i];

                if (newroomtoconsider.HasBats == true)
                {
                    hasBat = true;
                }
            }

            checkBoxbatsnearby.Checked = hasBat;
        }

        private void listBoxTriviaQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTriviaQuestion.SelectedIndex != -1)
            {
                int IndexofTrivia = listBoxTriviaQuestion.SelectedIndex;

                ShowTriviaAnswer(ListofPastTriviaQuestions[IndexofTrivia], false);
            }

            listBoxTriviaQuestion.SelectedIndex = -1;
        }
    }
}
