using MVP.Services;

namespace MVP.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new CliView();
            var viewSignInResult = new CliViewSignInResult();
            var authService = new LocalDbAuthService();
            var presenter = new Presenter(view, viewSignInResult, authService);
            presenter.Run();
        }
    }
}
