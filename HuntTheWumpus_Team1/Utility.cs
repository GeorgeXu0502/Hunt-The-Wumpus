using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HuntTheWumpus_Team1
{
    public class Utility
    {
        public static void WriteUserLoginToFile(List<UserLoginObject> ListofUserObjects, string filename)
        {
            JsonSerializer serlizer = new JsonSerializer();

            serlizer.Formatting = Formatting.Indented;

            StreamWriter streakwriter = new StreamWriter(filename);
            serlizer.Serialize(streakwriter, ListofUserObjects, typeof(List<UserLoginObject>));

            streakwriter.Flush();
            streakwriter.Close();
        }

        public static List<UserLoginObject> ReadUserLoginFromFile(string filename)
        {
            JsonSerializer serlizer = new JsonSerializer();
            StreamReader streamReader = new StreamReader(filename);


            var objectdefied = serlizer.Deserialize(streamReader, typeof(List<UserLoginObject>));
            streamReader.Close();
            if (objectdefied != null)
            {
                return (List<UserLoginObject>)objectdefied;
            }
            else
            {
                List<UserLoginObject> newUserObjectList = new List<UserLoginObject>();
                return newUserObjectList;
            }
        }
    }
}
