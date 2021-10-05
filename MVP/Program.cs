using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace MVP
{
    static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Model.SetupDb();
            string login;
            string password;
            string destination;
            if (args?.Length < 2) throw new Exception("Отсутствуют данные для авторизации");
            else 
            {
                login = args[0];
                password = args[1];
                destination = args[2];

            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new Form1();
            var signInResultForm = new ViewSignInResultForm();
            var presenter = new Presenter(mainForm,signInResultForm); 
            presenter.Run();

            
        }           

    }
}
