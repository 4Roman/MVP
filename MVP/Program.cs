using MVP.Services;
using System;
using System.Windows.Forms;

namespace MVP
{
    static class Program
    {
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        [STAThread]
        public static void Main(string[] args)
        {
            _logger.Info("App started");
            for (int i = 0; i<300; i++)
                _logger.Info("adxczxc");
            //Model.SetupDb();
            //string login;
            //string password;
            //string destination;
            //if (args?.Length < 2) throw new Exception("Отсутствуют данные для авторизации");
            //else 
            //{
            //    login = args[0];
            //    password = args[1];
            //    destination = args[2];
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new Form1();
            var signInResultForm = new ViewAuthResultForm();
            //var authService = new FakeAuthService();
            var authService = new LocalDbAuthService();
            _logger.Info("Current authService is " + authService.Name + " SomeInfo: " + authService.SomeInfo);
            var presenter = new Presenter(mainForm, signInResultForm, authService);                      
            presenter.Run();
            
        }

    }
}
