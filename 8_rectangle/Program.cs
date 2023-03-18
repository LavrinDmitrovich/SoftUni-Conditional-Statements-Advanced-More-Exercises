using System;

namespace _8_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double xx = double.Parse(Console.ReadLine());
            double yy = double.Parse(Console.ReadLine());

            if ((yy == y1 || yy == y2) && (xx <= x2 && xx >= x1)) { Console.WriteLine("Border"); }
            else if ((xx == x1 || xx == x2) && (yy <= y2 && yy >= y1)) { Console.WriteLine("Border"); }
            else Console.WriteLine("Inside / Outside");
        }
    }
}
