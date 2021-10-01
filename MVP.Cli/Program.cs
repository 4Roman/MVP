using System;

namespace MVP.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new CliView();
            var viewSignInResult = new CliViewSignInResult();
            var presenter = new Presenter(view,viewSignInResult) ;
            presenter.Run();
        }
    }
}
