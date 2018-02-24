using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int emptySpace = n - 1;
            //string top = new string(' ', n) + '|' + new string(' ', n);
            
            //Console.WriteLine(top);

            for (int i = 0; i <=n; i++)
            {
                string tree = new string(' ', n - i) + new string('*', i) +' '+ '|' +' '+ new string('*', i) + new string(' ', n - i);
                Console.WriteLine(tree);
            }
        }
    }
}
