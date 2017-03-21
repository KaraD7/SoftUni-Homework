namespace _01.Letter_Repetition
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook["John Smith"] = "558976";
            phoneBook["Lisa"] = "0877655553555";
            phoneBook["Sam Doe"] = "0877653555";
            phoneBook["Nakov"] = "0877653555";
            phoneBook["Nakov"] = "0877653555";

            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }
        }
    }
}