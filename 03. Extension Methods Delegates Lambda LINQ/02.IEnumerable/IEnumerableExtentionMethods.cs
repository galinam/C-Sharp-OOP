/* Implement a set of extension methods for IEnumerable<T> 
 * that implement the following group functions: sum, product, min, max, average.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.IEnumerable
{
    public static class IEnumerableExtentionMethods
    {
        public static T Sum<T>(this IEnumerable<T> enumeration)
            where T : struct,
                      IComparable,
                      IComparable<T>,
                      IConvertible,
                      IEquatable<T>,
                      IFormattable
        {
            dynamic result = 0;
            foreach (var num in enumeration)
            {
                result += (dynamic)num;
            }
            return (T)result;
        }

        public static T Product<T>(this IEnumerable<T> enumeratrion)
        {
            dynamic result = 1;
            foreach (var num in enumeratrion)
            {
                result *= (dynamic)num;
                if (result == 0)
                {
                    break;
                }
            }

            return (T)result;
        }

        public static T Average<T>(this IEnumerable<T> enumeration)
             where T : struct,
                      IComparable,
                      IComparable<T>,
                      IConvertible,
                      IEquatable<T>,
                      IFormattable
        {
            if (enumeration.Count() == 0)
            {
                throw new ArgumentException("The passed collection is empty.");
            }
            else
            {
                dynamic result = 0;
                result = enumeration.Sum<T>() / (dynamic)enumeration.Count();

                return (T)result;
            }
        }


        public static T Min<T>(this IEnumerable<T> enumeration)
        {
            dynamic result = long.MaxValue;
            foreach (var num in enumeration)
            {
                if (num < result)
                {
                    result = num;
                }
            }

            return (T)result;
        }

        public static T Max<T>(this IEnumerable<T> enumeration)
        {
            dynamic result = long.MinValue;
            foreach (var num in enumeration)
            {
                if (num > result)
                {
                    result = num;
                }
            }

            return (T)result;
        }
    }
}
