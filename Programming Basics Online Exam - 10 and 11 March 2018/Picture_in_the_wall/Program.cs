using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_in_the_wall
{
    class Program
    {
        static void Main(string[] args)
        {
            int holeHeight = int.Parse(Console.ReadLine());
            int holeWidth = int.Parse(Console.ReadLine());
            int paintingSide = int.Parse(Console.ReadLine());
            int paintings = int.Parse(Console.ReadLine());

            int paintingsArea = (paintingSide * paintingSide) * paintings;
            int holeArea = holeHeight * holeWidth;

            if(holeArea>paintingsArea)
            {
                Console.WriteLine($"The pictures fit in the hole. Hole area is {holeArea - paintingsArea} bigger than pictures area.");
                
            }
            else
            {
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {paintingsArea - holeArea} bigger than hole area.");
               
            }
        }
    }
}
