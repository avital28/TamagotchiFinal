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
        Animal a= new Animal();
        string name;
        string owner;
        DateTime birthday;
        public override void Show()
        {
            base.Show();
            SetName();
            //SetPassword();
            //CreatePlayer();
            Screen next1 = new LoginScreen();
            next1.Show();
        }
        private void SetName()
        {
            Console.WriteLine("Please enter your chosen name for your tamagotchi ");
            name = Console.ReadLine();
        }
        private void SetOwner()
        {
            Console.WriteLine("Please enter your username");
            owner = Console.ReadLine();
            while (owner!=MainUi.p.Username)
            {
                Console.WriteLine("unfortunately the username you have entered couldn't be recognized. please make sure you've entered the same username as the one you're currently using");
                owner = Console.ReadLine();
            }
        }

        private void CreateAnimal()
        {
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();
            try
            {
                //P.Firstname = firstname;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please re-enter your first name");
                firstname = Console.ReadLine();
            }
            Console.WriteLine("Enter your last name");
            string lastname = Console.ReadLine();
            try
            {
                //P.Lastname = lastname;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("enter your gender");
            string gender = Console.ReadLine();
            Console.WriteLine("Please enter your birthday");
            birthday = DateTime.ParseExact(Console.ReadLine(), "dd/M/yyyy", CultureInfo.InvariantCulture);
            //Player c = new Player(firstname, lastname, username, password, gender, birthday);
            //Data.Data.Register(c);
        }
    }
}
