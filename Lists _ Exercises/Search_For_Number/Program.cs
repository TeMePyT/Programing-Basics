using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_For_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numbersToTake = array[0];
            int numbersToDelete = array[1];
            int searchedNumber = array[2];

            List<int> newNumbers = new List<int>();

            for (int i = 0; i < numbersToTake; i++)
            {
                newNumbers.Add(numbers[i]);

            }

            newNumbers.RemoveRange(0, numbersToDelete);

            foreach (int number in newNumbers)
            {

                if (number == searchedNumber)
                {
                    Console.WriteLine("YES!");
                    return;
                }

            }
            Console.WriteLine("NO!");
        }
    }
}
