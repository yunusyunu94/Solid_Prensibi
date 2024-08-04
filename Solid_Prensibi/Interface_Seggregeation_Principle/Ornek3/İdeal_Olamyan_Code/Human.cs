using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2.İdeal_Olamyan_Code
{

    // LİNK ;https://www.youtube.com/watch?v=2BDu6oHV738&list=PL_Z0TaFYSF3I7zyoHX-ubeSq_l0e2ztjm&index=6

    public class Human : IHuman
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
