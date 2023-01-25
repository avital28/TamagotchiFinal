﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.UI
{
    public class MainMenuScreen:MenuScreen
    {
        public MainMenuScreen() : base("main menu")
        {
            AddItem("Register", new RegisterScreen());
            AddItem("Login", new LoginScreen());
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
