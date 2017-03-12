using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal sumNumbers = 0;
            for (int i = 1; i <= count; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sumNumbers += number;
            }
            Console.WriteLine(sumNumbers);
        }
    }
}
