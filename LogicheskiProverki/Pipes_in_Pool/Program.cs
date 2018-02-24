using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes_in_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            var pool = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            var pipe1Debit = time * pipe1;
            var pipe2Debit = time * pipe2;
            var totalDebit = pipe1Debit + pipe2Debit;
            var poolDebit = (pool - totalDebit)/100;
             
            if (totalDebit<=pool)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(totalDebit/pool*100), Math.Truncate(pipe1Debit/totalDebit*100), Math.Truncate(pipe2Debit/totalDebit*100));
            }
            else
            {
                Console.WriteLine( "For {0} hours the pool overflows with {1} liters.", time, (totalDebit-pool).ToString("0.0"));
            }
        
        }
    }
}
