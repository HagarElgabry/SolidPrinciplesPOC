using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Text;

// does not follow SRP
public class RegisterService
{
    public void RegisterUser(string username)
    {
        if (username == "admin")
            throw new InvalidOperationException();

        SqlConnection connection = new SqlConnection();
        connection.Open();
        SqlCommand command = new SqlCommand("INSERT INTO [...]");       //Insert user into database. 

     SendEmail("Hagar@gmail.com", "Registeration ", " Welcome ");                         //Send a welcome email. 
    }
      public void SendEmail(string email, string subject, string message)
    {
        // email = "hagar.elgabry26@gmail.com";
        var emailMsg = new MimeKit.MimeMessage();
        emailMsg.From.Add(new MimeKit.MailboxAddress("Sender", "hagar.abdelsamad@integrant.com"));
        emailMsg.To.Add(new MimeKit.MailboxAddress("Reciver", email));
        emailMsg.Subject = subject;
        emailMsg.Body = new MimeKit.TextPart("plain") { Text = message };
        SmtpClient client = new SmtpClient("smtp.myhost.com");
        client.Send(new MailMessage());  //Send a welcome email. 
        

    }
}