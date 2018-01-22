using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Point3D.PointO.ToString());
            Point3D p1 = new Point3D(0, 1, 2);
            Console.WriteLine(p1);
            Point3D p2 = new Point3D(2, 3, 4);

            Console.WriteLine("{0:f2}", Distance.CalcDistance(p1, p2));

            Path myPath1 = new Path();
            myPath1.AddPoint(p1);
            //Console.WriteLine(myPath1);
            

            Path myPath2 = new Path();
            myPath2.AddPoint(p2);
            myPath2.AddPoint(p1);
            myPath2.AddPoint(p2);

            PathStorage.SavePath(myPath1);
            PathStorage.SavePath(myPath2);
            PathStorage.LoadPath();



        }
    }
}