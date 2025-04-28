using CaveMain_Offical;
using GameControl_Offical;
using TrivaMachine_Offical;

namespace HuntTheWumpus_Team1
{
    public partial class Form1 : Form
    {
        Player_GameControl GameControlObject = new GameControl_Offical.Player_GameControl();
        int RoomNumber = 1;
        bool SelfInitated = true;

        // List of Point for the User Interface Room Polygon
        Point[] PointArray =
        {
            new Point(0, 0),
            new Point(3, 0)
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = e.Graphics;
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Blue);
            myGraphics.DrawPolygon(myPen, PointArray);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Open the inital Menu. Give the User the oppertunity to login.
            OpeningMenu OpentheMenuObject = new OpeningMenu();
            OpentheMenuObject.ShowDialog();


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
