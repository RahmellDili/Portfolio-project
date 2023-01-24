﻿using System;
using System.Net.Mail;

namespace Portfolio.Service
{
    public class ContactService
    {
        public static void SendMessage(string name, string email, string message)
        {
            // Create a new email message
            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(email, name);
            mailMessage.To.Add("name@example.com");
            mailMessage.Subject = "Contact Form Submission";
            mailMessage.Body = message;

            // Send the email
            using (var smtp = new SmtpClient())
            {
                smtp.Send(mailMessage);
            }

        }
    }
}

