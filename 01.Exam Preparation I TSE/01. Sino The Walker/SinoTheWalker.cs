namespace _01.Sino_The_Walker
{
    using System;
    using System.Globalization;

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
            var timeFormat = @"hh\:mm:\ss"; // escape //HH
            var leavingTime = TimeSpan.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);//dateTime

            var stepsNeeded = decimal.Parse(Console.ReadLine());
            var secondsPerStep = decimal.Parse(Console.ReadLine());
            var secondsInADay = 60 * 60 * 24;
            var totalSecondsNeeded = (int)(stepsNeeded * secondsPerStep % secondsInADay);

            var arrivaltime = leavingTime.Add(new TimeSpan(0, 0, totalSecondsNeeded));

            Console.WriteLine("Time arrival: " + arrivaltime.ToString(timeFormat));
        }
    }
}
