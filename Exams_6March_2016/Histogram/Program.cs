using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double counter199 = 0;
            double counter399 = 0;
            double counter599 = 0;
            double counter799 = 0;
            double counter800 = 0;

            for (int i = 1; i <=n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number<=199)
                {
                    counter199++;
                }
                else if(number>=200 && number<=399)
                {
                    counter399++;
                }
                else if (number >= 400 && number<=599)
                {
                    counter599++;
                }
                else if(number>=600 && number<=799)
                {
                    counter799++;
                }
                else if(number>=800)
                {
                    counter800++;
                }
            }
            Console.WriteLine("{0:F2}", (counter199 / n) * 100);
            Console.WriteLine("{0:F2}", (counter399 / n) * 100);
            Console.WriteLine("{0:F2}", (counter599 / n) * 100);
            Console.WriteLine("{0:F2}", (counter799 / n) * 100);
            Console.WriteLine("{0:F2}", (counter800 / n) * 100);
        }
    }
}
