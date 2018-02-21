using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MatrixT;
using System.ComponentModel.DataAnnotations;

namespace MatrixT
{
    [Version(1, 0)]
    class Matrix<T>
        where T : IComparable<T>, IEquatable<T>//, INumeric<T>
    {
        private T[,] matrix;

        public int Row { get; set; }
        public int Col { get; set; }

        //[Required]
        public int Count { get; private set; }


        public T this[int row, int col]
        {
            get
            {

                try
                {
                    return this.matrix[row, col];
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    System.ArgumentException argEx = new System.ArgumentException("Index is out of range of the Matrix boundary!", "index", ex);
                    throw argEx;
                }

            }
            set
            {

                this.matrix[row, col] = value;
            }
        }

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.Count = 0;
            this.matrix = new T[Row, Col];
        }

        //public void Add(T item)
        //{

        //    this.matrix[Row - 1,Col -1] = item;
        //}



        public static Matrix<T> operator +(Matrix<T> matrixF, Matrix<T> matrixS)
        {

            Matrix<T> result = new Matrix<T>(matrixF.GetLength(0), matrixF.GetLength(1));

            if (ValidateMatrixSizes(matrixF, matrixS) && ValidateMatrixTypes(matrixF, matrixS))
            {
                for (int row = 0; row < matrixF.GetLength(0); row++)
                {
                    for (int col = 0; col < matrixF.GetLength(1); col++)
                    {
                        result[row, col] = (dynamic)matrixF[row, col] + matrixS[row, col];
                    }
                }
            }
            return (dynamic)result;

        }
        public static Matrix<T> operator -(Matrix<T> matrixF, Matrix<T> matrixS)
        {
            Matrix<T> result = new Matrix<T>(matrixF.GetLength(0), matrixF.GetLength(1));

            if (ValidateMatrixSizes(matrixF, matrixS) && ValidateMatrixTypes(matrixF, matrixS))
            {
                for (int row = 0; row < matrixF.GetLength(0); row++)
                {
                    for (int col = 0; col < matrixF.GetLength(1); col++)
                    {
                        result[row, col] = (dynamic)matrixF[row, col] - matrixS[row, col];
                    }
                }
            }
            return result;
        }
        public static Matrix<T> operator *(Matrix<T> matrixF, Matrix<T> matrixS)
        {
            Matrix<T> result = new Matrix<T>(matrixF.GetLength(0), matrixF.GetLength(1));

            if (ValidateMatrixSizes(matrixF, matrixS) && ValidateMatrixTypes(matrixF, matrixS))
            {
                for (int row = 0; row < matrixF.GetLength(0); row++)
                {
                    for (int col = 0; col < matrixF.GetLength(1); col++)
                    {
                        result[row, col] = (dynamic)matrixF[row, col] * matrixS[row, col];
                    }
                }
            }
            return result;
        }

        public int GetLength(int length)
        {
            int result = -1;
            if (length == 0)
            {
                result = this.Row;
            }
            else if (length == 1)
            {
                result = this.Col;
            }

            return result;
        }

        private static bool ValidateMatrixSizes(Matrix<T> matrixF, Matrix<T> matrixS)
        {
            bool result = false;
            try
            {
                if ((matrixF.GetLength(0) == matrixS.GetLength(0)) && (matrixF.GetLength(1) == matrixS.GetLength(1)))
                {
                    result = true;
                }
                else
                {
                    throw new ArgumentException("The operation cannot be performed. Size faild.");
                }
            }
            catch (FormatException ex)
            {

                throw new ArgumentException("The operation cannot be performed.", ex.Message);
            }

            return result;
        }

        private static bool ValidateMatrixTypes(Matrix<T> matrixF, Matrix<T> matrixS)
        {
            bool result = false;
            try
            {
                if (IsNumericType(matrixF) && IsNumericType(matrixS) && matrixF.GetType().Equals(matrixS.GetType()))
                {
                    result = true;
                }
                else
                {
                    throw new ArgumentException("The operation cannot be performed. Type faild.");
                }
            }
            catch (FormatException ex)
            {

                throw new ArgumentException("The operation cannot be performed.", ex.Message);
            }

            return result;
        }

        private static bool IsNumericType(Matrix<T> matrix)
        {
            switch (Type.GetTypeCode(matrix.GetType().GetTypeInfo().GenericTypeArguments[0]))
            {
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        //private static Matrix<T> ResultType(Matrix<T> matrixF)
        //{
        //    if (matrixF.GetType().GetTypeInfo().GenericTypeArguments[0].Equals(TypeCode.Byte) ||
        //        matrixF.GetType().GetTypeInfo().GenericTypeArguments[0].Equals(TypeCode.SByte) ||
        //        matrixF.GetType().GetTypeInfo().GenericTypeArguments[0].Equals(TypeCode.UInt16) ||
        //        matrixF.GetType().GetTypeInfo().GenericTypeArguments[0].Equals(TypeCode.Int16))
        //    {
        //        Matrix<int> result = new Matrix<int>(matrixF.GetLength(0), matrixF.GetLength(1));
        //        return (dynamic)result;
        //    }
        //    else
        //    {
        //        Matrix<T> result = new Matrix<T>(matrixF.GetLength(0), matrixF.GetLength(1));
        //        return result;
        //    };
        //}

        //private static bool IsNumericType1(Matrix<T> matrix)
        //{
           
        //    try
        //    {
        //        switch (Type.GetTypeCode(matrix.GetType().GetTypeInfo().GenericTypeArguments[0]))
        //        {
        //            case TypeCode.UInt32:
        //            case TypeCode.UInt64:
        //            case TypeCode.Int32:
        //            case TypeCode.Int64:
        //            case TypeCode.Decimal:
        //            case TypeCode.Double: //typeof(double) = typeof(MatrixT.INumeric<double>);
        //            case TypeCode.Single:
        //                return true;
        //            default:
        //                return false;
        //        }
        //    }
        //    catch (TypeAccessException ex)
        //    {

        //        throw new TypeAccessException(ex.Message);
        //    }

        //}

        public T Value { get; private set; }
        public Matrix(T val) { Value = val; }

        public static implicit operator T(Matrix<T> matrix) { return matrix.Value; }
        public static implicit operator Matrix<T>(T val) { return new Matrix<T>(val); }



        //public static implicit operator int (T)
        // {
        //if (IsNumericType(matrix.GetType()))
        //{
        //  return t.
        //}
        //}

        public static implicit operator bool(Matrix<T> matrix)
        {
            bool result = true;
            dynamic zero = 0;
            if (IsNumericType(matrix))
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == zero)
                        {
                            result = false;
                        }
                    }
                }
            }
            else result = false;

            return result;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < Row; row++)
            {
                for (int col = 0; col < Col; col++)
                {
                    sb.Append(matrix[row, col] + " ");
                }
                sb.Append("\n");
            }

            return sb.ToString();

        }
    }
}
