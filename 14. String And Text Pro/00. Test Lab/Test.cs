namespace _00.Test_Lab
{
    using System;
    using System.Diagnostics;
    using System.Text;

    public class Test
    {
        public static void Main()
        {
            var stopWatch = Stopwatch.StartNew();

            var text = "zdrasti! kakvo stava";

            var indexOfComma = text.IndexOf("!");

            // substring split text
            var partOftext = text.Substring(indexOfComma + 1);

            Console.WriteLine(partOftext);


            // split

            var textNum = "1 2 3 4 5";
            var parts = textNum.Split(' ');

            for (int i = 1; i <= parts.Length; i++)
            {
                Console.WriteLine(i);
            }

            // Replace

            var textR = "Sofia Sofia Burgas Sofia";
            var result = textR.Replace("Sofia", "Varna");
            Console.WriteLine(result);

            // Remove

            var textRemoveResult = textR.Remove(3, 4);
            Console.WriteLine(textRemoveResult);

            // or Remove, sth like hack

            var textRemoveHack = textR.Replace("Sofia", string.Empty).Trim();
            Console.WriteLine(textRemoveHack);

            // trimStart

            var textTrim = "aaa  ABc   D";

            Console.WriteLine(textTrim.Trim('A'));

            //

            stopWatch.Stop();

            Console.WriteLine(stopWatch.Elapsed);

            // stringBuilder

            stopWatch = Stopwatch.StartNew();

            var totalOperations = 20;
            var resultB = new StringBuilder();

            for (int i = 0; i < totalOperations; i++)
            {
                resultB.Append("a"); // a+=a // +
            }

            var resultAsString = resultB.ToString();
            Console.WriteLine(resultAsString);

            stopWatch.Stop();

            Console.WriteLine(stopWatch.Elapsed);

            //StringBuilder

            var sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sb.AppendLine("a");
            }

            Console.WriteLine(sb.Length);

            sb.Append("Ivan");
            sb.AppendLine("gosho");
            sb.Append("Test");

            sb[1] = '!';
            Console.WriteLine(sb[0]);

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
