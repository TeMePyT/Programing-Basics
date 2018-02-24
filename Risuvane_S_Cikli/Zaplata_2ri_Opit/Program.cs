using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaplata_2ri_Opit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Salary = double.Parse(Console.ReadLine());
            int yearsWorked = int.Parse(Console.ReadLine());
            string sindicate = Console.ReadLine();

            double currentSalary = Salary;
            for (int i = 1; i <= yearsWorked; i++)
            {
                if (i % 5 == 0)
                {
                    currentSalary = currentSalary + (currentSalary * 0.06);
                    currentSalary += 100;

                }
                else if (i % 10 == 0)
                {
                    currentSalary = currentSalary + (currentSalary * 0.06);
                    currentSalary += 200;

                }
                else
                {
                    if (sindicate == "No")
                    {
                        currentSalary = currentSalary + (currentSalary * 0.06);
                    }
                    else
                    {
                        currentSalary = currentSalary + (currentSalary * 0.06) - (currentSalary * 0.01);
                    }
                }
                if (currentSalary >= 5000)
                {
                    Console.WriteLine("Current salary: 5000.00");
                    Console.WriteLine("0 more years to max salary.");
                    break;
                }
                if (i == yearsWorked)
                {
                    double currentSalaryToMax = currentSalary;
                    for (int j = i; j <= 45; j++)
                    {
                        int yearstomax = j - yearsWorked;

                        if (j % 5 == 0)
                        {
                            currentSalaryToMax = currentSalaryToMax + (currentSalaryToMax * 0.06);
                            currentSalaryToMax += 100;

                        }
                        else if (j % 10 == 0)
                        {
                            currentSalaryToMax = currentSalaryToMax + (currentSalaryToMax * 0.06);
                            currentSalaryToMax += 200;

                        }
                        else
                        {
                            if (sindicate == "No")
                            {
                                currentSalaryToMax = currentSalaryToMax + (currentSalaryToMax * 0.06);
                            }
                            else
                            {
                                currentSalaryToMax = currentSalaryToMax + (currentSalaryToMax * 0.06) - (currentSalaryToMax * 0.01);
                            }
                        }
                        if (currentSalaryToMax >= 5000)
                        {
                            Console.WriteLine($"Current salary: {currentSalary:F2}");
                            Console.WriteLine($"{yearstomax} more years to max salary.");
                            break;
                        }
                    }
                }
            }
        }
    }
}
