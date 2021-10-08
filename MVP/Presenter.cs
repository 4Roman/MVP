using MVP.Services;

namespace MVP
{
    public class Presenter
    {
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private IView _view;
        private IViewAuthResult _viewSignInResult;
        private IAuthService _authService;

        public Presenter(IView view, IViewAuthResult viewSignInResult, IAuthService authService)
        {
            _view = view;
            _view.ViewCheckLogAndPass += PrCheckLogAndPass;
            _view.ViewShowCheckLogAndPassResult += PrShowCheckLogAndPassResult;
            _view.ViewCheckPincode += PrCheckPincode;
            _view.ViewShowCheckPincodeResult += PrShowCheckPincodeResult;
            _viewSignInResult = viewSignInResult;
            _authService = authService;
        }
        public void Run()
        {
            _view.Show2();
        }

        bool PrCheckLogAndPass(string login, string password)  //проверка логина и пароля
        {
            _logger.Info("Try check login");

            var user = _authService.DbCheckLogAndPass(login, password);
            if (user != null) return true;
            else return false;
        }
        void PrShowCheckLogAndPassResult(bool success)  // результат проверки логина и пароля
        {
            _viewSignInResult.ShowLogAndPassResult(success);           
        }        
        bool PrCheckPincode(string pincode)  //проверка пинкода
        {
            var user = _authService.DbCheckPincode(pincode);
            if (user != null) return true;
            else return false;
        }
        void PrShowCheckPincodeResult(bool success)  // результат пинкода
        {
            _viewSignInResult.ShowPincodeResult(success);
        }




    }
}
