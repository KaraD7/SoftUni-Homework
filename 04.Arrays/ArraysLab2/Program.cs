namespace ArraysLab2
{
    using System;

    public class Program
    {
        public static void Main()
        {   
            //alphabet with Array a-z
            var alphabet = new char[26];

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[i - 'a'] = i;
            }
            Console.WriteLine(alphabet);
        }
    }
}
