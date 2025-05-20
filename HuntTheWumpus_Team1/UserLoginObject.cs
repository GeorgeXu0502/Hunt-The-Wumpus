using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus_Team1
{
    public class UserLoginObject
    {
        public string UserUsername { get; set; }

        public string UserPassword { get; set; }

        public int UserIdentificationNumber { get; set; }

        public string UserEmail { get; set; }

        public UserLoginObject(string userUsername, string userPassword, int userIdentificationNumber, string userEmail)
        {
            UserUsername = userUsername;
            UserPassword = userPassword;
            UserIdentificationNumber = userIdentificationNumber;
            UserEmail = userEmail;
        }
    }
}
