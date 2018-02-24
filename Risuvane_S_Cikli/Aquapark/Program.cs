using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int hours = int.Parse(Console.ReadLine());
            int visitors = int.Parse(Console.ReadLine());
            string time = Console.ReadLine().ToLower();

            double discountPerPerson = 0.1;
            double discountPerHour = 0.5;

            double PricePerPerson = 0.0;
            

            if (time=="day")
            {
                if(visitors>=4)
                {
                    if (hours>=5)
                    {
                        if (month=="march" || month == "april" || month == "may")
                        {
                            PricePerPerson = (10.50 - (10.50 * discountPerPerson))*discountPerHour ;
                        }
                        else if(month == "june" || month == "july"|| month == "august")
                        {
                            PricePerPerson = (12.60 - (12.60 * discountPerPerson)) * discountPerHour ;
                        }
                    }
                    else
                    {
                        if (month == "march" || month == "april" || month == "may")
                        {
                            PricePerPerson = 10.50  - (10.50  * discountPerPerson);
                        }
                        else if (month == "june" || month == "july" || month == "august")
                        {
                            PricePerPerson = 12.60   - (12.60 * discountPerPerson);
                        }
                    }
                }
                else
                {
                    if (month == "march" || month == "april" || month == "may")
                    {
                        PricePerPerson = 10.50 ;
                    }
                    else if (month == "june" || month == "july" || month == "august")
                    {
                        PricePerPerson = 12.60 ;
                    }
                }
            }
            else if (time == "night")
            {
                if (visitors >= 4)
                {
                    if (hours >= 5)
                    {
                        if (month == "march" || month == "april" || month == "may")
                        {
                            PricePerPerson = (8.4  - (8.4 * discountPerPerson))* discountPerHour ;
                        }
                        else if (month == "june" || month == "july" || month == "august")
                        {
                            PricePerPerson = (10.20 - (10.20 * discountPerPerson)) * discountPerHour;
                        }
                    }
                    else
                    {
                        if (month == "march" || month == "april" || month == "may")
                        {
                            PricePerPerson = 8.4  -( 8.4  * discountPerPerson);
                        }
                        else if (month == "june" || month == "july" || month == "august")
                        {
                            PricePerPerson = 10.20  - (10.20 * discountPerPerson);
                        }
                    }
                }
                else
                {
                    if (month == "march" || month == "april" || month == "may")
                    {
                        PricePerPerson = 8.4 ;
                    }
                    else if (month == "june" || month == "july" || month == "august")
                    {
                        PricePerPerson = 10.20;
                    }
                }
            }
            double totalCost = (PricePerPerson * visitors)*hours;

            Console.WriteLine($"Price per person for one hour: {PricePerPerson:F2}") ;
            Console.WriteLine($"Total cost of the visit: {totalCost:F2}");
        }
    }
}
