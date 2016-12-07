using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Namespace for sending messages to SMTP server for delivery.
using System.Net.Mail;


// author: Johnny Romano
// date:   06-Dec-2016
// ver:    1.0
// name:   clsBusinessLayer.cs
// desc:   BusinessLayer Class
public class clsBusinessLayer
{
    public clsBusinessLayer()
    {
    }   
    public static bool SendEmail(string Sender, string Recipient, string bcc, string cc, string Subject, string Body)
    {
        try
        {
            // Represents an email message that can be sent using SmtpClient class
            MailMessage MyMailMessage = new MailMessage();
            
            // Set FROM address for Sender
            MyMailMessage.From = new MailAddress(Sender);
            
            // Set TO address for Recipient
            MyMailMessage.To.Add(new MailAddress(Recipient));
            
            // Set BCC Recipient if not NULL or EmptyString
            if (bcc != null && bcc != string.Empty)
            {
                // Set BCC Recipient
                MyMailMessage.Bcc.Add(new MailAddress(bcc));
            }
            
            // Set CC Recipient if not NULL or EmptyString
            if (cc != null && cc != string.Empty)
            {
                // Set CC Recipient
                MyMailMessage.CC.Add(new MailAddress(cc));
            }
            
            // Set SUBJECT_LINE for message
            MyMailMessage.Subject = Subject;
            
            // Set BODY for message
            MyMailMessage.Body = Body;
            
            // Sets indicator of HTML message body
            MyMailMessage.IsBodyHtml = true;
            
            // Sets PRIORITY of message
            MyMailMessage.Priority = MailPriority.Normal;
            
            // Initialize new SmtpClient instance
            SmtpClient MySmtpClient = new SmtpClient("localhost");
            //SMTP Port = 25;
            //Generic IP host = "127.0.0.1";
            
            // Sends message to SMTP server
            MySmtpClient.Send(MyMailMessage);
            
            // Message Successful return true
            return true;
        }
        catch (Exception ex)
        {
            // Message NOT Successful return false
            return false;
        }
    }
}


