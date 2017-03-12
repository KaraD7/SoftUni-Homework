namespace _02.Reverse_Array_of_Integers
{
    using System;

    public class Arrays
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(array[i]+" ");
                Console.WriteLine();
            }

        }
    }
}
