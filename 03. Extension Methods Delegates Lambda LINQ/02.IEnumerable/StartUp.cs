using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.IEnumerable
{
    class StartUp
    {
        
        static void Main(string[] args)
        {
            try
            {
                //IEnumerable<string> strList = new string[] { "2", "3" };
                IEnumerable<uint> list = new uint[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                //IEnumerable<string> s = strList.Sum<string>;

                Console.WriteLine("The sum is {0}", list.Sum<uint>());
                Console.WriteLine("The product is {0}", list.Product<uint>());
                Console.WriteLine("The averige is {0}", list.Average<uint>());
                Console.WriteLine("The min element is {0}", list.Min<uint>());
                Console.WriteLine("The max element is {0}", list.Max<uint>());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error!" + ex.Message);
            }
            
        }

        
    }
}
