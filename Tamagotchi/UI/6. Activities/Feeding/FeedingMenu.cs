using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;
using Tamagotchi.UI;

namespace Tamagotchi.Actions
{
    public class FeedingMenu :MenuScreen, IAction
    {
        public void Act() { }
        public FeedingMenu (): base ("Food menu")
        {
            AddItem("Grapes", new FeedingScreen(new Grapes(), ""));
            AddItem("Cookie", new FeedingScreen(new Cookie(), ""));
            AddItem("Pizza", new FeedingScreen(new Pizza(), ""));
        }
        
    }
}
