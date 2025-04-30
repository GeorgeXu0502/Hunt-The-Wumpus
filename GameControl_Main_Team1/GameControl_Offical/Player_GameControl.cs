using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrivaMachine_Offical;
using CaveMain_Offical;
using PlayerInventory_Offical;

namespace GameControl_Offical
{
    
    public class Player_GameControl
    {
        Player_TriviaMachine TriviaMachineObject = new TrivaMachine_Offical.Player_TriviaMachine();
        Player_CaveMain CaveMainObject = new CaveMain_Offical.Player_CaveMain();
        Player_HighScore PlayerInventoryObject = new PlayerInventory_Offical.Player_HighScore();

        int RoomUserIsIn=1; // Please set this variable to what it needs to be at the begining of the game. // For Now we start at Room 1.
        public List<Room> AdjacentRoomInformation(int RoomNumberForInformation)
        {
            // Change This Function to return the correct List. 
            List<Room> roomlistotreturn = new List<Room>();

            int[] newintarray = { 1, 2, 3, 4, 5 };
            Room Room1 = new Room(1, false, false, false, newintarray);
            roomlistotreturn.Add(Room1);
            return roomlistotreturn;
        }
        public int WhereIsUser()
        {
            // This Function should return where the User is. Room Number (int)
            return RoomUserIsIn;
        }

        public void UpdateWhereUserIs(int RoomNumberWhereWeAreGoing)
        {
            // Already Up To Date. 
            RoomUserIsIn = RoomNumberWhereWeAreGoing;
        }

        public TriviaAnswer SendTriviaAnswer()
        {
            TriviaAnswer TriviaAnswertoReturn = TriviaMachineObject.GetTriviaAnswer();

            return TriviaAnswertoReturn;
        }

        public int PlayerGoldCoinAmount()
        {
            // Write a Function to return the amount of Gold Coin the Player Has. 

            return 0;
        }

        public int PlayerArrowAmount()
        {
            // Write a Function to return the amount of Arrows the Player Has. 

            return 0;
        }

        public TriviaQuestion GetQuestion()
        {
            // Write a Function to return a TriviaQuestion Variable.  
            List<string> newstringlist = new List<string>();
            newstringlist.Add("Hi");
            TriviaQuestion triviaquestiontoreturn = new TriviaQuestion("Hi", newstringlist, 0);


            return triviaquestiontoreturn;
        }

        public void MoveWumpus(int RoomNumberWhereUserIsIn)
        {
            // Given Where the User Is, Have the Cave move the Wumpus From This Room.
        }

        public bool CheckIfWampusInRoom(int RoomToCheck)
        {
            // Write Code To Check if Wampus Was In the Room. 
            return false;
        }


    }
}
