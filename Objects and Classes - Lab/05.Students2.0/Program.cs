using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students
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
                string firstName = studentProparty[0];
                string lastName = studentProparty[1];
                int age = int.Parse(studentProparty[2]);
                string town = studentProparty[3];


                Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                if (student != null)
                {
                    student.Age = age;
                    student.Town = town;
                }
                else
                {
                    student = new Student(firstName, lastName, age, town);
                    students.Add(student);
                }


                
            }

            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (city == student.Town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Town = town;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
    }
}
