using LiteDB;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace MVP
{
    public class Model : IModel
    {
        private const string ConnectionString = "../../../../UserDataBase.db";

        public static void SetupDb()
        {
            using (var db = new LiteDatabase(connectionString: ConnectionString))
            {
                var col = db.GetCollection<User>("Users");
                var allUsers = col.FindAll().ToList();

                //string login = "a";
                //string pass = "b";
                //string pin = "c";
                //var tempUser = new User(login, pass, pin);
                //col.Insert(tempUser);
            }

        }

        public void SendPincode(string eMailLogin, string eMailpassword, string login, string pincode)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(eMailLogin);
                mail.To.Add(login);
                mail.Subject = "Your pincode";
                mail.Body = "<h1>" + pincode + "</h1>";
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
}
