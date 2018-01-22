using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();

            for (int i = 2; i <= 4; i++)
			{
                numbers.Add(i);
			}

            //numbers.Print();
            //for (int i = 5; i <= 7; i++)
            //{
            //    numbers.RemoveFirst(i);
            //}
            //numbers.Print();

            //Console.WriteLine(numbers[0]);

            //numbers[1] = 33;
            //numbers[3] = 99;
            //numbers[5] = -1;
            //numbers.Print();

            //numbers.RemoveAt(1);
            //numbers.RemoveAt(1);

            //numbers.Print();

            //numbers.InsertAt(33, 1);
            //numbers.Print();
            //numbers.Clear();
            //numbers.Print();

            //numbers--;
            //--numbers;
            //numbers.Print();

            if (numbers)
            {
                Console.WriteLine(numbers[0] + " " + numbers[numbers.Count-1]);
            }

            var minV = numbers.Min<Int32>();
            Console.WriteLine(minV);

            var maxV = numbers.Max<Int32>();
            Console.WriteLine(maxV);

            //Console.WriteLine(numbers[10]);
        }
    }
}
