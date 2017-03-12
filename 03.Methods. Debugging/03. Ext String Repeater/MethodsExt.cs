namespace _03.Ext_String_Repeater
{
    using System;
    using System.Linq;

    public class MethodsExt
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(text, number));
        }

        public static string RepeatString(string str, int count)
        {
            var result = string.Join("", Enumerable.Repeat(str, count));

            return result;
        }

    }
}
