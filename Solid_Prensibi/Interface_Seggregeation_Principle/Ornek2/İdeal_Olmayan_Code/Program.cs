using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek2.İdeal_Olmayan_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamsungPrinter printer = new();

            printer.PrinterDuplex(); // NotImplementedException Donecektir
        }
    }
}
