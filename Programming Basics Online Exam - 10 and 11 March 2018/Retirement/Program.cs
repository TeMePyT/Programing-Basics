using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int service = int.Parse(Console.ReadLine());

            if(sex=="male")
            {
                if(age >= 64 && service >= 38)
                {
                    Console.WriteLine($"Ready to retire at {age} and {service} years of experience!");
                }
                else if (age < 64 && service >= 38)
                {
                    Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {64 - age}.");
                }
                else if (age >= 64 && service < 38)
                {
                    Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {38 - service}.");
                }
                else if(age<64&&service<38)
                {
                    Console.WriteLine($"Too early. Years left to retirement: {64-age}. Work experience left to retirement: {38-service}.");
                }
            }
            else if(sex=="female")
            {
                if (age >= 61 && service >= 35)
                {
                    Console.WriteLine($"Ready to retire at {age} and {service} years of experience!");
                }
                else if (age < 61 && service >= 35)
                {
                    Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {61 - age}.");
                }
                else if (age >= 61 && service < 35)
                {
                    Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {35 - service}.");
                }
                else if (age < 61 && service < 35)
                {
                    Console.WriteLine($"Too early. Years left to retirement: {61 - age}. Work experience left to retirement: {35 - service}.");
                }
            }
            else if(sex!="male"||sex!="female")
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
