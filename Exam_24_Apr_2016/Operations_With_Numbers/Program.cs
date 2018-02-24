using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_With_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            var Operator = Console.ReadLine();

           // if (Operator == "/" && Operator == "%" && N2 == 0)
           // {
            //    Console.WriteLine("Cannot divide {0} by {1}", N1, N2);
           // }
             if (Operator == "+")
            {
                var result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine(N1 + " + "+ N2 +" = " + result + " - " + "even");
                }
                else
                {
                    Console.WriteLine(N1 + " + " + N2 +  " = " +result + " - " + "odd");
                }
            }
            else if (Operator == "-")
            {
                var result = N1 - N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine(N1 + " - " + N2 + " = "+ result + " - " + "even");
                }
                else
                {
                    Console.WriteLine(N1 + " - " + N2 + " = " + result + " - " + "odd");
                }
            }
            else if (Operator == "*")
            {
                var result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine(N1 + " * " + N2 + " = " + result + " - " + "even");
                }
                else
                {
                    Console.WriteLine(N1 + " * " + N2 + " = " + result + " - " + "odd");
                }
            }
            else if (Operator == "/")
            {
                var zero = Math.Min(N1, N2);
                if (zero == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    double result = N1 / N2;
                    Console.WriteLine(N1 + " / " + N2 + " = " + result.ToString("0.00"));
                }
            }
            else if (Operator == "%")
            {
                var zero = Math.Min(N1, N2);
                if (zero == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    var result = N1 % N2;
                    Console.WriteLine(N1 + " % " + N2 + " = " + result);
                }

            }
            

        }
    }
}
