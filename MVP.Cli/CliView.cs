using System;

namespace MVP.Cli
{
    class CliView : IView
    {
        public event Func<string, string, bool> ViewCheckLogAndPass;
        public event Action<bool> ViewShowCheckLogAndPassResult;        
        public event Func<string, bool> ViewCheckPincode;
        public event Action<bool> ViewShowCheckPincodeResult;

        public void Show2()
        {
            var isSuccess = false;
            while (!isSuccess)
            {
                Console.WriteLine("Введите логин: ");
                var login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                var password = Console.ReadLine();
                isSuccess = ViewCheckLogAndPass(login, password);
                ViewShowCheckLogAndPassResult(isSuccess);
            }

            isSuccess = false;
            while (!isSuccess)
            {
                Console.WriteLine("Введите Пинкод: ");
                var pincode = Console.ReadLine();
                isSuccess = ViewCheckPincode(pincode);
                ViewShowCheckPincodeResult(isSuccess);
            }
        }
        
    }
}
