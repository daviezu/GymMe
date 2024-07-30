using Solo_GymMe.Controller;
using Solo_GymMe.Factory;
using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Repository
{
    public class UserRepository
    {
        static LocalDatabaseEntities db = Singleton.GetInstance();

        public static string InsertUser(string username, string email, DateTime dob, string gender, string role, string password)
        {
            MsUser newUser = UserFactory.createUser(username, email, dob, gender, role, password);  
            db.MsUsers.Add(newUser);
            db.SaveChanges();
            return "Registration Success";
        }
    }
}