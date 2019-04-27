using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{

    class StartUp
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("some text");
            var newStr = str.Substring(1,3);
            Console.WriteLine(newStr);
        }
    }
}