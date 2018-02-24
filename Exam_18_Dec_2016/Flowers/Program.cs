using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {

            int hrizantemi = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string weekend = Console.ReadLine().ToLower();

            double hrizantemiSpringPrice = hrizantemi * 2.00;
            double rosesSpringPrice = roses * 4.10;
            double tulipsSpringPrice = tulips * 2.50;
            double hrizantemiWinterPrice = hrizantemi * 3.75;
            double rosesWinterPrice = roses * 4.50;
            double tulipsWinterPrice = tulips * 4.15;
            double totalflowers = hrizantemi + tulips + roses;
            double totalPrice = 0.0;
            

            if (season == "spring" || season == "summer")
            {
                 totalPrice = hrizantemiSpringPrice + rosesSpringPrice + tulipsSpringPrice;
                if (weekend == "y")
                {
                    totalPrice = totalPrice + (totalPrice * 0.15);
                
                    if (tulips>=7 && season =="spring")
                    {
                        totalPrice = totalPrice - (totalPrice * 0.05);
                        if (totalflowers>=20)
                        {
                            totalPrice = totalPrice - (totalPrice * 0.20);
                        }
                        
                    }
                    else
                    {
                       
                       
                        if (totalflowers >= 20)
                        {
                            totalPrice = totalPrice - (totalPrice * 0.20);
                        }
                        
                    }
                }
                else
                {
                    
                    if (tulips >= 7 && season == "spring")
                    {
                        totalPrice = totalPrice - (totalPrice * 0.05);
                        if (totalflowers >= 20)
                        {
                            totalPrice = totalPrice - (totalPrice * 0.20);
                        }
                        
                    }
                    else
                    {
                        
                        if (totalflowers >= 20)
                        {
                            totalPrice = totalPrice - (totalPrice * 0.20);
                        }
                        
                    }
                }
            }
            else if(season == "autumn" || season=="winter")
            {
                totalPrice= hrizantemiWinterPrice + rosesWinterPrice + tulipsWinterPrice;
                if (weekend == "y")
                {
                    totalPrice = totalPrice + (totalPrice * 0.15);
                    if (roses>=10 && season == "winter")
                    {
                        totalPrice = totalPrice - (totalPrice * 0.10);
                        if (totalflowers >= 20)
                        {
                            totalPrice = totalPrice - (totalPrice * 0.20);
                        }
                        
                    }
                    else
                    {
                       
                        if (totalflowers >= 20)
                        {
                            totalPrice = totalPrice - (totalPrice * 0.20);
                        }
                        
                    }
                }
                else
                {
                    
                    if (roses >= 10 && season == "winter")
                    {
                        totalPrice = totalPrice - (totalPrice * 0.10);
                        if (totalflowers >= 20)
                        {
                            totalPrice = totalPrice - (totalPrice * 0.20);
                        }
                        
                    }
                    else
                    {

                        if (totalflowers >= 20)
                        {
                            totalPrice = totalPrice - (totalPrice * 0.20);
                        }

                    }

                }
            }
            Console.WriteLine($"{totalPrice+2:F2}");
        }
    }
}
