using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrainingLlab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            var peopleH = Math.Truncate((h * 100) / 120);
            var peopleW = Math.Truncate(((w * 100) - 100) / 70);

            var result = (peopleH * peopleW)-3;

            Console.WriteLine(result);
            


        }
    }
}
