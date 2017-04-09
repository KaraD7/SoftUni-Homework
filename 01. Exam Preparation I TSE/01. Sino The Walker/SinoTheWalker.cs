namespace _01.Sino_The_Walker
{
    using System;
    public class SinoTheWalker
    {
        public static void Main()
        {
            TimeSpan time = TimeSpan.Parse(Console.ReadLine());

            int steps = int.Parse(Console.ReadLine()) % 86400; 
            int seconds = int.Parse(Console.ReadLine()) % 86400;

            long stepsSum = steps * seconds;

    
            TimeSpan timeRes = TimeSpan.FromSeconds(stepsSum);

            TimeSpan timeSum = time + timeRes;

            Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", timeSum);

        }
    }
}
