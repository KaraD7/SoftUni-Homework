using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            for (var i = 0; i < n ; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(sum);

        }
    }
}
