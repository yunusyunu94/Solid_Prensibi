using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Prensibi.Single_Responsibility_Prensibi.Ornek2
{
    public class EmployeeProcess
    {
        
        public void Proces()
        {
            Console.WriteLine("**** deneme ");
            Console.BackgroundColor = ConsoleColor.Green;
            System.Diagnostics.Process.Start("calc.exe"); // Hesap makinesini acar
            // İslemler
        }
    }
}

