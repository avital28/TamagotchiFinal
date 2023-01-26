using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tamagotchi.UI._5._AnimalMenu
{
    public class ViewAnimalDetails: Screen
    {
        public ViewAnimalDetails() : base("View tamagotchi's details") { }

        public override void Show()
        {
            base.Show();
            string h = MainUi.a.HealthStatus;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Tamagotchi's details:");
            Console.ResetColor();
            Console.ResetColor();
            Console.WriteLine("Tamagotchi's name: " + MainUi.a.Animalname);
            Console.WriteLine("Tamagotchi's weight: " + MainUi.a.Weight);
            Console.WriteLine("Tamagotchi's healthStatus " + h[0].ToString().ToUpper()+ h.Substring(1));
            Console.WriteLine("Tamagotchi's birthday: " + MainUi.a.AnimalBirthday.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
            Console.WriteLine("Tamagotchi's age: " + MainUi.a.Age);
            Console.WriteLine("Tamagotchi's lifecycle: " + MainUi.a.LifeCycle);
            Console.WriteLine("Tamagotchi's hunger level: " +MainUi.a.HungerLevel);
            Console.WriteLine("Tamagotchi's happiness level: " + MainUi.a.HappinessLevel);
            Console.WriteLine("Tamagotchi's cleanliness level: " + MainUi.a.CleanlinessLevel);
            Console.WriteLine("Owner's username: " + MainUi.p.Username);
            Console.WriteLine();
            Console.WriteLine();
            Console.CursorVisible = false;
            Thread.Sleep(1000);
            Console.WriteLine("Press any key to go back");
            Console.CursorVisible = true;
            Console.ReadKey();
            Screen next4 = new AnimalActionsMenu();
            next4.Show();
            

        }
    }
}
