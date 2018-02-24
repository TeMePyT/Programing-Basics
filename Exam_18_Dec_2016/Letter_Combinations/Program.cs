using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string skip = Console.ReadLine();
            int firstToNumber=first[0];
            int secondToNumber = second[0];
            int skipToNumber = skip[0];
            int number = 0;
            StringBuilder combinations  = new StringBuilder();

            for (int i = firstToNumber; i <= secondToNumber; i++)
            {
                for (int j  = firstToNumber; j <= secondToNumber; j++)
                {
                    for (int k = firstToNumber; k <= secondToNumber; k++)
                    {
                        if (i != skipToNumber && j != skipToNumber && k != skipToNumber)
                        {
                             combinations.Append(Convert.ToChar(i));
                            combinations.Append(Convert.ToChar(j));
                            combinations.Append(Convert.ToChar(k));
                            combinations.Append(" ");
                            number++;
                        }  
                    }
                }
            }
            Console.Write(combinations);
            Console.WriteLine(number);
        }
    }
}
