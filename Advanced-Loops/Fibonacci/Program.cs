using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n<2)
            {
                Console.WriteLine(1);
            }
            else
            {
                int f0 = 0;
                int f1 = 1;
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum = f0 + f1;
                    f0 = f1;
                    f1 = sum;
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}
