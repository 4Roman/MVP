using LiteDB;
using System.Linq;

namespace MVP
{
    public class Model : IModel
    {
        private const string ConnectionString = "../../../../UserDataBase.db";

        public static void SetupDb()
        {
            using (var db = new LiteDatabase(connectionString: ConnectionString))
            {
                var col = db.GetCollection<User>("Users");
                var allUsers = col.FindAll().ToList();

                //string login = "a";
                //string pass = "b";
                //string pin = "c";
                //var tempUser = new User(login, pass, pin);
                //col.Insert(tempUser);
            }

        }
    }
}