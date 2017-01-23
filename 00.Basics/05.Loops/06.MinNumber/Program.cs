using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var minValue = int.MaxValue;

            for (int i = 1; i <= count; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < minValue)
                {
                    minValue = number;
                }
            
            }
            Console.WriteLine("The smaller number is:" + minValue );
        }
    }
}
