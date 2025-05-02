using System.Security.Cryptography.X509Certificates;

namespace CaveMain_Test
{
    public partial class Form1 : Form
    {
        // information about each room in Version 1 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next
        Room Room1V1 = new Room(1, false, false, false, [2, 6, 7, 25, 26, 30]);
        Room Room2V1 = new Room(2,false, false, false, [1, 3, 7, 8, 9, 26]);
        Room Room3V1 = new Room(3,false, false, true, [2, 4, 9, 26, 27, 28]);
        Room Room4V1 = new Room(4,false, false, false, [3, 5, 9, 10, 11, 28]);
        Room Room5V1 = new Room(5,false, false, false, [4, 6, 11, 28, 29, 30]);
        Room Room6V1 = new Room(6,false, false, false, [1, 5, 7, 11, 12, 30]);
        Room Room7V1 = new Room(7,false, false, false, [1, 2, 6, 8, 12, 13]);
        Room Room8V1 = new Room(8,true, false, false, [2, 7, 9, 13, 14, 15]);
        Room Room9V1 = new Room(9,false, false, false, [2, 3, 4, 8, 10, 15]);
        Room Room10V1 = new Room(10,false, false, false, [4, 9, 11, 15, 16, 17]);
        Room Room11V1 = new Room(11,false, false, false, [4, 5, 6, 10, 12, 17]);
        Room Room12V1 = new Room(12,true, false, false, [6, 7, 11, 13, 17, 18]);
        Room Room13V1 = new Room(13,false, false, false, [7, 8, 12, 14, 18, 19]);
        Room Room14V1 = new Room(14,false, false, false, [8,13, 15, 19, 20, 21]);
        Room Room15V1 = new Room(15,false, false, false, [8, 9, 10, 14, 16, 21]);
        Room Room16V1 = new Room(16,false, false, false, [10, 15, 17, 21, 22, 23]);
        Room Room17V1 = new Room(17,false, false, false, [10, 11, 12, 16, 18, 23]);
        Room Room18V1 = new Room(18,false, false, false, [12, 13, 17, 19, 23, 24]);
        Room Room19V1 = new Room(19,false, false, false, [13, 14, 18, 20, 24, 25]);
        Room Room20V1 = new Room(20,false, false, false, [14, 19, 21, 25, 26, 27]);
        Room Room21V1 = new Room(21,false, true, false, [14, 15, 16, 20, 22, 27]);
        Room Room22V1 = new Room(22,false, false, false, [16, 21, 23, 27, 28, 29]);
        Room Room23V1 = new Room(23,false, false, false, [16, 17, 18, 22, 24, 29]);
        Room Room24V1 = new Room(24,false, false, false, [18, 19, 23, 25, 29, 23]);
        Room Room25V1 = new Room(25,false, false, false, [1, 19, 20, 24, 26, 30]);
        Room Room26V1 = new Room(26,false, false, false, [1, 2, 3, 20, 25, 27]);
        Room Room27V1 = new Room(27,false, false, false, [3, 20, 21, 22, 26, 28]);
        Room Room28V1 = new Room(28,false, false, false, [3, 4, 5, 22, 27, 29]);
        Room Room29V1 = new Room(29,false, false, false, [5, 22, 23, 24, 28, 30]);
        Room Room30V1 = new Room(30,false, false, false, [1, 5, 6, 24, 25, 29]);


        // information about each room in Version 2 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next
        Room Room1V2 = new Room(1,false, false, false, [2, 6, 7, 25, 26, 30]);
        Room Room2V2 = new Room(2,false, false, false, [1, 3, 7, 8, 9, 26]);
        Room Room3V2 = new Room(3,false, false, false, [2, 4, 9, 26, 27, 28]);
        Room Room4V2 = new Room(4,false, false, false, [3, 5, 9, 10, 11, 28]);
        Room Room5V2 = new Room(5,false, false, false, [4, 6, 11, 28, 29, 30]);
        Room Room6V2 = new Room(6,false, false, false, [1, 5, 7, 11, 12, 30]);
        Room Room7V2 = new Room(7,false, false, false, [1, 2, 6, 8, 12, 13]);
        Room Room8V2 = new Room(8,false, false, false, [2, 7, 9, 13, 14, 15]);
        Room Room9V2 = new Room(9,false, false, false, [2, 3, 4, 8, 10, 15]);
        Room Room10V2 = new Room(10,false, false, false, [4, 9, 11, 15, 16, 17]);
        Room Room11V2 = new Room(11,false, false, false, [4, 5, 6, 10, 12, 17]);
        Room Room12V2 = new Room(12,false, false, false, [6, 7, 11, 13, 17, 18]);
        Room Room13V2 = new Room(13,false, true, false, [7, 8, 12, 14, 18, 19]);
        Room Room14V2 = new Room(14,false, false, false, [8, 13, 15, 19, 20, 21]);
        Room Room15V2 = new Room(15,false, false, false, [8, 9, 10, 14, 16, 21]);
        Room Room16V2 = new Room(16,false, false, false, [10, 15, 17, 21, 22, 23]);
        Room Room17V2 = new Room(17,false, false, false, [10, 11, 12, 16, 18, 23]);
        Room Room18V2 = new Room(18,true, false, false, [12, 13, 17, 19, 23, 24]);
        Room Room19V2 = new Room(19,true, false, false, [13, 14, 18, 20, 24, 25]);
        Room Room20V2 = new Room(20,false, false, false, [14, 19, 21, 25, 26, 27]);
        Room Room21V2 = new Room(21,false, false, false, [14, 15, 16, 20, 22, 27]);
        Room Room22V2 = new Room(22,false, false, true, [16, 21, 23, 27, 28, 29]);
        Room Room23V2 = new Room(23,false, false, false, [16, 17, 18, 22, 24, 29]);
        Room Room24V2 = new Room(24,false, false, false, [18, 19, 23, 25, 29, 23]);
        Room Room25V2 = new Room(25,false, false, false, [1, 19, 20, 24, 26, 30]);
        Room Room26V2 = new Room(26,false, false, false, [1, 2, 3, 20, 25, 27]);
        Room Room27V2 = new Room(27,false, false, false, [3, 20, 21, 22, 26, 28]);
        Room Room28V2 = new Room(28,false, false, false, [3, 4, 5, 22, 27, 29]);
        Room Room29V2 = new Room(29,false, false, false, [5, 22, 23, 24, 28, 30]);
        Room Room30V2 = new Room(30,false, false, false, [1, 5, 6, 24, 25, 29]);


        // information about each room in Version 3 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next
        Room Room1V3 = new Room(1,false, false, true, [2, 6, 7, 25, 26, 30]);
        Room Room2V3 = new Room(2,false, false, false, [1, 3, 7, 8, 9, 26]);
        Room Room3V3 = new Room(3,false, false, false, [2, 4, 9, 26, 27, 28]);
        Room Room4V3 = new Room(4,false, false, false, [3, 5, 9, 10, 11, 28]);
        Room Room5V3 = new Room(5,false, false, false, [4, 6, 11, 28, 29, 30]);
        Room Room6V3 = new Room(6,false, false, false, [1, 5, 7, 11, 12, 30]);
        Room Room7V3 = new Room(7,false, false, false, [1, 2, 6, 8, 12, 13]);
        Room Room8V3 = new Room(8, true, false, false, [2, 7, 9, 13, 14, 15]);
        Room Room9V3 = new Room(9, false, false, false, [2, 3, 4, 8, 10, 15]);
        Room Room10V3 = new Room(10,false, false, false, [4, 9, 11, 15, 16, 17]);
        Room Room11V3 = new Room(11,false, false, false, [4, 5, 6, 10, 12, 17]);
        Room Room12V3 = new Room(12,false, false, false, [6, 7, 11, 13, 17, 18]);
        Room Room13V3 = new Room(13,false, false, false, [7, 8, 12, 14, 18, 19]);
        Room Room14V3 = new Room(14,false, false, false, [8, 13, 15, 19, 20, 21]);
        Room Room15V3 = new Room(15,false, false, false, [8, 9, 10, 14, 16, 21]);
        Room Room16V3 = new Room(16,false, false, false, [10, 15, 17, 21, 22, 23]);
        Room Room17V3 = new Room(17,false, true, false, [10, 11, 12, 16, 18, 23]);
        Room Room18V3 = new Room(18,false, false, false, [12, 13, 17, 19, 23, 24]);
        Room Room19V3 = new Room(19,false, false, false, [13, 14, 18, 20, 24, 25]);
        Room Room20V3 = new Room(20,false, false, false, [14, 19, 21, 25, 26, 27]);
        Room Room21V3 = new Room(21, false, false, false, [14, 15, 16, 20, 22, 27]);
        Room Room22V3 = new Room(22,false, false, false, [16, 21, 23, 27, 28, 29]);
        Room Room23V3 = new Room(23, false, false, false, [16, 17, 18, 22, 24, 29]);
        Room Room24V3 = new Room(24,false, false, false, [18, 19, 23, 25, 29, 23]);
        Room Room25V3 = new Room(25,false, false, false, [1, 19, 20, 24, 26, 30]);
        Room Room26V3 = new Room(26,true, false, false, [1, 2, 3, 20, 25, 27]);
        Room Room27V3 = new Room(27,false, false, false, [3, 20, 21, 22, 26, 28]);
        Room Room28V3 = new Room(28,false, false, false, [3, 4, 5, 22, 27, 29]);
        Room Room29V3 = new Room(29,false, false, false, [5, 22, 23, 24, 28, 30]);
        Room Room30V3 = new Room(30,false, false, false, [1, 5, 6, 24, 25, 29]);


        // information about each room in Version 4 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next
        Room Room1V4 = new Room(1,false, false, false, [2, 6, 7, 25, 26, 30]);
        Room Room2V4 = new Room(2,false, false, false, [1, 3, 7, 8, 9, 26]);
        Room Room3V4 = new Room(3,false, false, false, [2, 4, 9, 26, 27, 28]);
        Room Room4V4 = new Room(4,true, false, false, [3, 5, 9, 10, 11, 28]);
        Room Room5V4 = new Room(5,false, false, false, [4, 6, 11, 28, 29, 30]);
        Room Room6V4 = new Room(6,false, true, false, [1, 5, 7, 11, 12, 30]);
        Room Room7V4 = new Room(7,false, false, false, [1, 2, 6, 8, 12, 13]);
        Room Room8V4 = new Room(8,false, false, false, [2, 7, 9, 13, 14, 15]);
        Room Room9V4 = new Room(9,false, false, false, [2, 3, 4, 8, 10, 15]);
        Room Room10V4 = new Room(10,false, false, false, [4, 9, 11, 15, 16, 17]);
        Room Room11V4 = new Room(11,false, false, false, [4, 5, 6, 10, 12, 17]);
        Room Room12V4 = new Room(12,false, false, false, [6, 7, 11, 13, 17, 18]);
        Room Room13V4 = new Room(13,false, false, false, [7, 8, 12, 14, 18, 19]);
        Room Room14V4 = new Room(14,true, false, false, [8, 13, 15, 19, 20, 21]);
        Room Room15V4 = new Room(15,false, false, false, [8, 9, 10, 14, 16, 21]);
        Room Room16V4 = new Room(16,false, false, false, [10, 15, 17, 21, 22, 23]);
        Room Room17V4 = new Room(17,false, false, false, [10, 11, 12, 16, 18, 23]);
        Room Room18V4 = new Room(18,false, false, false, [12, 13, 17, 19, 23, 24]);
        Room Room19V4 = new Room(19,false, false, false, [13, 14, 18, 20, 24, 25]);
        Room Room20V4 = new Room(20,false, false, false, [14, 19, 21, 25, 26, 27]);
        Room Room21V4 = new Room(21,false, false, false, [14, 15, 16, 20, 22, 27]);
        Room Room22V4 = new Room(22,false, false, false, [16, 21, 23, 27, 28, 29]);
        Room Room23V4 = new Room(23,false, false, false, [16, 17, 18, 22, 24, 29]);
        Room Room24V4 = new Room(24,false, false, false, [18, 19, 23, 25, 29, 23]);
        Room Room25V4 = new Room(25,false, false, false, [1, 19, 20, 24, 26, 30]);
        Room Room26V4 = new Room(26,false, false, false, [1, 2, 3, 20, 25, 27]);
        Room Room27V4 = new Room(27,false, false, false, [3, 20, 21, 22, 26, 28]);
        Room Room28V4 = new Room(28,false, false, false, [3, 4, 5, 22, 27, 29]);
        Room Room29V4 = new Room(29,false, false, false, [5, 22, 23, 24, 28, 30]);
        Room Room30V4 = new Room(30,false, false, true, [1, 5, 6, 24, 25, 29]);


        // information about each room in Version 5 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next
        Room Room1V5 = new Room(1,true, false, false, [2, 6, 7, 25, 26, 30]);
        Room Room2V5 = new Room(2,false, false, false, [1, 3, 7, 8, 9, 26]);
        Room Room3V5 = new Room(3,false, false, false, [2, 4, 9, 26, 27, 28]);
        Room Room4V5 = new Room(4,false, false, false, [3, 5, 9, 10, 11, 28]);
        Room Room5V5 = new Room(5,false, false, false, [4, 6, 11, 28, 29, 30]);
        Room Room6V5 = new Room(6,false, false, false, [1, 5, 7, 11, 12, 30]);
        Room Room7V5 = new Room(7,false, false, false, [1, 2, 6, 8, 12, 13]);
        Room Room8V5 = new Room(8,false, false, false, [2, 7, 9, 13, 14, 15]);
        Room Room9V5 = new Room(9,false, false, false, [2, 3, 4, 8, 10, 15]);
        Room Room10V5 = new Room(10,false, false, false, [4, 9, 11, 15, 16, 17]);
        Room Room11V5 = new Room(11,false, false, false, [4, 5, 6, 10, 12, 17]);
        Room Room12V5 = new Room(12,false, false, false, [6, 7, 11, 13, 17, 18]);
        Room Room13V5 = new Room(13,false, false, false, [7, 8, 12, 14, 18, 19]);
        Room Room14V5 = new Room(14,false, false, false, [8, 13, 15, 19, 20, 21]);
        Room Room15V5 = new Room(15,false, false, false, [8, 9, 10, 14, 16, 21]);
        Room Room16V5 = new Room(16,false, false, false, [10, 15, 17, 21, 22, 23]);
        Room Room17V5 = new Room(17,false, false, true, [10, 11, 12, 16, 18, 23]);
        Room Room18V5 = new Room(18,false, false, false, [12, 13, 17, 19, 23, 24]);
        Room Room19V5 = new Room(19,false, false, false, [13, 14, 18, 20, 24, 25]);
        Room Room20V5 = new Room(20,false, false, false, [14, 19, 21, 25, 26, 27]);
        Room Room21V5 = new Room(21,false, false, false, [14, 15, 16, 20, 22, 27]);
        Room Room22V5 = new Room(22,false, false, false, [16, 21, 23, 27, 28, 29]);
        Room Room23V5 = new Room(23,false, false, false, [16, 17, 18, 22, 24, 29]);
        Room Room24V5 = new Room(24,false, false, false, [18, 19, 23, 25, 29, 23]);
        Room Room25V5 = new Room(25,false, true, false, [1, 19, 20, 24, 26, 30]);
        Room Room26V5 = new Room(26,false, false, false, [1, 2, 3, 20, 25, 27]);
        Room Room27V5 = new Room(27,false, false, false, [3, 20, 21, 22, 26, 28]);
        Room Room28V5 = new Room(28,false, false, false, [3, 4, 5, 22, 27, 29]);
        Room Room29V5 = new Room(29,true, false, false, [5, 22, 23, 24, 28, 30]);
        Room Room30V5 = new Room(30,false, false, false, [1, 5, 6, 24, 25, 29]);

        public Form1()
        {
            InitializeComponent();

            
        }

        public void MoveWumpus(int roomRoomNumberWhereUserIsIn)
        {
            Random rnd = new Random();
            int newWumpusRoom = rnd.Next(1, 30);



           
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
