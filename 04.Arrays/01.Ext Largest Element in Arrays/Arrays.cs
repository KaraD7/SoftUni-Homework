namespace _01.Ext_Largest_Element_in_Arrays
{
    using System;

    public class Arrays
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            int smallest = numbers[0];
            for (int index = 0; index < numbers.Length; index++)
            {
                
                if (numbers[index] < smallest) smallest = numbers[index];
            }
            Console.WriteLine(smallest);
        }
    }
}
