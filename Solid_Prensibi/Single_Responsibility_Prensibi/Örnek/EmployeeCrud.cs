using Solid_Prensibi.Single_Responsibility_Prensibi.Örnek;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Prensibi._2.Örnek
{
    public class EmployeeCrud
    {
        public int EmployeeAdd(EmployeeDef p)
        {

            SqlCommand commandad = new SqlCommand("insert into Employess (FirstName, LastName,City) values (@p1,@p2,@p3)", EmployeeConnection.connec);

            if (commandad.Connection.State != ConnectionState.Open)
            {
                commandad.Connection.Open();
            }
            commandad.Parameters.AddWithValue("@p1", p.EmployeeName);
            commandad.Parameters.AddWithValue("@p1", p.EmployeeSurname);
            commandad.Parameters.AddWithValue("@p1", p.City);

            // Calisan Ekleme Kodlari
            return commandad.ExecuteNonQuery(); // Bu isten etkilenen kayit sayisi
        }

        public void EmployeeList()
        {
            // SQL Baglanti adresi


            SqlCommand command1 = new SqlCommand("SELECT * FROM Employees(tablo_ismi,)",
                EmployeeConnection.connec);
            if (command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            SqlDataReader dr = command1.ExecuteReader(); // command1 den gelen degerleri oku

            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[8]);
            }

            dr.Close(); // Okuma islemini kapat




            // Calisan Listeleme Kodlari
        }
    }
}
