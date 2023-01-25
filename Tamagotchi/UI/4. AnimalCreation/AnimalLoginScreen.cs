using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi.UI._5._AnimalMenu;

namespace Tamagotchi.UI._4._AnimalCreation
{
    public class AnimalLoginScreen : Screen
    {
        public AnimalLoginScreen () : base("Animal login") { }
        public override void Show()
        {
            base.Show();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your tamagotchi's name");
            string animalname = Console.ReadLine();
            MainUi.a = Data.Data.AnimalLogin(username, animalname);
            while (MainUi.a == null || MainUi.p.Username!=username)
            {
                Console.WriteLine("Login failed, please try again");
                username = Console.ReadLine();
                animalname = Console.ReadLine();
                MainUi.a = Data.Data.AnimalLogin(username, animalname);
            }
            Console.WriteLine("Login was successful");
            HungerTask();
            AgeTask();
            Thread.Sleep(400);
            Screen next2 = new AnimalActionsMenu();
            next2.Show();
            Console.ReadKey();
        }

        public static async Task HungerTask()
        {
            MainUi.a.StartHunger();
        }

        public static async Task AgeTask()
        {
            MainUi.a.StartAging();
        }


    }

}
