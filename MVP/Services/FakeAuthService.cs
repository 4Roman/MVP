using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Services
{
    /// <summary>
    /// Всегда успешная авторизация
    /// </summary>
    public class FakeAuthService : IAuthService
    {
        public User TryAuth(string login, string pass, string pincode)
        {
            var fakeUser = new User(login, pass, pincode);
            fakeUser.record = 666;
            return fakeUser;
        }
    }
}
