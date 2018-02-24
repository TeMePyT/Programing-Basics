using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romb_Ot_Zvezdi
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countOfWhiteSpaces = size - 1;
            for (int row = 1; row <= size; row++)
            {
                for (int col = 0; col <  countOfWhiteSpaces; col++)
                {
                    Console.Write(" ");

               }
                Console.Write('*');
                for (int j = 1; j <=row-1; j++)
                {
                    Console.Write(" *");
                }
                countOfWhiteSpaces--;
                Console.WriteLine();
            }
            countOfWhiteSpaces = 1;
            int countOfStars = size - 1;
            int botRows = countOfStars;
            for (int k = 0; k < botRows; k++)
            {
                for (int l = 0; l < countOfWhiteSpaces; l++)
                {
                    Console.Write(" ");
                }
                Console.Write('*');
                for (int m = 0; m < countOfStars-1; m++)
                {
                    Console.Write(" *");
                }
                countOfWhiteSpaces++;
                Console.WriteLine();
                countOfStars--;
            }

        }
    }
}
