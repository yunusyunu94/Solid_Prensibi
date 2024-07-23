using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// NUGETPAGETTEN YUKLEDİM System.Data.SqlClien

using System.Data.SqlClient;




// ASSAGIDAKİ YAPİ Single_Responsibility_Prensibi AYKİRİ 

// Burayı parcalıcaz ayrı class larda 
// EmployeeCrud ,  EmployeeConnection , EmployeeProcess , EmployeeDef


using Microsoft.Data.SqlClient;
namespace Single_Responsibility_Prensibi._2.Örnek
{
    public class EmployeeDef
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string City { get; set; }

        public int EmployeeAdd()
        {

            // Calisan Ekleme Kodlari
            return 1;
        }

        // Buranın assagısını parcaladık
        // -------------------------------------------------------------------------------------------------

        public void EmployeeList()
        {
            // SQL Baglanti adresi
            SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS; Database=Northwind; Trusted_Connection=True;\" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -ContextDir Contexts\r\n ");

            con.Open(); // Baglantiyi ac

            SqlCommand command1 = new SqlCommand("SELECT * FROM Employees(tablo_ismi,)", con);

            SqlDataReader dr = command1.ExecuteReader(); // command1 den gelen degerleri oku

            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[8]);
            }




            // Calisan Listeleme Kodlari
        }

        public void Connection()
        {
            // Baglanti sinifi
        }

        public void Proces()
        {
            Console.WriteLine("**** deneme ");
            Console.BackgroundColor = ConsoleColor.Green;
            System.Diagnostics.Process.Start("calc.exe");
            // İslemler
        }
    }
}
