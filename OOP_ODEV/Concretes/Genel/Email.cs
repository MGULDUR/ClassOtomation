using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.Genel
{
    public static class Email
    {
        public static void Sender(string gelenAd, string gelenSoyad, string gelenMail, string gelenParola)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.office365.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("teamprojector@outlook.com", "Projector123");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("teamprojector@outlook.com", "Team Projector");
            mail.To.Add(gelenMail);
            mail.Subject = "Kayıt Oluşturuldu";
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            mail.Body = $"Merhaba, {gelenAd} {gelenSoyad}!  {DateTime.Now.ToShortDateString()} tarihinde üyeliğin oluşturuldu. <br>Şifre :{gelenParola} <br/><br/><b>Güvenliğiniz için lüfen bu maili kimseyle paylaşmayınız.</b>";
            sc.Send(mail);
        }

        public static void Sender(string gelenAd, string gelenSoyad, string gelenMail)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.office365.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("teamprojector@outlook.com", "Projector123");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("teamprojector@outlook.com", "Team Projector");
            mail.To.Add(gelenMail);
            mail.Subject = "Kayıt Oluşturuldu";
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            mail.Body = $"Merhaba, {gelenAd} {gelenSoyad}!  {DateTime.Now.ToShortDateString()} tarihinde üyeliğin oluşturuldu. <br/><br/><b>Güvenliğiniz için lüfen bu maili kimseyle paylaşmayınız.</b>";
            sc.Send(mail);
        }
    }
}
