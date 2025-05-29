using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HuntTheWumpus_Team1
{
    public class PlayerDataBase_Offical
    {
        List<UserLoginObject> ListofAllUsers = new List<UserLoginObject>();

        string MainFile = "UserObjectFile.json";
        public PlayerDataBase_Offical()
        {
            ListofAllUsers = Utility.ReadUserLoginFromFile(MainFile);
        }

        public bool DoesUserExsit(string Username, string Password)
        {
            foreach (UserLoginObject UserToObserve in ListofAllUsers)
            {
                if (UserToObserve.UserUsername == Username && UserToObserve.UserPassword == Password)
                {
                    return true;
                }
            }
            return false;
        }

        public UserLoginObject GetUserInformation(string Username)
        {
            foreach (UserLoginObject UserToObserve in ListofAllUsers)
            {
                if (UserToObserve.UserUsername == Username)
                {
                    return UserToObserve;
                }
            }

            return new UserLoginObject("None", "None", -1, "None");
        }


        public bool IsEmailValid(string EmailToConsider)
        {
            foreach (UserLoginObject UserToObserve in ListofAllUsers)
            {
                if (UserToObserve.UserEmail == EmailToConsider)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsUserNameValid(string UsernameToConsider)
        {
            foreach (UserLoginObject UserToObserve in ListofAllUsers)
            {
                if (UserToObserve.UserUsername == UsernameToConsider)
                {
                    return false;
                }
            }
            return true;
        }

        public void AddUserToList(UserLoginObject UserToAdd)
        {
            ListofAllUsers.Add(UserToAdd);
            Utility.WriteUserLoginToFile(ListofAllUsers, MainFile);
        }

        public int GetLatestIdentificationNumber()
        {
            return ListofAllUsers[ListofAllUsers.Count - 1].UserIdentificationNumber;
        }
    }
}
