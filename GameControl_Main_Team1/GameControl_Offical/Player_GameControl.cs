using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrivaMachine_Offical;
using CaveMain_Offical;
using PlayerInventory_Offical;

namespace GameControl_Offical
{
    
    public class Player_GameControl
    {
        Player_TriviaMachine TriviaMachineObject = new TrivaMachine_Offical.Player_TriviaMachine();
        Player_CaveMain CaveMainObject = new CaveMain_Offical.Player_CaveMain();
        Player_HighScore PlayerInventoryObject = new PlayerInventory_Offical.Player_HighScore();
    }
}
