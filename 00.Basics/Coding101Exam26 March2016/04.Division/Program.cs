using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;


            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number%2==0)
                {
                    p1++;
                }
                if (number%3==0)
                {
                    p2++;
                }
                if (number%4==0)
                {
                    p3++;
                }
            }
            double p1Percent = ((p1 / count) * 100);
            double p2Percent = (p2 / count) * 100;
            double p3Percent = (p3 / count) * 100;

            Console.WriteLine("{0:f2}%",p1Percent);
            Console.WriteLine("{0:f2}%",p2Percent);
            Console.WriteLine("{0:f2}%",p3Percent);
        }
    }
}
