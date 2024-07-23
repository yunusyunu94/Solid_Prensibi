using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Prensibi.Single_Responsibility_Prensibi.Ornek2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Burasi parcalamadan önceki hali
            EmployeeDef em = new();
            em.EmployeeList();

            Console.ReadLine();

            // Parcaladiktan sonra

            EmployeeCrud emp = new();
            emp.EmployeeList();
        }
    }
}
