using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {

            string season = Console.ReadLine();
            string typeOfStudents = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int numOvernights = int.Parse(Console.ReadLine());

            string sport = null;
            double priceOvernight = 0.0;


            if (season == "Winter")
            {
                if (typeOfStudents == "boys")
                {
                    sport = "Judo";
                    if (numStudents >= 50)
                    {
                        priceOvernight = 9.60 * numStudents * numOvernights - (9.60 * numStudents * numOvernights * 0.5);
                    }
                    else if (numStudents >= 20 && numStudents < 50)
                    {
                        priceOvernight = 9.60 * numStudents * numOvernights - (9.60 * numStudents * numOvernights * 0.15);
                    }
                    else if (numStudents >= 10 && numStudents < 20)
                    {
                        priceOvernight = 9.60 * numStudents * numOvernights - (9.60 * numStudents * numOvernights * 0.05);
                    }
                    else if (numStudents < 10)
                    {
                        priceOvernight = 9.60 * numStudents * numOvernights;
                    }
                }
                else if (typeOfStudents == "girls")
                {
                    sport = "Gymnastics";
                    if (numStudents >= 50)
                    {
                        priceOvernight = 9.60 * numStudents * numOvernights - (9.60 * numStudents * numOvernights * 0.5);
                    }
                    else if (numStudents >= 20 && numStudents < 50)
                    {
                        priceOvernight = 9.60 * numStudents * numOvernights - (9.60 * numStudents * numOvernights * 0.15);
                    }
                    else if (numStudents >= 10 && numStudents < 20)
                    {
                        priceOvernight = 9.60 * numStudents * numOvernights - (9.60 * numStudents * numOvernights * 0.05);
                    }
                    else if (numStudents < 10)
                    {
                        priceOvernight = 9.60 * numStudents * numOvernights;
                    }
                }
                else if (typeOfStudents == "mixed")
                {
                    sport = "Ski";
                    if (numStudents >= 50)
                    {
                        priceOvernight = 10 * numStudents * numOvernights - (10 * numStudents * numOvernights * 0.5);
                    }
                    else if (numStudents >= 20 && numStudents < 50)
                    {
                        priceOvernight = 10 * numStudents * numOvernights - (10 * numStudents * numOvernights * 0.15);
                    }
                    else if (numStudents >= 10 && numStudents < 20)
                    {
                        priceOvernight = 10 * numStudents * numOvernights - (10 * numStudents * numOvernights * 0.05);
                    }
                    else if (numStudents < 10)
                    {
                        priceOvernight = 10 * numStudents * numOvernights;
                    }
                }
            }
            if (season == "Spring")
            {
                if (typeOfStudents == "boys")
                {
                    sport = "Tennis";
                    if (numStudents >= 50)
                    {
                        priceOvernight = 7.20 * numStudents * numOvernights - (7.20 * numStudents * numOvernights * 0.5);
                    }
                    else if (numStudents >= 20 && numStudents < 50)
                    {
                        priceOvernight = 7.20 * numStudents * numOvernights - (7.20 * numStudents * numOvernights * 0.15);
                    }
                    else if (numStudents >= 10 && numStudents < 20)
                    {
                        priceOvernight = 7.20 * numStudents * numOvernights - (7.20 * numStudents * numOvernights * 0.05);
                    }
                    else if (numStudents < 10)
                    {
                        priceOvernight = 7.20 * numStudents * numOvernights;
                    }
                }
                else if (typeOfStudents == "girls")
                {
                    sport = "Athletics";
                    if (numStudents >= 50)
                    {
                        priceOvernight = 7.20 * numStudents * numOvernights - (7.20 * numStudents * numOvernights * 0.5);
                    }
                    else if (numStudents >= 20 && numStudents < 50)
                    {
                        priceOvernight = 7.20 * numStudents * numOvernights - (7.20 * numStudents * numOvernights * 0.15);
                    }
                    else if (numStudents >= 10 && numStudents < 20)
                    {
                        priceOvernight = 7.20 * numStudents * numOvernights - (7.20 * numStudents * numOvernights * 0.05);
                    }
                    else if (numStudents < 10)
                    {
                        priceOvernight = 7.20 * numStudents * numOvernights;
                    }
                }
                else if (typeOfStudents == "mixed")
                {
                    sport = "Cycling";
                    if (numStudents >= 50)
                    {
                        priceOvernight = 9.50 * numStudents * numOvernights - (9.50 * numStudents * numOvernights * 0.5);
                    }
                    else if (numStudents >= 20 && numStudents < 50)
                    {
                        priceOvernight = 9.50 * numStudents * numOvernights - (9.50 * numStudents * numOvernights * 0.15);
                    }
                    else if (numStudents >= 10 && numStudents < 20)
                    {
                        priceOvernight = 9.50 * numStudents * numOvernights - (9.50 * numStudents * numOvernights * 0.05);
                    }
                    else if (numStudents < 10)
                    {
                        priceOvernight = 9.50 * numStudents * numOvernights;
                    }
                }
            }
            if (season == "Summer")
            {
                if (typeOfStudents == "boys")
                {
                    sport = "Football";
                    if (numStudents >= 50)
                    {
                        priceOvernight = 15 * numStudents * numOvernights - (15 * numStudents * numOvernights * 0.5);
                    }
                    else if (numStudents >= 20 && numStudents < 50)
                    {
                        priceOvernight = 15 * numStudents * numOvernights - (15 * numStudents * numOvernights * 0.15);
                    }
                    else if (numStudents >= 10 && numStudents < 20)
                    {
                        priceOvernight = 15 * numStudents * numOvernights - (15 * numStudents * numOvernights * 0.05);
                    }
                    else if (numStudents < 10)
                    {
                        priceOvernight = 15 * numStudents * numOvernights;
                    }
                }
                else if (typeOfStudents == "girls")
                {
                    sport = "Volleyball";
                    if (numStudents >= 50)
                    {
                        priceOvernight = 15 * numStudents * numOvernights - (15 * numStudents * numOvernights * 0.5);
                    }
                    else if (numStudents >= 20 && numStudents < 50)
                    {
                        priceOvernight = 15 * numStudents * numOvernights - (15 * numStudents * numOvernights * 0.15);
                    }
                    else if (numStudents >= 10 && numStudents < 20)
                    {
                        priceOvernight = 15 * numStudents * numOvernights - (15 * numStudents * numOvernights * 0.05);
                    }
                    else if (numStudents < 10)
                    {
                        priceOvernight = 15 * numStudents * numOvernights;
                    }
                }
                else if (typeOfStudents == "mixed")
                {
                    sport = "Swimming";
                    if (numStudents >= 50)
                    {
                        priceOvernight = 20 * numStudents * numOvernights - (20 * numStudents * numOvernights * 0.5);
                    }
                    else if (numStudents >= 20 && numStudents < 50)
                    {
                        priceOvernight = 20 * numStudents * numOvernights - (20 * numStudents * numOvernights * 0.15);
                    }
                    else if (numStudents >= 10 && numStudents < 20)
                    {
                        priceOvernight = 20 * numStudents * numOvernights - (20 * numStudents * numOvernights * 0.05);
                    }
                    else if (numStudents < 10)
                    {
                        priceOvernight = 20 * numStudents * numOvernights;
                    }
                }
            }

            Console.WriteLine("{0} {1:F2} lv.", sport, priceOvernight);

        }
    }
}
