// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.FirstBeforeLast;

namespace _04.AgeRange
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student { FirstName = "A", LastName = "B", Age = 18 },
                new Student { FirstName = "C", LastName = "B", Age = 19 },
                new Student { FirstName = "F", LastName = "B", Age = 17 },
                new Student { FirstName = "A", LastName = "B", Age = 25 },
                new Student { FirstName = "G", LastName = "P", Age = 24 },
                new Student { FirstName = "G", LastName = "M", Age = 20 }
            };

            var studentsWithAgeBetween18And24 = students
                .Where(s => (s.Age > 18 && s.Age < 24))
                .Select(s => s)
                .ToList();

            foreach (var student in studentsWithAgeBetween18And24)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
