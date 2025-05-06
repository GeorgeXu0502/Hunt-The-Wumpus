using System.Security.Cryptography.X509Certificates;

namespace CaveMain_Test
{
    public partial class Form1 : Form
    {
        // as long as the random map works, ignore these
        List<Room> Version1Map = new List<Room>();
        List<Room> Version2Map = new List<Room>();
        List<Room> Version3Map = new List<Room>();
        List<Room> Version4Map = new List<Room>();
        List<Room> Version5Map = new List<Room>();

        // this is the random map
        List<Room> RandomMap = new List<Room>();


        // created an empty room for the making indexing easier
        Room EmptyRoom = new Room(0, false, false, false, [0, 0, 0, 0, 0, 0]);

        // information about each room in Version 1 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next

        // as long as the random map works, can ignore all
        Room Room1V1 = new Room(1, false, false, false, [30, 6, 7, 2, 26, 25]);
        Room Room2V1 = new Room(2, false, false, false, [1, 7, 8, 9, 3, 26]);
        Room Room3V1 = new Room(3, false, false, true, [26, 2, 9, 4, 28, 27]);
        Room Room4V1 = new Room(4, false, false, false, [3, 9, 10, 11, 5, 28]);
        Room Room5V1 = new Room(5, false, false, false, [28, 4, 11, 6, 30, 29]);
        Room Room6V1 = new Room(6, false, false, false, [5, 11, 12, 7, 1, 30]);
        Room Room7V1 = new Room(7, false, false, false, [6, 12, 13, 8, 2, 1]);
        Room Room8V1 = new Room(8, true, false, false, [7, 13, 14, 15, 9, 2]);
        Room Room9V1 = new Room(9, false, false, false, [2, 8, 15, 10, 4, 3]);
        Room Room10V1 = new Room(10, false, false, false, [9, 15, 16, 17, 11, 4]);
        Room Room11V1 = new Room(11, false, false, false, [4, 10, 17, 12, 6, 5]);
        Room Room12V1 = new Room(12, true, false, false, [11, 17, 18, 13, 7, 6]);
        Room Room13V1 = new Room(13, false, false, false, [12, 18, 19, 14, 8, 7]);
        Room Room14V1 = new Room(14, false, false, false, [13, 19, 20, 21, 15, 8]);
        Room Room15V1 = new Room(15, false, false, false, [8, 14, 21, 16, 10, 9]);
        Room Room16V1 = new Room(16, false, false, false, [15, 21, 22, 23, 17, 10]);
        Room Room17V1 = new Room(17, false, false, false, [10, 16, 23, 18, 12, 11]);
        Room Room18V1 = new Room(18, false, false, false, [17, 23, 24, 19, 13, 12]);
        Room Room19V1 = new Room(19, false, false, false, [18, 24, 25, 20, 14, 13]);
        Room Room20V1 = new Room(20, false, false, false, [19, 25, 26, 27, 21, 14]);
        Room Room21V1 = new Room(21, false, true, false, [14, 20, 27, 22, 16, 15]);
        Room Room22V1 = new Room(22, false, false, false, [21, 27, 28, 29, 23, 16]);
        Room Room23V1 = new Room(23, false, false, false, [16, 22, 29, 24, 18, 17]);
        Room Room24V1 = new Room(24, false, false, false, [23, 29, 30, 25, 19, 18]);
        Room Room25V1 = new Room(25, false, false, false, [24, 30, 1, 26, 20, 19]);
        Room Room26V1 = new Room(26, false, false, false, [25, 1, 2, 3, 27, 20]);
        Room Room27V1 = new Room(27, false, false, false, [20, 26, 3, 28, 22, 21]);
        Room Room28V1 = new Room(28, false, false, false, [27, 3, 4, 5, 29, 22]);
        Room Room29V1 = new Room(29, false, false, false, [22, 28, 5, 30, 24, 23]);
        Room Room30V1 = new Room(30, false, false, false, [29, 5, 6, 1, 25, 24]);



        // information about each room in Version 2 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next
        Room Room1V2 = new Room(1, false, false, false, [30, 6, 7, 2, 26, 25]);
        Room Room2V2 = new Room(2, false, false, false, [1, 7, 8, 9, 3, 26]);
        Room Room3V2 = new Room(3, false, false, false, [26, 2, 9, 4, 28, 27]);
        Room Room4V2 = new Room(4, false, false, false, [3, 5, 9, 10, 11, 28]);
        Room Room5V2 = new Room(5, false, false, false, [28, 4, 11, 6, 30, 29]);
        Room Room6V2 = new Room(6, false, false, false, [5, 11, 12, 7, 1, 30]);
        Room Room7V2 = new Room(7, false, false, false, [6, 12, 13, 8, 2, 1]);
        Room Room8V2 = new Room(8, false, false, false, [7, 13, 14, 15, 9, 2]);
        Room Room9V2 = new Room(9, false, false, false, [2, 8, 15, 10, 4, 3]);
        Room Room10V2 = new Room(10, false, false, false, [9, 15, 16, 17, 11, 4]);
        Room Room11V2 = new Room(11, false, false, false, [4, 10, 17, 12, 6, 5]);
        Room Room12V2 = new Room(12, false, false, false, [11, 17, 18, 13, 7, 6]);
        Room Room13V2 = new Room(13, false, true, false, [12, 18, 19, 14, 8, 7]);
        Room Room14V2 = new Room(14, false, false, false, [13, 19, 20, 21, 15, 8]);
        Room Room15V2 = new Room(15, false, false, false, [8, 14, 21, 16, 10, 9]);
        Room Room16V2 = new Room(16, false, false, false, [15, 21, 22, 23, 17, 10]);
        Room Room17V2 = new Room(17, false, false, false, [10, 16, 23, 18, 12, 11]);
        Room Room18V2 = new Room(18, true, false, false, [17, 23, 24, 19, 13, 12]);
        Room Room19V2 = new Room(19, true, false, false, [18, 24, 25, 20, 14, 13]);
        Room Room20V2 = new Room(20, false, false, false, [19, 25, 26, 27, 21, 14]);
        Room Room21V2 = new Room(21, false, false, false, [14, 20, 27, 22, 16, 15]);
        Room Room22V2 = new Room(22, false, false, true, [21, 27, 28, 29, 23, 16]);
        Room Room23V2 = new Room(23, false, false, false, [16, 22, 29, 24, 18, 17]);
        Room Room24V2 = new Room(24, false, false, false, [23, 29, 30, 25, 19, 18]);
        Room Room25V2 = new Room(25, false, false, false, [24, 30, 1, 26, 20, 19]);
        Room Room26V2 = new Room(26, false, false, false, [25, 1, 2, 3, 27, 20]);
        Room Room27V2 = new Room(27, false, false, false, [20, 26, 3, 28, 22, 21]);
        Room Room28V2 = new Room(28, false, false, false, [27, 3, 4, 5, 29, 22]);
        Room Room29V2 = new Room(29, false, false, false, [22, 28, 5, 30, 24, 23]);
        Room Room30V2 = new Room(30, false, false, false, [29, 5, 6, 1, 25, 24]);


        // information about each room in Version 3 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next
        Room Room1V3 = new Room(1, false, false, true, [30, 6, 7, 2, 26, 25]);
        Room Room2V3 = new Room(2, false, false, false, [1, 7, 8, 9, 3, 26]);
        Room Room3V3 = new Room(3, false, false, false, [26, 2, 9, 4, 28, 27]);
        Room Room4V3 = new Room(4, false, false, false, [3, 9, 10, 11, 5, 28]);
        Room Room5V3 = new Room(5, false, false, false, [4, 6, 11, 28, 29, 30]);
        Room Room6V3 = new Room(6, false, false, false, [5, 11, 12, 7, 1, 30]);
        Room Room7V3 = new Room(7, false, false, false, [6, 12, 13, 8, 2, 1]);
        Room Room8V3 = new Room(8, true, false, false, [7, 13, 14, 15, 9, 2]);
        Room Room9V3 = new Room(9, false, false, false, [2, 8, 15, 10, 4, 3]);
        Room Room10V3 = new Room(10, false, false, false, [9, 15, 16, 17, 11, 4]);
        Room Room11V3 = new Room(11, false, false, false, [4, 10, 17, 12, 6, 5]);
        Room Room12V3 = new Room(12, false, false, false, [11, 17, 18, 13, 7, 6]);
        Room Room13V3 = new Room(13, false, false, false, [12, 18, 19, 14, 8, 7]);
        Room Room14V3 = new Room(14, false, false, false, [13, 19, 20, 21, 15, 8]);
        Room Room15V3 = new Room(15, false, false, false, [8, 14, 21, 16, 10, 9]);
        Room Room16V3 = new Room(16, false, false, false, [15, 21, 22, 23, 17, 10]);
        Room Room17V3 = new Room(17, false, true, false, [10, 16, 23, 18, 12, 11]);
        Room Room18V3 = new Room(18, false, false, false, [17, 23, 24, 19, 13, 12]);
        Room Room19V3 = new Room(19, false, false, false, [18, 24, 25, 20, 14, 13]);
        Room Room20V3 = new Room(20, false, false, false, [19, 25, 26, 27, 21, 14]);
        Room Room21V3 = new Room(21, false, false, false, [14, 20, 27, 22, 16, 15]);
        Room Room22V3 = new Room(22, false, false, false, [21, 27, 28, 29, 23, 16]);
        Room Room23V3 = new Room(23, false, false, false, [16, 22, 29, 24, 18, 17]);
        Room Room24V3 = new Room(24, false, false, false, [23, 29, 30, 25, 19, 18]);
        Room Room25V3 = new Room(25, false, false, false, [24, 30, 1, 26, 20, 19]);
        Room Room26V3 = new Room(26, true, false, false, [25, 1, 2, 3, 27, 20]);
        Room Room27V3 = new Room(27, false, false, false, [20, 26, 3, 28, 22, 21]);
        Room Room28V3 = new Room(28, false, false, false, [27, 3, 4, 5, 29, 22]);
        Room Room29V3 = new Room(29, false, false, false, [22, 28, 5, 30, 24, 23]);
        Room Room30V3 = new Room(30, false, false, false, [29, 5, 6, 1, 25, 24]);


        // information about each room in Version 4 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next
        Room Room1V4 = new Room(1, false, false, false, [30, 6, 7, 2, 26, 25]);
        Room Room2V4 = new Room(2, false, false, false, [1, 7, 8, 9, 3, 26]);
        Room Room3V4 = new Room(3, false, false, false, [26, 2, 9, 4, 28, 27]);
        Room Room4V4 = new Room(4, true, false, false, [3, 9, 10, 11, 5, 28]);
        Room Room5V4 = new Room(5, false, false, false, [28, 4, 11, 6, 30, 29]);
        Room Room6V4 = new Room(6, false, true, false, [5, 11, 12, 7, 1, 30]);
        Room Room7V4 = new Room(7, false, false, false, [6, 12, 13, 8, 2, 1]);
        Room Room8V4 = new Room(8, false, false, false, [7, 13, 14, 15, 9, 2]);
        Room Room9V4 = new Room(9, false, false, false, [2, 8, 15, 10, 4, 3]);
        Room Room10V4 = new Room(10, false, false, false, [9, 15, 16, 17, 11, 4]);
        Room Room11V4 = new Room(11, false, false, false, [4, 10, 17, 12, 6, 5]);
        Room Room12V4 = new Room(12, false, false, false, [11, 17, 18, 13, 7, 6]);
        Room Room13V4 = new Room(13, false, false, false, [12, 18, 19, 14, 8, 7]);
        Room Room14V4 = new Room(14, true, false, false, [13, 19, 20, 21, 15, 8]);
        Room Room15V4 = new Room(15, false, false, false, [8, 14, 21, 16, 10, 9]);
        Room Room16V4 = new Room(16, false, false, false, [15, 21, 22, 23, 17, 10]);
        Room Room17V4 = new Room(17, false, false, false, [10, 16, 23, 18, 12, 11]);
        Room Room18V4 = new Room(18, false, false, false, [17, 23, 24, 19, 13, 12]);
        Room Room19V4 = new Room(19, false, false, false, [18, 24, 25, 20, 14, 13]);
        Room Room20V4 = new Room(20, false, false, false, [19, 25, 26, 27, 21, 14]);
        Room Room21V4 = new Room(21, false, false, false, [14, 20, 27, 22, 16, 15]);
        Room Room22V4 = new Room(22, false, false, false, [21, 27, 28, 29, 23, 16]);
        Room Room23V4 = new Room(23, false, false, false, [16, 22, 29, 24, 18, 17]);
        Room Room24V4 = new Room(24, false, false, false, [23, 29, 30, 25, 19, 18]);
        Room Room25V4 = new Room(25, false, false, false, [24, 30, 1, 26, 20, 19]);
        Room Room26V4 = new Room(26, false, false, false, [25, 1, 2, 3, 27, 20]);
        Room Room27V4 = new Room(27, false, false, false, [20, 26, 3, 28, 22, 21]);
        Room Room28V4 = new Room(28, false, false, false, [27, 3, 4, 5, 29, 22]);
        Room Room29V4 = new Room(29, false, false, false, [22, 28, 5, 30, 24, 23]);
        Room Room30V4 = new Room(30, false, false, true, [29, 5, 6, 1, 25, 24]);


        // information about each room in Version 5 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next
        Room Room1V5 = new Room(1, true, false, false, [30, 6, 7, 2, 26, 25]);
        Room Room2V5 = new Room(2, false, false, false, [1, 7, 8, 9, 3, 26]);
        Room Room3V5 = new Room(3, false, false, false, [26, 2, 9, 4, 28, 27]);
        Room Room4V5 = new Room(4, false, false, false, [3, 9, 10, 11, 5, 28]);
        Room Room5V5 = new Room(5, false, false, false, [28, 4, 11, 6, 30, 29]);
        Room Room6V5 = new Room(6, false, false, false, [5, 11, 12, 7, 1, 30]);
        Room Room7V5 = new Room(7, false, false, false, [6, 12, 13, 8, 2, 1]);
        Room Room8V5 = new Room(8, false, false, false, [7, 13, 14, 15, 9, 2]);
        Room Room9V5 = new Room(9, false, false, false, [2, 8, 15, 10, 4, 3]);
        Room Room10V5 = new Room(10, false, false, false, [9, 15, 16, 17, 11, 4]);
        Room Room11V5 = new Room(11, false, false, false, [4, 10, 17, 12, 6, 5]);
        Room Room12V5 = new Room(12, false, false, false, [11, 17, 18, 13, 7, 6]);
        Room Room13V5 = new Room(13, false, false, false, [12, 18, 19, 14, 8, 7]);
        Room Room14V5 = new Room(14, false, false, false, [13, 19, 20, 21, 15, 8]);
        Room Room15V5 = new Room(15, false, false, false, [8, 14, 21, 16, 10, 9]);
        Room Room16V5 = new Room(16, false, false, false, [15, 21, 22, 23, 17, 10]);
        Room Room17V5 = new Room(17, false, false, true, [10, 16, 23, 18, 12, 11]);
        Room Room18V5 = new Room(18, false, false, false, [17, 23, 24, 19, 13, 12]);
        Room Room19V5 = new Room(19, false, false, false, [18, 24, 25, 20, 14, 13]);
        Room Room20V5 = new Room(20, false, false, false, [19, 25, 26, 27, 21, 14]);
        Room Room21V5 = new Room(21, false, false, false, [14, 20, 27, 22, 16, 15]);
        Room Room22V5 = new Room(22, false, false, false, [21, 27, 28, 29, 23, 16]);
        Room Room23V5 = new Room(23, false, false, false, [16, 22, 29, 24, 18, 17]);
        Room Room24V5 = new Room(24, false, false, false, [23, 29, 30, 25, 19, 18]);
        Room Room25V5 = new Room(25, false, true, false, [24, 30, 1, 26, 20, 19]);
        Room Room26V5 = new Room(26, false, false, false, [125, 1, 2, 3, 27, 20]);
        Room Room27V5 = new Room(27, false, false, false, [20, 26, 3, 28, 22, 21]);
        Room Room28V5 = new Room(28, false, false, false, [27, 3, 4, 5, 29, 22]);
        Room Room29V5 = new Room(29, true, false, false, [22, 28, 5, 30, 24, 23]);
        Room Room30V5 = new Room(30, false, false, false, [29, 5, 6, 1, 25, 24]);

        Room Room1 = new Room(1, false, false, false, [30, 6, 7, 2, 26, 25]);
        Room Room2 = new Room(2, false, false, false, [1, 7, 8, 9, 3, 26]);
        Room Room3 = new Room(3, false, false, false, [26, 2, 9, 4, 28, 27]);
        Room Room4 = new Room(4, false, false, false, [3, 9, 10, 11, 5, 28]);
        Room Room5 = new Room(5, false, false, false, [28, 4, 11, 6, 30, 29]);
        Room Room6 = new Room(6, false, false, false, [5, 11, 12, 7, 1, 30]);
        Room Room7 = new Room(7, false, false, false, [6, 12, 13, 8, 2, 1]);
        Room Room8 = new Room(8, false, false, false, [7, 13, 14, 15, 9, 2]);
        Room Room9 = new Room(9, false, false, false, [2, 8, 15, 10, 4, 3]);
        Room Room10 = new Room(10, false, false, false, [9, 15, 16, 17, 11, 4]);
        Room Room11 = new Room(11, false, false, false, [4, 10, 17, 12, 6, 5]);
        Room Room12 = new Room(12, false, false, false, [11, 17, 18, 13, 7, 6]);
        Room Room13 = new Room(13, false, false, false, [12, 18, 19, 14, 8, 7]);
        Room Room14 = new Room(14, false, false, false, [13, 19, 20, 21, 15, 8]);
        Room Room15 = new Room(15, false, false, false, [8, 14, 21, 16, 10, 9]);
        Room Room16 = new Room(16, false, false, false, [15, 21, 22, 23, 17, 10]);
        Room Room17 = new Room(17, false, false, false, [10, 16, 23, 18, 12, 11]);
        Room Room18 = new Room(18, false, false, false, [17, 23, 24, 19, 13, 12]);
        Room Room19 = new Room(19, false, false, false, [18, 24, 25, 20, 14, 13]);
        Room Room20 = new Room(20, false, false, false, [19, 25, 26, 27, 21, 14]);
        Room Room21 = new Room(21, false, false, false, [14, 20, 27, 22, 16, 15]);
        Room Room22 = new Room(22, false, false, false, [21, 27, 28, 29, 23, 16]);
        Room Room23 = new Room(23, false, false, false, [16, 22, 29, 24, 18, 17]);
        Room Room24 = new Room(24, false, false, false, [23, 29, 30, 25, 19, 18]);
        Room Room25 = new Room(25, false, false, false, [24, 30, 1, 26, 20, 19]);
        Room Room26 = new Room(26, false, false, false, [125, 1, 2, 3, 27, 20]);
        Room Room27 = new Room(27, false, false, false, [20, 26, 3, 28, 22, 21]);
        Room Room28 = new Room(28, false, false, false, [27, 3, 4, 5, 29, 22]);
        Room Room29 = new Room(29, false, false, false, [22, 28, 5, 30, 24, 23]);
        Room Room30 = new Room(30, false, false, false, [29, 5, 6, 1, 25, 24]);




        public Form1()
        {
            InitializeComponent();

            // as long as random map works, can ignore all
            Version1Map.Add(EmptyRoom);
            Version1Map.Add(Room1V1);
            Version1Map.Add(Room2V1);
            Version1Map.Add(Room3V1);
            Version1Map.Add(Room4V1);
            Version1Map.Add(Room5V1);
            Version1Map.Add(Room6V1);
            Version1Map.Add(Room7V1);
            Version1Map.Add(Room8V1);
            Version1Map.Add(Room9V1);
            Version1Map.Add(Room10V1);
            Version1Map.Add(Room11V1);
            Version1Map.Add(Room12V1);
            Version1Map.Add(Room13V1);
            Version1Map.Add(Room14V1);
            Version1Map.Add(Room15V1);
            Version1Map.Add(Room16V1);
            Version1Map.Add(Room17V1);
            Version1Map.Add(Room18V1);
            Version1Map.Add(Room19V1);
            Version1Map.Add(Room20V1);
            Version1Map.Add(Room21V1);
            Version1Map.Add(Room22V1);
            Version1Map.Add(Room23V1);
            Version1Map.Add(Room24V1);
            Version1Map.Add(Room25V1);
            Version1Map.Add(Room26V1);
            Version1Map.Add(Room27V1);
            Version1Map.Add(Room28V1);
            Version1Map.Add(Room29V1);
            Version1Map.Add(Room30V1);


            Version2Map.Add(EmptyRoom);
            Version2Map.Add(Room1V2);
            Version2Map.Add(Room2V2);
            Version2Map.Add(Room3V2);
            Version2Map.Add(Room4V2);
            Version2Map.Add(Room5V2);
            Version2Map.Add(Room6V2);
            Version2Map.Add(Room7V2);
            Version2Map.Add(Room8V2);
            Version2Map.Add(Room9V2);
            Version2Map.Add(Room10V2);
            Version2Map.Add(Room11V2);
            Version2Map.Add(Room12V2);
            Version2Map.Add(Room13V2);
            Version2Map.Add(Room14V2);
            Version2Map.Add(Room15V2);
            Version2Map.Add(Room16V2);
            Version2Map.Add(Room17V2);
            Version2Map.Add(Room18V2);
            Version2Map.Add(Room19V2);
            Version2Map.Add(Room20V2);
            Version2Map.Add(Room21V2);
            Version2Map.Add(Room22V2);
            Version2Map.Add(Room23V2);
            Version2Map.Add(Room24V2);
            Version2Map.Add(Room25V2);
            Version2Map.Add(Room26V2);
            Version2Map.Add(Room27V2);
            Version2Map.Add(Room28V2);
            Version2Map.Add(Room29V2);
            Version2Map.Add(Room30V2);

            Version3Map.Add(EmptyRoom);
            Version3Map.Add(Room1V3);
            Version3Map.Add(Room2V3);
            Version3Map.Add(Room3V3);
            Version3Map.Add(Room4V3);
            Version3Map.Add(Room5V3);
            Version3Map.Add(Room6V3);
            Version3Map.Add(Room7V3);
            Version3Map.Add(Room8V3);
            Version3Map.Add(Room9V3);
            Version3Map.Add(Room10V3);
            Version3Map.Add(Room11V3);
            Version3Map.Add(Room12V3);
            Version3Map.Add(Room13V3);
            Version3Map.Add(Room14V3);
            Version3Map.Add(Room15V3);
            Version3Map.Add(Room16V3);
            Version3Map.Add(Room17V3);
            Version3Map.Add(Room18V3);
            Version3Map.Add(Room19V3);
            Version3Map.Add(Room20V3);
            Version3Map.Add(Room21V3);
            Version3Map.Add(Room22V3);
            Version3Map.Add(Room23V3);
            Version3Map.Add(Room24V3);
            Version3Map.Add(Room25V3);
            Version3Map.Add(Room26V3);
            Version3Map.Add(Room27V3);
            Version3Map.Add(Room28V3);
            Version3Map.Add(Room29V3);
            Version3Map.Add(Room30V3);

            Version4Map.Add(EmptyRoom);
            Version4Map.Add(Room1V4);
            Version4Map.Add(Room2V4);
            Version4Map.Add(Room3V4);
            Version4Map.Add(Room4V4);
            Version4Map.Add(Room5V4);
            Version4Map.Add(Room6V4);
            Version4Map.Add(Room7V4);
            Version4Map.Add(Room8V4);
            Version4Map.Add(Room9V4);
            Version4Map.Add(Room10V4);
            Version4Map.Add(Room11V4);
            Version4Map.Add(Room12V4);
            Version4Map.Add(Room13V4);
            Version4Map.Add(Room14V4);
            Version4Map.Add(Room15V4);
            Version4Map.Add(Room16V4);
            Version4Map.Add(Room17V4);
            Version4Map.Add(Room18V4);
            Version4Map.Add(Room19V4);
            Version4Map.Add(Room20V4);
            Version4Map.Add(Room21V4);
            Version4Map.Add(Room22V4);
            Version4Map.Add(Room23V4);
            Version4Map.Add(Room24V4);
            Version4Map.Add(Room25V4);
            Version4Map.Add(Room26V4);
            Version4Map.Add(Room27V4);
            Version4Map.Add(Room28V4);
            Version4Map.Add(Room29V4);
            Version4Map.Add(Room30V4);

            Version5Map.Add(EmptyRoom);
            Version5Map.Add(Room1V5);
            Version5Map.Add(Room2V5);
            Version5Map.Add(Room3V5);
            Version5Map.Add(Room4V5);
            Version5Map.Add(Room5V5);
            Version5Map.Add(Room6V5);
            Version5Map.Add(Room7V5);
            Version5Map.Add(Room8V5);
            Version5Map.Add(Room9V5);
            Version5Map.Add(Room10V5);
            Version5Map.Add(Room11V5);
            Version5Map.Add(Room12V5);
            Version5Map.Add(Room13V5);
            Version5Map.Add(Room14V5);
            Version5Map.Add(Room15V5);
            Version5Map.Add(Room16V5);
            Version5Map.Add(Room17V5);
            Version5Map.Add(Room18V5);
            Version5Map.Add(Room19V5);
            Version5Map.Add(Room20V5);
            Version5Map.Add(Room21V5);
            Version5Map.Add(Room22V5);
            Version5Map.Add(Room23V5);
            Version5Map.Add(Room24V5);
            Version5Map.Add(Room25V5);
            Version5Map.Add(Room26V5);
            Version5Map.Add(Room27V5);
            Version5Map.Add(Room28V5);
            Version5Map.Add(Room29V5);
            Version5Map.Add(Room30V5);

            // don't ignore this
            RandomMap.Add(EmptyRoom);
            RandomMap.Add(Room1);
            RandomMap.Add(Room2);
            RandomMap.Add(Room3);
            RandomMap.Add(Room4);
            RandomMap.Add(Room5);
            RandomMap.Add(Room6);
            RandomMap.Add(Room7);
            RandomMap.Add(Room8);
            RandomMap.Add(Room9);
            RandomMap.Add(Room10);
            RandomMap.Add(Room11);
            RandomMap.Add(Room12);
            RandomMap.Add(Room13);
            RandomMap.Add(Room14);
            RandomMap.Add(Room15);
            RandomMap.Add(Room16);
            RandomMap.Add(Room17);
            RandomMap.Add(Room18);
            RandomMap.Add(Room19);
            RandomMap.Add(Room20);
            RandomMap.Add(Room21);
            RandomMap.Add(Room22);
            RandomMap.Add(Room23);
            RandomMap.Add(Room24);
            RandomMap.Add(Room25);
            RandomMap.Add(Room26);
            RandomMap.Add(Room27);
            RandomMap.Add(Room28);
            RandomMap.Add(Room29);
            RandomMap.Add(Room30);








        }

        public void MoveWumpus(int roomRoomNumberWhereUserIsIn)
        {
            int wumpusRoom = 0;
            foreach (Room roomToCheck in Version1Map)
            {
                if (roomToCheck.HasWumpus == true)
                {
                    break;
                }
                else
                {
                    wumpusRoom++;
                }
            }

            Random rnd = new Random();
            int newWumpusRoom = rnd.Next(1, 30);


            while (Version1Map[newWumpusRoom].HasWumpus == true || Version1Map[newWumpusRoom].HasBats == true || Version1Map[newWumpusRoom].HasPit == true || newWumpusRoom == roomRoomNumberWhereUserIsIn || newWumpusRoom == wumpusRoom)
            {
                newWumpusRoom++;
                if (newWumpusRoom > 30)
                {
                    newWumpusRoom -= 30;
                }
            }

            Version1Map[newWumpusRoom].HasWumpus = true;
            Version1Map[wumpusRoom].HasWumpus = false;








        }

        public List<Room> GetAdjacentRoomInformation(int RoomNumberForWhichToGetInformation)
        {
            // REturn List of Adjacet Rooms with. // This Room List should be of this form: [RoomUser, RoomtotheTopLeft, .... (Coutnerclockwise), ....]

            Room roomToUse = Version1Map[RoomNumberForWhichToGetInformation];
            List<Room> listToReturn = new List<Room>();

            listToReturn.Add(roomToUse);
            listToReturn.Add(Version1Map[roomToUse.NextRoomList[0]]);
            listToReturn.Add(Version1Map[roomToUse.NextRoomList[1]]);
            listToReturn.Add(Version1Map[roomToUse.NextRoomList[2]]);
            listToReturn.Add(Version1Map[roomToUse.NextRoomList[3]]);
            listToReturn.Add(Version1Map[roomToUse.NextRoomList[4]]);
            listToReturn.Add(Version1Map[roomToUse.NextRoomList[5]]);


            return listToReturn;
        }

        public bool IsWumpusInRoom(int RoomNumberToCheck)
        {
            if (Version1Map[RoomNumberToCheck].HasWumpus == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetNewRoom()
        {
            Random rnd = new Random();
            int newRoom = rnd.Next(1, 30);

            while (Version1Map[newRoom].HasWumpus == true || Version1Map[newRoom].HasBats == true || Version1Map[newRoom].HasPit == true)
            {
                newRoom++;
                if (newRoom > 30)
                {
                    newRoom -= 30;
                }

            }

            return newRoom;
        }

        public void MoveBatsToDifferentRoom(int RoomNumberWhereUserIs, int RoomWhereUserIsMoved)
        {
            //List<int> batRooms = new List<int>();

            //foreach (Room roomToCheck in Version1Map)
            //{
            //    if (roomToCheck.HasBats == true)
            //    {
            //        int batRoom = roomToCheck.RoomNumber;
            //        batRooms.Add(batRoom);

            //    }
            //}



            Random rnd = new Random();
            int newBatRoom = rnd.Next(1, 30);


            while (Version1Map[newBatRoom].HasWumpus == true || Version1Map[newBatRoom].HasBats == true || Version1Map[newBatRoom].HasPit == true || newBatRoom == RoomWhereUserIsMoved)
            {
                newBatRoom++;
                if (newBatRoom > 30)
                {
                    newBatRoom -= 30;
                }
            }

            Version1Map[newBatRoom].HasBats = true;
            Version1Map[RoomNumberWhereUserIs].HasBats = false;

        }

        //method to generate random rooms
        public List<Room> GenerateCave()
        {
            Random rndWumpus = new Random();
            int wumpusRoom = rndWumpus.Next(1, 30);

            Random rndBat1 = new Random();
            int batRoom1 = rndBat1.Next(1, 30);
            while (batRoom1 == wumpusRoom)
            {
                batRoom1++;
                if (batRoom1 > 30)
                {
                    batRoom1 -= 30;
                }
            }

            Random rndBat2 = new Random();
            int batRoom2 = rndBat2.Next(1, 30);
            while (batRoom2 == wumpusRoom || batRoom1 == batRoom2)
            {
                batRoom2++;
                if(batRoom2 > 30)
                {
                    batRoom2 -= 30;
                }
            }

            Random rndPit = new Random();
            int pitRoom = rndPit.Next(1, 30);
            while (pitRoom == wumpusRoom || pitRoom == batRoom2 || pitRoom == batRoom2)
            {
                if (pitRoom > 30)
                {
                    pitRoom -= 30;
                }
            }

            RandomMap[wumpusRoom].HasWumpus = true;
            RandomMap[batRoom1].HasBats = true;
            RandomMap[batRoom2].HasBats = true;
            RandomMap[pitRoom].HasPit = true;

            return RandomMap;

        }

        //tests the random room generator
        private void button_Generate_Click(object sender, EventArgs e)
        {

            Random rndWumpus = new Random();
            int wumpusRoom = rndWumpus.Next(1, 30);

            Random rndBat1 = new Random();
            int batRoom1 = rndBat1.Next(1, 30);
            while (batRoom1 == wumpusRoom)
            {
                batRoom1++;
                if (batRoom1 > 30)
                {
                    batRoom1 -= 30;
                }
            }

            Random rndBat2 = new Random();
            int batRoom2 = rndBat2.Next(1, 30);
            while (batRoom2 == wumpusRoom || batRoom1 == batRoom2)
            {
                batRoom2++;
                if (batRoom2 > 30)
                {
                    batRoom2 -= 30;
                }
            }

            Random rndPit = new Random();
            int pitRoom = rndPit.Next(1, 30);
            while (pitRoom == wumpusRoom || pitRoom == batRoom2 || pitRoom == batRoom2)
            {
                if (pitRoom > 30)
                {
                    pitRoom -= 30;
                }
            }
            textBox_WumpusRoom.Text = wumpusRoom.ToString();
            textBox_Bat1Room.Text = batRoom1.ToString();
            textBox_Bat2Room.Text = batRoom2.ToString();
            textBox_PitRoom.Text = pitRoom.ToString();
        }
    }
}
