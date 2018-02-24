using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    num = i + j + 1;
                    if (num>n)
                    {
                        num = 2 * n - num;
                    }
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
