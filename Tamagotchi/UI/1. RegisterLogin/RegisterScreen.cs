using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.UI
{
    public class RegisterScreen : Screen
    {
        Player P= new Player();
        string username;
        string password;
        DateTime birthday;
        public RegisterScreen() : base("Register")
        {

        }
        public override void Show()
        {
            base.Show();
            SetUserName();
            SetPassword();
            CreatePlayer();
            Screen next1 = new LoginScreen();
            next1.Show();
        }
        private void SetUserName()
        {
            Console.WriteLine("Please enter your chosen username");
            username = Console.ReadLine();
        }
        private void SetPassword()
        {
            Console.WriteLine("Please enter your chosen password");
            this.password = Console.ReadLine();
        }

        private void CreatePlayer()
        {
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();
            try
            {
                P.Firstname=firstname; 
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
                P.Lastname = lastname;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("enter your gender");
            string gender = Console.ReadLine();
            Console.WriteLine("Please enter your birthday");
            birthday = DateTime.ParseExact(Console.ReadLine(), "dd/M/yyyy", CultureInfo.InvariantCulture);
            Player c= new Player(firstname,lastname,username,password,gender,birthday);
            Data.Data.Register(c);


        }
    }
}
