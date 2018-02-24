using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatoes = double.Parse(Console.ReadLine());
            int cassettes = int.Parse(Console.ReadLine());
            int jarsPerCassette = int.Parse(Console.ReadLine());

            double lutenitsaKg = tomatoes / 5;
            double jarsFilled = lutenitsaKg / 0.535;
            double cassettesFilled = jarsFilled / jarsPerCassette;

            Console.WriteLine($"Total lutenica: {Math.Floor(lutenitsaKg)} kilograms.");

            if (cassettesFilled>cassettes)
            {
                Console.WriteLine($"{Math.Floor(cassettesFilled-cassettes)} boxes left.");
                Console.WriteLine($"{Math.Floor(jarsFilled-(cassettes*jarsPerCassette))} jars left.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(cassettes-cassettesFilled)} more boxes needed.");
                Console.WriteLine($"{Math.Floor(Math.Abs(jarsFilled - (cassettes * jarsPerCassette)))} more jars needed.");
            }
            
        }
    }
}
