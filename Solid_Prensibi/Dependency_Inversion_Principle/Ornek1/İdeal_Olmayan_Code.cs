using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek1
{
    public class İdeal_Olmayan_Code
    {
        public class MailService
        {
            public void SendMail(Gmail gmail)
            {
                gmail.Send("...");


            }
        }

        public class Gmail
        {
            public void Send(string mail)
            {
                // .. Sned Mail ..
            }
        }
        class Yandex
        {
            public void SendMail(string mail, string to)
            {
                // ..Sned Mail..
            }
        }
        class Hotmail
        {
            public void Send(string mail)
            {
                // ..Sned Mail..
            }
        }

    }
}
