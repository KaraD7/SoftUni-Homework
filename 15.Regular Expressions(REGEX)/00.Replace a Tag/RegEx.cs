namespace _00.Replace_a_Tag
{
    using System;
    using System.Text.RegularExpressions;
    public class RegEx
    {
        public static void Main()
        {
            var pattern = @"<a.+?href=(.+?)>(.+?)<\/a>";
            var regex = new Regex(pattern);

            var text = "<ul><li><a href=\"http://softuni.bg\">SoftUni</a></li></ul>";

            //var match = regex.IsMatch(text);
            //Console.WriteLine(match);

            //var match2 = regex.Match(text);
            //Console.WriteLine(match2.Value);

            var replacement = "[URL href=$1]$2[/URL]";

            var result = regex.Replace(text, replacement);

            Console.WriteLine(result);
        }
    }
}
