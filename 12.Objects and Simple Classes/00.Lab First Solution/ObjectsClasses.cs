namespace _00.Lab_First_Solution
{
    using System;
    using System.Globalization;

    public class ObjectsClasses
    {
        public static void Main()
        {
            /*var someDay = new DateTime(1992, 11, 25);
            var anotherDay = new DateTime(2017, 03, 21);*/

            
            var dateAsString = Console.ReadLine();
            var date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

            // Random, we must use only ONE time

            //var randomGenerator = new Random();
            //Console.WriteLine(randomGenerator.Next(0,100));  // 0-99 without last (100)
            //Console.WriteLine(randomGenerator.Next(0,100));
            //Console.WriteLine(randomGenerator.Next(0, 100));
            //Console.WriteLine(randomGenerator.Next(0, 100));

        }
    }
}
