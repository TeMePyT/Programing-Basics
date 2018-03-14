using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double v = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double carSpeed = (y * 3.6) + v;
            double truckTime = Math.Ceiling(x / v);
            double carTime = Math.Ceiling(x / carSpeed);

            Console.WriteLine($"The truck arrived after {truckTime} hours");
            Console.WriteLine($"The car arrived after {carTime} hours");
        }
    }
}
