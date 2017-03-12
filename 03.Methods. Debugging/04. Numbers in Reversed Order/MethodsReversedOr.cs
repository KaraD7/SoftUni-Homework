namespace _04.Numbers_in_Reversed_Order
{
    using System;

    class MethodsReversedOr
    {
        /*public static void Main() // first
        {
            decimal finalResult = PrintDigit();
            Console.WriteLine(finalResult);
        }

        public static decimal PrintDigit()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal left = number;
            decimal reversedResult = 0;
            while (left > 0)
            {
                var r = left % 10;
                reversedResult = reversedResult * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }
            return reversedResult;
            
        }*/
        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNum(num));
        }

        private static double ReversedNum(double num)
        {
            var numString = num.ToString();
            var reversedString = string.Empty;

            for (int i = numString.Length - 1; i >= 0; i--) // convert string to 12345, exam Pesho = 1/2/3/4/5
            {
                reversedString += numString[i];
            }
            var reversedNum = double.Parse(reversedString);
            return reversedNum;
        }
    }
}
