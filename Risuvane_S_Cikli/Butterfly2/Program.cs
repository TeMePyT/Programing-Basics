using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = (4 * n) - 4;
            var emptySpaces = width - 4;
           // string topLeft = "*\\";
           // string topRight = "/*";
            string topLine = "\\/";
            string bottomLine = "/\\";
           // string bottomLeft = "*/";
           // string bottomRight = "*\\";


           
            for (int i = 1; i <= n-2; i++)
            {
                

                 string line = new String('x', i).Replace("x", "*\\") + new String('x', emptySpaces).Replace("x", " ")+ new String('x', i).Replace("x", "/*");

                emptySpaces -= 4;
               

                Console.WriteLine(line);
            }
            


            for (int i = 0; i < width/2; i++)
            {
                Console.Write("{0}", topLine);
            }
            Console.WriteLine();
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{1}{2}{1}{3}", new string('<', width/2-3), "*", "|", new string('>', width/2-3));
            }
            for (int i = 0; i < width / 2; i++)
            {
                Console.Write("{0}", bottomLine);
               
            }
            Console.WriteLine();

            for (int i = n-2; i >= 1; i--)
            {
                emptySpaces += 4;

                string line = new String('x', i).Replace("x", "*/") + new String('x', emptySpaces).Replace("x", " ") + new String('x', i).Replace("x", "\\*");

                

                Console.WriteLine(line);

            }

        }
    }
}
