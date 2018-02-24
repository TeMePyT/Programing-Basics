using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mid = n - 2;
            int midLine = (n - 1) / 2 ;
            string topAndBottom = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);

            Console.WriteLine(topAndBottom);

            for (int i = 1; i <= mid; i++)
            {
                if (i == midLine)
                {
                    string middle1 = '*' + new string('/', 2 * n - 2) + '*' + new string('|', n) + '*' + new string('/', 2 * n - 2) + '*';
                    Console.WriteLine(middle1);
                }
                else
                { 
                string middle = '*' + new string('/', 2 * n - 2) + '*' + new string(' ', n) + '*' + new string('/', 2 * n - 2) + '*';
                Console.WriteLine(middle);
                }
            }
            Console.WriteLine(topAndBottom);
        }
    }
}
