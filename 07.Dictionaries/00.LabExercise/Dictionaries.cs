namespace _00.LabExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dictionaries
    {
        public static void Main()
        {
            Dictionary <string, string> phoneBook = new Dictionary<string, string>();
            phoneBook["John Smith"] = "558976";
            phoneBook["Lisa"] = "0877655553555";
            phoneBook["Sam Doe"] = "0877653555";
            phoneBook["Nakov"] = "0877653555";
            phoneBook["Nakov"] = "0877653555";


            foreach (var item in phoneBook)
            {
                var key = item.Key;
                var value = item.Value;
                Console.WriteLine($"{key} --> {value}");
            }
        }
    }
}
