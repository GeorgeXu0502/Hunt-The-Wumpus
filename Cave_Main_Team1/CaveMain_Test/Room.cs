using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveMain_Test
{
    public class Room
    {
        public bool HasBats { get; set; }
        public bool HasWumpus { get; set; }
        public bool HasPit { get; set; }

        public int[] NextRoomList { get; set; }

        public int RoomNumber { get; set; }

        public Room(int roomNumber, bool hasBats, bool hasWumpus, bool hasPit, int[] nextRoomList)
        {
            RoomNumber = roomNumber;
            HasBats = hasBats;
            HasWumpus = hasWumpus;
            HasPit = hasPit;
            NextRoomList = nextRoomList;
        }





    }
}
