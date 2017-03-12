namespace _06.Prime_Checker
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(number);
            Console.WriteLine(isPrime);
        }

        public static bool IsPrime(long n)
        {
            var isPrime = true;
            if (n == 0 || n== 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++) // Math.Sqrt корен квадратен
            {
                if (n % i == 0)  // if n=9 i=3 result 3, 9 is not prime
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
