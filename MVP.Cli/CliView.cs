using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Cli
{
    class CliView : IView
    {
        public event Func<string, string,string, bool> TrySignIn;
        public event Action<bool> ShowSignInResult;

        public void Show2()
        {
            Console.WriteLine("Введите логин: ");
            var login= Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            var password = Console.ReadLine();
            Console.WriteLine("Введите пинкод: ");
            var pincode = Console.ReadLine();

            var isSuccess = TrySignIn(login, password, pincode);
            ShowSignInResult(isSuccess);
            
        }
    }
}
