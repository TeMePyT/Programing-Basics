using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int players = int.Parse(Console.ReadLine());
            int playerPower = int.Parse(Console.ReadLine());
            int illidanHealth = int.Parse(Console.ReadLine());

            int totalPlayerPower = players * playerPower;

            if(totalPlayerPower>illidanHealth)
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {totalPlayerPower-illidanHealth} points.");
            }
            else
            {
                Console.WriteLine($"You are not prepared! You need {illidanHealth-totalPlayerPower} more points.");
            }
        }
    }
}
