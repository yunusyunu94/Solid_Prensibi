using Liskov_Substitution_Princilbe.Ornek3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._4.Ornek
{
    public class MercedesBenz : BaseCar, ISmsSendable, IEmailSendable
    {
        public override double GetCostPerKm()
        {
            return 2;
        }

        //public int TrimKM { get; set; }

        public void go()
        {
            Console.WriteLine("Car is now going");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped");
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

        public void SendTripInfoSmsToDriver(DriveInfo driver)
        {
            if (!string.IsNullOrEmpty(driver.PhoneNumber))
            {
                var SmsSender = new SmsSender();
                SmsSender.SenderSms(new SmsModel()
                {
                    Message = "Todays trip"
                    PhoneNumver = driver.PhoneNumber,
                    SendTime = DateTime.Now
                });

            }
        }


    }
}
