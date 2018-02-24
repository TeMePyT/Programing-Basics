using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_Of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 1; i <= n+1; i++)
            {
                if(i==1)
                {
                    num = 1;
                    Console.WriteLine(num);
                }
                else
                {
                    num *= 2;
                    Console.WriteLine(num);
                }
            }
        }
    }
}
