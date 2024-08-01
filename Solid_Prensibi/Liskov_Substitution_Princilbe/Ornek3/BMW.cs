using Liskov_Substitution_Princilbe.Ornek3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._4.Ornek
{
    public class BMW : BaseCar, IEmailSendable
    {
        public override double GetCostPerKm()
        {
            return 1.5;
        }

        public void SendTripInfoEmailToDriver(DriveInfo driver)
        {

            if (!string.IsNullOrEmpty(driver.EmailAdress))
            {
                var mailMessage = new MailMessage();
                mailMessage.To.Add(driver.EmailAdress);

                var client = new SmtpClient("Mil.merceders.com", 587);

            }

        }
    }
}
