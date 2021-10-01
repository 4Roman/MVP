using System;
using System.Collections.Generic;
using System.Text;

namespace MVP
{
    public interface IView
    {
        //delegate void ResultOfAuthorization();
        event Action<bool> ShowSignInResult;
        event Func<string, string,string, bool> TrySignIn; // логин, пароль, пинкод, булева переменная
        void Show2();
    }
}