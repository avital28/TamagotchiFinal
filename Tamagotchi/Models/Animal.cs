using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Events;

namespace Tamagotchi
{
    public class Animal
    {
        
        public event EventHandler<EventArgs> IsHungry;

        public string Animalname { get; set; }
        public string Owner { get; set; }   
        public int Weight { get; set; } 
        public int Age { get; set; }    
        public DateTime AnimalBirthday { get; }
        public string LifeCycle { get; set; }
        public string HealthStatus { get; set; }
        public int HungerLevel { get; set; } 
        public int HappinessLevel { get; set; } 
        public int CleanlinessLevel { get; set; }
        public int SerialNumber{ get; set; }

        public static int count = Data.Data.animallist.Count+1;
        public Animal() { }
        public Animal (string animalname, string owner, int weight, string healthStatus)
        {
            Animalname = animalname;
            Owner = owner;
            Weight = weight;
            Age = 0;
            AnimalBirthday = DateTime.Now;
            LifeCycle = "Baby";
            HealthStatus = "Healthy";
            SerialNumber = count;
            count++;
        }

        public void Start()
        {
            IsHungry += HungerAlert.PrintAlert;
            IsHungry.Invoke(MainUi.a, new EventArgs());
        }




    }
}
