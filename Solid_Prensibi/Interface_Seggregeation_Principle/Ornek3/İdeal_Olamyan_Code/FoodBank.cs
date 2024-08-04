using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2.İdeal_Olamyan_Code
{
    public class FoodBank
    {
        public void AddTolist(IHuman human)
        {
            //...
        }

        public void AddTolist(IAnimal animal)
        {
            //..
        }


    }
}
