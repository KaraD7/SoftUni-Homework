using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var minutes15 = minutes + 15;


            if (minutes15 <= 59)
            {
                minutes = minutes15;
            }
            else if (minutes15 > 59 && hours < 23)
            {
                hours = hours + 1;
                minutes = minutes15 - 60;
            }
            else if (minutes15 >= 59 && hours <= 23)
            {
                hours = hours - 23;
                minutes = minutes15 - 60;
            }

            if (minutes >= 10)
            {
                Console.WriteLine(hours + ":" + minutes);
            }
            else if (minutes < 10)
            {
                Console.WriteLine(hours + ":0" + minutes);
            }
            //var totalMin = minutes + 15;
            //var totalHour = hour + totalMin / 60;
            //var minutesAfterHour = totalMin % 60;
            //
            //if (totalHour == 24)
            //{
            //    Console.WriteLine("0:{0:00}", minutesAfterHour);
            //}
            //else
            //{
            //    Console.WriteLine("{0:0}:{1:00}", totalHour, minutesAfterHour);
            //}
        }
    }
}