using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.UI._1;

namespace Tamagotchi.UI._5._AnimalMenu
{
    public class ChangeAnimalDetails : Screen
    {
        public ChangeAnimalDetails() : base("Change tamagotchi's name") { }

        public override void Show()
        {
            base.Show();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter your tamagotchi's new name");
            string name = Console.ReadLine();
            MainUi.a.Animalname = name; 
            Console.WriteLine("Your details have been sucssesfully updated, press any key to go back to the previous menu");
            Console.ReadKey();
            Screen next2 = new AnimalActionsMenu();
            next2.Show();
        }
    }
}
