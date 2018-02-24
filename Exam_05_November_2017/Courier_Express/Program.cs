using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string deliveryType = Console.ReadLine().ToLower();
            int kilometers = int.Parse(Console.ReadLine());

            double deliveryPrice = 0.0;
            if(weight<1)
            {
                if(deliveryType=="standard")
                {
                    deliveryPrice = 0.03 * kilometers;
                }
                else if(deliveryType=="express")
                {
                    deliveryPrice= (0.03)*kilometers+(weight*(0.03*0.8)) * kilometers;
                }
            }
            else if(weight > 1 && weight <=10)
            {
                if (deliveryType == "standard")
                {
                    deliveryPrice = 0.05 * kilometers;
                }
                else if (deliveryType == "express")
                {
                    deliveryPrice = (0.05)*kilometers + (weight*(0.05 * 0.4)) * kilometers;
                }
            }
            else if (weight > 11 && weight <= 40)
            {
                if (deliveryType == "standard")
                {
                    deliveryPrice = 0.10 * kilometers;
                }
                else if (deliveryType == "express")
                {
                    deliveryPrice = (0.10)*kilometers + (weight*(0.10 * 0.05)) * kilometers;
                }
            }
            else if (weight > 41 && weight <= 90)
            {
                if (deliveryType == "standard")
                {
                    deliveryPrice = 0.15 * kilometers;
                }
                else if (deliveryType == "express")
                {
                    deliveryPrice = (0.15) * kilometers +(weight* (0.15 * 0.02)) * kilometers;
                }
            }
            else if (weight > 91 && weight <= 150)
            {
                if (deliveryType == "standard")
                {
                    deliveryPrice = 0.20 * kilometers;
                }
                else if (deliveryType == "express")
                {
                    deliveryPrice = (0.20)*kilometers + (weight*(0.20 * 0.01)) * kilometers;
                }
            }
            Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {deliveryPrice:F2} lv.");
        }
    }
}
