using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPolygonLib
{
    interface IRegularPolygonAreaCalc
    {
        double CalculateArea(double n, double sideLength);
    }
}
