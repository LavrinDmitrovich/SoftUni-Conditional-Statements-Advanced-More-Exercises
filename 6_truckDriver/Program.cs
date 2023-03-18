using System;

namespace _6_truckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double tax = 0;
            double salary = 0;

            if (km > 10000 && km <= 20000)
            {
                tax = 1.45;
            }
            if (km > 5000 && km <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        tax = 0.95;
                        break;
                    case "Summer":
                        tax = 1.1;
                        break;
                    case "Winter":
                        tax = 1.25;
                        break;
                }
            }
            if (km <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        tax = 0.75;
                        break;
                    case "Summer":
                        tax = 0.9;
                        break;
                    case "Winter":
                        tax = 1.05;
                        break;
                }
            }
            salary = tax * km * 4 * 0.9;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
