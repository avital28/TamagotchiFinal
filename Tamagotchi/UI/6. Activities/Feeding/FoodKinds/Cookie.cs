using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.Actions
{
    public class Cookie : Food, IFeed
    {
        public Cookie() 
        {
            hungerlevelaffect= 1;   
        }
        public void Feed() 
        {
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine(@"
                                 __   ___   ____   ____                    _  _
                                 \ \ / / | | |  \/   | |                 _/0\/ \_
                                  \ V /| | | | .  .  | |        .-.   .-` \_/\0/ '-.
                                   \ / | | | | |\/|  | |       /:::\ / ,_________,  \
                                   | | | |_| | |  |  |_|      /\:::/ \  '. (:::/  `'-;
                                   \_/  \___/\_|  |_ (_)      \ `-'`\ '._ `""'""'\__ \
                                                               `'-.  \   `)-=-=(  `,  |
                                                                   \  `-""`     `""-`/
                      
                      
");

          MainUi.activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "Feeding", "cookie", MainUi.a.Age, MainUi.a.LifeCycle));
          MainUi.a.HungerLevel -= hungerlevelaffect;
          if(MainUi.a.HungerLevel<0)
          MainUi.a.HungerLevel = 0;
            MainUi.a.Weight += 3;
          Console.WriteLine("");
          Back();
        }

    }
}
