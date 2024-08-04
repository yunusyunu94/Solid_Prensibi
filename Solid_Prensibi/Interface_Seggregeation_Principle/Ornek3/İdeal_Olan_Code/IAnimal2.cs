using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2.İdeal_Olan_Code
{
    public interface IAnimal2 : IOmnivore
    {
        void Bark();
        void Walk();
        void Sleep();
        void Run();
        void Bite();
    }
}
