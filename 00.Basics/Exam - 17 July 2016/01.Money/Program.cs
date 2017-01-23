using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {

            int bitcoin = int.Parse(Console.ReadLine());
            double uans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            var bitcoinToLev = 1168;
            var uanToLev = 0.15 * 1.76;
            var euroToLev = 1.95;

            var allCurrency = ((bitcoin * bitcoinToLev) + (uans * uanToLev)) / euroToLev;
            var resultWithCommision = allCurrency * (commission / 100);
            var result = allCurrency - resultWithCommision;

            Console.WriteLine(result);

        }
    }
}
