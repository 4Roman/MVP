using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVP.Services
{
    public class LocalDbAuthService : IAuthService, IDisposable
    {
        private readonly string _connectionString;// = "../../../../UserDataBase.db";
        private readonly LiteDatabase _db;

        public LocalDbAuthService(string connectionString = "../../../../UserDataBase.db")
        {
            _connectionString = connectionString;
            _db = new LiteDatabase(connectionString);
        }

        public User TryAuth(string login, string pass, string pincode)
        {
            // сходить в базу, поискать юзера
            var col = _db.GetCollection<User>("Users");
            var allUsers = col.FindAll().ToList();

            //Выбор юзера по логину
            //var loginToSearchFor = login;
            var user = allUsers.FirstOrDefault(u => u.login == login && u.password == pass && u.pincode == pincode);
            //if (user == null) throw new Exception("no user with this login");
            //}

            return user;
        }


        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
