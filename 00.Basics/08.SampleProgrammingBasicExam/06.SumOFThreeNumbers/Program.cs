using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOFThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int numberC = int.Parse(Console.ReadLine());


            if (numberA + numberB==numberC)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(numberA, numberB), Math.Max (numberA,numberB), numberC);
            }
            else if (numberB + numberC == numberA)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(numberB, numberC), Math.Max(numberB, numberC), numberA);
            }
            else if (numberA + numberC == numberB)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(numberA, numberC), Math.Max(numberA, numberC), numberB);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
