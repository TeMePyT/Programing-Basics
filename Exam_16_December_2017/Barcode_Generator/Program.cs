using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int firstNum1 = (num1 / 1000) % 10;
            int secondNum1 = (num1 / 100) % 10;
            int thirdNum1 = (num1 / 10) % 10;
            int fourthNum1 = num1 % 10;

            int firstNum2 = (num2 / 1000) % 10;
            int secondNum2 = (num2 / 100) % 10;
            int thirdNum2 = (num2 / 10) % 10;
            int fourthNum2 = num2 % 10;

            StringBuilder barcodes = new StringBuilder();

            for (int i = firstNum1; i <= firstNum2; i++)
            {
                for (int j = secondNum1; j <= secondNum2; j++)
                {
                    for (int k = thirdNum1; k <= thirdNum2; k++)
                    {
                        for (int l = fourthNum1; l <= fourthNum2; l++)
                        {
                            if(i%2!=0 && j%2!=0 && k%2!=0 && l%2!=0)
                            {
                                barcodes.Append(i);
                                barcodes.Append(j);
                                barcodes.Append(k);
                                barcodes.Append(l);
                                barcodes.Append(' ');
                            }
                        }
                    }
                }
            }
            Console.WriteLine(barcodes);
        }
    }
}
