using System;

namespace _5_vacation
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

            if (budget <= 1000)
            {
                place = "Camp";
                coef1 = 0.65;
                coef2 = 0.45;
            }
            else if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                coef1 = 0.8;
                coef2 = 0.6;
            }
            else
            {
                place = "Hotel";
                coef1 = 0.9;
                coef2 = 0.9;
            }

            if (seasone == "Summer")
            {
                double price = budget * coef1;
                Console.WriteLine($"Alaska - {place} - {price:f2}");
            }
            if (seasone == "Winter")
            {
                double price = budget * coef2;
                Console.WriteLine($"Morocco - {place} - {price:f2}");
            }
        }
    }
}
