using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Sock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string top1 = '|' + new string('-', n * 2) + '|';
            string top2 = '|' + new string('*', n * 2) + '|';
            Console.WriteLine($"{top1}");
            Console.WriteLine($"{top2}");
            Console.WriteLine($"{top1}");
            for (int i = 1; i < ((((2 * n) - 2) / 2) + 1) ; i++)
            {
                string left = '|' + new string('-', n - i) + new string('~', i);
                string right = new string('~', i) + new string('-', n - i) + '|';
                Console.WriteLine($"{left}{right}");
                
            }
            for (int i = ((((2 * n) - 2) / 2)-1); i >= 1; i--)
            {
                
                string left1 = '|' + new string('-', n - i) + new string('~', i);
                string right1 = new string('~', i) + new string('-', n - i) + '|';
                Console.WriteLine($"{left1}{right1}");
            }
            for (int i = 0; i < n+2; i++)
            {
                string boot = new string('-', i) + '\\' + new string('.', 2 * n + 1) + '\\';
                
                if(i==((n+2)/2)-1)
                {
                    Console.WriteLine(new string('-',i)+'\\'+new string('.', n-2)+"MERRY"+new string('.', n - 2)+'\\');
                }
                else if(i==((n+2)/2)+1)
                {
                    Console.WriteLine(new string('-', i) + '\\' + new string('.', n - 2) + "X-MAS" + new string('.', n - 2) + '\\');
                }
                else
                {
                    Console.WriteLine(boot);
                }
            }

            string bottom = new string('-', n + 2) + '\\' + new string('_', 2 * n + 1) + ')';
            Console.WriteLine(bottom);
        }
    }
}

