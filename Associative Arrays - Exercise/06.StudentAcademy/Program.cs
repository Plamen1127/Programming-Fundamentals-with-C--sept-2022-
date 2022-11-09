using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrade = new Dictionary<string, List<double>>();
            int pairTimesOfRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < pairTimesOfRows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrade.ContainsKey(name))
                {
                    studentGrade.Add(name, new List<double>());
                }
                studentGrade[name].Add(grade);
            }

            foreach (var curentStdent in studentGrade.Where(x => x.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{curentStdent.Key} -> {curentStdent.Value.Average():F2}");
            }
        }
    }
}
