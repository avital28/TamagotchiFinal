using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.UI._6._Activities.Cleaning.CleaningKinds;
using Tamagotchi.UI._6._Activities.Feeding.FoodKinds;

namespace Tamagotchi.UI._6._Activities.Cleaning
{
    public class CleaningMenu : MenuScreen
    {
        public CleaningMenu() : base ("Cleaning menu")
        {
            AddItem("Shower", new CleaningScreen(new Shower(), ""));
            AddItem("Face wash", new CleaningScreen(new FaceWash(), ""));
            AddItem("Skincare", new CleaningScreen(new SkinCare(), ""));

        }
    }
}
