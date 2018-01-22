using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public static class Distance
    {
        public static double CalcDistance(Point3D first, Point3D second)
        {
            double result = 0;

            result = Math.Sqrt((first.XCoord - second.XCoord) * (first.XCoord - second.XCoord)
                              + (first.YCoord - second.YCoord) * (first.YCoord - second.YCoord)
                               + (first.ZCoord - second.ZCoord) * (first.ZCoord - second.ZCoord));

            return result;
        }
    }
}
