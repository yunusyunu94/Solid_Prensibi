using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._3.Örnek
{
    public class Circle : Shape 
    {
        
        public double Radius { get; set; } 


        public Circle(double radius)
        {
            Radius = radius;
        }


        public override double Area() 
        {
            return Radius * Radius * Math.PI;
        }
    }
}
