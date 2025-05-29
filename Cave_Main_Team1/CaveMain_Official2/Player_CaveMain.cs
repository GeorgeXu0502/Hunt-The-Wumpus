using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveMain_Official2
{
    public class Player_CaveMain
    {
        // Here is the description of each room in the randomly generated map.
        // Format: room number, [if has bat, if has wumpus, if has pit (all false before random], list of neighboring rooms, which rooms can be accessed from that room)
        List<Room> RandomMap = new List<Room>();

        // empty room that isn't used. Makes indexing list easier (ie room 1 will be index 1)
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
            // adds rooms to random map list
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

            // randomly generates which room to contain each hazard, which neighboring rooms cannot be accessed
            GenerateCave();
        }

        /// <summary>
        /// This method is part of the Generate Cave method. When making some room not accessible from one room,
        /// need to make sure that "door" is closed from both sides. This method determines the index of the first
        /// room in the list of rooms in the second room
        /// </summary>
        /// <param name="room"></param>
        /// <param name="i1"></param>
        /// <returns> The index of the list needed to change </returns>
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

                   
                }

            }
            return index1;
        }

        /// <summary>
        /// Same thing as above
        /// </summary>
        /// <param name="room"></param>
        /// <param name="i1"></param>
        /// <returns> The index of the list needed to change </returns>
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
                   

                }

            }
            return index2;

        }

        /// <summary>
        /// This method finds the number of inacessible rooms from a room. This is used to make sure there is at least 1 way to access it
        /// </summary>
        /// <param name="room"></param>
        /// <returns> The number of closed rooms <returns>
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

        /// <summary>
        /// This method randomly assigns a room to (initially) contain a wumpus, 2 rooms for bats, and 1 room for the pit
        /// It also sets which rooms are accessible from each room (ie not all 6 neighboring rooms are accessible)
        /// </summary>
        /// <returns> The random map </returns>
        public List<Room> GenerateCave()
        {
            // gets a random starting room for Wumpus. Since user starts in room 1, make sure it isn't in room 1
            Random rndWumpus = new Random();
            int wumpusRoom = rndWumpus.Next(2, 31);

            // gets a random starting room for Bat 1. Makes sure it isn't in wumpus room, or room 1
            Random rndBat1 = new Random();
            int batRoom1 = rndBat1.Next(2, 31);
            while (batRoom1 == wumpusRoom || batRoom1 == 1)
            {
                // the chances of above happening are relatively low, so will just increment by 1 in case it does happen
                batRoom1++;

                // for if by incrementing makes room number more than 30
                if (batRoom1 > 30)
                {
                    batRoom1 -= 30;
                }
            }

            // same as above, except also makes sure bat room2 isn't the same as bat room 1
            Random rndBat2 = new Random();
            int batRoom2 = rndBat2.Next(2, 31);
            while (batRoom2 == wumpusRoom || batRoom1 == batRoom2 || batRoom2 == 1)
            {
                batRoom2++;
                if (batRoom2 > 30)
                {
                    batRoom2 -= 30;
                }
            }

            // same as above, except also makes sure bat room2 isn't the same as bat room 2
            Random rndPit = new Random();
            int pitRoom = rndPit.Next(2, 31);
            while (pitRoom == wumpusRoom || pitRoom == batRoom1 || pitRoom == batRoom2 || pitRoom == 1)
            {
                pitRoom++;
                if (pitRoom > 30)
                {
                    pitRoom -= 30;
                }
            }
            
            // since the random map starts with all hazards false, changes required room to have hazards
            RandomMap[wumpusRoom].HasWumpus = true;
            RandomMap[batRoom1].HasBats = true;
            RandomMap[batRoom2].HasBats = true;
            RandomMap[pitRoom].HasPit = true;

            // everything below this is for making it so not all 6 neighboring rooms are accessible from each room
            foreach (Room room in RandomMap)
            {
                if (room.RoomNumber != 0)
                {
                    // to prevent having inaccessible room
                    int numberOfClosedRooms = FindNumberClosedRooms(room);
                    if (numberOfClosedRooms < 4)
                    {
                        // for each room, selects two random indexes (corresponding to the rooms in the neighboring 
                        // rooms list, to have closed
                        Random rndInt1 = new Random();
                        int rndClosed1 = rndInt1.Next(0, 6);

                        Random rndInt2 = new Random();
                        int rndClosed2 = rndInt1.Next(0, 6);

                        // closes off room from one side
                        room.CanGoToRoom[rndClosed1] = false;
                        room.CanGoToRoom[rndClosed2] = false;

                        int roomToChange1 = room.NextRoomList[rndClosed1];
                        int i3 = FindRoomToChange1(room, roomToChange1);
                        int numberOfClosedRooms1 = FindNumberClosedRooms(RandomMap[roomToChange1]);
                        if (numberOfClosedRooms1 < 4)
                        {
                            // closes off room from other side
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
        /// This method moves the wumpus to a random room (that the player isn't in, and that doesn't have any hazards)
        /// It is called when the player shoots an arrow into a room and misses, or encounters wumpus and escapes it.
        /// </summary>
        /// <param name="roomRoomNumberWhereUserIsIn">this parameter is the room number that the player is currently in</param>
        public void MoveWumpus(int roomRoomNumberWhereUserIsIn)
        {
            // determines where wumpus is
            int wumpusRoom = 0;
            foreach (Room roomToCheck in RandomMap)
            {
                if (roomToCheck.HasWumpus == true)
                {
                    wumpusRoom += roomToCheck.RoomNumber;
                    break;
                }
                
            }

            Random rnd = new Random();
            int newWumpusRoom = rnd.Next(1, 31);

            // makes sure the room to where wumpus is being moved doesn;t have any hazards, and isn't old room
            while (RandomMap[newWumpusRoom].HasWumpus == true || RandomMap[newWumpusRoom].HasBats == true || RandomMap[newWumpusRoom].HasPit == true || newWumpusRoom == roomRoomNumberWhereUserIsIn || newWumpusRoom == wumpusRoom)
            {
                newWumpusRoom++;
                if (newWumpusRoom > 30)
                {
                    newWumpusRoom -= 30;
                }
            }

            // updates room information
            RandomMap[newWumpusRoom].HasWumpus = true;
            RandomMap[wumpusRoom].HasWumpus = false;
        }

        /// <summary>
        /// This method gets the room information for all adjacent rooms for the room the player moves to. 
        /// It will return all accessible rooms, with stating their room number, and if it has any hazards
        /// </summary>
        /// <param name="RoomNumberForWhichToGetInformation">this is the room number to get information for</param>
        /// <returns></returns>
        public List<Room> GetAdjacentRoomInformation(int RoomNumberForWhichToGetInformation)
        {
            // REturn List of Adjacet Rooms with. // This Room List should be of this form: [RoomUser, RoomtotheTopLeft, .... (Coutnerclockwise), ....]


            Room roomToUse = RandomMap[RoomNumberForWhichToGetInformation];
            List<Room> listotreturn = new List<Room>();
            listotreturn.Add(roomToUse);

            // adds list of accessible rooms
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
        /// <returns> the random room (chosen from the list of rooms) </returns>
        public int GetNewRoom()
        {
            //Return a new room with no hazards. Just an Integer.

            Random rnd = new Random();
            int newRoom = rnd.Next(1, 30);

            // makes sure newRoom doesn't have any hazards
            while (RandomMap[newRoom].HasWumpus == true || RandomMap[newRoom].HasBats == true || RandomMap[newRoom].HasPit == true)
            {
                newRoom++;
                if (newRoom > 30)
                {
                    newRoom -= 30;
                }
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
            int newBatRoom = rnd.Next(1, 31);

            // makes sure new bat room doesn't have any hazard, and isn't the same room it was before/where user is moved to
            while (RandomMap[newBatRoom].HasWumpus == true || RandomMap[newBatRoom].HasBats == true || RandomMap[newBatRoom].HasPit == true || newBatRoom == RoomWhereUserIsMoved)
            {
                newBatRoom++;
                if (newBatRoom > 30)
                {
                    newBatRoom -= 30;
                }
            }

            // updates room information
            RandomMap[newBatRoom].HasBats = true;
            RandomMap[RoomNumberWhereUserIs].HasBats = false;
        }

        /// <summary>
        /// This method determines if the Wumpus is in a room that player can directly access from their current room
        /// </summary>
        /// <param name="RoomNumberwhereUserIs"></param>
        /// <returns> true/false, depending on if the Wumpus is there </returns>
        public bool IsWampusInTheNextRoom(int RoomNumberwhereUserIs)
        {
            Room RoomWhereUserIs = RandomMap[RoomNumberwhereUserIs];

            bool IsWumpusIntheNextRoom = false;

            List<Room> RoomsToCheck = new List<Room>();

            // finds which rooms are accessible from current room
            for (int i = 0; i < 6; i++)
            {
                if (RoomWhereUserIs.CanGoToRoom[i] == true)
                {
                    RoomsToCheck.Add(RandomMap[RoomWhereUserIs.NextRoomList[i]]);
                }
            }

            // checks each of the accessible rooms for the wumpus
            foreach (Room RoomToCheck in RoomsToCheck)
            {
                if (RoomToCheck.HasWumpus == true)
                {
                    IsWumpusIntheNextRoom = true;
                }
            }

            return IsWumpusIntheNextRoom;
        }

        /// <summary>
        /// This method determines if the pit is in a room that player can directly access from their current room
        /// </summary>
        /// <param name="RoomNumberwhereUserIs"></param>
        /// <returns> true/false, depending on if the pit is there </returns>
        public bool IsPitInTheNextRoom(int RoomNumberwhereUserIs)
        {
            
            Room RoomWhereUserIs = RandomMap[RoomNumberwhereUserIs];

            bool IsPitInNextRoom = false;

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
                    IsPitInNextRoom = true;
                }
            }

            return IsPitInNextRoom;
        }

        /// <summary>
        /// This method determines if the bat is in a room that player can directly access from their current room
        /// </summary>
        /// <param name="RoomNumberwhereUserIs"></param>
        /// <returns> true/false, depending on if the bat is there </returns>
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

         /// <summary>
         /// This method gives which room has the Wumpus
         /// </summary>
         /// <returns></returns>
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

        /// <summary>
        /// This method gives which room has the pit
        /// </summary>
        /// <returns> pit room </returns>
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

        /// <summary>
        /// This method gives one of the rooms with a bat
        /// </summary>
        /// <returns>bat room</returns>
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











        // Anastasia please decide what you want to do with these functions

        /// <summary>
        /// This method determines if the wumpus is 1 or 2 accessible rooms away from where the user is (if neither, returns 0)
        /// </summary>
        /// <param name="RoomWhereUserIs"></param>
        /// <returns>1, 2, or 0 </returns>
        public int HowManyRoomsAwayIsWumpus(int RoomWhereUserIs)
        {
            int HowManyRoomsAwayIsWumpus = 0;

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
                    HowManyRoomsAwayIsWumpus += 1;


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
                                HowManyRoomsAwayIsWumpus += 2;
                            }
                        }
                    }

                }
            }

            if (HowManyRoomsAwayIsWumpus == 1 || HowManyRoomsAwayIsWumpus == 2)
            {
                return HowManyRoomsAwayIsWumpus;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// This method determines if the pit is 1 or 2 accessible rooms away from where the user is (if neither, returns 0)
        /// </summary>
        /// <param name="RoomWhereUserIs"></param>
        /// <returns>1, 2, or 0 </returns>
        public int HowManyRoomsAwayIsThePit(int RoomWhereUserIs)
        {
            int HowManyRoomsAwayIsPit = 0;

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
                    HowManyRoomsAwayIsPit += 1;


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
                                HowManyRoomsAwayIsPit += 2;
                            }
                        }
                    }

                }
            }

            if (HowManyRoomsAwayIsPit == 1 || HowManyRoomsAwayIsPit == 2)
            {
                return HowManyRoomsAwayIsPit;
            }
            else
            {
                return 0;
            }
        }



    }
}

