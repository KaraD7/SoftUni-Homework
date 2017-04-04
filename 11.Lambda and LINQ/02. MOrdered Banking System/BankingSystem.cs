namespace _02.MOrdered_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class BankingSystem
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, decimal>> banksAndAccounts = new Dictionary<string, Dictionary<string, decimal>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] {' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string bankName = inputParams[0];
                string bankAccountName = inputParams[1];
                decimal bankAccountBalance = decimal.Parse(inputParams[2]);

                if (!banksAndAccounts.ContainsKey(bankName))
                {
                    banksAndAccounts.Add(bankName, new Dictionary<string, decimal>());
                }
                if (!banksAndAccounts[bankName].ContainsKey(bankAccountName))
                {
                    banksAndAccounts[bankName].Add(bankAccountName, 0);
                }

                banksAndAccounts[bankName][bankAccountName] += bankAccountBalance;

                inputLine = Console.ReadLine();
            }

            /*banksAndAccounts
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value
                    .OrderByDescending(account => account.Value)
                    .ToList()
                    .ForEach(account => Console.WriteLine("{0} -> {1}.{2}",
                    account.Key, 
                    account.Value,
                    bank.Key)));*/

            // other print solution
            foreach (var bank in banksAndAccounts.OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value)))
            {
                foreach (var account in bank.Value.OrderByDescending(account => account.Value))
                {
                    Console.WriteLine("{1} -> {2} ({0})", bank.Key, account.Key, account.Value);
                }
            }
        }
    }
}
