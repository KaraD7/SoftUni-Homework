using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.TestAverage_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictOfStudentGrade = new Dictionary<string, List<double>>();

            for (int i = 1; i <= n; i++)
            {
                var inputLine = Console.ReadLine().Split();

                var name = inputLine[0];
                var grade = double.Parse(inputLine[1]);

                if (!dictOfStudentGrade.ContainsKey(name))
                {
                    dictOfStudentGrade[name] = new List<double>();
                }

                dictOfStudentGrade[name].Add(grade);
            }

            foreach (var grades in dictOfStudentGrade)
            {
                var name = grades.Key;
                var studentGrades = grades.Value;
                var average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                {
                    Console.Write("{0:f2}", grade);
                }
                Console.WriteLine($"(avg: {average:f2})");
            }

        }
    }
}
