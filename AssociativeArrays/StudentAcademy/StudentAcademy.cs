using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class StudentAcademy
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<double> { grade, 1 });
                }
                else
                {
                    studentsGrades[name][0] += grade;
                    studentsGrades[name][1]++;
                }
            }

            foreach (var student in studentsGrades.Values)
            {
                student[0] /= student[1];
            }

            studentsGrades = studentsGrades.OrderByDescending(pair => pair.Value[0])
                                           .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var student in studentsGrades)
            {
                if (student.Value[0] >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value[0]:F2}");
                }
            }
        }
    }
}
