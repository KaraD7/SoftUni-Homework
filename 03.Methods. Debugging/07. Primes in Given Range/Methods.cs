using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            var primesInRange = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", primesInRange)); //1,2,3- without , end-(1,2,3,)
        }

        static List<int> FindPrimesInRange(int startNum, int endNum) // Lists of int, lect 5.
        {
            var primes = new List<int>();
            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
        }
        public static bool IsPrime(long n) // from exer 06
        {
            var isPrime = true;
            if (n == 0 || n == 1)
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
