using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._4.Ornek
{
    public abstract class BaseCar
    {
        public int TrimKM { get; set; }

        public abstract double GetCostPerKm();
    }
}
