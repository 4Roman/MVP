using MVP.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MVP
{
    public class Presenter
    {
        private IView _view;
        private IViewSignInResult _viewSignInResult;
        private IAuthService _authService;

        public Presenter(IView view,IViewSignInResult viewSignInResult, IAuthService authService)
        {
            _view =view;
            _view.TrySignIn += TrySignIn;
            _view.ShowSignInResult += ShowSignInResult;
            _viewSignInResult= viewSignInResult;
            //_viewSignInResult.ShowSignInResult += ShowSignInResult;
            _authService = authService;
        }
        public void Run()
        {
            _view.Show2();
        }

        bool TrySignIn(string login, string password, string pincode)
        {
            var user = _authService.TryAuth(login,password,pincode);
            if (user != null) return true;
            else return false;
        }

        void ShowSignInResult(bool success)
        {
            if (success)
                _viewSignInResult.Show(success);
            else
                _viewSignInResult.Show(success);
        }


    }
}