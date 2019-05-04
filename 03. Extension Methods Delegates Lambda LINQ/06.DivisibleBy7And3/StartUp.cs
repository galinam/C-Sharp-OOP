/*Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
 *Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy7And3
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 21, 30, 42, 50, 60, 70, 84, 90, 100 };

            var numDevisibleBy7And3 = array
                .Where(n => n % 7 == 0 && n % 3 == 0)
                .Select(n => n)
                .ToList();

            foreach (var num in numDevisibleBy7And3)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            var _numDevisibleBy7And3 =
                (from number in array
                where number % 7 == 0 && number % 3 == 0
                select number).ToList();

            foreach (var num in _numDevisibleBy7And3)
            {
                Console.Write(num + ", ");
            }
        }
    }
}
