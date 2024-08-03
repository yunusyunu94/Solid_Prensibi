using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek2.İdeal_Olan_Code
{
    public class HPPrinter2 : IPrinter2, IScan2, IFax2, IPrinterDuplex2
    {
        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void Printer()
        {
            throw new NotImplementedException();
        }

        public void PrinterDuplex()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
