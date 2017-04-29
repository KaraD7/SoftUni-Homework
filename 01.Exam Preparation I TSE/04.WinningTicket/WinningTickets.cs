using System.Text.RegularExpressions;

namespace _04.WinningTicket
{
    using System;
    using System.Linq;
    public class WinningTickets
    {
        public static void Main()
        {
            const string pattern  = @"([$#^@])\1{5,}";

            var ticketRegex = new Regex(pattern);

            var tickets = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length !=20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var leftHalf = ticket.Substring(0, ticket.Length / 2);
                var rightHalf = ticket.Substring(ticket.Length / 2);

                var leftMatch = ticketRegex.Match(leftHalf);
                var rightMatch = ticketRegex.Match(rightHalf);

                if (leftMatch.Success && rightMatch.Success)
                {
                    var winningSymbol = leftMatch.Value[0];
                    var shortedMatch = Math.Min(leftMatch.Length, rightMatch.Length);

                    var jackpot = string.Empty;

                    if (shortedMatch == 10)
                    {
                        jackpot = "Jackpot!";
                    }

                    Console.WriteLine($"ticket \"{ticket}\" - {shortedMatch}{winningSymbol} {jackpot}");
                }

                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }

            }
        }
    }
}
