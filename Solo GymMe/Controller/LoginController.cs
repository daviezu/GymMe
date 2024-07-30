using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Controller
{
    public class LoginController
    {
        static LocalDatabaseEntities db = new LocalDatabaseEntities();

        public static string ValidateLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                return "Username cannot be empty";
            }
            if (string.IsNullOrEmpty(password))
            {
                return "Password cannot be empty";
            }
            return null;
        }

        public static MsUser CheckUserLogin(string username, string password)
        {
            return (from user in db.MsUsers where user.UserName == username && user.UserPassword == password select user).FirstOrDefault();
        }
    }
}