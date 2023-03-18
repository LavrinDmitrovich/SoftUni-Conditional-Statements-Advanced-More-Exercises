using System;

namespace _10_multiByTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            while ((a = double.Parse(Console.ReadLine())) >= 0)
            {
                if (a < 0) break;
                Console.WriteLine($"Result: {a*2:f2}");
            }
            Console.WriteLine("Negative number!");
        }
    }
}
