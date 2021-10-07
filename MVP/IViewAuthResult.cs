namespace MVP
{
    public interface IViewAuthResult
    {
        //event Action<bool> ShowSignInResult;
        void ShowLogAndPassResult(bool success); //проверка логина и пароля
        void ShowPincodeResult(bool success); // проверка пинкода    

    }
}
