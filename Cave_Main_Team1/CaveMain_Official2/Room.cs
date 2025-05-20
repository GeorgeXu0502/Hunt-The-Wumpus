using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveMain_Official2
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public bool HasBats { get; set; }
        public bool HasWumpus { get; set; }
        public bool HasPit { get; set; }

        public int[] NextRoomList { get; set; }

        public bool[] CanGoToRoom { get; set; }

        public Room(int roomNumber, bool hasBats, bool hasWumpus, bool hasPit, int[] nextRoomList, bool[] canGoToRoom)
        {
            RoomNumber = roomNumber;
            HasBats = hasBats;
            HasWumpus = hasWumpus;
            HasPit = hasPit;
            NextRoomList = nextRoomList;
            CanGoToRoom = canGoToRoom;
        }
    }
}
