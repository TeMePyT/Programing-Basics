using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourExam = int.Parse(Console.ReadLine());
            var minExam = int.Parse(Console.ReadLine());
            var hourArr = int.Parse(Console.ReadLine());
            var minArr = int.Parse(Console.ReadLine());

            var hourToMinExam = hourExam * 60;
            var hourToMinArr = hourArr * 60;
            var totalExam = hourToMinExam + minExam;
            var totalArr = hourToMinArr + minArr;
            var result = totalArr - totalExam;

            if (result>0)
            {
                if (result<60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", result);
                }
                else if(result>=60)
                {
                    var hour = result / 60;
                    var min = result % 60;
                    if (min<10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine("{0}:0{1} hours after the start", hour, min);
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine("{0}:{1} hours after the start", hour, min);
                    }
                    
                }
            }
            else if (result==0)
            {
                Console.WriteLine("On time");
            }
            else if (result<0)
            {
                var result1 = totalExam - totalArr;
                if (result1<=30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", result1);
                }
                else if (result1<=59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", result1);
                }
                else if(result1>=60)
                {
                    var hour1 = result1 / 60;

                    var min1 = result1 % 60;
                    if (min1<10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:0{1} hours before the start", hour1, min1);
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:{1} hours before the start", hour1, min1);
                    }
                   
                }
            }
            
        }
    }
}
