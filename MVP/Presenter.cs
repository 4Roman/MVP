using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MVP
{
    public class Presenter
    {
        private IView _view;

        public Presenter(IView view)
        {
            _view =view;

            _view.TrySignIn += TrySignIn;
        }
        public void Run()
        {
            _view.Show2();
        }

        bool TrySignIn(string login, string password)
        {
            if (login == "Login" && password == "Password")
            {
                MessageBox.Show("Success");
                return true; 
            }
            else
            {
                MessageBox.Show("Fail");
                return false;
            }
        }
    }
}