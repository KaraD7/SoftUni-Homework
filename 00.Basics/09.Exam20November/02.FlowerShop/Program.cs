using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double magnoliiPrice = 3.25 * magnolii;
            double zumbuliPrice = 4.00*zumbuli;
            double roziPrice = 3.50*rozi;
            double kaktusiPrice = 8.00*kaktusi;

            double sum = magnoliiPrice + zumbuliPrice + roziPrice + kaktusiPrice;
            double sumPlusPercent = sum * 0.05;
            double result = sum - sumPlusPercent;

            if (price > result)
            {
                var notEnough = Math.Ceiling(price - result);
                Console.WriteLine("She will have to borrow {0} leva.",notEnough);
            }
            else if (price <= result)
            {
                var enough = Math.Truncate(result - price);
                Console.WriteLine("She is left with {0} leva.", enough);
            }

        }
    }
}
