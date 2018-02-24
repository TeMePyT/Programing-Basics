using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometri = double.Parse(Console.ReadLine());
            double razhod = double.Parse(Console.ReadLine());
            double cenaGorivo = double.Parse(Console.ReadLine());
            double pari = double.Parse(Console.ReadLine());

            double razhodTotal = kilometri * razhod / 100;
            double gorivoTotal = razhodTotal * cenaGorivo;

            if (gorivoTotal<=pari)
            {
                Console.WriteLine($"You can take a trip. {pari-gorivoTotal:F2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {pari/5:f2} money.");
            }
        }
    }
}
