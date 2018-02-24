using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double dailyMoney = double.Parse(Console.ReadLine());
            double usdCourse = double.Parse(Console.ReadLine());

            double monthSalary = workDays * dailyMoney;
            double yearSalary = monthSalary * 12 + monthSalary * 2.5;
            double taxedSalary = yearSalary - yearSalary * 0.25;
            double salaryInLeva = taxedSalary * usdCourse;
            double dailyYearProfit = salaryInLeva / 365;

            Console.WriteLine($"{dailyYearProfit:F2}");
        }
    }
}
