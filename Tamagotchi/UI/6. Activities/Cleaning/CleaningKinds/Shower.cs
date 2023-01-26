using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._6._Activities.Cleaning.CleaningKinds
{
    public class Shower : Cleansing, IClean
    {
        public Shower ()  
        {
            cleanlinesslevelaffect = 3;
        }
        public void Clean()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
          ______ _________________ _____ _____ _   _ _____ _   _ _____   _ 
          | ___ \  ___|  ___| ___ \  ___/  ___| | | |_   _| \ | |  __ \ | |
          | |_/ / |__ | |_  | |_/ / |__ \ `--.| |_| | | | |  \| | |  \/ | |
          |    /|  __||  _| |    /|  __| `--. \  _  | | | | . ` | | __  | |
          | |\ \| |___| |   | |\ \| |___/\__/ / | | |_| |_| |\  | |_\ \ |_|
          \_| \_\____/\_|   \_| \_\____/\____/\_| |_/\___/\_| \_/\____/ (_)
                                                                 
                                                                 
");
            Console.ResetColor();
            MainUi.activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "Cleaning", "Shower", MainUi.a.Age, MainUi.a.LifeCycle));
            MainUi.a.CleanlinessLevel += cleanlinesslevelaffect;
            if (MainUi.a.CleanlinessLevel > 5)
                MainUi.a.CleanlinessLevel = 5;
            Back();

        }
    }
}
    

