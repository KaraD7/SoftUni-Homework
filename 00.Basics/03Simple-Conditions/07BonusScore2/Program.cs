using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07BonusScore2
{
    class Program
    {
        static void Main(string[] args)
        {
            var racer1 = int.Parse(Console.ReadLine());
            var racer2 = int.Parse(Console.ReadLine());
            var racer3 = int.Parse(Console.ReadLine());
            var allRacers = racer1 + racer2 + racer3;

            var minutes = allRacers / 60;
            var seconds = allRacers % 60;

            if (seconds > 9)
            {
                Console.WriteLine(minutes+":"+seconds);
            }
            else
            {
                Console.WriteLine(minutes+":0"+seconds);
            }
        }
    }
}
