using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int roof = (n + 1) / 2;
            int countOfStars = n % 2 == 0 ? 2 : 1;
            int countOfDashes = (n - countOfStars) / 2;
            for (int i = 0; i < roof; i++)
            {
                Console.Write(new string('-',countOfDashes)+new string('*',countOfStars)+new string('-',countOfDashes));
                Console.WriteLine();
                countOfStars += 2;
                countOfDashes--;
            }

            int body = n / 2;
            for (int b = 0; b < body; b++)
            {
                Console.Write('|'+new string('*',n-2)+'|');
                Console.WriteLine();
            }
        }
    }
}
