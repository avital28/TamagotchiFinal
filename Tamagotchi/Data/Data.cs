using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tamagotchi.Actions;
using Tamagotchi.UI;

namespace Tamagotchi.Data
{
    public class Data
    {
        public static List<Player> playerlist = new List<Player>();
        public static List<Animal> animallist = new List<Animal>();
        public static void AddPlayer()
        {
            DateTime b1 = Convert.ToDateTime("12/1/2006");
            playerlist.Add(new Player("Yali", "Eldar", "Yali12", "123", "female", b1));
            DateTime b2 = DateTime.ParseExact("20/5/1976", "dd/M/yyyy", CultureInfo.InvariantCulture);
            playerlist.Add(new Player("Tal", "Simon", "Talsi", "abc", "male", b2));
        }

        public static void AddAnimal()
        {
            animallist.Add(new Animal("Kitty", "Yali12", 0, "healthy"));
            animallist.Add(new Animal("oliver", "Talsi", 0, "healthy"));
        }

        public static Player Login(string username, string password)
        {
            return playerlist.FirstOrDefault(p => p.Username == username && p.Password == password);

        }

        public static Animal AnimalLogin(string owner, string animalname)
        {
            return animallist.FirstOrDefault(a => a.Owner == owner && a.Animalname == animalname);
        }

        public static void Register(Player P1)
        {
            Player newplayer = playerlist.FirstOrDefault(p => P1.Username == p.Username);
            if (newplayer == null)
            {
                playerlist.Add(P1);
            }
            else
            {
                Console.WriteLine("This username is already taken, please choose a different one");
                Console.WriteLine("press any key to go back to the registration screen");
                Console.ReadKey();
                Screen next = new RegisterScreen();
                next.Show();
            }

        }
    }
}
