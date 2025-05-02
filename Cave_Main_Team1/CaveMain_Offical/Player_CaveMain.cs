using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveMain_Offical
{
    public class Player_CaveMain
    {
        public void MoveWumpus(int roomRoomNumberWhereUserIsIn)
        {
            //Move the Wumpus to a different room, not where the User is. Please check guide for this.
        }

        public List<Room> GetAdjacentRoomInformation(int RoomNumberForWhichToGetInformation)
        {
            // REturn List of Adjacet Rooms with. // This Room List should be of this form: [RoomUser, RoomtotheTopLeft, .... (Coutnerclockwise), ....]

            return new List<Room>();
        }

        public bool IsWumpusInRoom(int RoomNumberToCheck)
        {
            // Check if Wumpus is in the room.
            return false;
        }

        public int GetNewRoom()
        {
            //Return a new room with no hazards. Just an Integer.
            return 0;
        }

        public void MoveBatsToDifferentRoom(int RoomNumberWhereUserIs, int RoomWhereUserIsMoved)
        {
            // Move the bats to a different room than the user. The room where the User was (and meet Bats), where the User is to be moved to.
            // Move bats to any other room bu thits.
        }
    }
}
