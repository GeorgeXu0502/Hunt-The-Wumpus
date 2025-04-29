using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrivaMachine_Offical
{
    public class Player_TriviaMachine
    {
        TriviaAnswer exmaplefornow = new TriviaAnswer("What is the radius of Mars?", "1000 miles"); // This will need to be changed.
        public bool GetResult()
        {
            return true;
        }

        public TriviaAnswer GetTriviaAnswer()
        {
            return exmaplefornow;
        }

    }
}
