using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._6._Activities.playing.Games
{
    public class Jumpingrope: Games, IPlay
    {
        public Jumpingrope() 
        {
            happinesslevelaffect = 2;
        }

        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
           _   _ _____ _____  _____   _____   ___  ___  ___ _____   _ 
          | \ | |_   _/  __ \|  ___| |  __ \ / _ \ |  \/  ||  ___| | |
          |  \| | | | | /  \/| |__   | |  \// /_\ \| .  . || |__   | |
          | . ` | | | | |    |  __|  | | __ |  _  || |\/| ||  __|  | |
          | |\  |_| |_| \__/\| |___  | |_\ \| | | || |  | || |___  |_|
          \_| \_/\___/ \____/\____/   \____/\_| |_/\_|  |_/\____/  (_)
                                                            
                                                            
");
            Console.ResetColor();
            MainUi.activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "Playing", "umping rope", MainUi.a.Age, MainUi.a.LifeCycle));
            MainUi.a.HappinessLevel += happinesslevelaffect;
            if (MainUi.a.HappinessLevel > 5)
                MainUi.a.HappinessLevel = 5;
            MainUi.a.Weight--; ;
            if (MainUi.a.Weight < 0)
                MainUi.a.Weight = 0;
            Back(); }
        }

    }

