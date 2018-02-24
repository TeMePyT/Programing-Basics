using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 4 * n + 1;
            int height = 2 * n + 5;

            
            


            Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', 2*n-1), "/", "|", "\\");
            Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', 2 * n - 1), "\\", "|", "/");

            for (int i = 0; i < 2*n; i++)
            {
                int leftright = 2 * n - 1-i;
               // string leftRight = new string('.', leftright);
                string middle = "*" + new string('-', i ) + "*" + new string('-', i) + "*";
                Console.WriteLine("{0}{1}{0}", new string('.', leftright), middle);
                //leftright--;
            }
            Console.WriteLine(new string('*', 4*n+1));
            Console.WriteLine('*' + new string('x', n * 2).Replace("x", ".*")) ;
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
