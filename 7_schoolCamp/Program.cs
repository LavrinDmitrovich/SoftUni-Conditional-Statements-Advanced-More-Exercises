using System;

namespace _7_schoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string gender = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double price = 0;
            string sport = string.Empty;
            double sum = 0;
            double koef = 1;

            switch (season)
            {
                case "Winter":
                    {
                        if (gender == "mixed")
                        {
                            price = 10;
                            sport = "Ski";
                        }

                        if (gender == "boys")
                        {
                            price = 9.6;
                            sport = "Judo";
                        }

                        if (gender == "girls")
                        {
                            price = 9.6;
                            sport = "Gymnastics";
                        }
                        break;
                    }
                case "Spring":
                    {
                        if (gender == "mixed")
                        {
                            price = 9.5;
                            sport = "Cycling";
                        }

                        if (gender == "boys")
                        {
                            price = 7.2;
                            sport = "Tennis";
                        }

                        if (gender == "girls")
                        {
                            price = 7.2;
                            sport = "Athletics";
                        }
                        break;
                    }
                case "Summer":
                    {
                        if (gender == "mixed")
                        {
                            price = 20;
                            sport = "Swimming";
                        }

                        if (gender == "boys")
                        {
                            price = 15;
                            sport = "Football";
                        }

                        if (gender == "girls")
                        {
                            price = 15;
                            sport = "Volleyball";
                        }
                        break;
                    }

            }
            if (qty >= 10 && qty < 20) { koef = 0.95; }
            if (qty >= 20 && qty < 50) { koef = 0.85; }
            if (qty >= 50) { koef = 0.5; }

            sum = qty * price * days * koef;
            Console.WriteLine($"{sport} {sum:f2} lv.");
        }
    }
}
