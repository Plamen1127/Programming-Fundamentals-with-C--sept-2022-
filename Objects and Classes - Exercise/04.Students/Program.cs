using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < qty; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                students.Add(new Student(firstName, lastName, grade));
            }

            foreach (var curentStuden in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{curentStuden.FirstName} {curentStuden.LastName}: {curentStuden.Grade:F2}");
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
