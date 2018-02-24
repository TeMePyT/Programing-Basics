using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine();
            var lines = int.Parse(Console.ReadLine());
            var rows = int.Parse(Console.ReadLine());

            var result = 0.0;

            if (projection == "Premiere")
            {
                result = (lines * rows) * 12.00;
                Console.WriteLine("{0:F2}", result);
            }
            else if (projection == "Normal")
            {
                result = (lines * rows) * 7.50;
                Console.WriteLine("{0:F2}", result);
            }
            else if (projection == "Discount")
            {
                result = (lines * rows) * 5.00;
                Console.WriteLine("{0:F2}", result);
            }
           
            
               
            
        }  
    }
}
