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
            ListofAllUsers = Utility.ReadUserLoginFromFile(MainFile); // Read the File to get all the Users. 
        }

        /// <summary>
        /// Check if the User already Exists to allow the User to Login. 
        /// </summary>
        /// <param name="Username"> Username to See if the Username Exsists. </param>
        /// <param name="Password"> Password to make sure the User is entering their account. </param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the User Object from the Username of the User. 
        /// </summary>
        /// <param name="Username"> User Username to use to find the User for which to get the infromation. </param>
        /// <returns> Return the UserLoginObject that is associated with the User </returns>
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

        /// <summary>
        /// See if the Email has already been used. 
        /// </summary>
        /// <param name="EmailToConsider"> Email to consider when seraching. </param>
        /// <returns> Bool that showcases wheter the Email has already been used for a User Account. </returns>
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

        /// <summary>
        /// See if the Username has already been used. 
        /// </summary>
        /// <param name="UsernameToConsider"> Username to consider when seraching. </param>
        /// <returns> Bool that showcases wheter the USername has already been used for a User Account. </returns>
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


        /// <summary>
        /// Add the User to the List. 
        /// </summary>
        /// <param name="UserToAdd"> The UesrLoginObject to add to the Main User List. </param>
        public void AddUserToList(UserLoginObject UserToAdd)
        {
            ListofAllUsers.Add(UserToAdd);
            Utility.WriteUserLoginToFile(ListofAllUsers, MainFile);
        }

        /// <summary>
        /// Get the Latest Indentification Number plus one, to get the new Indetification Number. 
        /// </summary>
        /// <returns></returns>
        public int GetLatestIdentificationNumber()
        {
            return ListofAllUsers[ListofAllUsers.Count - 1].UserIdentificationNumber;
        }
    }
}
