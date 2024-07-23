using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Prensibi._2.Örnek
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
