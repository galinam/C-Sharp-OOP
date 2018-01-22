using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D();

        public static Point3D PointO
        {
            get { return pointO; }
        }
        public int XCoord { get; private set; }
        public int YCoord { get; private set; }
        public int ZCoord { get; private set; }
        static Point3D()
        {
            pointO.XCoord = 0;
            pointO.YCoord = 0;
            pointO.ZCoord = 0;
        }

        public Point3D(int x, int y, int z) : this()
        {
            this.XCoord = x;
            this.YCoord = y;
            this.ZCoord = z;
        }

        public override string ToString()
        {
            return String.Format("X = {0}, Y = {1}, Z = {2}", XCoord, YCoord, ZCoord);
        }
    }
}
