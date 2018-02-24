using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadratna_Ramka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int calc = n - 2;

            Console.Write("+");
            for (int i = 1; i <=calc; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            for (int j = 1; j <=calc; j++)
            {
                Console.Write("|");
                for (int h = 1; h <=calc; h++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (int i = 1; i <= calc; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

        }
    }
}
