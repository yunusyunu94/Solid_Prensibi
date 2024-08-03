using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek2.İdeal_Olan_Code
{
    public class SamsungPrinter2 : IPrinter2, IFax2
    {
        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void Printer()
        {
            throw new NotImplementedException();
        }
    }
}
