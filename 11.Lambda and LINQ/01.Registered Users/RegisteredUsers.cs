namespace _01.Registered_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RegisteredUsers
    {
        public static void Main()
        {
            var nameAndDate = Console.ReadLine()
                .Split(new[] { '-', '>', '/' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
        }
    }
}
