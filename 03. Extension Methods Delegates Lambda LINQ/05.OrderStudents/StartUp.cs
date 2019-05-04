/*Using the extension methods OrderBy() and ThenBy() with lambda expressions 
 * sort the students by first name and last name in descending order.
Rewrite the same with LINQ.
 */
using _03.FirstBeforeLast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OrderStudents
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student { FirstName = "A", LastName = "C", Age = 18 },
                new Student { FirstName = "C", LastName = "B", Age = 19 },
                new Student { FirstName = "F", LastName = "B", Age = 17 },
                new Student { FirstName = "A", LastName = "B", Age = 25 },
                new Student { FirstName = "G", LastName = "P", Age = 24 },
                new Student { FirstName = "G", LastName = "M", Age = 20 }
            };

            var orderSudentsByFirstAndLastNameDescending = students
                .OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName)
                .Select(s => s)
                .ToList();

            foreach (var student in orderSudentsByFirstAndLastNameDescending)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
            var orderSudentsByFirstAndLastNameDescending1 =
                (from student in students
                 orderby student.FirstName descending
                 select student
                 ).ToList();
            
            foreach (var student in orderSudentsByFirstAndLastNameDescending1)
            {
                Console.WriteLine(student.FirstName +" "+ student.LastName);
            }


            Console.WriteLine();
            var orderSudentsByFirstAndLastNameDescending11 =
                 from student in students
                 group student by student.FirstName into newGroup
                 orderby newGroup.Key descending
                 select newGroup;
            foreach (var nameGroup in orderSudentsByFirstAndLastNameDescending11)
            {
                Console.WriteLine($"Key: {nameGroup.Key}");
                foreach (var student in nameGroup)
                {
                    Console.WriteLine($"\t{student.FirstName}, {student.LastName}");
                }
            }

            Console.WriteLine();
            var orderSudentsByFirstAndLastNameDescending2 =
                (from student in students
                 orderby student.FirstName descending
                 orderby student.LastName descending
                 select new
                 {
                     student.FirstName,
                     student.LastName
                 }).ToList();

            foreach (var student in orderSudentsByFirstAndLastNameDescending2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
