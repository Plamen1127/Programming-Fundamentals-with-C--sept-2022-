using System;
using System.Collections.Generic;

namespace _05.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] command = input.Split(" : ");
                string course = command[0];
                string studentName = command[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                courses[course].Add(studentName);

            }
            foreach (var curentCourse in courses)
            {
                Console.WriteLine($"{curentCourse.Key}: {curentCourse.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", curentCourse.Value)}");
            }
        }
    }
}
