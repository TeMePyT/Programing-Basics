using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_For_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var time = Console.ReadLine();


            if(n<20)
            {
                if(time=="day")
                {
                    var taxiDay = (0.79 * n) + 0.70;
                    Console.WriteLine( "{0}", taxiDay);
                }
                else if(time=="night")
                {
                    var taxiNight = 0.70 + (n * 0.90);
                    Console.WriteLine("{0}", taxiNight);
                }
            }
            else if (n>=20 && n<100)
            {
                var priceBus = 0.09 * n;
                Console.WriteLine(priceBus);
            }
            else if (n>=100)
            {
                var priceTrain = 0.06 * n;
                Console.WriteLine(priceTrain);
            }
        }
    }
}
