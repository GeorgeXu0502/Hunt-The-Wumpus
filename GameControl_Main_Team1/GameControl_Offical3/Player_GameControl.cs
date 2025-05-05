using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaveMain_Official2;
using TrivaMachine_Offical;
using PlayerInventory_Offical;
using TriviaMachine_Offical;

namespace GameControl_Offical
{
    
    public class Player_GameControl
    {
        
        Player_TriviaMachine TriviaMachineObject = new TrivaMachine_Offical.Player_TriviaMachine();
        WritingNewTriviaToFile FileWritingObject = new TriviaMachine_Offical.WritingNewTriviaToFile();
        Player_CaveMain CaveMainObject = new CaveMain_Official2.Player_CaveMain();
        Player_HighScore PlayerInventoryObject = new PlayerInventory_Offical.Player_HighScore();
        

        int RoomUserIsIn = 1; // This is where the User Starts
        int goldCoinsCount = 0;
        List<string> SecretList = new List<string>();

        bool WumpusDefeated = false;

        /*
        public void AddOriginalTriviaFile()
        {
            FileWritingObject.WriteTriviaToFile(); // This function is to be used only with the greatest care! This is the oringinal Trivia File. 
        }
        */
        
        

        public List<Room> AdjacentRoomInformation(int RoomToGetInformationFor)
        {
            // Write Function to get a List: // This Room List should be of this form: [RoomUser, RoomtotheTopLeft, .... (Coutnerclockwise), ....]
            return CaveMainObject.GetAdjacentRoomInformation(RoomToGetInformationFor);
        }

        public void ChangeWumpusDefetedStatus()
        {
            WumpusDefeated = true;
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
           return TriviaMachineObject.GetTriviaAnswer();
        }

        public void MoveWumpus(int RoomNumberWhereUserIsIn)
        {
            // Given Where the User Is, Have the Cave move the Wumpus From This Room.
            CaveMainObject.MoveWumpus(RoomNumberWhereUserIsIn);
        }

        public bool CheckIfWampusInRoom(int RoomToCheck)
        {
            // Write Code To Check If Wampus is in the Room.

            return CaveMainObject.IsWumpusInRoom(RoomToCheck);
        }

        public int GetNewUserRoom()
        {
            // Return a new room with no hazards. Ask Cave to do this. 
            return CaveMainObject.GetNewRoom();
        }

        public void MoveBatsFromRoom(int RoomWhereUserIsMoved)
        {
            // Move Bats from the Room the User is In, to a new Room. Ask Cave to do this.
            CaveMainObject.MoveBatsToDifferentRoom(RoomUserIsIn, RoomWhereUserIsMoved);
        }

        public void AddGoldCoin()
        {
            // Add a Gold Coin to the Player Inventory. 
            PlayerInventoryObject.AddGoldCoin();
        }

        public void AddArrow()
        {
            // Add a Arrow to the Player Invnetory. 
            PlayerInventoryObject.NumberOfArrowsIndex(true);
        }

        public void RemoveGoldCoin()
        {
            // Remove a Gold Coin From the Player. 
            PlayerInventoryObject.RemoveGoldCoin();
        }
        public void RemoveArrowPlayerInventory()
        {
            // Take a Arrow From the Player.
            PlayerInventoryObject.NumberOfArrowsIndex(false);
        }

        public string AddASecretToList()
        {
            // Get a Secret and Add it To The List defined at the Top. SecretList[]
            // Get the Secret From Trivia Machine, also return the string.


            string secret = TriviaMachineObject.GetSecret();
            SecretList.Add(secret);
            return secret;
        }

        public List<string> ReturnSecretList()
        {
            return SecretList;
        }

        public bool CanWeBuyAnArrow()
        {
            // Write a Function if we can buy a Arrow Still. Rember only 2 per Game. Collaborate with Player Invnetory. 
            return PlayerInventoryObject.CanWeBuyAnArrow();
        }

        public int PlayerScoreFinal()
        {
            // Return Player Score. Ask Player Inventory To Do This. 

            return PlayerInventoryObject.CalculateHighScore(WumpusDefeated);
        }

        public List<int> GetTopScores()
        {
            // Return a List with the Top 5 Scores. Ask Player Inventory To Do This.

            return PlayerInventoryObject.GetTopScores();
        }
    }
}
