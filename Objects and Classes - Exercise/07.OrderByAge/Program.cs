using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> persons = new List<Person>();

            while (input != "End")
            {
                string[] data = input.Split().ToArray();

                string name = data[0];
                string id = data[1];
                int age = int.Parse(data[2]);

                if (persons.Any(x => x.Id == id))
                {
                    persons.Where(x => x.Id == id)
                           .FirstOrDefault()
                           .Edit(name, age);
                }
                else
                {
                    persons.Add(new Person(name, id, age));
                }

                input = Console.ReadLine();

            }

            foreach (var person in persons.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }

        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public void Edit(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
