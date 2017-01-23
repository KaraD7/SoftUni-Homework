using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {

            double juniors = double.Parse(Console.ReadLine());
            double seniors = double.Parse(Console.ReadLine());
            var trace = Console.ReadLine();

            double taxJuniors = 0.0;
            double taxSeniors = 0.0;

            if (trace == "trail")
            {
                taxJuniors = 5.5;
                taxSeniors = 7;
            }
            else if (trace == "cross-country")
            {
                taxJuniors = 8;
                taxSeniors = 9.5;
            }
            else if (trace == "downhill")
            {
                taxJuniors = 12.25;
                taxSeniors = 13.75;
            }
            else if (trace == "road")
            {
                taxJuniors = 20;
                taxSeniors = 21.5;
                
            }

            if (juniors + seniors >= 50 && trace == "cross-country")
            {
                var sum = (taxJuniors * juniors) + (taxSeniors * seniors);
                var sum25Cross = sum * 0.25;
                var result = sum - sum25Cross;
                var sumWithR = result * 0.05;
                var resultEnd = result - sumWithR;

                Console.WriteLine("{0:f2}", resultEnd);
            }
            else
            {
            var sum = (taxJuniors*juniors) + (taxSeniors*seniors);
            var sumWithR = sum * 0.05;
            var resultEnd = sum - sumWithR;

            Console.WriteLine("{0:f2}", resultEnd);  
            }

            
        }
    }
}
