using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Prensibi._2.Örnek
{
    public class EmployeeConnection
    {

        public static SqlConnection connec = new SqlConnection("Server=localhost\\SQLEXPRESS; " +
        "Database=Northwind; Trusted_Connection=True;\" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -ContextDir Contexts\r\n ");

    }
}
