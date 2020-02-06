using System;
using System.Net;
// using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using Google.Apis.Auth.OAuth2;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;


namespace Biblioteka_w.net.lib
{
    class MailSender
    {
        public void mailSender(string messageTo, string messageSubject, string messageBody)
        {
          /*  
            using (SmtpClient client = new SmtpClient())
            using (MailMessage message = new MailMessage())
            {
                message.To.Add(messageTo);
                message.IsBodyHtml = true;
                message.Subject = messageSubject;
                message.Body = messageBody;

                    client.Send(message);
            }
*/
    //  **********************************************************************************************************
            
            // STEP 1: Navigate to this page https://www.google.com/settings/security/lesssecureapps & set to "Turn On"

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Biblioteka", "biblioteka.testowy@gmail.com"));
            message.To.Add(new MailboxAddress(messageTo));
            message.Subject = messageSubject;

            message.Body = new TextPart("plain")
            {
                Text = messageBody
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 25);


                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("biblioteka.testowy@gmail.com", "jakies haslo");

                client.Send(message);
                client.Disconnect(true);
            }
            
         //   **************************************************************************************
            /*
            SmtpClient client = new SmtpClient();
           

                //host oraz port poczty,
                //dostawca udostępnia nam te dane
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 1000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("biblioteka.testowy@gmail.com", "Damian123");


            //tworzymy wiadomość
            var message = new MailMessage();

                //dodajemy odbiorców
                message.To.Add(new MailAddress(messageTo));
                //podajemy adres nadawcy
                message.From = new MailAddress("biblioteka.testowy@gmail.com");
                //Tytuł wiadomości
                message.Subject = messageSubject;
                message.Body = messageBody;
                //Możemy uzyć znaczników html wewnątrz ciała wiadomości (parametr Body), w tym celu ustawiamy parametr na true
                message.IsBodyHtml = false;

                //Opcjonalnie możemy również dodać załącznik
                //Attachment a = new Attachment("zdjecie.jpg", System.Net.Mime.MediaTypeNames.Image.Jpeg);
                //message.Attachments.Add(a);

                client.Send(message);
                MessageBox.Show("Wiadomość została wysłana.");
            */

        }
       
    }
}
/*
       using (SmtpClient client = new SmtpClient())
           {
               //podajemy dane dostępowe
               var credential = new NetworkCredential
               {
                   UserName = "biblioteka.testowy@gmail.com",
                   Password = "Damian123"
               };
               client.Credentials = credential;
*/

