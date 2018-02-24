using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossing_sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int tribonacciFirst = int.Parse(Console.ReadLine());
            int tribonacciSecond = int.Parse(Console.ReadLine());
            int tribonacciThird = int.Parse(Console.ReadLine());
            int spiralCurrent = int.Parse(Console.ReadLine());
            int spiralStep = int.Parse(Console.ReadLine());

            if (spiralCurrent == tribonacciFirst || spiralCurrent == tribonacciSecond || spiralCurrent == tribonacciThird)
            {
                Console.WriteLine(spiralCurrent);
                return;
            }

            int tribonacciCurrent = tribonacciFirst;
            int spiralIncrement = 0;
            int spiralStepMul = 1;

            while (tribonacciCurrent <= 1000000 && spiralCurrent <= 1000000)
            {
                if (spiralCurrent == tribonacciCurrent)
                {
                    Console.WriteLine(spiralCurrent);
                    return;
                }
                else if (tribonacciCurrent < spiralCurrent)
                {

                    tribonacciCurrent = tribonacciFirst + tribonacciSecond + tribonacciThird;
                    tribonacciFirst = tribonacciSecond;
                    tribonacciSecond = tribonacciThird;
                    tribonacciThird = tribonacciCurrent;

                }
                else
                {

                    spiralCurrent += spiralStepMul * spiralStep;
                    spiralIncrement++;
                    if (spiralIncrement == 2)
                    {
                        spiralStepMul++;
                        spiralIncrement = 0;
                    }
                }
            }
            Console.WriteLine("No");
        }
    }
}
