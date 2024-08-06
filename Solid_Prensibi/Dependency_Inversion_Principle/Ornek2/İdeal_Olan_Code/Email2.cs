using Dependency_Inversion_Principle.Ornek2.İdeal_Olan_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2
{
    public class Email2 : IMessage
    {
        public string ToAdress { get; set; }
        public string Subject { get; set; }
        public string Connect { get; set; }
        
        public void SendMessage()
        {
            Console.WriteLine("Yeni Mail Geldi");
            Console.WriteLine("Kimden:" + ToAdress + "Konu:" + Subject +
                "İçerik" + Connect);
        }
    }
}
