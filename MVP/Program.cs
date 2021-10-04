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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            //SetupDb();
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
            var presenter = new Presenter(mainForm,signInResultForm); // Dependency Injection presenter.Run(); }
            presenter.Run();

            
           
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            
        }


        public static void SetupDb()
        {
            using (var db = new LiteDatabase(@"UserDataBase.db"))
            {
                
                var col = db.GetCollection<Users>("Users");
                var allCustomers = col.FindAll().ToList();                
                var user = new Users
                {
                    login = "matveev.romon",
                    password = "MaTVei",
                    pincode = "7777"
                    
                };                
                col.Insert(user);
            }

        }       

    }
}
