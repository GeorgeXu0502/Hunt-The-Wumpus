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
    }
}
