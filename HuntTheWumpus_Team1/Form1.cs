using System.Data.SqlTypes;
using System.Net.Http.Headers;
using Microsoft.VisualBasic.ApplicationServices;
using GameControl_Offical;
using CaveMain_Official2;
using TrivaMachine_Offical;
using System.Net.Sockets;
using TriviaMachine_Offical3;
using System.Xml;
using System.Security.AccessControl;


namespace HuntTheWumpus_Team1
{
    public partial class Form1 : Form
    {
        Player_GameControl GameControlObject = new GameControl_Offical.Player_GameControl();
        UserLoginObject UserThatIsPlaying;
        // int RoomNumber = 1;
        // bool SelfInitated = true;

        string UserUsername;
        // System Specific Image Location:
        List<string> ListofImageLocation = new List<string>();
        List<Room> listofadjacentrooms = new List<Room>();
        List<TriviaQuestion> ListofPastTriviaQuestions = new List<TriviaQuestion>();

        // Button Clicking Bool Variables.
        int WhatAreWeChoosingMove0orWampus1;

        List<ResizeObject> ListofAllObjects = new List<ResizeObject>();
        private Rectangle MovetoNextRoomButtonRectangle;
        private Rectangle originalFormSize;
        private Rectangle ShootanArrowButtonRectangle;
        private Rectangle PurchaseAnArrowButtonRectangle;
        private Rectangle PurchaseSecretButtonRectangle;
        private Rectangle EndGameButtonRectangle;
        private Rectangle GroupBoxRectangle;


        public Form1()
        {
            InitializeComponent();
        }

        private void ResizeMethod(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Size.Width) - (float)(originalFormSize.Width);
            float yRatio = (float)(this.Size.Height) - (float)(originalFormSize.Height);

            // float centerofOldObjectX = r.Location.X + r.Width / 2;
            // float centerofOldObjectY = r.Location.Y + r.Height / 2;

            int newCenterX = (int)(r.Location.X + xRatio);
            int newCenterY = (int)(r.Location.Y + yRatio);

            /*
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);
            */

            // int newX = (int)(newCenterX - r.Width / 2);
            // int newY = (int)(newCenterY - r.Height / 2);

            c.Location = new Point(newCenterX, newCenterY);
            // c.Size = new Size(newWidth, newHeight);
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
        /// Enables only the rooms next to the room where the User is in, that the User cna actually shoot an arrow or move into. 
        /// </summary>
        private void EnableOnlyTheCorrectRooms()
        {
            buttonNextRoom1.Enabled = true;
            buttonNextRoom2.Enabled = true;
            buttonNextRoom3.Enabled = true;
            buttonNextRoom4.Enabled = true;
            buttonNextRoom5.Enabled = true;
            buttonNextRoom6.Enabled = true;

            listofadjacentrooms = GameControlObject.AdjacentRoomInformation(GameControlObject.WhereIsUser());

            if (listofadjacentrooms[0].CanGoToRoom[0] == false)
            {
                buttonNextRoom1.Enabled = false;
            }

            if (listofadjacentrooms[0].CanGoToRoom[1] == false)
            {
                buttonNextRoom2.Enabled = false;
            }

            if (listofadjacentrooms[0].CanGoToRoom[2] == false)
            {
                buttonNextRoom3.Enabled = false;
            }

            if (listofadjacentrooms[0].CanGoToRoom[3] == false)
            {
                buttonNextRoom4.Enabled = false;
            }

            if (listofadjacentrooms[0].CanGoToRoom[4] == false)
            {
                buttonNextRoom5.Enabled = false;
            }

            if (listofadjacentrooms[0].CanGoToRoom[5] == false)
            {
                buttonNextRoom6.Enabled = false;
            }
        }
        
        /// <summary>
        /// Starts the Game. Shows the Opening Menu, and then draws the Initial Room. 
        /// </summary>
        private void StartTheGame()
        {
            // Open the inital Menu. Give the User the oppertunity to login.

            OpeningMenu OpentheMenuObject = new OpeningMenu();
            OpentheMenuObject.ShowDialog();
            UserThatIsPlaying = OpentheMenuObject.UserToReturn;

            while (string.IsNullOrWhiteSpace(UserThatIsPlaying.UserUsername) == true)
            {
                this.Close();
            }

            IntroductionVideoForum IntroductionVideoFormDlg = new IntroductionVideoForum();
            this.Hide();
            IntroductionVideoFormDlg.ShowDialog();
            this.Show();

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
                    EnableOnlyTheCorrectRooms();

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
                EnableOnlyTheCorrectRooms();

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
            HighScoreDlg.DoneFromOpeningMenu = false;
            HighScoreDlg.GameControlObject = GameControlObject;
            HighScoreDlg.UserThatPlayer = UserThatIsPlaying;
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

            // The Following are some other ways to get the Background Image to be correct. 
            // pictureBoxGeneralRoomBackground.Image = Properties.Resources.ListofImageLocations[] 
            // pictureBoxGeneralRoomBackground.Image = Image.FromFile(ListofImageLocation[RoomIndex]);
            // "\"C:\\Users\\1117057\\source\\repos\\SergeiMakarevich_HuntTheWumpusLocal\\HuntTheWumpus_Team1\\PictureforRoomBackground\\HuntheWumpusRoom1.png\""
            GetCorrectRoomBackground(RoomNumberToDraw);
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

            buttonNextRoom1.Visible = true;
            buttonNextRoom2.Visible = true;
            buttonNextRoom3.Visible = true;
            buttonNextRoom4.Visible = true;
            buttonNextRoom5.Visible = true;
            buttonNextRoom6.Visible = true;

            // Hide from view all the rooms that are actually not connected.

            if (listofadjacentrooms[0].CanGoToRoom[0] == false)
            {
                buttonNextRoom1.Visible = false;
            }

            if (listofadjacentrooms[0].CanGoToRoom[1] == false)
            {
                buttonNextRoom2.Visible = false;
            }

            if (listofadjacentrooms[0].CanGoToRoom[2] == false)
            {
                buttonNextRoom3.Visible = false;
            }

            if (listofadjacentrooms[0].CanGoToRoom[3] == false)
            {
                buttonNextRoom4.Visible = false;
            }

            if (listofadjacentrooms[0].CanGoToRoom[4] == false)
            {
                buttonNextRoom5.Visible = false;
            }

            if (listofadjacentrooms[0].CanGoToRoom[5] == false)
            {
                buttonNextRoom6.Visible = false;
            }

            EnableAllButtonsForRoomInput();

            // Redraw Inventory

            textBoxGoldCoinAmount.Text = GameControlObject.PlayerGoldCoinAmount().ToString();
            textBoxArrowAmount.Text = GameControlObject.PlayerArrowAmount().ToString();
            textBoxAmountofTurns.Text = GameControlObject.PlayerTurnAmount().ToString();

            checkBoxbatsnearby.Checked = GameControlObject.IsBatInTheNextRoom();
            checkBoxpitnearby.Checked = GameControlObject.IsPitInTheNextRoom();
            checkBoxwumpusneabry.Checked = GameControlObject.IsWampusInTheNextRoom();

            bool[] BoolListToReturn = { listofadjacentrooms[0].HasWumpus, listofadjacentrooms[0].HasBats, listofadjacentrooms[0].HasPit };
            return BoolListToReturn;
        }

        /// <summary>
        /// Function that handels the event of a Wampus in the Room. If User fails ends the game, otherwise moves Wumpus. 
        /// </summary>
        public void WampusInRoom()
        {
            DisplayaMessage("You encountered a Wumpus! You now have to answer 3 out of 5 Trivia Questions correctly to escape!");

            TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
            triviaDlg.AmountofQuestions = 5;
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
                DisplayaMessage("We narrowly avoided the Wumpus! It will now move to a different room!");
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
            DisplayaMessage("You encountered a Pit! You now have to answer 2 out of 3 Trivia Questions correctly to escape!");

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
                string StringtoShow = "This operation costs 3 Coins. You have: " + GameControlObject.PlayerGoldCoinAmount().ToString() + " Coins. Do You want to continue?";
                bool DoWeContiueWithAction = DisplayAYesNoMessage(StringtoShow);

                if (DoWeContiueWithAction)
                {
                    if (GameControlObject.PlayerGoldCoinAmount() >= 3)
                    {
                        GameControlObject.AddUserTurn();
                        DisplayaMessage("We will continue. You must get 2 Questions out of 3 correct!");

                        TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
                        triviaDlg.AmountofQuestions = 3;
                        triviaDlg.GameControlObject = GameControlObject;
                        this.Hide();
                        triviaDlg.ShowDialog();
                        this.Show();

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
                                DisplayaMessage("We have an extra Arrow!");
                                GameControlObject.AddArrow();
                                textBoxArrowAmount.Text = GameControlObject.PlayerArrowAmount().ToString();
                            }
                            else
                            {
                                DisplayaMessage("We did not get an extra Arrow!");
                            }
                        }
                    }
                    else
                    {
                        DisplayaMessage("You will not have enought coins to continue with this operation.");
                    }
                }
                else
                {
                    DisplayaMessage("We will not continue.");
                }
            }
            else
            {
                DisplayaMessage("You can no longer buy an arrow! Only 2 per game can fit in your quiver!.");
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
                DisplayaMessage("You got the Wumpus! Ending the Game");
                GameControlObject.ChangeWumpusDefetedStatus();
                EndTheGame();
            }
            else
            {
                DisplayaMessage("You did not get the Wumpus. The Wumpus fled to a new room.");
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
            string StringtoShow = "This operation costs 3 Coins. You have: " + GameControlObject.PlayerGoldCoinAmount().ToString() + " Coins. Do You want to contiue?";
            bool DoWeContiueWithAction = DisplayAYesNoMessage(StringtoShow);

            if (DoWeContiueWithAction)
            {
                if (GameControlObject.PlayerGoldCoinAmount() >= 3)
                {
                    GameControlObject.AddUserTurn();
                    DisplayaMessage("We will continue. You must get 2 Questions out of 3 correct!");

                    TriviaQuestionUI triviaDlg = new TriviaQuestionUI();
                    triviaDlg.AmountofQuestions = 3;
                    triviaDlg.GameControlObject = GameControlObject;
                    this.Hide();
                    triviaDlg.ShowDialog();
                    this.Show();

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
                            DisplayaMessage("We have an extra Secret!");
                            string SecretToShow = GameControlObject.GetSecretObject();
                            DisplayaMessage("Secret is: " + SecretToShow);
                        }
                        else
                        {
                            DisplayaMessage("We do not have an extra Secret");
                        }

                    }
                }
                else
                {
                    DisplayaMessage("You will not have enought coins to continue with this operation.");
                }
            }
            else
            {
                DisplayaMessage("We will not continue.");
            }   
        }

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
            checkBoxwumpusneabry.Checked = GameControlObject.IsWampusInTheNextRoom();
        }

        private void checkBoxpitnearby_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxpitnearby.Checked = GameControlObject.IsPitInTheNextRoom();
        }

        private void checkBoxbatsnearby_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxbatsnearby.Checked = GameControlObject.IsBatInTheNextRoom();
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            /*
            if (this.Size.Width != 1836)
            {
                foreach (ResizeObject i in ListofAllObjects)
                {
                    ResizeMethod(i.RectangleToUse, i.ControlToChange);
                }
                this.Refresh();
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            MovetoNextRoomButtonRectangle = new Rectangle(buttonMovetoNextRoom.Location.X, buttonMovetoNextRoom.Location.Y, buttonMovetoNextRoom.Size.Width, buttonMovetoNextRoom.Size.Height);
            ResizeObject MovetoNewRoomButton = new ResizeObject(MovetoNextRoomButtonRectangle, buttonMovetoNextRoom);
            ShootanArrowButtonRectangle = new Rectangle(buttonShootanArrow.Location.X, buttonShootanArrow.Location.Y, buttonShootanArrow.Size.Width, buttonShootanArrow.Size.Height);
            ResizeObject ShootAnArrowButton = new ResizeObject(ShootanArrowButtonRectangle, buttonShootanArrow);
            PurchaseAnArrowButtonRectangle = new Rectangle(buttonPurchaseArrow.Location.X, buttonPurchaseArrow.Location.Y, buttonPurchaseArrow.Size.Width, buttonPurchaseArrow.Size.Height);
            ResizeObject PurchaseAnArrowButton = new ResizeObject(PurchaseAnArrowButtonRectangle, buttonPurchaseArrow);
            PurchaseSecretButtonRectangle = new Rectangle(buttonPurchaseSecret.Location.X, buttonPurchaseSecret.Location.Y, buttonPurchaseSecret.Size.Width, buttonPurchaseSecret.Size.Height);
            ResizeObject PurchaseSecretButton = new ResizeObject(PurchaseSecretButtonRectangle, buttonPurchaseSecret);
            EndGameButtonRectangle = new Rectangle(buttonEndGameNow.Location.X, buttonEndGameNow.Location.Y, buttonEndGameNow.Size.Width, buttonEndGameNow.Size.Height);
            ResizeObject EndGameNowButton = new ResizeObject(EndGameButtonRectangle, buttonEndGameNow);
            GroupBoxRectangle = new Rectangle(groupBoxplayeractions.Location.X, groupBoxplayeractions.Location.Y, groupBoxplayeractions.Size.Width, groupBoxplayeractions.Size.Height);
            ResizeObject GroupBoxButotn = new ResizeObject(GroupBoxRectangle, groupBoxplayeractions);

            ListofAllObjects.Add(MovetoNewRoomButton);
            ListofAllObjects.Add(ShootAnArrowButton);
            ListofAllObjects.Add(PurchaseAnArrowButton);
            ListofAllObjects.Add(PurchaseSecretButton);
            ListofAllObjects.Add(EndGameNowButton);
            ListofAllObjects.Add(GroupBoxButotn);
            // GameControlObject.AddOriginalTriviaFile(); // Only Active This if you need to write Trivia to File. Please talk to Sergei before doing this! YOU WILL MESS UP YOUR LOCAL FILE!
            // GameControlObject.AddOriginalHighScores(); // Only Active This if you need to write High Scores to File. Please talk to Sergei before doing this! YOU WILL MESS UP YOUR LOCAL FILE!
            // GameControlObject.AddOriginalSecretFile(); // Only Active This if you need to write High Scores to File. Please talk to Sergei before doing this! YOU WILL MESS UP YOUR LOCAL FILE!
            StartTheGame();
        }
    }
}
