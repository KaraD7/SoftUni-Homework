using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.DivisionWithoutRest
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers%2==0)
                {
                    p1++;
                }
                if(numbers%3==0)
                {
                    p2++;
                }
                if(numbers%4==0)
                {
                    p3++;
                }
            }
            double resultP1 = (p1 / n)*100;
            double resultP2 = (p2 / n)*100;
            double resultP3 = (p3 / n)*100;

            Console.WriteLine("{0:f2}%", resultP1);
            Console.WriteLine("{0:f2}%", resultP2);
            Console.WriteLine("{0:f2}%", resultP3);
        }
    }
}
