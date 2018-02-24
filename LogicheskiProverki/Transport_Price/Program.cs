using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            var taxiDay =  0.70 + (0.79 * n);
            var taxiNight = 0.70 + (0.90 * n);
            var bus = 0.09 * n;
            var train = 0.06 * n;
            if (n<=20 && time=="day")
            {
                Console.WriteLine ((taxiDay).ToString("0.00"));
            }
            else if(n < 20 && time == "night")
            {
                Console.WriteLine((taxiNight).ToString("0.00"));
            }
             if (n>=20 && n<100 )
            {
                Console.WriteLine ((bus).ToString("0.00"));
            }
            
            if (n>=100 )
            {
                Console.WriteLine ((train).ToString("0.00"));
            }
            
        }
    }
}
