using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._4.Ornek
{
    public class BMW : BaseCar
    {
        public override double GetCostPerKm()
        {
            return 1.5;
        }
    }
}
