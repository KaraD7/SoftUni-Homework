namespace _00.Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ObjectsClasses
    {
        public static void Main()
        {
            var total = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, decimal>();

            for (int i = 0; i < total; i++)
            {
                var currentSaleAsString = Console.ReadLine();
                var currentSale = Sale.Parse(currentSaleAsString);

                if (!result.ContainsKey(currentSale.Town))
                {
                    result[currentSale.Town] = 0;
                }
                result[currentSale.Town] += currentSale.Quantity * currentSale.Price;
            }
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
