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

    }
}
