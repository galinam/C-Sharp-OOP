using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;

namespace MatrixT
{
    class StartUp
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int ShowMessageBox(int hWnd, string text, string caption, int type);

        static void Main(string[] args)
        {
            //ShowMessageBox(0, "Some message", "ERROR", 0);

            var assembly = Assembly.GetCallingAssembly();
            var allTypesThatHaveVersion = assembly.GetTypes().Where(x => x.GetCustomAttributes(typeof(VersionAttribute)).Count() > 0).ToList();
            foreach (var myItem in allTypesThatHaveVersion)
            {
                Console.WriteLine(myItem);
            }


            Matrix<double> matrixF = new Matrix<double>(2, 2);
            Matrix<double> matrixS = new Matrix<double>(2, 2);

            double counter = 0;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    matrixF[row, col] = counter;
                    counter+= 1;
                    matrixS[row, col] = counter;
                    counter += 1;
                }
            }

            Console.WriteLine(matrixF.ToString());
            Console.WriteLine(matrixS.ToString());

            Matrix<double> matrixSum = new Matrix<double>(2, 2);
            matrixSum = matrixS + matrixF;
            Console.WriteLine(matrixSum.ToString());
            
            //Console.WriteLine(matrixF);
            //Console.WriteLine(matrixS);
            //Console.WriteLine(Type.GetTypeCode(matrixS.GetType().GetTypeInfo().GenericTypeArguments[0]));
            //Console.WriteLine(TypeCode.Byte);
            
         }
    }
}
