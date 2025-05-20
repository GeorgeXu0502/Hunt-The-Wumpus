using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaMachine_Offical3
{
    /// <summary>
    /// this class holds all secrets/hints for stuff such as whumpus location, trivia, etc.
    /// </summary>
    public class SecretObject
    {
        /// <summary>
        /// the secret itself
        /// </summary>
        public string SecretString { get; set; }

        /// <summary>
        /// the index of the secret
        /// </summary>
        public int SecretIndex { get; set; }

        /// <summary>
        /// constructor for the secret and secret index
        /// </summary>
        /// <param name="StringToUse"></param>
        /// <param name="IndextoUSE"></param>
        public SecretObject(string StringToUse, int IndextoUSE) 
        {
            SecretString = StringToUse;
            SecretIndex = IndextoUSE;
        }
    }
}
