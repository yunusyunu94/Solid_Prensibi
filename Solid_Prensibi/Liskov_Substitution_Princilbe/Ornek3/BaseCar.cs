using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._4.Ornek
{
    public abstract class BaseCar
    {
        public int TrimKM { get; set; }

        public abstract double GetCostPerKm();


        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        // Asagıdaki Metotlari Lizkov yapisina uygun olacak sekilde interface ile ayirdim



        //public void SendTripInfoEmailToDriver(DriveInfo driver)
        //{
        //    if (!string.IsNullOrEmpty(driver.EmailAdress))
        //    {
        //        var mailMessage = new MailMessage();
        //        mailMessage.To.Add(driver.EmailAdress);

        //        var client = new SmtpClient("Mil.merceders.com", 587);

        //    }
        //}

        //public void SendTripInfoSmsToDriver(DriveInfo driver)
        //{
        //    if (!string.IsNullOrEmpty(driver.PhoneNumber))
        //    {
        //        var SmsSender = new SmsSender();
        //        SmsSender.SenderSms(new SmsModel()
        //        {
        //            Message =  "Todays trip"
        //            PhoneNumver = driver.PhoneNumber,
        //            SendTime = DateTime.Now
        //        });

        //    }
        //}
    }
}
