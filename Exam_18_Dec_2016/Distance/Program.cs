using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialSpeed = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            double secondSpeed = (initialSpeed * 0.1)+initialSpeed;
            double thirdSpeed = secondSpeed-(secondSpeed * 0.05);

            double firstDistance = initialSpeed * (firstTime / 60);
            double secondDistance = secondSpeed * (secondTime / 60);
            double thirdDistance = thirdSpeed * (thirdTime / 60);
            double totalDistance = firstDistance + secondDistance + thirdDistance;

            Console.WriteLine("{0:F2}", totalDistance);

        }
    }
}
