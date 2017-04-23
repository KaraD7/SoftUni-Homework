namespace _00.Test_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class RegEx
    {
        public static void Main()
        {
            var pattern = @"(\d{4})-(\w{3})-\d{2}";

            var regex = new Regex(pattern);

            var text = "Today is 2017-Apr-04";

            var match = regex.Match(text); // regex.IsMatch(text)
                     // regex.Matches with foreach
            //System.Console.WriteLine(match);

            Console.WriteLine(match.Groups[1].Value);
            Console.WriteLine(match.Groups[0].Value);
            Console.WriteLine(match.Groups[2].Value);



        }
    }
}
