using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dependency_Inversion_Principle.Ornek1.Ideal_Code;
using static Dependency_Inversion_Principle.Ornek1.İdeal_Olmayan_Code;

namespace Dependency_Inversion_Principle.Ornek1
{
    internal class Program
    {

        static void Main(string[] args) 
        {
            // İdeal Omayan Code ;

            MailService mailService = new();
            mailService.SendMail(new Gmail());



            // İdeal Code ; 

            MailService2 mailService2 = new();
            mailService2.SendMail(new Gmail2(), " asdf", "asfdas");
            mailService2.SendMail(new Hotmail2(), " asdf", "asfdas");


        }
        
    }
}
