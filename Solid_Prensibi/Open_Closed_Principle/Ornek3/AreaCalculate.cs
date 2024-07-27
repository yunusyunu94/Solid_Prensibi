﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Prensibi.Open_Closed_Principle.Ornek3
{
    public class AreaCalculate // Alan hesaplama
    {
        public double Area(Shape[] shapes) // Areat: Alan
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
