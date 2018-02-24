using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int N = n % 10;
            int M = (n / 10) % 10;
            int X = (n / 100) % 10;
            int rows = X + M;
            int cols = X + N;

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (n % 5 == 0)
                    {
                        n -= X;
                        result.Append(n);
                        result.Append(' ');
                    }
                    else if (n % 3 == 0)
                    {
                        n -= M;
                        result.Append(n);
                        result.Append(' ');
                    }
                    else
                    {
                        n += N;
                        result.Append(n);
                        result.Append(' ');
                    }
                    
                }
                Console.WriteLine(result);
                result.Clear();
            }
            
        }
    }
}
