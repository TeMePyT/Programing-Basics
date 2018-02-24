using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_Eve_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double couvert = numberOfGuests * 20;
            

            if(couvert<=budget)
            {
                double moneyleft = budget - couvert;
                double fireworks = moneyleft * 0.4;
                double donation = moneyleft - fireworks;
                Console.WriteLine($"Yes! {fireworks:F0} lv are for fireworks and {donation:F0} lv are for donation. ");
            }
            else if(couvert>budget)
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {couvert-budget} lv more.");
            }
        }
    }
}
