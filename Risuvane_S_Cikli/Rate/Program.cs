using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rate
{
    class Program
    {
        static void Main(string[] args)

        {
            double myMoney = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double myMoneySimple = 0.0;
            double myMoneyComplex = myMoney;
            double simpleTax = myMoney * 0.03;

            for (int i = 0; i < months; i++)
            {
                double complexTax = myMoneyComplex * 0.027;
                if (i == 0)
                {
                    myMoneySimple = myMoney + simpleTax;
                    myMoneyComplex = myMoney + complexTax;
                }
                else
                {
                    myMoneySimple += simpleTax;
                    myMoneyComplex += complexTax;
                }
            }
            if (myMoneySimple > myMoneyComplex)
            {
                Console.WriteLine($"Simple interest rate: {myMoneySimple:F2} lv.");
                Console.WriteLine($"Complex interest rate: {myMoneyComplex:F2} lv.");
                Console.WriteLine($"Choose a simple interest rate. You will win {myMoneySimple - myMoneyComplex:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Simple interest rate: {myMoneySimple:F2} lv.");
                Console.WriteLine($"Complex interest rate: {myMoneyComplex:F2} lv.");
                Console.WriteLine($"Choose a complex interest rate. You will win {myMoneyComplex - myMoneySimple:F2} lv.");
            }
        }
    }
}
