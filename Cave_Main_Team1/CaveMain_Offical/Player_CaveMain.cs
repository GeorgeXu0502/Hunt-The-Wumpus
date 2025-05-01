using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveMain_Offical
{
    public class Player_CaveMain
    {
        public Room GetRoomInformation(int RoomNumber)
        {
            int[] samplearray = { 1, 2, 3, 4, 5, 6 };
            Room RoomtoReturn = new Room(1, false, false, false, samplearray);

            return RoomtoReturn;
        }

        public void MoveWumpus(int roomRoomNumberWhereUserIsIn)
        {
            //Move the Wumpus to a different room
        }

        public List<Room> GetAdjacentRoomInformation(int RoomNumberForWhichToGetInformation)
        {
            // REturn List of Adjacet Rooms with. // This Room List should be of this form: [RoomUser, RoomtotheTopLeft, .... (Coutnerclockwise), ....]

            return new List<Room>();
        }

        public bool IsWumpusInRoom(int RoomNumber)
        {
            // Check if Wumpus is in the room
            return false;
        }

        public int GetNewRoom()
        {
            //Return a new room with no hazards
            return 0;
        }

        public void MoveBatsToDifferentRoom(int roomNumber)
        {
            // Move the bats to a different room than the user
        }
    }
}
