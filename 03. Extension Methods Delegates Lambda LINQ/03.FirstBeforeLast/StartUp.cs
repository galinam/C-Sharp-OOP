using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{
    class StartUp
    {
        private static List<Student> FirstBeforeLast(Student[] students)
        {
            var result = students
                .Where(s => s.FirstName.CompareTo(s.LastName) < 0)
                .Select(s => s)
                .ToList();

            return result;
        }

        static void Main(string[] args)
        {
            var s1 = new Student { FirstName = "A", LastName = "B" };

            Student[] students = new Student[]
            {
                new Student { FirstName = "A", LastName = "B" },
                new Student { FirstName = "C", LastName = "B" },
                new Student { FirstName = "F", LastName = "B" },
                new Student { FirstName = "A", LastName = "B" },
                new Student { FirstName = "G", LastName = "P" }
            };

            var studentsWithFirstBeforeLastName = FirstBeforeLast(students);
            foreach (var student in studentsWithFirstBeforeLastName)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
