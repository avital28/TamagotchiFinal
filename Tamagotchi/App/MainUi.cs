using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.UI;

namespace Tamagotchi
{
    public class MainUi
    {
        public static Player p;
        public static Animal a;
        public static List<Animal> pastanimals;
        public static List<Activity> activitiesHistory = new List<Activity>();
        private Screen main;

        public MainUi(Screen main)
        {
            this.main = main;
        }

        public void Start()
        {
            Data.Data.AddPlayer();
            Data.Data.AddAnimal();  
            main.Show();
        }
    }
}
