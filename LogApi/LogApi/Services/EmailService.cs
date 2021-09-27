using LogApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Mail;

namespace LogApi.Services
{
    public class EmailService : Service
    {
        public override void Create(LogDto log)
        {
            string creation = JsonSerializer.Serialize(log);
            //Console.WriteLine(creation);

            //System.Net.Mail.MailMessage oMailMsg = new System.Net.Mail.MailMessage();
            //oMailMsg.To.Add(ConfigurationManager.AppSettings["ksistofpio@gmail.com"]);
            //oMailMsg.Subject = ConfigurationManager.AppSettings["Projektas"];

            //oMailMsg.IsBodyHtml = true;
            //oMailMsg.Body = creation;

            //System.Net.Mail.SmtpClient oSMTPClient = new System.Net.Mail.SmtpClient();
            //oSMTPClient.Send(oMailMsg);


            //2 var.

            //SmtpClient smtpClient = new SmtpClient("gmail.com", 25);

            //smtpClient.Credentials = new System.Net.NetworkCredential("testowy198907@gmail.com", "labas123*");
            //// smtpClient.UseDefaultCredentials = true; // uncomment if you don't want to use the network credentials
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.EnableSsl = true;
            //MailMessage mail = new MailMessage();

            ////Setting From , To
            //mail.From = new MailAddress("testowy198907@gmail.com", "TEST");
            //mail.To.Add(new MailAddress("testowy198907@gmail.com"));
            //mail.Body = creation;
       
            //smtpClient.Send(mail);


        }
    }

}
