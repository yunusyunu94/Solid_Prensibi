using Dependency_Inversion_Principle.Ornek2.İdeal_Olmayan_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2.İdeal_Olan_Code
{


    // LİNK ; https://www.youtube.com/watch?v=zu4iZS142vg


    internal class Program
    {
        static void Main(string[] args) 
        {
            Email2 email2 = new Email2();

            email2.Connect = "Bu bir deneme mail'dir";
            email2.Subject = "Test";
            email2.ToAdress = "denem@gmail.com";
            email2.SendMessage();

            Whatsapp whatsapp = new Whatsapp();
            whatsapp.Message = "Selam Nasılsın";
            whatsapp.PhoneNumber = "2345234";
            whatsapp.Emoje = '2';
            whatsapp.SendWhatsappMessage();

            Console.ReadLine();

        }
    }
}
