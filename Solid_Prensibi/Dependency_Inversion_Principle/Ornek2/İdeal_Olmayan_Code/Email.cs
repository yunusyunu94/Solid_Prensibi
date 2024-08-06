using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2.İdeal_Olmayan_Code
{
    public class Email
    {
        public string ToAdress { get; set; }
        public string Subject { get; set; }
        public string Connect { get; set; }
        public void SendEmail()
        {
            //Send Mail
        }
    }
}
