namespace _00.StudentsGrades_ThenBy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ThenBy
    {
        public static void Main()
        {
            var numbers = new List<int>
            {
                1, 6, 3, 0, 5, 2, 7, 8, 9, 4
            };

            var studens = new Dictionary<string, int>()
            {
                ["Ivan"] = 2,
                ["Mira"] = 6,
                ["Gosho"] = 4,
                ["Lubo"] = 2,
                ["Zina"] = 2,
                ["Pavko"] = 5,
            };

            //studens.OrderBy(st => st.Value);  without a appropriation it doesn`t work
            
            // First method
            /*studens.OrderBy(st => st.Value)
                   .ThenBy(st => st.Key)
                   .ToDictionary(
                        st => st.Key,
                        st => st.Value);*/
            
            //Second method
            var sortedStudent = studens
                .OrderBy(st => st.Value) // If the students grade is equal,
                .ThenBy(st => st.Key); // then sorted by their names

            foreach (var student in sortedStudent)
            {
                Console.WriteLine($"{student.Key} --> {student.Value}");
            }

            //Console.WriteLine(string.Join(" ", sortedNumbers));
        }
    }
}
