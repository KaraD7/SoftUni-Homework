using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourExam = double.Parse(Console.ReadLine());
            var minuteExam = double.Parse(Console.ReadLine());
            var hourArrive = double.Parse(Console.ReadLine());
            var minuteArrive = double.Parse(Console.ReadLine());

            var exam = hourExam * 60 + minuteExam;
            var arrive = hourArrive * 60 + minuteArrive;

            var difference = exam - arrive;

            if (difference<0)
            {
                Console.WriteLine("Late");
                if (difference >=-59)
                {
                    Console.WriteLine("{0} minutes after the start", Math.Abs(difference));
                }
                else if(difference <-59)
                {
                    var hourLate = Math.Truncate(Math.Abs(difference / 60));
                    var minuteLate = ( Math.Abs (difference) - (Math.Truncate(hourLate) * 60));
                    Console.WriteLine("{0} {1:00} hours after the start", hourLate,minuteLate);
                }
                
            }
            else if (difference>=0 && difference <=30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", difference);
            }
            else if(difference > 30)
            {
                Console.WriteLine("Early");
                if (difference > 30 && difference < 60)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(difference));
                }
                else if (difference > 59)
                {
                    var hourLate = Math.Truncate(Math.Abs(difference / 60));
                    var minuteLate = (Math.Abs(difference) - (Math.Truncate(hourLate) * 60));
                    //Console.WriteLine("{0}:{1} hours after the start", hourLate, minuteLate);
                    Console.WriteLine("{0} {1:00} hours before the start", hourLate, minuteLate);
                    //{1:00} if 55 minutes -> 0:55; else 2 minutes -> 0:02
                }
            }

        }
    }
}
