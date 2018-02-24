using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "Odd" || input != "Even")
            {
                var pieces = input.Split();
                var command = pieces[0];
                if (command == "Delete")
                {
                    var element = int.Parse(pieces[1]);
                    numbers.RemoveAll((item => item == element));
                }
                else if (command == "Insert")
                {
                    var element = int.Parse(pieces[1]);
                    var index = int.Parse(pieces[2]);
                    numbers.Insert(index, element);
                }
                if (input == "Odd")
                {
                    GetOddNumbers(numbers);
                    return;
                }
                else if (input == "Even")
                {
                    GetEvenNumbers(numbers);
                    return;
                }
                input = Console.ReadLine();
            }
        }

        static void GetEvenNumbers(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }

            }
            Console.WriteLine();
        }
        static void GetOddNumbers(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    Console.Write(number + " ");
                }

            }
            Console.WriteLine();
        }


    }
}
