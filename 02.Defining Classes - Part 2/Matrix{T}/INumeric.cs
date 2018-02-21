using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixT
{
    interface INumeric<T>
       where T : IComparable<T>, IEquatable<T>
    {

        //bool IsNumericType1(Matrix<T> matrix);
    }
}
