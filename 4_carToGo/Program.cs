using System;

namespace _4_carToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seasone = Console.ReadLine();

            string place = String.Empty;
            double coef1 = 1;
            double coef2 = 1;

            if (budget <= 100)
            {
                place = "Economy class";
                coef1 = 0.35;
                coef2 = 0.65;
            }
            else if (budget > 100 && budget <= 500)
            {
                place = "Compact class";
                coef1 = 0.45;
                coef2 = 0.80;
            }
            else
            {
                place = "Luxury class";
                coef1 = 0.9;
                coef2 = 0.9;
            }


            if (seasone == "Winter" || place == "Luxury class")
            {
                double price = budget * coef2;
                Console.WriteLine(place);
                Console.WriteLine($"Jeep - {price:f2}");
            }

            else
            {
                {
                    double price = budget * coef1;
                    Console.WriteLine(place);
                    Console.WriteLine($"Cabrio - {price:f2}");
                }
            }
        }
    }
}
