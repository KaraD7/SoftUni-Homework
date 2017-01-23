using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double counts = double.Parse(Console.ReadLine());
            int sum199 = 0;
            int sum399 = 0;
            int sum599 = 0;
            int sum799 = 0;
            int sum800 = 0;

            for (int i = 1; i <= counts; i++)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (number >=1 && number < 200)
                {
                    sum199++;
                }

                if (number >= 200 && number <= 399)
                {
                    sum399++;
                }
                if (number >= 400 && number <= 599)
                {
                    sum599 ++;
                }
                if (number >= 600 && number <= 799)
                {
                    sum799 ++;
                }
                if (number >= 800 && number <= 1000)
                {
                    sum800 ++;
                }
            }

            Console.WriteLine("{0:f2}%", ((sum199 / counts) * 100));
            Console.WriteLine("{0:f2}%", ((sum399 / counts) * 100));
            Console.WriteLine("{0:f2}%", ((sum599 / counts) * 100));
            Console.WriteLine("{0:f2}%", ((sum799 / counts) * 100));
            Console.WriteLine("{0:f2}%", ((sum800 / counts) * 100));

        }
    }
}
