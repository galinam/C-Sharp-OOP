using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public class Path
    {
        private  List<Point3D> pointPath;
        public  List<Point3D> PointPath
        {
            get { return pointPath; }
            private set { pointPath = new List<Point3D>(); }
        }
        public Path()
        {
            PointPath = pointPath;
        }
        public void AddPoint(Point3D point)
        {
            PointPath.Add(point);
        }

        public override string ToString()
        {
            return String.Join(" || ", this.PointPath);
        }
    }
}
