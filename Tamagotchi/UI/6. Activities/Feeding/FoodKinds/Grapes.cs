using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.Actions
{
    public class Grapes: Food, IFeed
    {
        public Grapes() 
        {
            hungerlevelaffect = 2;
        }
        public void Feed() 
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"                                                 __
                                   __   ___   ____   ____                    __ {_/ 
                                   \ \ / / | | |  \/   | |                   \_}\\ _
                                    \ V /| | | | .  .  | |                      _\(_)_
                                     \ / | | | | |\/|  | |                     (_)_)(_)_
                                     | | | |_| | |  |  |_|                    (_)(_)_)(_)
                                     \_/  \___/\_|  |_ (_)                     (_)(_))_)  
                                                                                (_(_(_)  
                                                                                 (_)_)   
                                                                                  (_) 
");
            Console.ResetColor();       
            MainUi.activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "feeding", "Rice", MainUi.a.Age, MainUi.a.LifeCycle));
            MainUi.a.HungerLevel -= hungerlevelaffect;
            if (MainUi.a.HungerLevel < 0)
                MainUi.a.HungerLevel = 0;
            MainUi.a.Weight++;
            Console.WriteLine("");
            Back();
        }

    }
}
