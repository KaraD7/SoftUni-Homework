using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BackToPast
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double yearEven = 0;
            double yearOdd = 0;
            double sumEven = 0;
            double sumOdd = 0;

            for (int i = 1800; i <= year; i++)
            {


                if (year % 2 == 0)
                {
                    yearEven = 12000;
                    sumEven = heritage - yearEven;


                }
                else
                {
                    yearOdd = 12000 + (50*);
                    sumOdd = 

                }

                double result = heritage - year;
                Console.WriteLine(result);
            }
        }
    }
}
