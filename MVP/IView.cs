using System;

namespace MVP
{
    public interface IView
    {
        event Action<bool> ViewShowCheckLogAndPassResult;
        event Func<string, string, bool> ViewCheckLogAndPass; // логин, пароль, пинкод, булева переменная
        event Action<bool> ViewShowCheckPincodeResult;
        event Func<string, bool> ViewCheckPincode;
        event Action LoginOrPassAreInvalid;

        void Show();
        void ShowInfoMessage(string message);

        #region общая функциональность
        public bool ValidateLoginPass(string login, string pass)
        {
            if (ValidateLogin(login) && ValidatePass(pass))
                return true;
            else return false;
        }
        private bool ValidateLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return false;
            else return true;
        }
        private bool ValidatePass(string pass)
        {
            if (string.IsNullOrWhiteSpace(pass))
                return false;
            else return true;
        }
        #endregion
    }
}
