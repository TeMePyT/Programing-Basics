using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = (n * 2) - 1;
            Console.WriteLine("{0}{1}{0}{1}{0}", '@', new string(' ', n - 2));

            for (int i = 0; i < n / 2; i++)
            {
                int emptySpace = (n - 3) - i * 2 < 0 ? 0 : (n - 3) - i * 2;
                string middle = string.Empty;
                if (i == 0)
                {
                    middle = "*";
                }
                else
                {
                    int starCount = i == n / 2 - 1 ? 0 : 1;
                    middle = string.Format("{0}{1}{0}", new string('*', starCount), new string('.', (i - 1) * 2 + 1));
                }
                Console.WriteLine("{0}{1}{0}{2}{3}{2}{0}{1}{0}", '*', new string('.', i), new string(' ', emptySpace), middle);
            }
            Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", '*', new string('.', n / 2), new string('*', (n - 4) / 2), '.');
            Console.WriteLine(new string('*', width));
            Console.WriteLine(new string('*', width));
        }
    }
}
