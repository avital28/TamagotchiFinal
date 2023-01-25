using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.UI;

namespace Tamagotchi.Events
{
    public class AgeChange
    {
        public static async void ChangeAnimalsAge(object sender, EventArgs a)
        {
            while (MainUi.a.IsAlive == true)
            {
                await Task.Delay(80000);
                MainUi.a.Age++;
                if (MainUi.a.Age == 5)
                    MainUi.a.LifeCycle = "Child";
                else if (MainUi.a.Age == 12)
                    MainUi.a.LifeCycle = "Teen";
                else if (MainUi.a.Age == 20)
                    MainUi.a.LifeCycle = "Adult";
                else if (MainUi.a.Age == 70)
                    MainUi.a.LifeCycle = "Elder";
            }
            
        }
    }
}
