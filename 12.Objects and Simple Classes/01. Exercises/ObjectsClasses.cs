﻿namespace _01.Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class ObjectsClasses
    {
        public static void Main()
        {
            List<Exercise> exercises = new List<Exercise>();

            string inputLine = Console.ReadLine();

            while (inputLine != "go go go")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string topic = inputParams[0];
                string courseName = inputParams[1];
                string judgeContestLink = inputParams[2];
                List<string> problems = inputParams.Skip(3).ToList();

                //POINT point = new Point();
                Exercise newExercise = new Exercise();
                
                newExercise.Topic = topic;
                newExercise.CourseName = courseName;
                newExercise.JudgeContestLink = judgeContestLink;
                newExercise.Problems = problems;

                exercises.Add(newExercise);

                inputLine = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine("Exercises: {0}", exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}", exercise.JudgeContestLink);

                int count = 1;

                foreach (var problems in exercise.Problems)
                {
                    Console.WriteLine("{0}. {1}", count, problems); 
                    count++;
                }
            }
        }
    }
}
