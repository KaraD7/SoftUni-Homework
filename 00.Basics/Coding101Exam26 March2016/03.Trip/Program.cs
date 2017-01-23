using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (budget<=100)
            {
                if (season=="summer")
                {
                    double summerPercent = ((budget/100)*30);
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}",(summerPercent));

                }
                else if(season == "winter")
                {
                    double winterPercent = ((budget / 100) * 70);
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", (winterPercent));
                }
            }
            else if (budget<=1000)
            {
                if (season == "summer")
                {
                    double summerPercent = ((budget / 100) * 40);
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}",(summerPercent));

                }
                else if (season == "winter")
                {
                    double winterPercent = ((budget / 100) * 80);
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}",(winterPercent));
                }

            }
            else if (budget>1000)
            {
                double budgetPercent = ((budget / 100) * 90);
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}",(budgetPercent));
            }


        }
    }
}
