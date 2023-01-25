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
            
                while (MainUi.a.HungerLevel <= 5)
                {
                    await Task.Delay(20000);
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
                        Console.WriteLine("Your animal's hunger level is getting dangerously low, and it currently approaches its last stage of hunger before death of starvation");
                        Console.ResetColor();
                    }

                    else if (MainUi.a.HungerLevel == 5)
                    {
                    string name = MainUi.a.Animalname;
                        MainUi.a.IsAlive = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($@"
                                           _____          __  __ ______                                       /)
                                          / ____|   /\   |  \/  |  ____|                                     / )
                                         | |  __   /  \  | \  / | |__                                     |/)\)    
                                         | | |_ | / /\ \ | |\/| |  __|                                     /\__ 
                                         | |__| |/ ____ \| |  | | |____                                     \__|=
                                          \_____/_/    \_\_|  |_|______|                                   (    )
                                                                                                                __)(__
                                            ______      ________ _____                               _____/      \\_____
                                           / __ \ \    / /  ____|  __ \                              |  _     ___   _   ||
                                          | |  | \ \  / /| |__  | |__) |                             | | \     |   | \  ||
                                          | |  | |\ \/ / |  __| |  _  /                              | |  |    |   |  | ||
                                          | |__| | \  /  | |____| | \ \                              | |_/     |   |_/  ||
                                           \____/   \/   |______|_|  \_\                             | | \     |   |    ||
                                                                                                     | |  \.  _|_. | .  ||
                                                                                                     |                  ||
                                                                                                     |      {name}      ||
                                                                                                     | *   **    * **   |



















                 
                  
                                                               
                                                               
");
                        Console.ResetColor();
                        Thread.Sleep(600);
                        Console.WriteLine("Unfortunately you failed to take care of your animal and it has died of starvation.");
                        Thread.Sleep(600);
                        Console.WriteLine("you will still be able to play with your current animal, but all of its data will be reset.");
                        Thread.Sleep(600);
                        Console.WriteLine("We hope you enjoyed the game and wish you better luck next time. you will be removed from the game shortly");
                        Thread.Sleep(10000);
                        Environment.Exit(0);
                    }




                }
            
            
        }
    }
}
