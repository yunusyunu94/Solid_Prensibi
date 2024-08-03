using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek2.İdeal_Olmayan_Code
{
    class HPPrinter : IPrinter
    {
        public void Fax()
        {
            // Fax İşlemleri
        }

        public void Printer()
        {
            // Print işlemleri
        }

        public void PrinterDuplex()
        {
            // Print Duplex işlemleri
        }

        public void Scan()
        {
            // Scan işlemleri
        }
    }
}
