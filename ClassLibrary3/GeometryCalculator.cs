using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class GeometryCalculator
    {
        public static double CalculateSquareArea(double sideLength)
        {
            return sideLength * sideLength;
        }
        public static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }
        public static double CalculateTriangleeArea(double baseLength, double heidht)
        {
            return 0.5 * baseLength * heidht;
        }


    }
}
