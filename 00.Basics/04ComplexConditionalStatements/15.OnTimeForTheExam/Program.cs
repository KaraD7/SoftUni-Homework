using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var hourArrival = int.Parse(Console.ReadLine());
            var minuteArrival = int.Parse(Console.ReadLine());

            var start = (hour * 60) + minute;
            var arrival = (hourArrival * 60) + minuteArrival;
            var resultStart = start - arrival;
            var resultArrival = arrival - start;
            var resultLate = resultStart <= 59 && resultStart > 0 || resultStart >= 60;
            var resultOnTime = resultArrival == 0 || resultArrival <= 30 && resultArrival > 0;
            var resultEarly = resultArrival > 30 && resultArrival < 60 || resultArrival >= 60;

            if (resultLate)
            {
                Console.WriteLine("Late");
            }
            else if (re)
            {

            }

        }
    }
}
