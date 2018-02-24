using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santa_s_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysVacation = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string evaluation = Console.ReadLine();

            int nightsVacation = daysVacation - 1;

            double singlePersonRoomPrice = nightsVacation * 18.00;
            double appartmentPrice = nightsVacation * 25.00;
            double presidentAppartmPrice = nightsVacation * 35.00;

            if (daysVacation < 10)
            {
                appartmentPrice = appartmentPrice - appartmentPrice * 0.30;
                presidentAppartmPrice = presidentAppartmPrice - presidentAppartmPrice * 0.1;
            }
            else if (daysVacation >= 10 && daysVacation <= 15)
            {
                appartmentPrice = appartmentPrice - appartmentPrice * 0.35;
                presidentAppartmPrice = presidentAppartmPrice - presidentAppartmPrice * 0.15;
            }
            else if (daysVacation > 15)
            {
                appartmentPrice = appartmentPrice - appartmentPrice * 0.5;
                presidentAppartmPrice = presidentAppartmPrice - presidentAppartmPrice * 0.2;
            }
            if(evaluation=="negative")
            {
                singlePersonRoomPrice -= singlePersonRoomPrice * 0.1;
                appartmentPrice -= appartmentPrice * 0.1;
                presidentAppartmPrice -= presidentAppartmPrice * 0.1;
            }
            else if(evaluation=="positive")
            {
                singlePersonRoomPrice += singlePersonRoomPrice * 0.25;
                appartmentPrice += appartmentPrice * 0.25;
                presidentAppartmPrice += presidentAppartmPrice * 0.25;
            }

            if(room=="room for one person")
            {
                Console.WriteLine($"{singlePersonRoomPrice:F2}");
            }
            else if(room=="apartment")
            {
                Console.WriteLine($"{appartmentPrice:F2}");
            }
            else if(room=="president apartment")
            {
                Console.WriteLine($"{presidentAppartmPrice:F2}");
            }
        }
    }
}
