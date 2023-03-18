using System;

namespace _3_flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hriz = double.Parse(Console.ReadLine());
            double rose = double.Parse(Console.ReadLine());
            double lale = double.Parse(Console.ReadLine());
            string seas = Console.ReadLine();
            string vacday = Console.ReadLine();
            double a = 0, b = 0, c = 0;


            double coef1 = 1;
            double coef2 = 1;
            double coef3 = 1;

            if (lale > 7 && seas == "Spring")
                coef1 = 0.95;
            if (rose >= 10 && seas == "Winter")
                coef2 = 0.90;
            if (hriz + rose + lale > 20)
                coef3 = 0.8;

            if (seas == "Spring" || seas == "Summer")
            { a = 2; b = 4.1; c = 2.5; }
            else { a = 3.75; b = 4.5; c = 4.15; }

            double sum = (a * hriz + b * rose + c * lale) * coef1 * coef2 * coef3 + 2;

            if (vacday == "Y")
                sum = (a * hriz + b * rose + c * lale) * coef1 * coef2 * coef3 * 1.15 + 2;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
