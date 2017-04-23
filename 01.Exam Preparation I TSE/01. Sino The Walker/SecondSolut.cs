//namespace _01.Sino_The_Walker
//{
//    public class SecondSolut
//    {
//        var dateAsString = Console.ReadLine();
//        var date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);

//        Console.WriteLine(date.DayOfWeek);

//        string[] timeInput = Console.ReadLine().Split(':');
//        int hours = int.Parse(timeInput[0]) * 3600;
//        int minutes = int.Parse(timeInput[1]) * 60;
//        int seconds = int.Parse(timeInput[2]);
//        int totalInputInSeconds = hours + minutes + seconds;

//        BigInteger steps = int.Parse(Console.ReadLine());
//        BigInteger secPerStep = int.Parse(Console.ReadLine());

//        BigInteger totalTimeInSeconds = (steps * secPerStep) + totalInputInSeconds;

//        BigInteger arriveHour = (totalTimeInSeconds / 3600) % 24;
//        BigInteger arriveMinute = (totalTimeInSeconds / 60) % 60;
//        BigInteger arriveSecond = totalTimeInSeconds % 60;

//        Console.WriteLine($"Time Arrival: {arriveHour:00}:{arriveMinute:00}:{arriveSecond:00}");
//    }
//}
