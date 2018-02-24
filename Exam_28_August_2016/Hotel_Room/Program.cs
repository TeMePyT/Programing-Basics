using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyzrast_i_pol
{
    class Program
    {
        static void Main(string[] args)
        {

            var month = Console.ReadLine().ToLower();
            var days = int.Parse(Console.ReadLine());

            var priceStudio = 0.0;
            var priceAppartment = 0.0;
            {
                if (month == "may" || month == "october")
                {
                    priceStudio = days * 50;
                    priceAppartment = days * 65;
                }

                else if (month == "june" || month == "september")

                {
                    priceStudio = days * 75.20;
                    priceAppartment = days * 68.70;
                }

                else if (month == "july" || month == "august")

                {
                    priceStudio = days * 76;
                    priceAppartment = days * 77;
                }
            }

            var discountStudio = 0.0;

            {

                if ((days > 7 && days <= 14) && (month == "may" || month == "october"))

                {
                    discountStudio = priceStudio * 0.05;
                }

                else if (days > 14 && (month == "may" || month == "october"))

                {
                    discountStudio = priceStudio * 0.30;
                }

                else if (days > 14 && (month == "june" || month == "september"))

                {
                    discountStudio = priceStudio * 0.20;
                }
            }

            var discountAppartment = 0.0;

            {
                if (days > 14)

                {
                    discountAppartment = priceAppartment * 0.10;
                }
            }

            Console.WriteLine("Apartment: " + "{0:F2}" + " lv.", priceAppartment - discountAppartment);
            Console.WriteLine("Studio: " + "{0:F2}" + " lv.", priceStudio - discountStudio);


        }
    }
}