using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Autonomy
{
    class Program
    {
        static void Main(string[] args)
        {
            short width = short.Parse(Console.ReadLine());
            short length = short.Parse(Console.ReadLine());
            short height = short.Parse(Console.ReadLine());

            string boxes = Console.ReadLine();
            int totalVolume = width * length * height;
            int volumeUsed = 0;
            while(boxes!="Done")
            {
                int boxVolume = 0;
                int.TryParse(boxes, out boxVolume);

                volumeUsed += boxVolume;
                if(volumeUsed>totalVolume)
                {
                    Console.WriteLine($"No more free space! You need {volumeUsed-totalVolume} Cubic meters more.");
                    return;
                }
                boxes = Console.ReadLine();
            }
            Console.WriteLine($"{totalVolume-volumeUsed} Cubic meters left.");
        }
    }
}
