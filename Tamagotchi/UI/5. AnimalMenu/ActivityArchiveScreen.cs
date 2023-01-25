using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;
using Tamagotchi.UI;
using Tamagotchi.UI._5._AnimalMenu;

namespace Tamagotchi.Actions
{
    public class ActivityArchiveScreen : Screen
    {
        public ActivityArchiveScreen() : base("Activities archive") { }

        public override void Show()
        {
            Console.Clear();
            IEnumerable<Activity> currentanimalactivities = from n in MainUi.activitiesHistory where n.AnimalName==MainUi.a.Animalname select n;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Please choose activities to view:");
            Console.ResetColor();
            Console.WriteLine("1 - View all past activities");
            Console.WriteLine("2 - View activities sorted by animal's age ");
            Console.WriteLine("3 - View activities sorted by animal's lifecycle");
            Console.WriteLine("4 - View activities sorted by activity kind ");
            Console.WriteLine("5 - Go back to the animal menu");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    PrintActivities(currentanimalactivities);
                    if (currentanimalactivities.Any()==false)
                    {
                        Console.WriteLine($"unfortunately we couldn't find any activities");
                    }
                    Console.WriteLine("");
                    Thread.Sleep(900);
                    Console.WriteLine("press any key to go back");
                    Console.ReadKey();
                    Screen next = new ActivityArchiveScreen();
                    next.Show();
                    break;
                case 2:
                    Console.WriteLine("please enter the age you would like to sort your activities by");
                    int age = int.Parse(Console.ReadLine());
                    IEnumerable<Activity> sortedbyage = from a in currentanimalactivities where a.Age == age select a;
                    while (sortedbyage.Any()==false)
                    {
                        if (age == -1)
                        {
                            Thread.Sleep(500);
                            Screen next2 = new ActivityArchiveScreen();
                            next2.Show();
                        }
                        else
                        {
                            Console.WriteLine($"unfortunately we couldn't find any activities that happened when your animal's age was {age}, please enter a new value, or enter -1 to exit");
                            age = int.Parse(Console.ReadLine());
                            sortedbyage = from a in currentanimalactivities where a.Age == age select a;
                            Console.Clear();
                        }
                    }
                    PrintActivities(sortedbyage);
                    break;
                case 3:
                    Console.WriteLine("please enter the lifecycle you would like to sort your activities by");
                    string lifecycle = Console.ReadLine();
                    IEnumerable<Activity> sortedbylifecycle = from l in currentanimalactivities where l.Lifecycle == lifecycle select l;
                    while (sortedbylifecycle.Any()==false)
                    {
                        if (lifecycle == "e")
                        {
                            Thread.Sleep(500);
                            Screen next2 = new ActivityArchiveScreen();
                            next2.Show();
                        }
                        else
                        {
                            Console.WriteLine($"unfortunately we couldn't find any activities that happened when your animal's lifecycle was {lifecycle}, please enter a new value, or enter e to exit");
                            lifecycle = Console.ReadLine();
                            sortedbylifecycle = from l in currentanimalactivities where l.Lifecycle == lifecycle select l;
                            Console.Clear();
                        }
                    }
                    PrintActivities(sortedbylifecycle);
                    break;
                case 4:
                    Console.WriteLine("please enter the activity kind you would like to sort your activities by");
                    string kind = Console.ReadLine();
                    IEnumerable<Activity> sortedbykind = from k in currentanimalactivities where k.Action == kind select k;
                    while (sortedbykind.Any()==false)
                    {
                        if (kind == "e")
                        {
                            Thread.Sleep(500);
                            Screen next2 = new ActivityArchiveScreen();
                            next2.Show();
                        }
                        else
                        {
                            Console.WriteLine($"unfortunately we couldn't find any {kind} activities, please choose another activity kind, or enter e to exit");
                            kind = Console.ReadLine();
                            sortedbykind = from k in currentanimalactivities where k.Action == kind select k;
                            Console.Clear();
                        }
                    }
                    PrintActivities(sortedbykind);
                    break;
                case 5:
                    Screen n = new AnimalActionsMenu();
                    n.Show();
                    break;



            }

        }

        public void PrintActivities (IEnumerable <Activity> a)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Activities:");
            Console.ResetColor();
            Console.WriteLine();
            foreach (Activity activity in a)
            {
                Console.WriteLine("Animal's owner: " + activity.Owner);
                Console.WriteLine("Animal's name: " +activity.AnimalName);
                Console.WriteLine("Animal's age: " + activity.Age);
                Console.WriteLine("Animal's Lifecycle: " + activity.Lifecycle);
                Console.WriteLine("Activity: " + activity.Action);
                Console.WriteLine("Activity kind: " + activity.ActionKind);
                Thread.Sleep(4000);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
