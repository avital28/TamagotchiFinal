using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.UI._4._AnimalCreation
{
    public class AnimalMainMenu:MenuScreen
    {
        public AnimalMainMenu() : base ("Main animal menu")
        {
            AddItem("Create new animal", new AnimalCreationScreen());
            AddItem("Login with existing animal", new AnimalLoginScreen());
        }
    }
}
