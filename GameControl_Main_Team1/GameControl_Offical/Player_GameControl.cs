using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrivaMachine_Offical;
using CaveMain_Offical;
using PlayerInventory_Offical;

namespace GameControl_Offical
{
    
    public class Player_GameControl
    {
        Player_TriviaMachine TriviaMachineObject = new TrivaMachine_Offical.Player_TriviaMachine();
        Player_CaveMain CaveMainObject = new CaveMain_Offical.Player_CaveMain();
        Player_HighScore PlayerInventoryObject = new PlayerInventory_Offical.Player_HighScore();

        public List<Room> AdjacentRoomInformation()
        {
            List<Room> roomlistotreturn = new List<Room>();

            int[] newintarray = { 1, 2, 3, 4, 5 };
            Room Room1 = new Room(1, false, false, false, newintarray);
            roomlistotreturn.Add(Room1);
            return roomlistotreturn;
        }
        public int WhereIsUser()
        {
            return 1;
        }
        public Room GetRoomUserMovingTo(int RoomNumber, bool SelfIntitated)
        {
            Room RoomtoReturn = CaveMainObject.GetRoomInformation(RoomNumber);

            /*
            if (SelfIntitated)
            {
                PlayerInventoryObject.GoldCoinIndex();
            }
            */

            return RoomtoReturn;
        }

        public TriviaAnswer SendTriviaAnswer()
        {
            TriviaAnswer TriviaAnswertoReturn = TriviaMachineObject.GetTriviaAnswer();

            return TriviaAnswertoReturn;
        }

        

        
    }
}
