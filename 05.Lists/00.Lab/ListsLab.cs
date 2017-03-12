namespace _00.Lab
{
    using System;
    using System.Collections.Generic; 
    using System.Linq;

    public class ListsLab
    {
        public static void Main()
        {
            /*var arrayOfNumbers = new int[100]; // Array only 100 cells

            arrayOfNumbers[0] = 10;
            arrayOfNumbers[1] = 20;
            arrayOfNumbers[2] = 30;


            List<int> listOfNumbers = new List<int>(); // List is endless/infinite
            var listOfNumbers = new List<int>();
            listOfNumbers.Add(10);
            listOfNumbers.Add(20);
            listOfNumbers.Add(30);*/

            /*var listOfStrings = new List<string>();  // first ex
            listOfStrings.Add ("Pesho");
            listOfStrings.Add("Kolio");
            listOfStrings.Add("Vladi");
            listOfStrings.Add("Test");

            Console.WriteLine(string.Join(", ", listOfStrings)); // second ex

            foreach (var text in listOfStrings) //first ex
            {
                Console.WriteLine(text);
            }
            */
            int n = int.Parse(Console.ReadLine());  // third ex
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                list.Add(currentNumber); // lists
                //arr[i] = currentNumber;// arrays
                Console.WriteLine();

            }
            
            var listOfNumbers = new List<int>  // fourth ex
            {
                1, 2, 3, 4, 5
            };

            // print with first variant
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                Console.WriteLine(listOfNumbers[i]);
            }
            // print with second v
            foreach (var numbers in listOfNumbers)
            {
                Console.WriteLine(numbers);
            }
            // print with third v
            Console.WriteLine(string.Join(",", listOfNumbers));
            // print with fourth v
            listOfNumbers.ForEach(Console.WriteLine);
            
        }
    }
}
