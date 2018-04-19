using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLength = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double astronautsHeight = double.Parse(Console.ReadLine());

            double shipVolume = shipHeight * shipWidth * shipLength;
            double roomVolume = (astronautsHeight + 0.40) * 2 * 2;

            double space = Math.Floor(shipVolume / roomVolume);

            if(space<3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if(space>10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {space} astronauts.");
            }
        }
    }
}
