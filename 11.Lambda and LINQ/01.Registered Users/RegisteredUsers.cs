namespace _01.Registered_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;
    public class RegisteredUsers
    {
        public static void Main()
        {
            Dictionary<string, DateTime> registeredUserNames = new Dictionary<string, DateTime>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] {' ','>','-' }, StringSplitOptions.RemoveEmptyEntries);
                string username = inputParams[0];
                DateTime registryDate = DateTime.ParseExact(inputParams[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                registeredUserNames[username] = registryDate; // OR    registeredUserNames.Add(username, registryDate);


                inputLine = Console.ReadLine();
            }

            Dictionary<string, DateTime> orderedUsernames = registeredUserNames
                .Reverse()
                .OrderBy(d => d.Value)
                .Take(5)
                .OrderByDescending(d => d.Value)
                .ToDictionary(d => d.Key, d => d.Value);

            foreach (var orderedUsername in orderedUsernames)
            {
                Console.WriteLine($"{orderedUsername.Key}");
            }
        }
    }
}
