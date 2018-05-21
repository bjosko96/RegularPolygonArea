using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPolygonLib
{
    class BasicRegularPolygonAreaCalc : IRegularPolygonAreaCalc
    { 
        public double CalculateArea(double n, double sideLength)
        {
            double area = (1.0 / 4.0) * n * sideLength * sideLength * (1.0 / Math.Tan(Math.PI/n));
            return area;
        }
    }
}
