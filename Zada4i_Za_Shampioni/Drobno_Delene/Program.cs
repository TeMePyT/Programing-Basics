using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drobno_Delene
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1234;
            int number1 = (number / 1000) % 10;
            int number2 = (number / 100) % 10;
            int number3 = (number / 10) % 10;
            int number4 = number % 10;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
        }
    }
}
