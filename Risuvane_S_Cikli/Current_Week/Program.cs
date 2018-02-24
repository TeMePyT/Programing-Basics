using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Current_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int currentWeek = 1; currentWeek <=4; currentWeek++)
            {
                Console.WriteLine(currentWeek);
                for (int currentDayOfWeek = 1; currentDayOfWeek <=7; currentDayOfWeek++)
                {
                    Console.WriteLine($"---{currentDayOfWeek}");
                }
            }
        }
    }
}
