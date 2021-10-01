using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Cli
{
    class CliView : IView
    {
        public event Func<string, string, bool> TrySignIn;

        public void Show2()
        {
            Console.WriteLine("Введите логин: ");
            var login= Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            var password = Console.ReadLine();

            var isSuccess = TrySignIn(login,password);
            if (isSuccess) Console.WriteLine("Success");
            else Console.WriteLine("Fail");
        }
    }
}
