﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2.İdeal_Olan_Code
{
    public interface IHuman2 : IOmnivore
    {
        void Talk();
        void Walk();
        void Sleep();
        void Run();
    }
}
