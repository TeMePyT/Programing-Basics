using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double Top = 0;
            double fourToFive = 0;
            double threeToFour = 0;
            double failers = 0;
            double average = 0;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                average += grade;
                if (grade >=5)
                {
                    Top++;
                }
                else if(grade>=4 && grade <= 4.99)
                {
                    fourToFive++;
                }
                else if(grade>=3 && grade<=3.99)
                {
                    threeToFour++;
                }
                else
                {
                    failers++;
                }
            }
            Console.WriteLine("Top students: {0:F2}%",( Top / students )* 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%",( fourToFive / students )* 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", (threeToFour / students )* 100);
            Console.WriteLine("Fail: {0:F2}%", (failers / students) * 100);
            Console.WriteLine("Average: {0:F2}", average / students);
        }
    }
}
