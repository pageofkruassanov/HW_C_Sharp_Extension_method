using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp_Extension_method
{
    public static class Point3DExtensions
    {
        public static double CalculateDistance(this Point3D point, Point3D secondPoint)
        {
            double deltaX = point.X - secondPoint.X;
            double deltaY = point.Y - secondPoint.Y;
            double deltaZ = point.Z - secondPoint.Z;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }
}
