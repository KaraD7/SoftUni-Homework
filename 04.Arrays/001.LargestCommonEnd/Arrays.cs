namespace _001.LargestCommonEnd
{
    using System;

    public class Arrays
    {
        public static void Main()
        {


            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var bigger = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > bigger)
                {
                    bigger = array[i];
                }
            }

            Console.WriteLine(bigger);
        }
    }
}

