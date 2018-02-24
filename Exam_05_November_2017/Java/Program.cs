using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(' ', n) + new string('~', 3).Replace("~", "~ "));
            }
            Console.WriteLine(new string('=', 3 * n + 5));
            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 2) / 2)
                {
                    Console.WriteLine('|' + new string('~', n) + "JAVA" + new string('~', n) + '|' + new string(' ', n - 1) + '|');
                }
                else
                {
                    Console.WriteLine('|' + new string('~', 2 * n + 4) + '|' + new string(' ', n - 1) + '|');
                }
            }
            Console.WriteLine(new string('=', 3 * n + 5));
            int middle = 2 * n + 4;
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(new string(' ', i) + '\\' + new string('@', middle) + '/');
                middle -= 2;
            }
            Console.WriteLine(new string('=', 2 * n + 6));
        }
    }
}
