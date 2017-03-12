namespace _05.ExtDistance_of_the_Stars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DataTypes
    {
        public static void Main()
        {
            decimal earthToNearStar = 4.22m;
            decimal distanceMilkyWay = 26000.0m;
            decimal diameterMilkyWay = 100000.0m;
            decimal distanceEarthToUniverse = 46500000000.0m;
            decimal oneLightYearToKM = 9450000000000.0m;

            
            Console.WriteLine(Math.Round(earthToNearStar * oneLightYearToKM).ToString("e2"));
            Console.WriteLine(Math.Round(distanceMilkyWay * oneLightYearToKM).ToString("e2"));
            Console.WriteLine(Math.Round(diameterMilkyWay*oneLightYearToKM).ToString("e2"));
            Console.WriteLine(Math.Round(distanceEarthToUniverse*oneLightYearToKM).ToString("e2"));
        }
    }
}
