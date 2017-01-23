using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            var bonusScore2 = 0.0;


            if (number <= 100)
            {
                bonusScore = bonusScore + 5;
            }
            else if (number <= 1000)
            {
                bonusScore = number * 0.2;
            }
            else
            {
                bonusScore = number * 0.1;
            }

            if (number % 2 == 0)
            {
                bonusScore2 = 1;
            }
            else if (number % 5 == 0)
            {
                bonusScore2 = 2;
            }

            var result = bonusScore + bonusScore2;
            var secondResult = number + result;
            Console.WriteLine(result);
            Console.WriteLine(secondResult);

        }
    }
}
