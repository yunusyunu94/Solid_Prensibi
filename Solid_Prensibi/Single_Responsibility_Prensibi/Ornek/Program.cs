using Single_Responsibility_Prensibi._2.Örnek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Prensibi
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

            // Video Linki https://www.youtube.com/watch?v=aO8Clg8OrY8

        }
    }
}
