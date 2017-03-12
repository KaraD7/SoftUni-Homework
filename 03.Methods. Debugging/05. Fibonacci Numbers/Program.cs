namespace Fibonacci
{
    using System;

    public class Fibonacci
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(number));
        }

        public static long Fib(int n)
        {
            if (n < 2)
            {
                return 1L; // 1 in long 
            }

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}