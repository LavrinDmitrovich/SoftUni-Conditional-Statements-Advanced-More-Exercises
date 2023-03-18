using System;

namespace _1_matchTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double persons = double.Parse(Console.ReadLine());
            double price = 0;
            double coef = 0.25;
            double avblWoutTran = 0;
            double haveToPayTick = 0;

            switch (type)
            {
                case "VIP":
                    price = 499.99;
                    break;

                case "Normal":
                    price = 249.99;
                    break;
            }

            if (persons >= 5 && persons <= 9)
            { coef = 0.4; }
            else if (persons >= 10 && persons <= 24)
            { coef = 0.5; }
            else if (persons >= 25 && persons <= 49)
            { coef = 0.6; }
            else if (persons >= 50)
            { coef = 0.75; }

            avblWoutTran = budget * coef;
            haveToPayTick = price * persons;

            if (avblWoutTran > haveToPayTick)
            { Console.WriteLine($"Yes! You have {(avblWoutTran - haveToPayTick):f2} leva left."); }
            else
            { Console.WriteLine($"Not enough money! You need {(haveToPayTick - avblWoutTran):f2} leva."); }

        }
    }
}
