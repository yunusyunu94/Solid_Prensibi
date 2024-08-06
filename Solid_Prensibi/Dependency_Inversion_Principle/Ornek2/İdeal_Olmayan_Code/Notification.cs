using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2.İdeal_Olmayan_Code
{
    // Burada bir sinif daha eklersek Notification'da
    // degisiklik yapmamiz gerek

    public class Notification
    {
        private Email _email;
        private Sms _sms;
        private Whatsapp2 _whatsapp;

        public Notification()
        {
            _email = new Email();
            _sms = new Sms();
            _whatsapp = new Whatsapp2();
        }
        public void Send()
        {
            _email.SendEmail();
            _sms.SendSms();
            _whatsapp.SendWhatsappMessage();
        }
    }
}
