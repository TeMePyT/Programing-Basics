using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanovi_s_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine().ToLower();
            string transport = Console.ReadLine().ToLower();

            double transportPrice = 0.0;
            if (transport == "train")
            {
                transportPrice = 2 * 22.30 + 3 * 12.50;
            }
            else if (transport == "bus")
            {
                transportPrice = 2 * 45 + 3 * 37;
            }
            else if(transport=="airplane")
            {
                transportPrice = 2 * 90 + 3 * 68.50;
            }

            double hotelprice = 0.0;
            if (destination=="miami")
            {
                if(days<=10)
                {
                    hotelprice = (2 * 24.99 + 3 * 14.99) * days;
                }
                else if(days>=11 && days<=15)
                {
                    hotelprice = (2 * 22.99 + 3 * 11.99) * days;
                }
                else if(days>15)
                {
                    hotelprice = (2 * 20 + 3 * 10) * days;
                }
            }
            else if (destination == "canary islands")
            {
                if (days <= 10)
                {
                    hotelprice = (2 * 32.50 + 3 * 28.50) * days;
                }
                else if (days >= 11 && days <= 15)
                {
                    hotelprice = (2 * 30.50 + 3 * 25.60) * days;
                }
                else if (days > 15)
                {
                    hotelprice = (2 * 28 + 3 * 22) * days;
                }
            }
            else if (destination == "philippines")
            {
                if (days <= 10)
                {
                    hotelprice = (2 * 42.99 + 3 * 39.99) * days;
                }
                else if (days >= 11 && days <= 15)
                {
                    hotelprice = (2 * 41 + 3 * 36) * days;
                }
                else if (days > 15)
                {
                    hotelprice = (2 * 38.50 + 3 * 32.40) * days;
                }
            }
            double dogPrice = hotelprice * 0.25;
            double totalPrice = transportPrice + hotelprice + dogPrice;

            Console.WriteLine($"{totalPrice:F3}");
        }
    }
}
