using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)

        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            var min = m + 15;

            if (min >= 60)
            {
                var min1 = min - 60;
                var h1 = h + 1;
                if (h1 >= 24)
                {
                    var h2 = h1 - 24;
                    if (min1 < 10)
                    {
                        Console.WriteLine(h2 + ":" + "0" + min1);
                    }



                    else
                    {
                        Console.WriteLine(h2 + ":" + min1);
                    }

                }

                else
                {
                    if (min1 < 10)
                    {
                        Console.WriteLine(h1 + ":" + "0" + min1);
                    }
                    else
                    {
                        Console.WriteLine(h1 + ":" + min1);
                    }
                }
            }



            else if (min < 10)
            {
            
    Console.WriteLine(h + ":" + "0" + min);
            }
            else
            {
                Console.WriteLine(h + ":" + min);
            }

            
            
        }
    }
}
