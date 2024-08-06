using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2.İdeal_Olmayan_Code
{
    public class Whatsapp
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public char Emoje { get; set; }

        public void SendWhatsappMessage()
        {
            //Send
        }
    }
}
