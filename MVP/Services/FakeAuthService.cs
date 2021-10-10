namespace MVP.Services
{
    /// <summary>
    /// Всегда успешная авторизация
    /// </summary>
    public class FakeAuthService : IAuthService
    {

        public User DbCheckLogAndPass(string login, string pass)
        {
            var fakeUser = new User(login, pass, pass);
            fakeUser.record = 666;
            return fakeUser;
        }

        public User DbCheckPincode(string pincode)
        {
            var fakeUser = new User(pincode, pincode, pincode);
            fakeUser.record = 666;
            return fakeUser;
        }
    }
}
