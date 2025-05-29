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
        /// <summary>
        /// Write User Lists to a File. 
        /// </summary>
        /// <param name="ListofUserObjects"> List of UserLoginObject to Write to File. </param>
        /// <param name="filename"> FileName to Use. </param>
        public static void WriteUserLoginToFile(List<UserLoginObject> ListofUserObjects, string filename)
        {
            JsonSerializer serlizer = new JsonSerializer();

            serlizer.Formatting = Formatting.Indented;

            StreamWriter streakwriter = new StreamWriter(filename);
            serlizer.Serialize(streakwriter, ListofUserObjects, typeof(List<UserLoginObject>));

            streakwriter.Flush();
            streakwriter.Close();
        }

        /// <summary>
        /// Read Users from a File. 
        /// </summary>
        /// <param name="filename"> File to Read From. </param>
        /// <returns> List of UserLoginObjects </returns>
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
