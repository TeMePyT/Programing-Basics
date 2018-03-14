using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double gpuPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int ramPcs = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double cpuPriceLv = cpuPrice * 1.57;
            double gpuPriceLv = gpuPrice * 1.57;
            double ramPriceLv = (ramPrice * ramPcs) * 1.57;

            double cpuPriceDisc = cpuPriceLv - (cpuPriceLv * discount);
            double gpuPriceDisc = gpuPriceLv - (gpuPriceLv * discount);

            double totalSum = cpuPriceDisc + gpuPriceDisc + ramPriceLv;

            Console.WriteLine($"Money needed - {totalSum:F2} leva.");


        }
    }
}
