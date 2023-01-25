using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tamagotchi.UI
{
    public class LoginScreen:Screen
    {
        public LoginScreen() : base("Login screen")
        {

        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();
            MainUi.p = Data.Data.Login(username, password);
            while (MainUi.p == null)
            {
                Console.WriteLine("Login failed, please try again");
                username = Console.ReadLine();
                password = Console.ReadLine();
                MainUi.p = Data.Data.Login(username, password);
            }
            Console.WriteLine("Login was successful");
            Thread.Sleep(400);
            Screen next2 = new PlayerAnimalMenu();
            next2.Show();   
            
            


        }
    }
}
