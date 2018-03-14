using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPair = int.Parse(Console.ReadLine());
            int secondPair = int.Parse(Console.ReadLine());
            int firstStep = int.Parse(Console.ReadLine());
            int secondStep = int.Parse(Console.ReadLine());

            int firstEnd = firstPair + firstStep;
            int secondEnd = secondPair + secondStep;

            for (int i = firstPair; i <= firstEnd; i++)
            {
                for (int j = secondPair; j < secondEnd; j++)
                {
                    
                    

                    if (IsPrime(i) && IsPrime(j))
                    {
                        Console.Write(i);
                        Console.WriteLine(j);
                          
                    }
                }
            }
        }

        private static bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            double squareRoot = (int)Math.Floor(Math.Sqrt(n));
            

            for (int i = 2; i <= squareRoot; i ++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}


