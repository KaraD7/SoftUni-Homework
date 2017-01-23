using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dayNight = Console.ReadLine();

            var taxiD = 0.70 + (0.79 * n);
            var taxiN = 0.70 + (0.90 * n);
            var bus = n * 0.09;
            var train = n * 0.06;


            if (n < 20)
            {
                if (dayNight=="day")
                {
                    Console.WriteLine(taxiD);

                }
                else if(dayNight=="night")
                {
                    Console.WriteLine(taxiN);
                }
               
            }
            else if (n>=20 && n<100)
            {
                Console.WriteLine(bus);
            }
            else if (n>=100 && n<=5000)
            {
                Console.WriteLine(Math.Min(train,bus));
            }
             
        }
    }
}
