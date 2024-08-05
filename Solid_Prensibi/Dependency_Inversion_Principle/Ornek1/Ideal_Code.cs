using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek1
{
    internal class Ideal_Code
    {
        public class MailService2
        {
            public void SendMail(IMailService2 mailService, string To, string BSody)
            {
                mailService.Send(To, BSody);


            }
        }

        public interface IMailService2
        {
            void Send(string to, string body);
        }

        public class Gmail2 : IMailService2
        {
            public void Send(string to, string body)
            {
                // .. Sned Mail ..
            }
        }
        public class Yandex2 : IMailService2
        {
            public void Send(string to, string body)
            {
                // .. Sned Mail ..
            }
        }
        public class Hotmail2 : IMailService2
        {
            public void Send(string to, string body)
            {
                // .. Sned Mail ..
            }
        }
    }
}
