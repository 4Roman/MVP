using System;
using System.Net;
using System.Net.Mail;


public class Users
{
    public string login { get; set; }
    public string password { get; set; }
    public string pincode { get; set; }
    public bool record { get; set; }
}

public string CreatePincode()
{   
    Random rnd = new Random();
    int value = rnd.Next(0, 9999);
    string pincode = value.ToString(string pincode);
    return value;
}

static void SendPincode(string pincode)
{

    // отправитель - устанавливаем адрес и отображаемое в письме имя
    MailAddress from = new MailAddress("matveev.romon@bk.ru", "WinForms");
    // кому отправляем
    MailAddress to = new MailAddress("roman.matveev2002@gmail.com");
    // создаем объект сообщения
    MailMessage m = new MailMessage(from, to);
    // тема письма
    m.Subject = "Пинкод";
    // текст письма
    m.Body = pincode;
    // письмо представляет код html
    m.IsBodyHtml = false;
    // адрес smtp-сервера и порт, с которого будем отправлять письмо
    SmtpClient smtp = new SmtpClient("smtp.mail.ru", 465);
    // логин и пароль
    smtp.Credentials = new NetworkCredential("matveev.romon@bk.ru", "IIpYYei#it13");
    smtp.EnableSsl = true;
    smtp.Send(m);
    Console.Read();
}
