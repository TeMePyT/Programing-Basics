using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num = int.Parse(Console.ReadLine());
            var sum = num;
            for (int i = 1; i < n; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                sum +=readNumber;
                if (num<readNumber)
                {
                    num = readNumber;
                }
               

            }
            var rest = sum - num;
            var diff = Math.Abs(num - rest);
            
            if (num==(sum-num))
            {
                Console.WriteLine("Yes Sum = "+num);
            }
            else
            {
                Console.WriteLine("No Diff = "+diff);
            }
            
        }
    }
}
