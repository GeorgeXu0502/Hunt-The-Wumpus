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
            return RoomUserIsIn;
        }

        public TriviaQuestion SendTriviaQuestion()
        {
            TriviaQuestion TriviaAnswertoReturn = TriviaMachineObject.GetTriviaAnswer();

            return TriviaAnswertoReturn;
        }

        public int PlayerGoldCoinAmount()
        {
            return PlayerInventoryObject.NumberofGoldCoinIndex();
        }

        public int PlayerArrowAmount()
        {
            return PlayerInventoryObject.NumberOfArrowsIndex();
        }

        public TriviaQuestion GetQuestion()
        {
           return TriviaMachineObject.GetTriviaAnswer();
        }

        public void MoveWumpus(int RoomNumberWhereUserIsIn)
        {
            CaveMainObject.MoveWumpus(RoomNumberWhereUserIsIn);
        }

        public bool CheckIfWampusInRoom(int RoomToCheck)
        {
            return CaveMainObject.IsWumpusInRoom(RoomToCheck);
        }

        public int GetNewUserRoom()
        {
            return CaveMainObject.GetNewRoom();
        }

        public void MoveBatsFromRoom(int RoomWhereUserIsMoved)
        {
            CaveMainObject.MoveBatsToDifferentRoom(RoomUserIsIn, RoomWhereUserIsMoved);
        }

        public void AddGoldCoin()
        {
            PlayerInventoryObject.AddGoldCoin();
        }

        public void AddArrow()
        {
            PlayerInventoryObject.NumberOfArrowsIndex(true);
        }

        public void RemoveGoldCoin()
        {
            PlayerInventoryObject.RemoveGoldCoin();
        }
        public void RemoveArrowPlayerInventory()
        {
            PlayerInventoryObject.NumberOfArrowsIndex(false);
        }

        public string AddASecretToList()
        {
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
            return PlayerInventoryObject.CanWeBuyAnArrow();
        }

        public int PlayerScoreFinal()
        {
            return PlayerInventoryObject.CalculateHighScore(WumpusDefeated);
        }

        public List<HighScoreObject> GetTopScores()
        {
            return PlayerInventoryObject.GetTopScores();
        }

        public void AddPlayerScoreToList(HighScoreObject TheHighScoreObjectToWriteToFile)
        {
            PlayerInventoryObject.AddNewScoreToPastScoreList(TheHighScoreObjectToWriteToFile);
        }

        public void AddUserTurn()
        {
            PlayerInventoryObject.AddUserTurn();
        }

        public int PlayerTurnAmount()
        {
            return PlayerInventoryObject.NumberofTurnsIndex();
        }
    }
}
