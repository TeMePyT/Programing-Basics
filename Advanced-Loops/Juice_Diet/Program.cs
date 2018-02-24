using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juice_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            int rasp = int.Parse(Console.ReadLine());
            int straw = int.Parse(Console.ReadLine());
            int cherry = int.Parse(Console.ReadLine());
            int juice = int.Parse(Console.ReadLine());
            int cherryUsed = 0;
            int strawUsed = 0;
            int raspUsed = 0;
            double juiceTotal = 0.0;
            

            for (int i = 0; i <= cherry; i++)
            {
                for (int j = 0; j <= straw; j++)
                {
                    for (int k = 0; k <= rasp; k++)
                    {
                        
                        double juiceCurrent = i * 15 + j * 7.5 + k * 4.5;
                        if (juiceCurrent <= juice)
                        {
                            if (juiceCurrent > juiceTotal)
                            {
                                juiceTotal = juiceCurrent;
                            }
                            if (juiceCurrent>=juiceTotal)
                            {
                                cherryUsed = i;
                                strawUsed = j;
                                raspUsed = k;
                            }
                        }
                    }
                }
            }
            
            

            Console.WriteLine($"{raspUsed} Raspberries, {strawUsed} Strawberries, {cherryUsed} Cherries. Juice: {juiceTotal} ml.");
        }
   
    }
}
