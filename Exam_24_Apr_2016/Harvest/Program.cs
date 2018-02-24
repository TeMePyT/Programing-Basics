using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int AreaLoze = int.Parse(Console.ReadLine());
            double AmmountGrapesPerM = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            var totalGrapes = AmmountGrapesPerM * AreaLoze;
            var wine = (totalGrapes * 40 / 100) / 2.5;
            var wineleft = wine - neededWine;

            if (wine>=neededWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineleft), Math.Ceiling((wineleft/workers)));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(neededWine-wine));
            }
        }
    }
}
