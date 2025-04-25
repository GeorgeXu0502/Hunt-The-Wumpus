using System.Security.Cryptography.X509Certificates;

namespace CaveMain_Test
{
    public partial class Form1 : Form
    {
        Room Room1V1 = new Room(false, false, false, [2, 6, 7, 25, 26, 30]);
        Room Room2V1 = new Room(false, false, false, [1, 3, 7, 8, 9, 26]);
        Room Room3V1 = new Room(false, false, false, [2, 4, 9, 26, 27, 28]);
        Room Room4V1 = new Room(false, false, false, [3, 5, 9, 10, 11, 28]);
        Room Room5V1 = new Room(false, false, false, [4, 6, 11, 28, 29, 30]);
        Room Room6V1 = new Room(false, false, false, [1, 5, 7, 11, 12, 30]);
        Room Room7V1 = new Room(false, false, false, [1, 2, 6, 8, 12, 13]);
        Room Room8V1 = new Room(false, false, false, [2, 7, 9, 13, 14, 15]);
        Room Room9V1 = new Room(false, false, false, [2, 3, 4, 8, 10, 15]);
        Room Room10V1 = new Room(false, false, false, [4, 9, 11, 15, 16, 17]);
        Room Room11V1 = new Room(false, false, false, [2, 4, 9, 26, 27, 28]);


        public Form1()
        {
            InitializeComponent();

            
        }

       
    }
}
