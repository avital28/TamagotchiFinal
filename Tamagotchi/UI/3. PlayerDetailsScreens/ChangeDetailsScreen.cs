using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._1
{
    public class ChangeDetailsScreen:Screen, Idetails
    {
        public ChangeDetailsScreen() : base("") { }
        public void Details()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Current player details:"); 
            Console.ResetColor();
            string gender = MainUi.p.Gender;
            Console.WriteLine("1- First name: " + MainUi.p.Firstname);
            Console.WriteLine("2- Last name: " + MainUi.p.Lastname);
            Console.WriteLine("3- Username: " + MainUi.p.Username);
            Console.WriteLine("4- Password " + MainUi.p.Password);
            Console.WriteLine("5- Gender: " + gender[0].ToString().ToUpper() + gender.Substring(1));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Choose the number of the detail you would like to change");
            int choice = int.Parse(Console.ReadLine());
            while (choice>=6 && choice<=0)
            {
                Console.WriteLine("please re- enter your choice");
                choice = int.Parse(Console.ReadLine());
            }

                Console.WriteLine("please enter your desired value");
                string newvalue = Console.ReadLine();
            switch (choice)
            {
                case 1:
                    try
                    {
                        MainUi.p.Firstname = newvalue;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        newvalue = Console.ReadLine();
                    }                  
                    break;
                case 2:
                    try
                    {
                        MainUi.p.Lastname = newvalue;

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 3:
                    MainUi.p.Username = newvalue;
                    break;
                case 4:
                    MainUi.p.Password = newvalue;
                    break;
                case 5:
                    MainUi.p.Gender = newvalue;
                    break;
            }
            Console.WriteLine("Your details have been sucssesfully updated, press any key to go back to the Player / Animal menu");
            Console.ReadKey();
            Screen next2 = new PlayerDetailsMenu();
            next2.Show();
}

    }


        

        


    }


