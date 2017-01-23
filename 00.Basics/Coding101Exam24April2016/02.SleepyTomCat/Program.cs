using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int offDays = int.Parse(Console.ReadLine());

            var workDays = 365 - offDays;
            var allYear = ((workDays * 63) + (offDays * 127));
            var normYear = 30000 - allYear;

            var hours = normYear / 60;
            var minutes = normYear % 60;

            if (allYear<=30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", Math.Abs(hours), Math.Abs(minutes) );
            }
            else if (allYear>30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs(hours),Math.Abs( minutes));
            }
        }
    }
}
