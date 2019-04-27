using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.IEnumerable
{ //https://docs.microsoft.com/en-us/dotnet/api/system.valuetype?view=netframework-4.7.2
    public class NumericTypes
    {
        public static bool IsNumeric(ValueType value)
        {
            return (value is Byte ||
                    value is Int16 ||
                    value is Int32 ||
                    value is Int64 ||
                    value is SByte ||
                    value is UInt16 ||
                    value is UInt32 ||
                    value is UInt64 ||
                    value is BigInteger ||
                    value is Decimal ||
                    value is Double ||
                    value is Single);
        }
    }
}
