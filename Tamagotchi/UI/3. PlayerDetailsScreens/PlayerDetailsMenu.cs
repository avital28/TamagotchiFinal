using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.UI._1
{
    public class PlayerDetailsMenu:MenuScreen
    {
        public PlayerDetailsMenu (): base ("Player details")
        {
            AddItem("View player details", new PlayerScreen(new ViewDetails(), "Player details"));
            AddItem("Change player details", new PlayerScreen(new ChangeDetailsScreen(), "Change player details"));
            AddItem("Return to the previous menu", new PlayerAnimalMenu());
        }
    }
}
