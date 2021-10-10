using System;

namespace MVP.Cli
{
    public class CliViewAuthResult : IViewAuthResult
    {
        public CliViewAuthResult()
        {
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public void ShowLogAndPassResult(bool success) //проверка логина и пароля в mainForm
        {
            if (success)
                Console.WriteLine("Пинкод отправлен на вашу почту.");
            else
                Console.WriteLine("Пользователя с таким логином и паролем не существует.");
        }

        public void ShowPincodeResult(bool success) // проверка пинкода в mainForm
        {
            if (success)
                Console.WriteLine("Вы успешно авторизованы.");
            else
                Console.WriteLine("Пинкод неверный.");
        }


    }
}
