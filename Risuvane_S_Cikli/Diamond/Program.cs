using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int leftRightDashes = (n - 1) / 2;
            int mid = n - 2 * leftRightDashes;// - 2;
            int countOfStars = n % 2 == 0 ? 2 : 1;

          
        }
    }
}
