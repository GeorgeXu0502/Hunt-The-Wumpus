using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrivaMachine_Offical
{
    public class Player_TriviaMachine
    {
        
        public bool GetResult()
        {
            return true;
        }

        public TriviaQuestion GetTriviaAnswer()
        {
            List<string> possiblestringlist = new List<string>();
            possiblestringlist.Add("Hi");
            possiblestringlist.Add("Hi");
            possiblestringlist.Add("Hi");
            possiblestringlist.Add("Hi");

            TriviaQuestion exmaplefornow = new TriviaQuestion("What is the radius of Mars.", possiblestringlist, 1); // This will need to be changed.
            return exmaplefornow;
        }

        public string GetSecret()
        {
            //return a secret
            return "";
        }

    }
}
