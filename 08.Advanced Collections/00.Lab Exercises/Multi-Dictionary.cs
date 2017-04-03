namespace _00.Lab_Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AdvancedColl
    {
        public static void Main()
        {
            Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>(); // new + ctrl + space

            grades["Gosho"] = new List<int>();
            grades["Gosho"].Add(5);
            grades["Gosho"].Add(6);
            grades["Gosho"].Add(3);
            // or 
            grades["Pesho"] = new List<int>() { 6, 6, 6, 6 };

            Console.WriteLine("Gosho grades:" + string.Join(" ", grades["Gosho"])); // print list
            Console.WriteLine("Pesho grades:" + string.Join(" ", grades["Pesho"])); // print list
        }

        /* with method
        public static void Main()
        {
            Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>(); // new + ctrl + space

            AddGrade(grades,"Gosho", 5);
            AddGrade(grades,"Kiro", 6);
            AddGrade(grades,"Gosho", 2);
            AddGrade(grades,"Kiro", 2);

            Console.WriteLine("Gosho grades:" + string.Join(" ", grades["Gosho"])); // print list
            Console.WriteLine("Pesho grades:" + string.Join(" ", grades["Pesho"])); // print list
            //or print list
            foreach(var name in grades.Key)
            {
                Console.WriteLine("Grades of:" + name + ":");

                foreach(var grade in grades[name])
                {
                    Console.WriteLine(" - " + grade);
                }
            }
        }
        public static void AddGrade(Dictionary<string, List<int>> grades, string name, int grade)
        {
            if (!grades.ContainsKey(name)) // if the key name not exist ("Pesho", "Gosho")
            {
                grades[name] = new List<int>();  // do new list to add key Pesho
            }
            grades[name].Add(grade); // add a grade
        }
        */
    }
}


