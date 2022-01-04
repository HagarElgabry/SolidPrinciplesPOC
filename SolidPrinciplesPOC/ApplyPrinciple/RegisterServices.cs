using MailKit.Security;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;

public class RegisterServices
{
    public void AddUserIntoDB(string username)
    {
        SqlConnection connection = new SqlConnection();
        connection.Open();
        SqlCommand command = new SqlCommand("INSERT INTO [...]");          //Insert user into database.
    }
}
public class UpdateServices
{
    public void UpdateUserInfo(string username)
    {
        SqlConnection connection = new SqlConnection();
        connection.Open();
         SqlCommand Updatecommand = new SqlCommand("UPDATE `table_name` SET `column_name` = `new_value' [WHERE condition];");            //Update user into database. 

    }
}
public class EmailServices
{
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