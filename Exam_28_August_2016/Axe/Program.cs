using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int left = ((2 * n) - 2)-i;
                string top = new string('-', n * 3) + '*' + new string('-', i) + '*' + new string('-', left);
                Console.WriteLine(top);
                ;
            }

            for (int i = 0; i < n/2; i++)
            {
                string middle = new string('*', n * 3+1) + new string('-', n - 1) + '*' + new string('-', n - 1);
                Console.WriteLine(middle);
            }

            if (n <= 3)
            {
                string end = new string('-', n * 3) + new string('*', n + 1) + new string('-', n - 1);
                Console.WriteLine(end);
            }
            for (int i = 0; i < n/2-1; i++)
            {
                int left = (n * 3) - i;
                int right = (n - 1) - i;
                int middle = (n - 1) + 2 * i;
                string bottom = new string('-', left) + '*' + new string('-', middle) + '*' + new string('-', right);
                Console.WriteLine(bottom);
                if(i==(n/2-2))
                {
                    string end = new string('-', left-1) + '*' + new string('*', middle+2) + '*' + new string('-', right-1);
                    Console.WriteLine(end);
                }
            }
            
                
        }
    }
}
