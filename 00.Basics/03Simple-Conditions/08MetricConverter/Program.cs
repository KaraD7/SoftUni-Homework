using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();

            if (from == "mm")
            {
                number = number / 1000;
            }
            else if (from == "cm")
            {
                number = number / 100;
            }
            else if (from == "mi")
            {
                number = number / 0.000621371192;
            }
            else if (from == "in")
            {
                number = number / 39.3700787;
            }
            else if (from == "km")
            {
                number = number / 0.001;
            }
            else if (from == "ft")
            {
                number = number / 3.2808399;
            }
            else if (from == "yd")
            {
                number = number / 1.0936133;
            }
            if (to == "mm")
            {
                number = number * 1000;
            }
            else if (to == "cm")
            {
                number = number * 100;
            }
            else if (to == "mi")
            {
                number = number * 0.000621371192;
            }
            else if (to == "in")
            {
                number = number * 39.3700787;
            }
            else if (to == "km")
            {
                number = number * 0.001;
            }
            else if (to == "ft")
            {
                number = number * 3.2808399;
            }
            else if (to == "yd")
            {
                number = number * 1.0936133;
            }
            Console.WriteLine("{0} {1}",number,to);
        }
    }
}
