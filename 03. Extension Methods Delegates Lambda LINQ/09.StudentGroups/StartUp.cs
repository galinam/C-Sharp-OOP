/*
 Problem 9. Student groups
Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.
 Problem 10. Student groups extensions
Implement the previous using the same query expressed with extension methods.
 Problem 11. Extract students by email
Extract all students that have email in abv.bg.
Use string methods and LINQ.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StudentGroups
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Tosho",
                    LastName = "Goshev",
                    FN = 664025256,
                    Tel = "0878778899",
                    Email = "tg@abv.bg",
                    Marks = new List<int> { 5,2,4,6,6,5,4},
                    GroupNumber = 1
                },

                new Student
                {
                    FirstName = "Davit",
                    LastName = "Amigov",
                    FN = 664025646,
                    Tel = "0878787855",
                    Email = "da@gmail.com",
                    Marks = new List<int> { 6,6,6,2,5,6,6,},
                    GroupNumber = 2
                },

                new Student
                {
                    FirstName = "Gosho",
                    LastName = "Minkov",
                    FN = 664025244,
                    Tel = "0876333777",
                    Email = "gm@gmail.com",
                    Marks = new List<int> { 2,4,4,6,6,5,4},
                    GroupNumber = 1
                },

                new Student
                {
                    FirstName = "Pesho",
                    LastName = "Cekov",
                    FN = 664055546,
                    Tel = "0879122133",
                    Email = "pc@gmail.com",
                    Marks = new List<int> { 5,6,4,4,6,5,4},
                    GroupNumber = 2
                },

                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    FN = 664023236,
                    Tel = "0877112233",
                    Email = "ii@abv.bg",
                    Marks = new List<int> { 5,6,6,6,6,5,6},
                    GroupNumber = 3
                }
            };

            // Problem 9
            var studentsFromGproupTwo =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in studentsFromGproupTwo)
            {
                Console.WriteLine(student.FirstName);
            }

            // Problem 10
            Console.WriteLine();
            var studentsFromGpoup2 = students
                .FindAll(s => s.GroupNumber == 2)
                .OrderBy(s => s.FirstName)
                .ToList();

            foreach (var student in studentsFromGpoup2)
            {
                Console.WriteLine(student.FirstName);
            }

            // Problem 11
            Console.WriteLine();
            var studentWithABVemail =
                from student in students
                where student.Email.Substring(student.Email.Count() - 7, 7) == "@abv.bg" //Contains("@abv.bg")
                select student;
                        
            foreach (var student in studentWithABVemail)
            {
                Console.WriteLine(student.FirstName + " - " + student.Email);
            }
        }
    }
}
