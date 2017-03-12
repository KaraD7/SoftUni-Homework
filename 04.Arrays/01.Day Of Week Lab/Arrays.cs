namespace _01.Day_Of_Week_Lab
{
    using System;

    public class Arrays
    {
        public static void Main()
        {
            int day = int.Parse(Console.ReadLine());

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day > 0 && day <=7)
            {
                Console.WriteLine(days[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
