using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());

            int points = 0;
            int redPoints = 0;
            int orangePoints = 0;
            int yellowpoints = 0;
            int whitepoints = 0;
            int blackpoints = 0;
            int otherPoints = 0;

            for (int i = 0; i < balls; i++)
            {
                string color = Console.ReadLine();

                switch(color)
                {
                    case "red":
                        points += 5;
                        redPoints++;
                        break;
                    case "orange":
                        points += 10;
                        orangePoints++;
                        break;
                    case "yellow":
                        points += 15;
                        yellowpoints++;
                        break;
                    case "white":
                        points += 20;
                        whitepoints++;
                        break;
                    case "black":
                        points /= 2;
                        blackpoints++;
                        break;
                    default:
                        otherPoints++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {redPoints}");
            Console.WriteLine($"Points from orange balls: {orangePoints}");
            Console.WriteLine($"Points from yellow balls: {yellowpoints}");
            Console.WriteLine($"Points from white balls: {whitepoints}");
            Console.WriteLine($"Other colors picked: {otherPoints}");
            Console.WriteLine($"Divides from black balls: {blackpoints}");
        }
    }
}
