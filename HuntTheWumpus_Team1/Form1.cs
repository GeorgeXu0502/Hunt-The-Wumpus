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
        /* Interesting Function to maybe enact later, however this was the original idea.
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = e.Graphics;
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Blue);
            myGraphics.DrawPolygon(myPen, PointArray);
        }
        */

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Open the inital Menu. Give the User the oppertunity to login.
            OpeningMenu OpentheMenuObject = new OpeningMenu();
            OpentheMenuObject.ShowDialog();

            int RoomIndex = GameControlObject.WhereIsUser();
            pictureBoxGeneralRoomBackground.Image = Image.FromFile(ListofImageLocation[RoomIndex]);

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
