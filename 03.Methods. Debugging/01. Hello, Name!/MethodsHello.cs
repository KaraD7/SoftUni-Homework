namespace _01.Hello__Name_
{
    using System;

    public class MethodsHello
    {

        public static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        
    }
}
