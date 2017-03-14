namespace _00.LabExercise
{
    using System;
    using System.Collections.Generic;
    public class Dictionaries
    {
        public static void Main()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook["nakov"] = "55555555";
            phoneBook["misho"] = "6547787787878787";

            foreach (var pair in phoneBook)
            {
                Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);
            }
        }
    }
}
