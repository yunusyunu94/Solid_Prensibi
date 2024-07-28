using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._4.Ornek
{
    public class MercedesBenz : BaseCar
    {
        public override double GetCostPerKm()
        {
            return 2;
        }

        //public int TrimKM { get; set; }

        public void go()
        {
            Console.WriteLine("Car is now going");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped");
        }
    }
}
