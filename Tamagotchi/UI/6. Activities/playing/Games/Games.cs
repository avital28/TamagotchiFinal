﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.UI._5._AnimalMenu;

namespace Tamagotchi.UI._6._Activities.playing.Games
{
    public class Games 
    {
        protected int happinesslevelaffect;
        public void Back()
        {
            Thread.Sleep(1500);
            Console.WriteLine("press any key to go back to the animal action menu");
            Console.ReadKey();
            Screen next = new AnimalActionsMenu();
            next.Show();
        }
    }
}

