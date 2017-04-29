namespace _01.Sino_The_Walker
{
    using System;
    using System.Numerics;

    public class SinoTheWalker
    {
        public static void Main()
        {
            //TimeSpan time = TimeSpan.Parse(Console.ReadLine());

            //int steps = int.Parse(Console.ReadLine()) % 86400; 
            //int seconds = int.Parse(Console.ReadLine()) % 86400;

            //long stepsSum = steps * seconds;

            //TimeSpan timeRes = TimeSpan.FromSeconds(stepsSum);
            //TimeSpan timeSum = time + timeRes;

            //Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", timeSum);

            // Vladi`s Sol
            //var timeFormat = @"hh\:mm:\ss"; // escape //HH
            //var leavingTime = TimeSpan.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);//dateTime

            //var stepsNeeded = decimal.Parse(Console.ReadLine());
            //var secondsPerStep = decimal.Parse(Console.ReadLine());
            //var secondsInADay = 60 * 60 * 24;
            //var totalSecondsNeeded = (int)(stepsNeeded * secondsPerStep % secondsInADay);

            //var arrivaltime = leavingTime.Add(new TimeSpan(0, 0, totalSecondsNeeded));

            //Console.WriteLine("Time arrival: " + arrivaltime.ToString(timeFormat));

            string[] timeInput = Console.ReadLine().Split(':');
            int hours = int.Parse(timeInput[0]) * 3600;
            int minutes = int.Parse(timeInput[1]) * 60;
            int seconds = int.Parse(timeInput[2]);
            int totalInputInSeconds = hours + minutes + seconds;

            BigInteger steps = int.Parse(Console.ReadLine());
            BigInteger secPerStep = int.Parse(Console.ReadLine());

            BigInteger totalTimeInSeconds = (steps * secPerStep) + totalInputInSeconds;

            BigInteger arriveHour = (totalTimeInSeconds / 3600) % 24;
            BigInteger arriveMinute = (totalTimeInSeconds / 60) % 60;
            BigInteger arriveSecond = totalTimeInSeconds % 60;

            Console.WriteLine($"Time Arrival: {arriveHour:00}:{arriveMinute:00}:{arriveSecond:00}");


        }
    }
}
