using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCap = int.Parse(Console.ReadLine());
            int totalFans = int.Parse(Console.ReadLine());
            IDictionary<string, double> sectors = new Dictionary<string, double>
            {
                {"A", 0 },  {"B", 0 }, {"V", 0 }, {"G", 0 },
            };
            //string[] sectorNames = { "A", "B", "V", "G" };
            IList<string> places = new List <string>();
        
            
            for (int i = 0; i < totalFans; i++)
            {
                sectors[Console.ReadLine().ToUpper()]++;
                //places.Add(Console.ReadLine().ToUpper());
            

            }

            //foreach (var sector in sectorNames)
            //{
            //    double percent = (double) places.Count(a => a == sector)/totalFans*100;
            //    Console.WriteLine("{0:F2}%", percent);
            //}
            foreach (var item in sectors)
            {
                double percent = item.Value / totalFans * 100;
                Console.WriteLine("{0:F2}%", percent);
                
            }
           
            double totalPercent = (double) totalFans / stadiumCap * 100;
        
            Console.WriteLine("{0:F2}%", totalPercent);


        }
    }
}
