using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());

            var totalSec = sec1 + sec2 + sec3;
            var min = totalSec / 60;
            var sec = totalSec % 60;

            if (sec<10)
            {
                Console.WriteLine(min + ":0" + sec);
            }
            else
            {
                Console.WriteLine(min + ":" + sec);
            }
        }
    }
}
