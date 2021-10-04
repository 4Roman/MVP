using System;
using System.Net;
using System.Net.Mail;

public class Users
{
    public string login { get; set; }
    public string password { get; set; }
    public string pincode { get; set; }
    public bool record { get; set; }

    public static string CreatePincode()
    {
        Random rnd = new Random();
        int value = rnd.Next(0, 9999);
        string pincode = value.ToString();
        return pincode;
    }
    public void SendPincode(string eMailLogin, string eMailpassword, string login, string pincode)
    {        
        using (MailMessage mail = new MailMessage())
        {
            mail.From = new MailAddress(eMailLogin);
            mail.To.Add(login);
            mail.Subject = "Hello World";
            mail.Body = "<h1>"+pincode+"</h1>";
            mail.IsBodyHtml = true;

            using (SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25))
            {
                smtp.Credentials = new NetworkCredential(eMailLogin, eMailpassword);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }

    }
}

