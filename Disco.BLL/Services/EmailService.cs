﻿using Disco.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Disco.BLL.Services
{
    public class EmailService : IEmailService
    {
        public void SendToEmail(string to, string subject, string body)
        {
            MailMessage ms = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            ms.From = new MailAddress("korchevskyy.s@inprimex.com");
            ms.To.Add(new MailAddress(to));
            ms.Subject = subject;
            ms.IsBodyHtml = false; //to make message body as html  
            ms.Body = body;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host  
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("korchevskyy.s@inprimex.com", "cJM23H87");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(ms);
        }

        public async Task SendToEmailAsync(string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
