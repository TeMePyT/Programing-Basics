using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwarf_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int dwarfs = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double moneyForPresents = 0.0;

            for (int i = 0; i < dwarfs; i++)
            {
                string gift = Console.ReadLine();
                if (gift == "sand clock")
                {
                    moneyForPresents += 2.20;
                }
                else if (gift == "magnet")
                {
                    moneyForPresents += 1.50;
                }
                else if (gift == "cup")
                {
                    moneyForPresents += 5.0;
                }
                else if(gift=="t-shirt")
                {
                    moneyForPresents += 10.0;
                }
            }
            
            if(moneyForPresents<=budget)
            { 
                Console.WriteLine($"Santa Claus has {(budget-moneyForPresents):F2} more leva left!");
            }
            else
            {
                Console.WriteLine($"Santa Claus will need {(moneyForPresents-budget):F2} more leva.");
            }
        }
    }
}
