using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_Of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            for (int i = 0; i <= n; i+=2)
            {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine(power);
            }

        }
    }
}
