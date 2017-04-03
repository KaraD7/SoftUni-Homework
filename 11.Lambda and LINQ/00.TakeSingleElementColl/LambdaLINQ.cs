namespace _00.TakeSingleElementColl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LambdaLINQ
    {
        public static void Main()
        {
            var numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7 
            };

            var firstNum = numbers.First(); //or      var firstNum = numbers[0];
            var lastNum = numbers.Last();
            var firstNumDivide = numbers.First(n => n % 2 == 0);
            var firstSingle = numbers.Single(n => n == 5); //only one result, if more than one error
            var oneNumber = numbers.FirstOrDefault(n => n > 8);
            //var reversedNum = numbers.Reverse();
            var otherNum = new List<int> { 8, 9, 50 };
            var concatNumbers = numbers.Concat(otherNum);


            Console.WriteLine(string.Join(" ", firstNum));
            Console.WriteLine(string.Join(" ", lastNum));
            Console.WriteLine(string.Join(" ", firstNumDivide));
            Console.WriteLine(string.Join(" ", firstSingle));
            Console.WriteLine(string.Join(" ", oneNumber));
            Console.WriteLine(string.Join(" ", ));
            Console.WriteLine(string.Join(" ", concatNumbers));

        }
    }
}
