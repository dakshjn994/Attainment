using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Text;
using System.Security.Cryptography;
public class SendEmail123
{
    MailMessage mail;
    NetworkCredential mailAuthentication;
    static string FromID = "digitronicarts@gmail.com";                // ENTER FROM EMAIL ID
    static string pwd = "digi1234";                             // PASSWORD
    public void sendEMail(string ToEmail, string msg,string sub)
    {
        mail = new MailMessage(FromID, ToEmail, sub, msg);
        mailAuthentication = new NetworkCredential(FromID, pwd);
        SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
        mailClient.EnableSsl = true;
        mailClient.Credentials = mailAuthentication;
        mail.IsBodyHtml = true;
        mailClient.Send(mail);
    }
    public void sendEMail(string ToEmail, string msg, string path,string sub)
    {
        mail = new MailMessage(FromID, ToEmail,sub, msg);
        Attachment attachment;
        attachment = new Attachment(path);
        mail.Attachments.Add(attachment);
        mailAuthentication = new NetworkCredential(FromID, pwd);
        SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
        mailClient.EnableSsl = true;
        mailClient.Credentials = mailAuthentication;
        mail.IsBodyHtml = true;
        mailClient.Send(mail);
    }
    
}