using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp_Extension_method
{
    public class Point3D
    {
        public double X {  get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
