namespace _01.MLambada_Expressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LambadaExpr
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, string>> lambadaExpression = new Dictionary<string, Dictionary<string, string>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "lambada")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputParams.Length > 1)
                {
                    string selector = inputParams[0];
                    string selectorObject = inputParams[1];
                    string property = inputParams[2];

                    if (!lambadaExpression.ContainsKey(selector))
                    {
                        lambadaExpression.Add(selector, new Dictionary<string, string>());
                    }

                    lambadaExpression[selector][selectorObject] = property;
                }
                else
                {
                    lambadaExpression = lambadaExpression
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                        .ToDictionary(selectorObject => selectorObject.Key,
                            selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }

                inputLine = Console.ReadLine();
            }
            // first print
            lambadaExpression
                .ToList()
                .ForEach(selector => selector.Value
                .ToList()
                .ForEach(selectorObject => Console.WriteLine("{0} => {1}.{2}",
                selector.Key,
                selectorObject.Key,
                selectorObject.Value)));


            // second print
            /*foreach (var selector in lambadaExpression)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine("{0} => {1}.{2}",selector.Key,selectorObject.Key,selectorObject.Value);
                }
            }*/
        }
    }
}
