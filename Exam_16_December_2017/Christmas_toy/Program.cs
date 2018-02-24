using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_toy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string topBottom = new string('-', n * 2) + new string('*', n) + new string('-', n * 2);

            int firstLeftRight = (5 * n - (n + 4)) / 2;
            int middle = n + 2;
            int middle2 = 5 * n - (2 * n + 2);
            Console.WriteLine(topBottom);

            for (int i = 1; i <= n; i++)
            {

                string firstHalf = new string('-', firstLeftRight) + new string('*', i) + new string('&', middle) + new string('*', i) + new string('-', firstLeftRight);
                string secondHalf = new string('-', firstLeftRight + 1) + "**" + new string('~', middle2) + "**" + new string('-', firstLeftRight + 1);
                if (i <= n / 2)
                {
                    Console.WriteLine(firstHalf);
                    firstLeftRight -= 2;
                    middle += 2;
                }
                else
                {
                    Console.WriteLine(secondHalf);
                    firstLeftRight -= 1;
                    middle2 += 2;
                }
            }
            Console.WriteLine(new string('-', n / 2) + '*' + new string('|', 5 * n - (n + 2)) + '*' + new string('-', n / 2));
            for (int i = n; i >= 1; i--)
            {
                string firstHalf = new string('-', firstLeftRight+2) + new string('*', i) + new string('&', middle-2) + new string('*', i) + new string('-', firstLeftRight+2);
                string secondHalf = new string('-', firstLeftRight + 2) + "**" + new string('~', middle2-2) + "**" + new string('-', firstLeftRight + 2);
                if (i > n / 2)
                {
                    firstLeftRight += 1;
                    middle2 -= 2;

                    Console.WriteLine(secondHalf);
                }
                else
                {
                    firstLeftRight += 2;
                    middle -= 2;
                    Console.WriteLine(firstHalf);
                }
            }

            Console.WriteLine(topBottom);
        }
    }
}
