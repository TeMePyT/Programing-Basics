using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)



        {
            int trainingDays = int.Parse(Console.ReadLine());
            double firstDayKm = double.Parse(Console.ReadLine());
            double percentsIncr = 0.0;
            double kmTotal = firstDayKm;
            double kmToday = firstDayKm;
            for (int i = 0; i < trainingDays; i++)
            {
                percentsIncr = double.Parse(Console.ReadLine()) / 100;
                kmToday = kmToday+kmToday*percentsIncr;
                kmTotal += kmToday;
            }
            if (kmTotal >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(kmTotal - 1000)} more kilometers! ");
            }
            else if (kmTotal < 1000)
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - kmTotal)} more kilometers");
            }
        }
    }
}
