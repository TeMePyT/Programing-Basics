using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            var height = h * 100;
            var weight = w * 100;
            var lines = Math.Floor(height / 120);
            var rows = Math.Floor((weight - 100) / 70);
            var total = (lines * rows) - 3;
            Console.WriteLine(total);
        }
    }
}
