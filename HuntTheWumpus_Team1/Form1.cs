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

        private List<String> MakeListofImageLocation()
        {
            List<string> ListtoReturn = new List<string>();
            ListtoReturn.Add("Hi"); //  Change this. 

            return ListtoReturn;
        }
        
        private void DrawTheRoom()
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


            // Do the Warnings
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            // Open the inital Menu. Give the User the oppertunity to login.
            OpeningMenu OpentheMenuObject = new OpeningMenu();
            OpentheMenuObject.ShowDialog();

            DrawTheRoom();
        }


        public void StartNewGame()
        {
            // Start the Game Initiation.


        }

        public void UserMovesForward()
        {
            Room RoomUserIn = GameControlObject.GetRoomUserMovingTo(RoomNumber, SelfInitated);
            TriviaAnswer TriviatoShow = GameControlObject.SendTriviaAnswer();
        }


    }
}
