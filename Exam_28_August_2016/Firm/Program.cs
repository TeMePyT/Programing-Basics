using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysForWork = int.Parse(Console.ReadLine());
            int workersOfftime = int.Parse(Console.ReadLine());

            double daysTraining = daysForWork - daysForWork * 0.1;
            double daysTrainingInHours = daysTraining * 8;
            double hoursOfftime = workersOfftime * (2*daysForWork);
            double totalHours = daysTrainingInHours + hoursOfftime;

            if (totalHours>=hoursNeeded)
            {
                Console.WriteLine($"Yes!{Math.Floor(totalHours)-hoursNeeded} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded-Math.Floor(totalHours)} hours needed.");
            }
        }
    }
}
