/* Implement an extension method Substring(int index, int length) for the class StringBuilder 
 * that returns new StringBuilder and has the same functionality as Substring in the class String.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{
    public static class StringBuilderExtentionMethod
    {
        public static StringBuilder Substring(this StringBuilder collection, int index, int length)
        {
            var result = new StringBuilder();
            for (int i = index; i <= length; i++)
            {
                result.Append(collection[i]);
            }

            return result;
        }
    }
}
