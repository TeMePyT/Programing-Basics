using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        { 
            string dayOrNight = Console.ReadLine(); // day / night
            int time = int.Parse(Console.ReadLine());

            if (dayOrNight == "day")
            {
                if (time<12)
                {
                    Console.WriteLine("It`s breakfast time.");
                }
                else
                {
                    Console.WriteLine("It`s lunch time.");
                }
            }
            else if (dayOrNight == "night")
            {
                Console.WriteLine("It`s dinner time.");
            }
        }
    }
}
