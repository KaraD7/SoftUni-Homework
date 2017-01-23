using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number >=200 && number <=399)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }

            }

            var p1Result = ((p1 / n) * 100);
            var p2Result = (p2 / n) * 100;
            var p3Result = ((p3 / n) * 100);
            var p4Result = ((p4 / n) * 100);
            var p5Result = ((p5 / n) * 100);

            Console.WriteLine("{0:f2} %", p1Result);
            Console.WriteLine("{0:f2} %", p2Result);
            Console.WriteLine("{0:f2} %", p3Result);
            Console.WriteLine("{0:f2} %", p4Result);
            Console.WriteLine("{0:f2} %", p5Result);
        }
    }
}
