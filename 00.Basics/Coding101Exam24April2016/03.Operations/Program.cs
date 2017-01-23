using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var operators = Console.ReadLine();

            if (operators == "+")
            {
                var plus = n1 + n2;
                if (plus % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", n1, n2, plus);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, plus);
                }
            }
            else if (operators == "-")
            {
                var minus = n1 - n2;
                if (minus % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", n1, n2, minus);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, minus);
                }
            }
            else if (operators == "*")
            {
                var multiplication = n1 * n2;
                if (multiplication % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", n1, n2, multiplication);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, multiplication);
                }
            }
            else if (operators == "/" && n2>0)
            {

                var division = n1 / n2;
                Console.Write("{0} / {1} = ", n1, n2);
                Console.WriteLine("{0:f2}", division);
            }
            else if (operators == "%" && n2 > 0)
            {
                var modDiv = n1 % n2;
                Console.WriteLine("{0} % {1} = {2}", n1, n2, modDiv);
            }
            else if (operators == "%" || operators =="/" && n2 < 1)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
        }
    }
}
