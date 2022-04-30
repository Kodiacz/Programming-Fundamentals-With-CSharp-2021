using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Courses
    {
        static void Main(string[] args)
        {
            // Programming Fundamentals : John Smith
            // Programming Fundamentals : Linda Johnson
            // JS Core : Will Wilson
            // Java Advanced : Harrison White
            // end

            Dictionary<string, List<string>> courseData = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(" : ");
            string course = input[0];
            string student = input[1];

            while (course != "end")
            {
                if (!courseData.ContainsKey(course))
                {
                    courseData.Add(course, new List<string> { student });
                }
                else
                {
                    courseData[course].Add(student);
                }

                input = Console.ReadLine().Split(" : ");
                course = input[0];

                if (input.Length > 1)
                {
                    student = input[1];
                }
            }

            courseData = courseData.OrderByDescending(pair => pair.Value.Count)
                                   .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var courses in courseData)
            {
                courses.Value.Sort();
                Console.WriteLine($"{courses.Key}: {courses.Value.Count}");

                for (int i = 0; i < courses.Value.Count; i++)
                {
                    Console.WriteLine($"-- {courses.Value[i]}");
                }
            }
        }
    }
}
