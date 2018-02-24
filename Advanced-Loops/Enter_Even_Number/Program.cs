using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool even = false;

            do
            {
                Console.Write("Enter even number:");
                string text = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(text);
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {number}");
                        even = true;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                        even = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                
            } while (even == false);
         }
    }
}
