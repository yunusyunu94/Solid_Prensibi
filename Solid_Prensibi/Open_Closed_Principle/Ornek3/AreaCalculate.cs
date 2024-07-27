using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._3.Örnek
{
    public class AreaCalculate 
    {
        public double Area(Shape[] shapes) 
        {
            double area = 0;

            foreach (var s in shapes)
            {
                area += s.Area();
            }
            return area;
        }
    }
}
