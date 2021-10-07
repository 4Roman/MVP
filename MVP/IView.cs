using System;

namespace MVP
{
    public interface IView
    {
        event Action<bool> ViewShowCheckLogAndPassResult;
        event Func<string, string, bool> ViewCheckLogAndPass; // логин, пароль, пинкод, булева переменная
        event Action<bool> ViewShowCheckPincodeResult;
        event Func<string, bool> ViewCheckPincode;
        void Show2();
    }
}
