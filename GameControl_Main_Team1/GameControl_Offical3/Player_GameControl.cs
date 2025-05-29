using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaveMain_Official2;
using TrivaMachine_Offical;
using PlayerInventory_Offical;
using TriviaMachine_Offical;
using TriviaMachine_Offical3;

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

        bool WumpusDefeated = false;
        
        public void AddOriginalHighScores()
        {
            /*
            List<HighScoreObject> ListToWriteToFile = new List<HighScoreObject>();
            HighScoreObject highscore1 = new HighScoreObject("Sergei", 10);
            ListToWriteToFile.Add(highscore1);
            HighScoreObject highscore2 = new HighScoreObject("George", 10);
            ListToWriteToFile.Add(highscore2);
            HighScoreObject highscore3 = new HighScoreObject("Anastaia", 10);
            ListToWriteToFile.Add(highscore3);
            HighScoreObject highscore4 = new HighScoreObject("Zihe", 10);
            ListToWriteToFile.Add(highscore4);
            HighScoreObject highscore5 = new HighScoreObject("Adah", 10);
            ListToWriteToFile.Add(highscore5);
            

            PlayerInventoryObject.WriteToFile("HighScore.json", ListToWriteToFile);
            */
        }

        public void AddOriginalTriviaFile()
        {
            FileWritingObject.WriteTriviaToFile(); // This function is to be used only with the greatest care! This is the oringinal Trivia File. 
        }
        
        public void AddOriginalSecretFile()
        {
            TriviaMachineObject.WriteSecretsToFile();
        }


        /// <summary>
        /// Returns the list of neighboring rooms for the current room.
        /// </summary>
        public List<Room> AdjacentRoomInformation(int RoomToGetInformationFor)
        {
            // Write Function to get a List: // This Room List should be of this form: [RoomUser, RoomtotheTopLeft, .... (Coutnerclockwise), ....]
            return CaveMainObject.GetAdjacentRoomInformation(RoomToGetInformationFor);
        }
        /// <summary>
        /// This method is used to change the bool value of whether or not the Wumpus has been defeated.
        /// </summary>
        public void ChangeWumpusDefetedStatus()
        {
            WumpusDefeated = true;
        }
        /// <summary>
        /// Update the room number where the user is currently located.
        /// </summary>
        public void UpdateWhereUserIs(int RoomNumberWeAreMovingTo)
        {
            RoomUserIsIn = RoomNumberWeAreMovingTo;
        }
        /// <summary>
        /// Returns the room that the user is in
        /// </summary>
        public int WhereIsUser()
        {
            return RoomUserIsIn;
        }
        /// <summary>
        /// Returns a trivia answer to the UI
        /// </summary>
        public TriviaQuestion SendTriviaQuestion()
        {
            TriviaQuestion TriviaAnswertoReturn = TriviaMachineObject.GetTriviaAnswer();

            return TriviaAnswertoReturn;
        }
        /// <summary>
        /// Returns the amount of gold coins the player has.
        /// </summary>
        public int PlayerGoldCoinAmount()
        {
            return PlayerInventoryObject.NumberofGoldCoinIndex();
        }
        /// <summary>
        /// Returns the amount of arrows the player has.
        /// </summary>
        public int PlayerArrowAmount()
        {
            return PlayerInventoryObject.NumberOfArrowsIndex();
        }
        /// <summary>
        /// Returns a trivia answer to the UI
        /// </summary>
        public TriviaQuestion GetQuestion()
        {
           return TriviaMachineObject.GetTriviaAnswer();
        }
        /// <summary>
        /// Moves the wumpus to a different room.
        /// </summary>
        public void MoveWumpus(int RoomNumberWhereUserIsIn)
        {
            CaveMainObject.MoveWumpus(RoomNumberWhereUserIsIn);
        }
        /// <summary>
        /// Returns whether or not the Wumpus is in the room.
        /// </summary>
        public bool CheckIfWampusInRoom(int RoomToCheck)
        {
            return CaveMainObject.IsWumpusInRoom(RoomToCheck);
        }
        /// <summary>
        /// Get new room for the user to be moved to.
        /// </summary>
        public int GetNewUserRoom()
        {
            return CaveMainObject.GetNewRoom();
        }
        /// <summary>
        /// Move bats to a different room from the user
        /// </summary>
        public void MoveBatsFromRoom(int RoomWhereUserIsMoved)
        {
            CaveMainObject.MoveBatsToDifferentRoom(RoomUserIsIn, RoomWhereUserIsMoved);
        }
        /// <summary>
        /// Increase gold coin amount by 1.
        /// </summary>
        public void AddGoldCoin()
        {
            PlayerInventoryObject.AddGoldCoin();
        }
        /// <summary>
        /// Increase arrow amount by 1.
        /// </summary>
        public void AddArrow()
        {
            PlayerInventoryObject.NumberOfArrowsIndex(true);
        }
        /// <summary>
        /// Decrease gold coin amount by 1.
        /// </summary>
        public void RemoveGoldCoin()
        {
            PlayerInventoryObject.RemoveGoldCoin();
        }
        /// <summary>
        /// Decrease arrow amount by 1.
        /// </summary>
        public void RemoveArrowPlayerInventory()
        {
            PlayerInventoryObject.NumberOfArrowsIndex(false);
        }

        public string GetSecretObject()
        {
            // Please fix the actual implementation this is wrong. 
            SecretObject SecretToUse = TriviaMachineObject.GetSecret();

            if (SecretToUse.SecretIndex == 0)
            {
                return SecretToUse.SecretString + CaveMainObject.WhereisWampus().ToString();
            }
            else if (SecretToUse.SecretIndex == 1)
            {
                return SecretToUse.SecretString + CaveMainObject.WhereisPit().ToString();
            }
            else if (SecretToUse.SecretIndex == 2)
            {
                return SecretToUse.SecretString + CaveMainObject.WhereisaBat().ToString();
            }
            else if (SecretToUse.SecretIndex == 3)
            {
                return SecretToUse.SecretString + CaveMainObject.HowManyRoomsAwayIsWampus(RoomUserIsIn).ToString();
            }
            else if (SecretToUse.SecretIndex == 4)
            {
                return SecretToUse.SecretString + CaveMainObject.HowManyRoomsAwayIsPit(RoomUserIsIn).ToString();
            }
            else if (SecretToUse.SecretIndex == 5)
            {
                return SecretToUse.SecretString + RoomUserIsIn.ToString();
            }
            else if (SecretToUse.SecretIndex == 6)
            {
                return SecretToUse.SecretString;
            }
            else
            {
                return SecretToUse.SecretString;
            }
        }

        /// <summary>
        /// Returns whether or not we can buy an arrow
        /// </summary>
        public bool CanWeBuyAnArrow()
        {
            return PlayerInventoryObject.CanWeBuyAnArrow();
        }
        /// <summary>
        /// Returns the final calculated score of the user after playing the game.
        /// </summary>
        public int PlayerScoreFinal()
        {
            return PlayerInventoryObject.CalculateHighScore(WumpusDefeated);
        }
        /// <summary>
        /// Returns a list of the top scores.
        /// </summary>
        public List<HighScoreObject> GetTopScores()
        {
            return PlayerInventoryObject.GetTopScores();
        }
        /// <summary>
        /// Add new score to the list of past scores.
        /// </summary>
        public void AddPlayerScoreToList(HighScoreObject TheHighScoreObjectToWriteToFile)
        {
            PlayerInventoryObject.AddNewScoreToPastScoreList(TheHighScoreObjectToWriteToFile);
        }
        /// <summary>
        /// Increase the number of turns by 1.
        /// </summary>
        public void AddUserTurn()
        {
            PlayerInventoryObject.AddUserTurn();
        }
        /// <summary>
        /// Returns the number of turns the player has taken.
        /// </summary>
        public int PlayerTurnAmount()
        {
            return PlayerInventoryObject.NumberofTurnsIndex();
        }
        /// <summary>
        /// Returns whether the wumpus is in any of the neighboring rooms of the current room.
        /// </summary>
        public bool IsWampusInTheNextRoom()
        {
            return CaveMainObject.IsWampusInTheNextRoom(RoomUserIsIn);
        }
        /// <summary>
        /// Returns whether a pit is in any of the neighboring rooms of the current room.
        /// </summary>
        public bool IsPitInTheNextRoom()
        {
            return CaveMainObject.IsPitInTheNextRoom(RoomUserIsIn);
        }
        /// <summary>
        /// Returns whether a bat is in any of the neighboring rooms of the current room.
        /// </summary>
        public bool IsBatInTheNextRoom()
        {
            return CaveMainObject.IsBatInTheNextRoom(RoomUserIsIn);
        }
    }
}
