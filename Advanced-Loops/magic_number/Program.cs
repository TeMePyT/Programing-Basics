using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n>=531441)
            {
                Console.WriteLine(999999);
                return;
            }

            StringBuilder numbers = new StringBuilder();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <=9; j++)
                {
                    for (int k = 1; k <=9; k++)
                    {
                        for (int l = 1; l <=9 ; l++)
                        {
                            for (int m = 1; m <= 9; m++)
                            {
                                for (int o = 1; o <= 9; o++)
                                {
                                    if(i*j*k*l*m*o==n)
                                    {
                                        numbers.Append(i);
                                        numbers.Append(j);
                                        numbers.Append(k);
                                        numbers.Append(l);
                                        numbers.Append(m);
                                        numbers.Append(o);
                                        numbers.Append(" ");
                                    }
                                   
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(numbers);
        }
    }
}
