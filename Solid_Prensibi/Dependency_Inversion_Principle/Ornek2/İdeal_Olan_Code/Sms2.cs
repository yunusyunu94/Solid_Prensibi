using Dependency_Inversion_Principle.Ornek2.İdeal_Olan_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2
{
    public class Sms2 : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Yeni Mail Geldi");
            Console.WriteLine("Kimden:" + PhoneNumber + "İçerik:" + Message);


        }
    }
}
