using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LiteDB;

namespace MVP
{
    public class Model : IModel
    {
        public static void SetupDb()
        {
            using (var db = new LiteDatabase(@"UserDataBase.db"))
            {

                var col = db.GetCollection<Users>("Users");
                var allUsers = col.FindAll().ToList();    
            }

        }
    }
}