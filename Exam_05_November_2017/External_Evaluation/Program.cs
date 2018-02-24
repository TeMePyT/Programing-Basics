using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double poorMark = 0;
            double satisfactoryMark = 0;
            double goodMark = 0;
            double veryGoodMark = 0;
            double excellentMark = 0;

            for (int i = 0; i < students; i++)
            {
                double score = double.Parse(Console.ReadLine());

                if (score >= 0 && score <= 22.5)
                {
                    poorMark++;
                }
                else if (score > 22.5 && score <= 40.5)
                {
                    satisfactoryMark++;
                }
                else if (score > 40.5 && score <= 58.5)
                {
                    goodMark++;
                }
                else if (score > 58.5 && score <= 76.5)
                {
                    veryGoodMark++;
                }
                else if (score > 76.5 && score <= 100)
                {
                    excellentMark++;
                }
            }
            Console.WriteLine($"{((poorMark / students) * 100):F2}% poor marks");
            Console.WriteLine($"{(satisfactoryMark / students) * 100:F2}% satisfactory marks");
            Console.WriteLine($"{(goodMark / students) * 100:F2}% good marks");
            Console.WriteLine($"{(veryGoodMark / students) * 100:F2}% very good marks");
            Console.WriteLine($"{(excellentMark / students) * 100:F2}% excellent marks");

        }
    }
}
