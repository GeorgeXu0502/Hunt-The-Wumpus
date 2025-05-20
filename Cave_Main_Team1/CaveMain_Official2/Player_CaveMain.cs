using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveMain_Official2
{
    public class Player_CaveMain
    {

        List<Room> RandomMap = new List<Room>();

        Room EmptyRoom = new Room(0, false, false, false, [0, 0, 0, 0, 0, 0], [false,]);

        Room Room1 = new Room(1, false, false, false, [30, 6, 7, 2, 26, 25], [true, true, true, true, true, true]);
        Room Room2 = new Room(2, false, false, false, [1, 7, 8, 9, 3, 26], [true, true, true, true, true, true]);
        Room Room3 = new Room(3, false, false, false, [26, 2, 9, 4, 28, 27], [true, true, true, true, true, true]);
        Room Room4 = new Room(4, false, false, false, [3, 9, 10, 11, 5, 28], [true, true, true, true, true, true]);
        Room Room5 = new Room(5, false, false, false, [28, 4, 11, 6, 30, 29], [true, true, true, true, true, true]);
        Room Room6 = new Room(6, false, false, false, [5, 11, 12, 7, 1, 30], [true, true, true, true, true, true]);
        Room Room7 = new Room(7, false, false, false, [6, 12, 13, 8, 2, 1], [true, true, true, true, true, true]);
        Room Room8 = new Room(8, false, false, false, [7, 13, 14, 15, 9, 2], [true, true, true, true, true, true]);
        Room Room9 = new Room(9, false, false, false, [2, 8, 15, 10, 4, 3], [true, true, true, true, true, true]);
        Room Room10 = new Room(10, false, false, false, [9, 15, 16, 17, 11, 4], [true, true, true, true, true, true]);
        Room Room11 = new Room(11, false, false, false, [4, 10, 17, 12, 6, 5], [true, true, true, true, true, true]);
        Room Room12 = new Room(12, false, false, false, [11, 17, 18, 13, 7, 6], [true, true, true, true, true, true]);
        Room Room13 = new Room(13, false, false, false, [12, 18, 19, 14, 8, 7], [true, true, true, true, true, true]);
        Room Room14 = new Room(14, false, false, false, [13, 19, 20, 21, 15, 8], [true, true, true, true, true, true]);
        Room Room15 = new Room(15, false, false, false, [8, 14, 21, 16, 10, 9], [true, true, true, true, true, true]);
        Room Room16 = new Room(16, false, false, false, [15, 21, 22, 23, 17, 10], [true, true, true, true, true, true]);
        Room Room17 = new Room(17, false, false, false, [10, 16, 23, 18, 12, 11], [true, true, true, true, true, true]);
        Room Room18 = new Room(18, false, false, false, [17, 23, 24, 19, 13, 12], [true, true, true, true, true, true]);
        Room Room19 = new Room(19, false, false, false, [18, 24, 25, 20, 14, 13], [true, true, true, true, true, true]);
        Room Room20 = new Room(20, false, false, false, [19, 25, 26, 27, 21, 14], [true, true, true, true, true, true]);
        Room Room21 = new Room(21, false, false, false, [14, 20, 27, 22, 16, 15], [true, true, true, true, false, true]);
        Room Room22 = new Room(22, false, false, false, [21, 27, 28, 29, 23, 16], [true, true, true, true, true, true]);
        Room Room23 = new Room(23, false, false, false, [16, 22, 29, 24, 18, 17], [true, true, true, true, true, true]);
        Room Room24 = new Room(24, false, false, false, [23, 29, 30, 25, 19, 18], [true, true, true, true, true, true]);
        Room Room25 = new Room(25, false, false, false, [24, 30, 1, 26, 20, 19], [true, true, true, true, true, true]);
        Room Room26 = new Room(26, false, false, false, [25, 1, 2, 3, 27, 20], [true, true, true, true, true, true]);
        Room Room27 = new Room(27, false, false, false, [20, 26, 3, 28, 22, 21], [true, true, true, true, true, true]);
        Room Room28 = new Room(28, false, false, false, [27, 3, 4, 5, 29, 22], [true, true, true, true, true, true]);
        Room Room29 = new Room(29, false, false, false, [22, 28, 5, 30, 24, 23], [true, true, true, true, true, true]);
        Room Room30 = new Room(30, false, false, false, [29, 5, 6, 1, 25, 24], [true, true, true, true, true, true]);
        public Player_CaveMain()
        {
            /*
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
            */ 

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
            GenerateCave();
        }

        /*
        List<Room> Version1Map = new List<Room>();
        List<Room> Version2Map = new List<Room>();
        List<Room> Version3Map = new List<Room>();
        List<Room> Version4Map = new List<Room>();
        List<Room> Version5Map = new List<Room>();
        */ 

       
        // information about each room in Version 1 of the cave
        // if room has bats, if room has wumpus, if room has a pit, what rooms player can move to next
        
        /*
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
        */

        /* This is code to generate the old type of random cave, with random hazards but all of the rooms are connected. 
        public List<Room> GenerateCave()
        {
            Random rndWumpus = new Random();
            int wumpusRoom = rndWumpus.Next(1, 31);

            Random rndBat1 = new Random();
            int batRoom1 = rndBat1.Next(1, 31);
            while (batRoom1 == wumpusRoom)
            {
                batRoom1++;
                if (batRoom1 > 30)
                {
                    batRoom1 -= 30;
                }
            }

            Random rndBat2 = new Random();
            int batRoom2 = rndBat2.Next(1, 31);
            while (batRoom2 == wumpusRoom || batRoom1 == batRoom2)
            {
                batRoom2++;
                if (batRoom2 > 30)
                {
                    batRoom2 -= 30;
                }
            }

            Random rndPit = new Random();
            int pitRoom = rndPit.Next(1, 31);
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
        */



        public int FindRoomToChange1(Room room, int i1)
        {
            int index1 = 0;
            foreach (int i in RandomMap[i1].NextRoomList)
            {


                if (i == room.RoomNumber)
                {

                    for (int j = 0; j < 6; j++)
                    {
                        if (i == RandomMap[i1].NextRoomList[j])
                        {
                            index1 += j;
                        }
                    }

                    //if ((i == RandomMap[i1].NextRoomList[0]))
                    //{
                    //    index1 += 0;
                    //}

                    //else if ((i == RandomMap[i1].NextRoomList[1]))
                    //{
                    //    index1 += 1;
                    //}

                    //else if ((i == RandomMap[i1].NextRoomList[2]))
                    //{
                    //    index1 += 2;
                    //}

                    //else if ((i == RandomMap[i1].NextRoomList[3]))
                    //{
                    //    index1 += 3;
                    //}

                    //else if ((i == RandomMap[i1].NextRoomList[4]))
                    //{
                    //    index1 += 4;
                    //}

                    //else if ((i == RandomMap[i1].NextRoomList[5]))
                    //{
                    //    index1 += 5;
                    //}


                }

            }
            return index1;
        }


        public int FindRoomToChange2(Room room, int i1)
        {
            int index2 = 0;
            foreach (int i in RandomMap[i1].NextRoomList)
            {
                if (i == room.RoomNumber)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (i == RandomMap[i1].NextRoomList[j])
                        {
                            index2 += j;
                        }
                    }
                    //if ((i == RandomMap[i1].NextRoomList[0]))
                    //{
                    //    index2 += 0;
                    //}

                    //else if ((i == RandomMap[i1].NextRoomList[1]))
                    //{
                    //    index2 += 1;
                    //}

                    //else if ((i == RandomMap[i1].NextRoomList[2]))
                    //{
                    //    index2 += 2;
                    //}

                    //else if ((i == RandomMap[i1].NextRoomList[3]))
                    //{
                    //    index2 += 3;
                    //}

                    //else if ((i == RandomMap[i1].NextRoomList[4]))
                    //{
                    //    index2 += 4;
                    //}

                    //else if ((i == RandomMap[i1].NextRoomList[5]))
                    //{
                    //    index2 += 5;
                    //}


                }

            }
            return index2;

        }

        public int FindNumberClosedRooms(Room room)
        {
            int numberClosedRooms = 0;
            foreach (bool i in room.CanGoToRoom)
            {
                if (i == false)
                {
                    numberClosedRooms++;
                }
            }

            return numberClosedRooms;
        }

        public List<Room> GenerateCave()
        {
            Random rndWumpus = new Random();
            int wumpusRoom = rndWumpus.Next(2, 31);

            Random rndBat1 = new Random();
            int batRoom1 = rndBat1.Next(1, 31);
            while (batRoom1 == wumpusRoom)
            {
                batRoom1++;
                if (batRoom1 > 30)
                {
                    batRoom1 -= 30;
                }
            }

            Random rndBat2 = new Random();
            int batRoom2 = rndBat2.Next(2, 31);
            while (batRoom2 == wumpusRoom || batRoom1 == batRoom2)
            {
                batRoom2++;
                if (batRoom2 > 30)
                {
                    batRoom2 -= 30;
                }
            }

            Random rndPit = new Random();
            int pitRoom = rndPit.Next(2, 31);
            while (pitRoom == wumpusRoom || pitRoom == batRoom1 || pitRoom == batRoom2)
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

            foreach (Room room in RandomMap)
            {
                if (room.RoomNumber != 0)
                {
                    int numberOfClosedRooms = FindNumberClosedRooms(room);
                    if (numberOfClosedRooms < 4)
                    {
                        Random rndInt1 = new Random();
                        int rndClosed1 = rndInt1.Next(0, 6);

                        Random rndInt2 = new Random();
                        int rndClosed2 = rndInt1.Next(0, 6);

                        room.CanGoToRoom[rndClosed1] = false;
                        room.CanGoToRoom[rndClosed2] = false;

                        int roomToChange1 = room.NextRoomList[rndClosed1];
                        int i3 = FindRoomToChange1(room, roomToChange1);
                        int numberOfClosedRooms1 = FindNumberClosedRooms(RandomMap[roomToChange1]);
                        if (numberOfClosedRooms1 < 4)
                        {
                            RandomMap[roomToChange1].CanGoToRoom[i3] = false;
                        }


                        int roomToChange2 = room.NextRoomList[rndClosed2];
                        int numberOfClosedRooms2 = FindNumberClosedRooms(RandomMap[roomToChange2]);
                        int i4 = FindRoomToChange2(room, roomToChange2);
                        if (numberOfClosedRooms1 < 4)
                        {
                            RandomMap[roomToChange2].CanGoToRoom[i4] = false;
                        }






                    }

                }

            }
            return RandomMap;
        }


        /// <summary>
        /// This method moves the wumpus to a random room (that the player isn't in, and that doesn't hany any hazards)
        /// It is called when the player shoots an arrow into a room, and misses.
        /// </summary>
        /// <param name="roomRoomNumberWhereUserIsIn">this parameter is the room number that the player is currently in</param>
        public void MoveWumpus(int roomRoomNumberWhereUserIsIn)
        {
            //Move the Wumpus to a different room, not where the User is. Please check guide for this.


            int wumpusRoom = 0;
            foreach (Room roomToCheck in RandomMap)
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


            while (RandomMap[newWumpusRoom].HasWumpus == true || RandomMap[newWumpusRoom].HasBats == true || RandomMap[newWumpusRoom].HasPit == true || newWumpusRoom == roomRoomNumberWhereUserIsIn || newWumpusRoom == wumpusRoom)
            {
                newWumpusRoom++;
            }

            RandomMap[newWumpusRoom].HasWumpus = true;
            RandomMap[wumpusRoom].HasWumpus = false;
        }

        /// <summary>
        /// This method gets the room information for all adjacent rooms for the room the player moves to. 
        /// It will return all 6 rooms, with stating their room number, and if it has any hazards
        /// </summary>
        /// <param name="RoomNumberForWhichToGetInformation">this is the room number to get information for</param>
        /// <returns></returns>
        public List<Room> GetAdjacentRoomInformation(int RoomNumberForWhichToGetInformation)
        {
            // REturn List of Adjacet Rooms with. // This Room List should be of this form: [RoomUser, RoomtotheTopLeft, .... (Coutnerclockwise), ....]


            Room roomToUse = RandomMap[RoomNumberForWhichToGetInformation];
            List<Room> listotreturn = new List<Room>();
            listotreturn.Add(roomToUse);
            for (int i = 0; i < 6; i++)
            {
                listotreturn.Add(RandomMap[roomToUse.NextRoomList[i]]);
            }

            return listotreturn;
        }

        /// <summary>
        /// this method is used to determine if the wumpus is in the room, whether the one the player moves into, or shoots an arrow into
        /// 
        /// </summary>
        /// <param name="RoomNumberToCheck">this is the room number to check</param>
        /// <returns></returns>
        public bool IsWumpusInRoom(int RoomNumberToCheck)
        {
            // Check if Wumpus is in the room.
            if (RandomMap[RoomNumberToCheck].HasWumpus == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This function gets a new room with no hazard, into which we can move the user. 
        /// </summary>
        /// <returns></returns>
        public int GetNewRoom()
        {
            //Return a new room with no hazards. Just an Integer.

            Random rnd = new Random();
            int newRoom = rnd.Next(1, 30);

            while (RandomMap[newRoom].HasWumpus == true || RandomMap[newRoom].HasBats == true || RandomMap[newRoom].HasPit == true)
            {
                newRoom++;
            }

            return newRoom;
        }

        /// <summary>
        /// After the user encounters the bats, this method is called to move the bats to another random room, without any hazards 
        /// </summary>
        /// <param name="RoomNumberWhereUserIs"></param>
        /// <param name="RoomWhereUserIsMoved"></param>
        public void MoveBatsToDifferentRoom(int RoomNumberWhereUserIs, int RoomWhereUserIsMoved)
        {
            // Move the bats to a different room than the user. The room where the User was (and meet Bats), where the User is to be moved to.
            // Move bats to any other room bu thits.

            Random rnd = new Random();
            int newBatRoom = rnd.Next(1, 30);


            while (RandomMap[newBatRoom].HasWumpus == true || RandomMap[newBatRoom].HasBats == true || RandomMap[newBatRoom].HasPit == true || newBatRoom == RoomWhereUserIsMoved)
            {
                newBatRoom++;
            }

            RandomMap[newBatRoom].HasBats = true;
            RandomMap[RoomNumberWhereUserIs].HasBats = false;
        }


        public bool IsWampusInTheNextRoom(int RoomNumberwhereUserIs)
        {
            Room RoomWhereUserIs = RandomMap[RoomNumberwhereUserIs];

            bool IsWampusIntheNextRoom = false;

            List<Room> RoomstoCheck = new List<Room>();

            for (int i = 0; i < 6; i++)
            {
                if (RoomWhereUserIs.CanGoToRoom[i] == true)
                {
                    RoomstoCheck.Add(RandomMap[RoomWhereUserIs.NextRoomList[i]]);
                }
            }

            foreach (Room RoomToCheck in RoomstoCheck)
            {
                if (RoomToCheck.HasWumpus == true)
                {
                    IsWampusIntheNextRoom = true;
                }
            }

            return IsWampusIntheNextRoom;
        }

        public bool IsPitInTheNextRoom(int RoomNumberwhereUserIs)
        {
            Room RoomWhereUserIs = RandomMap[RoomNumberwhereUserIs];

            bool IsWampusIntheNextRoom = false;

            List<Room> RoomstoCheck = new List<Room>();

            for (int i = 0; i < 6; i++)
            {
                if (RoomWhereUserIs.CanGoToRoom[i] == true)
                {
                    RoomstoCheck.Add(RandomMap[RoomWhereUserIs.NextRoomList[i]]);
                }
            }

            foreach (Room RoomToCheck in RoomstoCheck)
            {
                if (RoomToCheck.HasPit == true)
                {
                    IsWampusIntheNextRoom = true;
                }
            }

            return IsWampusIntheNextRoom;
        }

        public bool IsBatInTheNextRoom(int RoomNumberwhereUserIs)
        {
            Room RoomWhereUserIs = RandomMap[RoomNumberwhereUserIs];

            bool IsWampusIntheNextRoom = false;

            List<Room> RoomstoCheck = new List<Room>();

            for (int i = 0; i < 6; i++)
            {
                if (RoomWhereUserIs.CanGoToRoom[i] == true)
                {
                    RoomstoCheck.Add(RandomMap[RoomWhereUserIs.NextRoomList[i]]);
                }
            }

            foreach (Room RoomToCheck in RoomstoCheck)
            {
                if (RoomToCheck.HasBats == true)
                {
                    IsWampusIntheNextRoom = true;
                }
            }

            return IsWampusIntheNextRoom;
        }

        // Functions to determine the location of certain objects in the Cave System. 

        public int WhereisWampus()
        {
            int wumpusRoom = 0;
            foreach(Room room in RandomMap)
            {
                if (room.HasWumpus == true)
                {
                    wumpusRoom = room.RoomNumber;
                    break;
                }
            }
            return wumpusRoom;
        }

        public int WhereisPit()
        {
            int pitRoom = 0;
            foreach (Room room in RandomMap)
            {
                if (room.HasPit == true)
                {
                    pitRoom = room.RoomNumber;
                    break;
                }
            }
            return pitRoom;
        }

        public int WhereisaBat()
        {
            int batRoom = 0;
            foreach (Room room in RandomMap)
            {
                if (room.HasBats == true)
                {
                    batRoom = room.RoomNumber;
                    break;
                }
            }
            return batRoom;
        }

        public int HowManyRoomsAwayIsWampus(int RoomWhereUserIs)
        {
            // Try to write a function to identify how many rooms away the Wumpus is from the User. 
            return 0;
        }

        public int HowManyRoomsAwayIsPit(int RoomWhereUserIs)
        {
            // Try to write a function to identify how many rooms away the Wumpus is from the User. 
            return 0;
        }











        // Anastasia please decide what you want to do with these functions. 
        public bool IsWumpusClose(int RoomWhereUserIs)
        {
            bool IsWumpusClose = false;

            Room roomToUse = RandomMap[RoomWhereUserIs];
            List<Room> roomsToCheck = new List<Room>();

            for (int i = 0; i < 6; i++)
            {
                if (roomToUse.CanGoToRoom[i] == true)
                {
                    roomsToCheck.Add(RandomMap[roomToUse.NextRoomList[i]]);
                }
            }

            foreach (Room room in roomsToCheck)
            {
                if (room.HasWumpus == true)
                {
                    IsWumpusClose = true;


                }
                else
                {
                    List<Room> roomsToCheckRoundTwo = new List<Room>();
                    for (int i = 0; i < 6; i++)
                    {
                        if (room.CanGoToRoom[i] == true)
                        {
                            if (room.HasWumpus == true)
                            {
                                IsWumpusClose = true;
                            }
                        }
                    }

                }
            }

            if (IsWumpusClose == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPitClose(int RoomWhereUserIs)
        {
            bool IsPitClose = false;

            Room roomToUse = RandomMap[RoomWhereUserIs];
            List<Room> roomsToCheck = new List<Room>();

            for (int i = 0; i < 6; i++)
            {
                if (roomToUse.CanGoToRoom[i] == true)
                {
                    roomsToCheck.Add(RandomMap[roomToUse.NextRoomList[i]]);
                }
            }

            foreach (Room room in roomsToCheck)
            {
                if (room.HasPit == true)
                {
                    IsPitClose = true;


                }
                else
                {
                    List<Room> roomsToCheckRoundTwo = new List<Room>();
                    for (int i = 0; i < 6; i++)
                    {
                        if (room.CanGoToRoom[i] == true)
                        {
                            if (room.HasPit == true)
                            {
                                IsPitClose = true;
                            }
                        }
                    }

                }
            }

            if (IsPitClose == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}

