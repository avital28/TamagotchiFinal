using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.UI._4._AnimalCreation;

namespace Tamagotchi.UI._5._AnimalMenu
{
    public class AnimalActionsMenu : MenuScreen
    {
        public AnimalActionsMenu () : base ("Animal actions menu")
        {
            AddItem("View animal's details", new ViewAnimalDetails());
            AddItem("Change animal's name", new ChangeAnimalDetails());
            AddItem("View activities history", new ActivityArchiveScreen());
            AddItem("Activities menu", new ActivityMenu());


        }
    }
}
