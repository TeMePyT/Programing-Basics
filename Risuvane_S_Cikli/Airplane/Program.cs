using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int flightTime = int.Parse(Console.ReadLine());

            int totalMinutes = hour * 60 + minutes;
            int totaltime = totalMinutes + flightTime;

            int hourArrive = totaltime / 60;
            int minutesArrive = totaltime % 60;

            if (minutesArrive >= 60)
            {
                minutesArrive -= 60;
                hourArrive += 1;
            }
            if (hourArrive >= 24)
            {
                hourArrive = hourArrive - 24;
            }


            Console.WriteLine($"{hourArrive}h {minutesArrive}m");
        }

    }
}
