using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = GetNumbers();
            GetLongestSequence(numbers);

        }

        static List<int> GetNumbers()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            return numbers;

        }
        static void GetLongestSequence(List<int> numbers)
        {
            int currentLongest = 0;
            int bestLongest = 0;
            int bestCurrent = 0;
            int current = 0;
            foreach (int number in numbers)
            {
                if (number != current)
                {
                   
                    current = number;
                    currentLongest = 0;
                   
                }
                if (number == current)
                {
                    currentLongest++;
                }
                if (currentLongest > bestLongest)
                {
                    bestLongest = currentLongest;
                    bestCurrent = current;
                }

            }
            for (int i = 0; i < bestLongest; i++)
            {
                Console.Write(bestCurrent+" ");
            }
            Console.WriteLine();
        }
    }
}
