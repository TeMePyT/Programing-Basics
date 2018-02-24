using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());


            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        int currentNumber = ((i * 100) + (j * 10) + k);

                        if (currentNumber % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (currentNumber % 5 == 0)
                        {
                            specialNumber -= 2;
                        }
                        else if (currentNumber % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
                            return;
                            break;
                        }

                    }
                   
                }
                
            }
           
            
                Console.WriteLine("No! {0} is the last reached special number.", specialNumber);
          

        }
    }
}
