using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._6._Activities.playing.Games
{
    public class Ball : Games, IPlay
    {

        public Ball() 
        {
            happinesslevelaffect = 3;
        }

        public void Play()
        { 
          Console.WriteLine("Nice game"); 
          MainUi.activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "playing", "ball", MainUi.a.Age, MainUi.a.LifeCycle));
          MainUi.a.HappinessLevel += happinesslevelaffect;
            if (MainUi.a.HappinessLevel >5)
                MainUi.a.HappinessLevel = 5;

            MainUi.a.Weight--; ;
            if (MainUi.a.Weight < 0)
                MainUi.a.Weight = 0;
            Back(); 
        }
        }
    }

