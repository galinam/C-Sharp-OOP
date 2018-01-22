using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixT
{
    class Matrix<T>
        where T : IComparable, IComparable<T>, IEquatable<T>
    {
        private T[,] matrix;

        public int Row { get; set; }
        public int Col { get; set; }
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
                    System.ArgumentException argEx = new System.ArgumentException("Index is out of range of the GenericList boundary", "index", ex);
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

            if (ValidateMatrixSize(matrixF, matrixS))
            {
                for (int row = 0; row < matrixF.GetLength(0); row++)
                {
                    for (int col = 0; col < matrixF.GetLength(1); col++)
                    {
                        result[row, col] = (dynamic)matrixF[row, col] + matrixS[row, col];
                    }
                }
            }
            return result;

        }
        public static Matrix<T> operator -(Matrix<T> matrixF, Matrix<T> matrixS)
        {
            Matrix<T> result = new Matrix<T>(matrixF.GetLength(0), matrixF.GetLength(1));

            if (ValidateMatrixSize(matrixF, matrixS))
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

            if (ValidateMatrixSize(matrixF, matrixS))
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

        private static bool ValidateMatrixSize(Matrix<T> matrixF, Matrix<T> matrixS)
        {
            bool result = false;
            try
            {
                if ((matrixF.GetLength(0) == matrixS.GetLength(0)) && (matrixF.GetLength(1) == matrixS.GetLength(1)))
                {
                    result = true;
                }
            }
            catch (FormatException ex)
            {

                throw new ArgumentException("The operation cannot be performed.", ex.Message);
            }

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
