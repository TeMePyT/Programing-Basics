using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int unTreatedPatients = 0;
            int doctors = 7;

            for (int i = 1; i <= workDays; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && unTreatedPatients > treatedPatients)
                {
                    doctors++;
                }
                if (patients <= doctors)
                {
                    treatedPatients += patients;
                }
                else
                {
                    treatedPatients += doctors;
                    unTreatedPatients += patients - doctors;
                }
                
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {unTreatedPatients}.");
        }
    }
}
