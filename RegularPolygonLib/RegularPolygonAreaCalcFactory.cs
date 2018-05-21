using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPolygonLib
{
    /// <summary>
    /// factory for IRegularPolygonAreaCalc object
    /// </summary>
    public class RegularPolygonAreaCalcFactory
    {
        /// <summary>
        /// method returning concrete implementation of IRegularPolygonAreaCalc
        /// </summary>
        /// <returns>IRegularPolygonAreaCalc</returns>
        public IRegularPolygonAreaCalc GetRegularPolygonAreaCalc()
        {
            //when other interface implementations added - pass a parameter to decide which method to use
            return new BasicRegularPolygonAreaCalc();
        }
    }
}
