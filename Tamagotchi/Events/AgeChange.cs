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
            if (sender is Animal)
            {
                await Task.Delay(10000);
                MainUi.a.Age++;
            }
        }
    }
}
