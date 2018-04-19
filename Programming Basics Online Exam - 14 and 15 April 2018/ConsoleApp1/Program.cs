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
            short gpuPrice = short.Parse(Console.ReadLine());
            sbyte adapterPrice = sbyte.Parse(Console.ReadLine());
            double electricityPrice = double.Parse(Console.ReadLine());
            double grossIncomePerGpu = double.Parse(Console.ReadLine());

            double totalGpuPrice = gpuPrice * 13;
            double totalAdapterPrice = adapterPrice * 13;
            double totalSpent = totalAdapterPrice + totalGpuPrice + 1000;

            double netIncomePerGPU = grossIncomePerGpu - electricityPrice;
            double totalNetIncPerGPU = netIncomePerGPU * 13;

            double daysToPayback = Math.Ceiling(totalSpent / totalNetIncPerGPU);

            Console.WriteLine(totalSpent);
            Console.WriteLine(daysToPayback);
        }
    }
}
