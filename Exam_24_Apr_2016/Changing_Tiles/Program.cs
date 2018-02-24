using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changing_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());

            int Space = N * N;
            double SpaceTiles = W * L;
            int SpaceSeat = M * O;

            double Tiles = (Space - SpaceSeat) / SpaceTiles;
            double time = Tiles * 0.2;

            Console.WriteLine(Tiles.ToString("0.00"));
            Console.WriteLine(time.ToString("0.00"));

        }
    }
}
