using System;
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
            var player = new PlayerCharacter();
            //player.DaysSinceLastLogin = 42;

            int days = player.DaysSinceLastLogin.Value;
            Console.WriteLine(days);
            
            Console.ReadLine();
        }
    }
}
