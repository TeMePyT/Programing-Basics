using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double nextNumber = double.Parse(Console.ReadLine());
                
                
                if(i%2==0)
                {
                    evenSum += nextNumber;
                    if (n == 2)
                    {
                        evenMin = nextNumber;
                        evenMax = nextNumber;
                    }
                     if (nextNumber>evenMax)
                    {
                        evenMax = nextNumber;
                    }
                    if(nextNumber<evenMin )
                    {
                        evenMin = nextNumber;
                    }
                   
                }
                else
                {
                    oddSum += nextNumber;
                    if(n==1||n==2)
                    {
                        oddMin = nextNumber;
                        oddMax = nextNumber;
                    }
                   
                    if(nextNumber>oddMax)
                    {
                        oddMax = nextNumber;
                    }
                    if(nextNumber<oddMin)
                    {
                        oddMin = nextNumber;
                    }
                    
                    
                }
            }

            Console.WriteLine($"OddSum={oddSum},");
           
            if(oddSum>0 || oddSum<0)
            {
                Console.WriteLine($"OddMin={oddMin},");
                Console.WriteLine($"OddMax={oddMax},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No");
            }

            Console.WriteLine($"EvenSum={evenSum},");
            if (evenSum>0 || evenSum<0)
            {
                Console.WriteLine($"EvenMin={evenMin},");
                Console.WriteLine($"EvenMax={evenMax}" );
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            
           
        }
    }
}
