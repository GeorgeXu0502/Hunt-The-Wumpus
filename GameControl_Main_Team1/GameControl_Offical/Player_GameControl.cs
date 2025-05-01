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

        int RoomUserIsIn = 1; // This is where the User Starts
        int goldCoinsCount = 0;
        List<string> SecretList = new List<string>();
        public List<Room> AdjacentRoomInformation(int RoomToGetInformationFor)
        {
            // Write Function to get a List: // This Room List should be of this form: [RoomUser, RoomtotheTopLeft, .... (Coutnerclockwise), ....]
            List<Room> roomlistotreturn = new List<Room>();

            int[] newintarray = { 1, 2, 3, 4, 5 };
            Room Room1 = new Room(1, false, false, false, newintarray);
            roomlistotreturn.Add(Room1);
            return roomlistotreturn;
        }

        public void UpdateWhereUserIs(int RoomNumberWeAreMovingTo)
        {
            RoomUserIsIn = RoomNumberWeAreMovingTo;
        }

        public int WhereIsUser()
        {
            // This Function should return where the User is. Room Number (int)
            return RoomUserIsIn;
        }
        public Room GetRoomUserMovingTo(int RoomNumber, bool SelfIntitated)
        {
            Room RoomtoReturn = CaveMainObject.GetRoomInformation(RoomNumber);

            return RoomtoReturn;
        }

        public TriviaQuestion SendTriviaQuestion()
        {
            TriviaQuestion TriviaAnswertoReturn = TriviaMachineObject.GetTriviaAnswer();

            return TriviaAnswertoReturn;
        }

        public int PlayerGoldCoinAmount()
        {
            // Write a Function to return the amount of Gold Coin the Player Has. 
            return PlayerInventoryObject.NumberofGoldCoinIndex();
        }

        public int PlayerArrowAmount()
        {
            // Write a Function to return the amount of Arrows the Player Has.

            return PlayerInventoryObject.NumberOfArrowsIndex();
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
            CaveMainObject.MoveWumpus(RoomNumberWhereUserIsIn);
        }

        public bool CheckIfWampusInRoom(int RoomToCheck)
        {
            // Write Code To Check If Wampus is in the Room.

            return false;
        }

        public int GetNewUserRoom()
        {
            // Return a new room with no hazards. Ask Cave to do this. 
            return 0;
        }

        public void MoveBatsFromRoom()
        {
            // Move Bats from the Room the User is In, to a new Room. Ask Cave to do this.
        }

        public void AddGoldCoin()
        {
            // Add a Gold Coin to the Player Inventory. 
        }

        public void AddArrow()
        {
            // Add a Arrow to the Player Invnetory. 
        }

        public void RemoveGoldCoin()
        {
            // Remove a Gold Coin From the Player. 
        }
        public void RemoveArrowPlayerInventory()
        {
            // Take a Arrow From the Player.
        }

        public void AddASecretToList()
        {
            // Get a Secret and Add it To The List defined at the Top. SecretList[]
            // Get the Secret From Trivia Machine. 
        }

        public List<string> ReturnSecretList()
        {
            return SecretList;
        }
    }
}
