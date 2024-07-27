using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Prensibi.Open_Closed_Principle.Ornek3
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
