namespace _00.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ShortWordsSorted
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                        .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '/', '!', '?', ' ', '\\', }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(w => w.Length < 5)
                        .Select(w => w.ToLower())
                        .OrderBy(w => w)
                        .Distinct()
                        .ToList();
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
