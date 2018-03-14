using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = Convert.ToChar(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            char m = Convert.ToChar(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            char k = Convert.ToChar(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());

            n += (char)n1;
            m += (char)m1;
            k += (char)k1;

            if (n == '@' && m == '@' && k == '@')
            {
                Console.WriteLine(n.ToString() + m + k + ' ');
                Console.WriteLine("!!! YOU LOSE EVERYTHING !!!");
            }
            else if (n == '7' && m == '7' && k == '7')
            {
                Console.WriteLine(n.ToString() + m + k + ' ');
                Console.WriteLine("*** JACKPOT ***");
            }
            else
            {
                Console.WriteLine(n.ToString() + m + k);
            }
        }
    }
}
