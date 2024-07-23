using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Prensibi.Single_Responsibility_Prensibi.Ornek2
{
    public class EmployeeConnection
    {
        public static SqlConnection connec = new SqlConnection("Server=localhost\\SQLEXPRESS; " +
        "Database=Northwind; Trusted_Connection=True;\" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -ContextDir Contexts\r\n ");

    }
}
