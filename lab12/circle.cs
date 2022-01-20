using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    static class circle
    {
        public static double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        public static double GetArea(double r)
        {
            return  Math.PI * r*r;
        }
         public static double BelongPoint( double x0 , double y0, double x, double y )
         {
            return Math.Sqrt((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y));
         }
    }

}
