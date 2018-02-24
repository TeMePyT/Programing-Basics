using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_range_1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range[1...100]:");
            int Num = int.Parse(Console.ReadLine());
            
            
           while(Num < 1 || Num > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range[1...100]:");
                Num = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine($"The number is: {Num}");
        }
    }
}
