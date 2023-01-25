using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.UI;

namespace Tamagotchi.Events
{
    public static class HungerAlert
    {
        public  static async void PrintAlert (object sender, EventArgs a)
        {
            if (sender is Animal)
            {
                while (MainUi.a.HungerLevel <= 5)
                {
                    await Task.Delay(10000);
                    MainUi.a.HungerLevel++;
                    if (MainUi.a.HungerLevel == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"You haven't fed your animal in a while, and its current hunger level is at {MainUi.a.HungerLevel}, you might want to consider feeding it soon ");
                        Console.ResetColor();
                    }
                    else if (MainUi.a.HungerLevel == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your animal's hunger level is getting dangerously low, and it currently approaches its last stage of hunger before death from starvation");
                        Console.ResetColor();
                    }

                    else if (MainUi.a.HungerLevel == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Unfortunately you failed to take care of your animal and it has died of starvation.");
                        Console.WriteLine("you will still be able to play with your current animal, but all of its data will be reset.");
                        Console.WriteLine("We hope you enjoyed the game and wish you better luck next time. you will be removed from the game shortly)");
                        Thread.Sleep(10000);
                        Environment.Exit(0);
                    }

                    //await Task.Delay(10000);
                    //MainUi.a.Age++;
                    //if (MainUi.a.Age == 5)
                    //    MainUi.a.LifeCycle = "Child";
                    //else if (MainUi.a.Age == 12)
                    //    MainUi.a.LifeCycle = "Teen";
                    //else if (MainUi.a.Age == 20)
                    //    MainUi.a.LifeCycle = "Adult";
                    //else if (MainUi.a.Age == 70)
                    //    MainUi.a.LifeCycle = "Elder";


                }
            }
            
        }
    }
}
