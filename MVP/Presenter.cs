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

        public Presenter(IView view,IViewSignInResult viewSignInResult)
        {
            _view =view;
            _view.TrySignIn += TrySignIn;
            _view.ShowSignInResult += ShowSignInResult;
            _viewSignInResult= viewSignInResult;
            //_viewSignInResult.ShowSignInResult += ShowSignInResult;

        }
        public void Run()
        {
            _view.Show2();
        }

        bool TrySignIn(string login, string password, string pincode)
        {
            if (login == "Login" && password == "Password" && pincode == "7777") return true;
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