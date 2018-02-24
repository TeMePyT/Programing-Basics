using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            decimal washingPrice = decimal.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toys = 0;
            int money = 0;
            int m = 0;
            int n = 0;
            decimal totalMoney = 0;
            decimal change = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    m += 10;
                    money = money + m;
                    n++;
                }
                else
                {
                    toys++;
                }
            }
            totalMoney = (toys * toyPrice) + (money - n);
            if (washingPrice <= totalMoney)
            {
                change = totalMoney - washingPrice;
                Console.WriteLine("Yes! {0:F2}", change);
            }
            else
            {
                change = washingPrice - totalMoney;
                Console.WriteLine("No! {0:F2}", change);
            }
        }
    }
}
