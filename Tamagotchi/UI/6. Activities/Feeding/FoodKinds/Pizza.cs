using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.Actions
{
    public class Pizza:Food, IFeed
    {
        public Pizza() 
        {
            hungerlevelaffect = 3;
        }
        public void Feed() 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
          Console.WriteLine(@" 
                                 __   ___   ____   ____                   _....._
                                 \ \ / / | | |  \/   | |              _.:`.--|--.`:._  
                                  \ V /| | | | .  .  | |            .: .'\o  | o /'. '.
                                   \ / | | | | |\/|  | |           // '.  \ o|  /  o '.\
                                   | | | |_| | |  |  |_|          //'._o'. \ |o/ o_.-'o\\
                                   \_/  \___/\_|  |_ (_)          || o '-.'.\|/.-' o   ||
                                                                  ||--o--o-->|");

            Console.ResetColor();
          MainUi.activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "feeding", "Pizza", MainUi.a.Age, MainUi.a.LifeCycle));
            MainUi.a.HungerLevel -= hungerlevelaffect;
            if (MainUi.a.HungerLevel < 0)
                MainUi.a.HungerLevel = 0;
            MainUi.a.Weight += 4;
            Console.WriteLine("");
            Back();

        }

    }
}
