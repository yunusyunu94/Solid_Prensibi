using Interface_Seggregeation_Principle.Ornek2.İdeal_Olmayan_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek2.İdeal_Olan_Code
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            SamsungPrinter printer = new();

            printer.Scan(); // Artik ihtihac olan code'ler geliyor
        }
    }
}
