using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus_Team1
{
    public class PlayerDataBase_Offical
    {
        List<UserLoginObject> ListofAllUsers = new List<UserLoginObject>();

        string MainFile = "UserObjectFile.json";
        public PlayerDataBase_Offical()
        {
            // ListofAllUsers = Utility.ReadUserLoginFromFile(MainFile);
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
    }
}
