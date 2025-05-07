using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaMachine_Offical3
{
    public class SecretObject
    {
        public string SecretString { get; set; }
        public int SecretIndex { get; set; }

        public SecretObject(string StringToUse, int IndextoUSE) 
        {
            SecretString = StringToUse;
            SecretIndex = IndextoUSE;
        }
    }
}
