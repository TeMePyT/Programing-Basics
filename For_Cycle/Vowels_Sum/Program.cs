using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            int sum = 0;
            for (int currentIndex = 0; currentIndex < text.Length; currentIndex++)
            {
                var symbol = text[currentIndex];
                 switch (symbol)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;

                }
            
            }
            Console.WriteLine(sum);
        }
    }
}
