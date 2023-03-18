using System;

namespace _2_bikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double jun = int.Parse(Console.ReadLine());
            double sen = int.Parse(Console.ReadLine());
            string road = Console.ReadLine();
            double pers = jun + sen;

            double money = 0;
            double sum = 0;
            switch (road)
            {
                case "trail":
                    money = 5.5;
                    break;
                case "cross-country":
                    money = 8.0;
                    break;
                case "downhill":
                    money = 12.25;
                    break;
                case "road":
                    money = 20.0;
                    break;
            }

            if (road == "cross-country" && pers >= 50)
                sum = (money * jun + (money + 1.5) * sen) * 0.95 * 0.75;
            else
                sum = (money * jun + (money + 1.5) * sen) * 0.95;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
