using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixT
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Matrix<int> matrixF = new Matrix<int>(2,2);
            Matrix<int> matrixS = new Matrix<int>(2, 2);

            int counter = 1;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    matrixF[row, col] = counter;
                    counter++;
                    matrixS[row, col] = counter;
                    counter++;
                }
            }

            Console.WriteLine(matrixF.ToString());
            Console.WriteLine(matrixS.ToString());

            Matrix<int> matrixSum = new Matrix<int>(2, 2);
            matrixSum = matrixS * matrixF;
            Console.WriteLine(matrixSum.ToString());
         }
    }
}
