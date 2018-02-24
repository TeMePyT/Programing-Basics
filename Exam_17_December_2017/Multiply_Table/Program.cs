using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int X = n % 10;
            int M = (n / 10) % 10;
            int N = (n / 100) % 10;

            for (int i = 1; i <= X; i++)
            {
                for (int j = 1; j <= M; j++)
                {
                    for (int k = 1; k <= N; k++)
                    {
                        int result = i*j*k;
                        Console.WriteLine($"{i} * {j} * {k} = {result};");
                    }
                }
            }
        }
    }
}
