using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Not prime");
            }
            bool isPrime = true;

            for (int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            string result = isPrime ? "Prime" : "Not Prime";
            Console.WriteLine(result);
        }
    }
}
