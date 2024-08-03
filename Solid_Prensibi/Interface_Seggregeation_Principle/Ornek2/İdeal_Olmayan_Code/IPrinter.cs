using Interface_Seggregeation_Principle.Ornek2.İdeal_Olan_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek2.İdeal_Olmayan_Code
{
    interface IPrinter : IPrinter2, IFax2
    {
        void Printer();
        void Scan();
        void Fax();
        void PrinterDuplex();
    }
}
