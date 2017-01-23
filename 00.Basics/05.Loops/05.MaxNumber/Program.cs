using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = int.Parse(Console.ReadLine());
            var max = int.MinValue;

            for (var i = 0; i < number; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (max < num)
                {
                    max = num;
                }
            }

            Console.WriteLine(max);
        }
    }
}
