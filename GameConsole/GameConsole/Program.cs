﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = null;
            //player.DaysSinceLastLogin = 42;

            //int days = player.DaysSinceLastLogin.Value;
            int days;
            if(player != null)
            {
                days = player.DaysSinceLastLogin ?? -1;
            }
            else
            {
                days = -1;
            }

            Console.WriteLine(days);
            
            Console.ReadLine();
        }
    }
}
