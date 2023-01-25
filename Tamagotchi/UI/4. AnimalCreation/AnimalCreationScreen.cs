using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._4._AnimalCreation
{
    public class AnimalCreationScreen :Screen 
    {
        public AnimalCreationScreen () :base(" Animal creation screen ")
        {
        }
        string name;
        string owner;
        DateTime birthday;
        public override void Show()
        {
            
            base.Show();
            Console.WriteLine();
            Console.WriteLine();
            SetName();
            SetOwner(); 
            CreateNewAnimal();
            Screen next = new AnimalLoginScreen();
            next.Show();
        }
        private void SetName()
        {
            Console.WriteLine("Please enter your tamagotchi's name ");
            name = Console.ReadLine();
        }
        private void SetOwner()
        {
            Console.WriteLine("Please enter your username");
            owner = Console.ReadLine();
            while (owner!=MainUi.p.Username)
            {
                Console.WriteLine("The username you've entered couldn't be recognized. Please re - enter your username");
                owner = Console.ReadLine();
            }
        }

        private void CreateNewAnimal()
        {
            Console.WriteLine("Please enter your Tamagotchi's weight");
            int weight = int.Parse(Console.ReadLine());
            Animal a = new Animal(name, MainUi.p.Username,weight);
            Data.Data.CreateAnimal(a);
        }
    }
}
