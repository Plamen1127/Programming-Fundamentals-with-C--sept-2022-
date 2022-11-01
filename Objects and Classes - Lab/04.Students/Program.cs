using System;
using System.Collections.Generic;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {

                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] studentProparty = command.Split(' ');

                Student student = new Student
                {
                    FirstName = studentProparty[0],
                    LastName = studentProparty[1],
                    Age = int.Parse(studentProparty[2]),
                    HomeTown = studentProparty[3],
                };

                students.Add(student);
            }

            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (city == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
