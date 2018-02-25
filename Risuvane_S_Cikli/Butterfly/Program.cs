using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n - 1;
            int weight = n - 2 ;
            int stars = n - 2;
            var lineDash = n % 2;

            string topString = new string('*', n - 2) + "\\ /" + new string('*', n - 2);
            string secondString = new string('-', n - 2) + "\\ /" + new string('-', n - 2);

            string bottomString = new string('*', n - 2) + "/ \\" + new string('*', n - 2);
            string bottomSecondString = new string('-', n - 2) + "/ \\" + new string('-', n - 2);

            for (int i = 0; i < weight; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(topString);
                }
                else
                {
                    Console.WriteLine(secondString);
                }
            }
            Console.WriteLine(new string(' ', n-1) + '@' + new string(' ', n-1));
            for (int i = 0; i < weight; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(bottomString);
                }
                else
                {
                    Console.WriteLine(bottomSecondString);
                }
            }
        }
            
    }
}
