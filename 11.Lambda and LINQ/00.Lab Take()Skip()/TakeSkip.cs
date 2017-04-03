namespace _00.Lab_Take__Skip__
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class TakeSkip
    {
        public static void Main()
        {
            var numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            var firstThree = numbers.Take(3);
            var firstFour = numbers.Skip(4).ToList();

            Console.WriteLine(string.Join(" ", firstFour));
            Console.WriteLine(string.Join(", ",firstThree));
        }
    }
}
