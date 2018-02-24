using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Piramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(sum+" ");
                    sum++;
                    if(sum>n)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
