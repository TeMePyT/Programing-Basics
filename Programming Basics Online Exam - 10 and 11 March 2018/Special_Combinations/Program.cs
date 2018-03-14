using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundreds = int.Parse(Console.ReadLine());
            int tens = int.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hundreds; i++)
            {
                for (int j = 1; j <= tens; j++)
                {
                    for (int k = 1; k <= numbers; k++)
                    {
                        if (i % 2 == 0 && isPrime(j) && j <= 7 && k % 2 == 0)
                        {
                            Console.Write(i+" ");
                            Console.Write(j+" ");
                            Console.Write(k);
                            Console.WriteLine();
                        }

                    }
                }
            }
        }

        private static bool isPrime(int j)
        {
            if (j == 1) return false;
            if (j == 2) return true;


            if (j % 2 == 0) return false;

            for (int i = 2; i <= j; i += 2)
            {
                if (j % i == 0) return false;
            }
            return true;
        }
    }
}
