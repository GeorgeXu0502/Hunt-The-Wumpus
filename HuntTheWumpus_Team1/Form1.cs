using CaveMain_Offical;
using GameControl_Offical;

namespace HuntTheWumpus_Team1
{
    public partial class Form1 : Form
    {
        Player_GameControl GameControlObject = new GameControl_Offical.Player_GameControl();
        int RoomNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }

        
        public void UserMovesForward()
        {
            Room RoomUserIn = GameControlObject.GetRoomUserMovingTo(RoomNumber);
        }


    }
}
