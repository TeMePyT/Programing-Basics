using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double total = (48 - h) * 3 / 4 + (p * 2 / 3) + h;

            if (year == "leap")
            {
                Console.WriteLine(Math.Floor(total + 0.15 * total));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Floor(total));
            }
        }
    }
}
