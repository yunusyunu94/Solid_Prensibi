using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._4.Ornek
{
    public class TestClass
    {
        public void CalculateTripCost()
        {
            var calculator = new FuelCostCalculator();

            var cost = calculator.Calculater(new MercedesBenz());

            Console.WriteLine($"Total cost for this car is {cost} TL");


            // Veya

            var calculator2 = new FuelCostCalculator();
            var cost2 = calculator.Calculater(new BMW());

            Console.WriteLine($"Total cost for this car is {cost} TL");

            FuelCostCalculator ef = new FuelCostCalculator();

            Console.WriteLine($"Total cost for this car is  {ef.Calculater(new BMW())} TL");
        }
    }
}
