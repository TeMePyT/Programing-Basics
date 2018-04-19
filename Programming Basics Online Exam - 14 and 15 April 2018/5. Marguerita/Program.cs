using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Marguerita
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("'" + '&' + '$' + new string('\'', 8 * n - 1));
            int left = 2;
            int right = 8 * n - 1;
            for (int i = 0; i < n - 1; i++)
            {

                Console.WriteLine(new string('\'', left) + "\\" + new string('\'', right));
                left++;
                right--;
            }
            Console.WriteLine(new String('x', 4 * n).Replace("x", "^*") + '^' + '\'');
            int rightSpacesValue = (8 * n + 2) - (n + 6);
            int mid = (8 * n + 2) - 3;
            for (int i = 0; i < 4 * n - 1; i++)
            {
                string left1 = new string('\'', i);
                string right1 = new string('\'', i);
                string leftSpaces = new string(' ', n);
                string rightSpaces = new string(' ', rightSpacesValue);
                if (i == n - 1)
                {
                    Console.WriteLine($"{left1}{'\\'}{new string('~', n + 2)}{new string('~', rightSpacesValue + 1)}{'/'}{right1}{ '\''}");
                    rightSpacesValue -= 2;
                    mid -= 2;
                }
                if (i < n - 1)
                {

                    Console.WriteLine($"{left1}{new string('\\', 2)}{leftSpaces}{'\\'}{rightSpaces}{new string('/', 2)}{right1}{ '\''}");
                    rightSpacesValue -= 2;
                    mid -= 2;
                }
                if (i == 4 * n - 2)
                {
                    Console.WriteLine($"{left1}{'\\'}{new string('_', mid)}{'/'}{right1}{ '\''}");

                }
                else if (i >= n)
                {

                    if (i == 2 * n - 2)
                    {

                        Console.WriteLine($"{left1}{'\\'}{new string('_', mid)}{'/'}{right1}{ '\''}");
                        mid -= 2;
                    }
                    else if (i == 2 * n - 1)
                    {
                        Console.WriteLine($"{left1}{'\\'}{new string('.', mid)}{'/'}{right1}{ '\''}");
                        mid -= 2;
                    }

                    else
                    {

                        Console.WriteLine($"{left1}{'\\'}{new string(' ', mid - 1)} {'/'}{right1}{ '\''}");
                        mid -= 2;

                    }
                }
            }
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine($"{new string('\'', 4 * n - 1)}{new string('|', 3)}{new string('\'', 4 * n - 1)}{ '\''}");
            }
            Console.WriteLine($"{new string('_', 8*n+1)}{ '\''}");
            Console.WriteLine($"{ '\''}{new string('-', 8*n-1)}{ '\''}{ '\''}");
        }
    }
}
