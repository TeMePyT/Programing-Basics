using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            var restDays = int.Parse(Console.ReadLine());

            var restDaysPlay = restDays * 127;
            var workDaysPlay = (365 - restDays) * 63;
            var totalDaysPlay = restDaysPlay + workDaysPlay;
            var hours = Math.Abs((totalDaysPlay-30000) / 60);
            var min = Math.Abs((totalDaysPlay-30000) % 60);

            if (totalDaysPlay<=30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, min );
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, min);
            }
        }
    }
}
