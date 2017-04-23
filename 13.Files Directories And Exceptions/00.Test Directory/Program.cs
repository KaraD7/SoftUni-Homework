using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _00.Test_Directory
{

    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<double> Grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //File - FileInfo
            //Directory - DirectoryInfo

            //Directory.CreateDirectory("../../Test");
            //File.Create("../../Test/output.txt");
            //File.Create("../../Test/test.txt");
            //File.Create("../../Test/workTest.txt");

            //DirectoryInfo directory = new DirectoryInfo("../../Test");
            ////Console.WriteLine(directory.Exists);

            //if (directory.Exists)
            //{
            //    Console.WriteLine("Hi my name is: " + directory.Name);
            //    Console.WriteLine("Hi my parameter is: " + directory.Parent);
            //    Console.WriteLine("Hi my root is: " + directory.Root);
            //    Console.WriteLine(directory.CreationTime);
            //    Console.WriteLine(directory.FullName);
            //    Console.WriteLine(directory.LastAccessTime);


            //}

            Dictionary<string, Student> studentsByName = new Dictionary<string, Student>();
            //
            string[] storedStudents = File.ReadAllLines("Students/database.schoolfile");

            foreach (var studentInfo in storedStudents)
            {
                string[] studentParams = studentInfo.Split(new[] { ' ', ',', '|' }, StringSplitOptions.RemoveEmptyEntries);

                Student newStudent = new Student();

                newStudent.Name = studentParams[0];
                newStudent.Age = int.Parse(studentParams[1]);
                newStudent.Grade = studentParams.Skip(2).Select(double.Parse).ToList();

                studentsByName.Add(newStudent.Name, newStudent);

            }
            //
            string inputLine = Console.ReadLine();

            // {student} -> {age} -> {grades} // Student only IF IT DOES NOT EXIST ||   PRINT THAT
            // {student} -> {grade}  || PRINT USER DOES NOT EXIST

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>',',' }, StringSplitOptions.RemoveEmptyEntries);


                if (inputParams.Length >= 3)  //register student logic
                {
                    try
                    {
                        Student newStudent = new Student();

                        newStudent.Name = inputParams[0];
                        newStudent.Age = int.Parse(inputParams[1]);
                        newStudent.Grade = inputParams.Skip(2).Select(double.Parse).ToList();

                        studentsByName.Add(newStudent.Name, newStudent);

                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Failed to register student. Student already exist.");
                    }
                }

                else  //add grades logic
                {
                    try
                    {
                        string studentName = inputParams[0];
                        studentsByName[studentName].Grade.AddRange(inputParams.Skip(1).Select(double.Parse));
                    }
                    catch (KeyNotFoundException)
                    {
                        Console.WriteLine("Failed to access student. Student does not exist");
                    }
                }

                inputLine = Console.ReadLine();
            }

            File.WriteAllLines("Students/database.schoolfile",
                studentsByName.OrderBy(x => x.Key)
                .Select(x => x.Value)
                .Select(x => string.Format("{0} | {1} | {2}", x.Name, x.Age, string.Join(", ", x.Grade))));
        }
    }
}
