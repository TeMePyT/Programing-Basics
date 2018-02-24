using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double paper = double.Parse(Console.ReadLine());
            double fabric = double.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine()) / 100;

            double totalPrice = paper * 5.80 + fabric * 7.20 + glue * 1.20;
            double discountedPrice = totalPrice - totalPrice * discount;

            Console.WriteLine($"{discountedPrice:F3}");
        }
    }
}
